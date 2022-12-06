namespace Network.Unique.SDK.Signer;

public abstract class SignerWrapper
{
    public abstract string Sign(string data);

    public byte[] ToByteArray(string data)
    {
        return Enumerable.Range(0, data.Length)
            .Where(x => x % 2 == 0)
            .Select(x => Convert.ToByte(data.Substring(x, 2), 16))
            .ToArray();
    }
    
}