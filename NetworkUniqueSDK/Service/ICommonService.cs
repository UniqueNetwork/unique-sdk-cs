using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service;

public interface ICommonService
{

    GetNonceResponse GetNonce(string address);

    ChainPropertiesResponse GetChainProperties();

}