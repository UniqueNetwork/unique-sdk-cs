using System.Text.Json;
using Network.Unique.API.Model;
using Network.Unique.SDK.Service;

namespace Network.Unique.SDK.Signer.Impl;

public class Sr25519SignerWrapper : SignerWrapper
{

    private IntPtr _handle;

    public Sr25519SignerWrapper(string suri, string password, bool generate)
    {
        if (generate)
        {
            string pairStr = Pair.Generate(CryptoScheme.Sr25519, password);
            NativePairWrapper? pairInfo = 
                JsonSerializer.Deserialize<NativePairWrapper>(pairStr);

            _handle = Pair.InitSuri(CryptoScheme.Sr25519, pairInfo.secretSeed, password);
        } else
        {
            Pair.InitSuri(CryptoScheme.Sr25519, suri, password);
        }
    }

    public override string Sign(string data)
    {
        var payload = ToByteArray(data);
        
        var bytes = Pair.Sign(_handle.ToInt64(), payload);
        return "0x01" + BitConverter.ToString(bytes).Replace("-","");
    }
}