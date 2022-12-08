using System.Runtime.InteropServices;
using System.Text;

namespace Network.Unique.SDK.Signer;

public class PairFFI
{
    private static IntPtr _pair;
    
    [DllImport("signer")]
    private static extern bool csharp_init_suri(out IntPtr pair, int ordinalCryptoScheme, byte[] suriBytes, byte[] passwordBytes);
    
    public static bool InitSuri(CryptoScheme cryptoScheme, string suri, string password)
    {
        return csharp_init_suri(out _pair, (int) cryptoScheme, Encoding.UTF8.GetBytes(suri), Encoding.UTF8.GetBytes(password));
    }
    
    [DllImport("signer")]
    private static extern byte[] csharp_sign(out IntPtr pair, byte[] payload);
    
    public static byte[] Sign(byte[] payload)
    {
        return csharp_sign(out _pair, payload);
    }
    
    [DllImport("signer")]
    private static extern void csharp_free(out IntPtr pair);
    
    public static void Free()
    {
        csharp_free(out _pair);
    }
}