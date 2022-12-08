use std::{mem::transmute, ptr::null_mut, result, str::Utf8Error, mem::drop};

use jni::{
    errors::Error as JniError,
    objects::{JClass, JString},
    strings::JavaStr,
    sys::{jbyteArray, jlong},
    JNIEnv,
};
use sp_core::{crypto::SecretStringError, Pair};

type Result<T, E = Error> = result::Result<T, E>;

#[derive(thiserror::Error, Debug)]
pub enum Error {
    #[error("invalid argument: {0}")]
    InvalidArgument(&'static str),
    #[error("invalid utf-8: {0}: {1}")]
    InvalidUtf8(&'static str, Utf8Error),
    #[error("secret string: {0:?}")]
    SecretString(SecretStringError),
    #[error("jni error: {0}")]
    Jni(#[from] JniError),
}

impl From<SecretStringError> for Error {
    fn from(value: SecretStringError) -> Self {
        Self::SecretString(value)
    }
}

impl Error {
    fn into_env(self, env: JNIEnv) {
        let _ = match self {
            Error::InvalidArgument(s) => env.throw_new("java/lang/InvalidArgumentException", s),
            Error::SecretString(s) => env.throw_new(
                "network/unique/signer/exception/SecretStringException",
                format!("{s:?}"),
            ),
            Error::Jni(e) => env.throw_new("java/lang/RuntimeException", e.to_string()),
            Error::InvalidUtf8(location, message) => env.throw_new(
                "network/unique/signer/exception/InvalidUtf8Exception",
                format!("{location}: {message}"),
            ),
        };
    }
}

pub struct CSharpPair {
    pair: Pair
}

impl<'a> CSharpPair {
    fn to_ptr(self) -> *mut CSharpPair {
        unsafe { transmute(Box::new(self)) }
    }

    fn from_ptr(ptr: *mut CSharpPair) -> &'a mut CSharpPair {
        unsafe { &mut *ptr }
    }

    fn sign(ptr: *mut *mut CSharpPair, input: &mut [i8]) -> &mut [i8] {
        let pair: Box<CSharpPair> = unsafe { transmute(*ptr) };

        pair.pair.sign(i2u(input.as_slice()))
    }
    
    fn free(ptr: *mut *mut CSharpPair) {
        let pair: Box<CSharpPair> = unsafe { transmute(*ptr) };
        
        drop(pair);
    }
}

fn i2u(v: &[i8]) -> &[u8] {
    // Safety: &[u8] has the same layout as &[i8]
    unsafe { transmute(v) }
}

fn u2i(v: &[u8]) -> &[i8] {
    // Safety: &[u8] has the same layout as &[i8]
    unsafe { transmute(v) }
}

trait JPair {
    fn sign(&self, env: &JNIEnv, input: &[u8]) -> Result<jbyteArray>;
}

impl<T: Pair> JPair for T {
    fn sign(&self, env: &JNIEnv, input: &[u8]) -> Result<jbyteArray> {
        let signature = self.sign(input);
        let signature = signature.as_ref();
        let array = env.new_byte_array(signature.len() as i32)?;
        env.set_byte_array_region(array, 0, u2i(signature))?;
        Ok(array)
    }
}

fn init_suri<P: Pair>(suri: String, password: String) -> Result<CSharpPair, String> {
    let pair = P::from_string(suri, password)?;
    Ok(CSharpPair { pair })
}

#[repr(u32)]
#[derive(Debug)]
pub enum CryptoScheme {
    Ed25519 = 0,
    Sr25519,
    EcDSA,
}

#[no_mangle]
pub extern "C" fn csharp_init_suri(
    ptr: *mut *mut Baton,
    pair_type: CryptoScheme,
    suri_ptr: *const c_char,
    password_ptr: *const c_char,
) -> bool {
    let suri = unsafe { CStr::from_ptr(suri_ptr) };
    let password = unsafe { CStr::from_ptr(password_ptr) };
    let result = match pair_type {
        CryptoScheme::Ed25519 => init_suri::<sp_core::ed25519::Pair>(suri, password),
        CryptoScheme::Sr25519 => init_suri::<sp_core::sr25519::Pair>(suri, password),
        CryptoScheme::EcDSA => init_suri::<sp_core::ecdsa::Pair>(suri, password),
    };
    match result {
        Ok(pair) => {
            unsafe {
                *ptr = pair.to_ptr();
            }
        }
        Err(message) => {
            unsafe {
                *ptr = ptr::null();
            }

            false
        }
    };
}

#[no_mangle]
pub extern "C" fn csharp_free(
    ptr: *mut *mut CSharpPair,
) {
    if !ptr.is_null() && unsafe { !(*ptr).is_null() } {
        CSharpPair::free(ptr);

        unsafe {
            *ptr = ptr::null_mut();
        }
    }
}

#[no_mangle]
pub extern "C" fn csharp_sign(
    ptr: *mut *mut CSharpPair,
    data_ptr: *mut i8,
) -> *mut i8 {
    let data: &mut [i8] = unsafe { 
        std::slice::from_raw_parts_mut(data_ptr, length) 
    };
    
    if !ptr.is_null() && unsafe { !(*ptr).is_null() } {
        let signature = CSharpPair::sign(ptr, data);
        unsafe {
            return transmute(signature);
        }
    }
}
