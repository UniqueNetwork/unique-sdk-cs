namespace Network.Unique.SDK.Signer.Impl;

public class Sr25519SignerWrapper : SignerWrapper
{
    public override string Sign(string data)
    {
        var pointer = Pair.InitSuri(CryptoScheme.Sr25519, "//Bob", null);
        var payload = ToByteArray(data);
        
        var bytes = Pair.Sign(pointer.ToInt64(), payload);
        return "0x01" + BitConverter.ToString(bytes).Replace("-","");
    }
}