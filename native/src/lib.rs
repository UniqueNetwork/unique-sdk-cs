use std::{mem::transmute, ptr::null_mut, result, str::Utf8Error, ffi::{CStr, c_char, c_int, c_uchar}};

use sp_core::{crypto::SecretStringError, Pair, Encode};

type Result<T, E = Error> = result::Result<T, E>;

#[derive(thiserror::Error, Debug)]
pub enum Error {
    #[error("invalid argument: {0}")]
    InvalidArgument(&'static str),
    #[error("invalid utf-8: {0}: {1}")]
    InvalidUtf8(&'static str, Utf8Error),
    #[error("secret string: {0:?}")]
    SecretString(SecretStringError),
}
impl From<SecretStringError> for Error {
    fn from(value: SecretStringError) -> Self {
        Self::SecretString(value)
    }
}


unsafe fn get_jpair(signer: i64) -> &'static &'static dyn JPair {
    assert!(signer != 0, "pair is already freed");
    transmute(signer as usize)
}

// fn i2u(v: &[i8]) -> &[u8] {
//     // Safety: &[u8] has the same layout as &[i8]
//     unsafe { transmute(v) }
// }
fn u2i(v: &[u8]) -> &[i8] {
    // Safety: &[u8] has the same layout as &[i8]
    unsafe { transmute(v) }
}

trait JPair {
    fn sign(&self, input: &[u8]) -> Result<*mut i8>;
}
impl<T: Pair> JPair for T {
    fn sign(&self, input: &[u8]) -> Result<*mut i8> {
        let signature = self.sign(input);
        let signature = signature.as_ref();
        let mut new_vec = u2i(signature).to_vec();
        // let array = env.new_byte_array(signature.len() as i32)?;
        // env.set_byte_array_region(array, 0, u2i(signature))?;
        // Ok(array)
        return Ok(new_vec.as_mut_ptr());
    }
}

fn init_suri<P: Pair>(suri: &str, password: Option<&str>) -> Result<Box<dyn JPair>> {
    let pair = P::from_string(suri, password)?;
    Ok(Box::new(pair))
}

fn sign(signer: &dyn JPair, input: *mut u8, input_length: i32) -> Result<*mut i8> {
    let buf: &mut [u8];
    unsafe {
        buf = core::slice::from_raw_parts_mut(input, input_length as usize);
    }

    signer.sign(buf)
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
    pair_type: CryptoScheme,
    suri_ptr: *const c_char,
    password_ptr: *const c_char,
) -> i64 {
    let suri = unsafe {
        assert!(!suri_ptr.is_null());

        CStr::from_ptr(suri_ptr)
    }.to_str().unwrap();
    let password;
    if !password_ptr.is_null() {
        unsafe {
            password = Some(CStr::from_ptr(password_ptr).to_str().unwrap());
        }
    } else {
        password = None;
    };

    let result = match pair_type {
        CryptoScheme::Ed25519 => init_suri::<sp_core::ed25519::Pair>(suri, password),
        CryptoScheme::Sr25519 => init_suri::<sp_core::sr25519::Pair>(suri, password),
        CryptoScheme::EcDSA => init_suri::<sp_core::ecdsa::Pair>(suri, password),
    };
    let signer = match result {
        Ok(v) => v,
        Err(_e) => {
            return -1;
        }
    };
    Box::into_raw(Box::new(signer)) as usize as i64
}

/// # Safety
/// JPair should be obtained from jPairInit* methods, and passed to this method only once
#[no_mangle]
pub unsafe extern "C" fn csharp_pair_free(
    jpair: i64,
) {
    let _ = <Box<Box<dyn JPair>>>::from_raw(jpair as usize as *mut _);
}

/// # Safety
/// JPair should be obtained from jPairInit* methods
#[no_mangle]
pub unsafe extern "C" fn csharp_pair_sign(
    jpair: i64,
    data: *mut u8,
    data_length: i32,
    result: *mut *mut c_char
) {
    match sign(unsafe { *get_jpair(jpair) }, data, data_length) {
        Ok(v) => {
            *result = v;
            std::mem::forget(v);
        },
        Err(_e) => {
            *result = null_mut()
        }
    }
}
