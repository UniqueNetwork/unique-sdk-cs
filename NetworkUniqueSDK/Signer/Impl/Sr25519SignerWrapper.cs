using Network.Unique.API.Model;
using Network.Unique.SDK.Service;

namespace Network.Unique.SDK.Signer.Impl;

public class Sr25519SignerWrapper : SignerWrapper
{

    private string _suri;
    private string _password;

    public Sr25519SignerWrapper(string suri, string password)
    {
        _suri = suri;
        _password = password;
    }

    public override string Sign(string data)
    {
        var pointer = Pair.InitSuri(CryptoScheme.Sr25519, _suri, _password);
        var payload = ToByteArray(data);
        
        var bytes = Pair.Sign(pointer.ToInt64(), payload);
        return "0x01" + BitConverter.ToString(bytes).Replace("-","");
    }
}