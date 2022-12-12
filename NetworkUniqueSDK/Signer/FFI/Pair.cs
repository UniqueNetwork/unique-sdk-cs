using System.Runtime.InteropServices;

namespace Network.Unique.SDK.Signer;

public class Pair
{
    private const string NativeLib = "signer";

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "csharp_init_suri")]
    private static extern IntPtr csharp_init_suri(int ordinalCryptoScheme, string suri, string? password);
    
    public static IntPtr InitSuri(CryptoScheme cryptoScheme, string suri, string? password)
    {
        return csharp_init_suri(
            (int)cryptoScheme,
            suri,
            password
        );
    }

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "csharp_pair_sign")]
    private static extern void csharp_sign(IntPtr pair, byte[] payload, int payloadLength, out IntPtr resultPtr);

    public static byte[] Sign(long pairPointer, byte[] payload)
    {
        csharp_sign(new IntPtr(pairPointer), payload, payload.Length, out IntPtr resultPtr);
        byte[] results = new byte[64];
        Marshal.Copy(resultPtr, results, 0, results.Length);
        return results;
    }

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "csharp_pair_free")]
    private static extern void csharp_free(IntPtr pair);

    public static void Free(long pairPointer)
    {
        csharp_free(new IntPtr(pairPointer));
    }
}