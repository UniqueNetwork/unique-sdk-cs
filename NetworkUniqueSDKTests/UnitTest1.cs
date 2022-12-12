using System.Diagnostics;
using Network.Unique.SDK.Signer;

namespace NetworkUniqueSDKTests;

public class Tests
{
    [OneTimeSetUp]
    public void StartTest()
    {
        Trace.Listeners.Add(new ConsoleTraceListener());
    }

    [Test]
    public void Test1()
    {
        var initSuri = Pair.InitSuri(CryptoScheme.Sr25519, "\\/Bob", "23");
        Console.WriteLine(initSuri.ToInt32());
        var initSuri2 = Pair.InitSuri(CryptoScheme.Sr25519, "//Bob", null);
        Console.WriteLine(initSuri2.ToInt32());
        Trace.Flush();
    }
}