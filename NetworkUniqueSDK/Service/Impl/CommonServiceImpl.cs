using Network.Unique.API.Api;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service.Impl;

public class CommonServiceImpl : ICommonService
{
    private readonly CommonApi _api;

    public CommonServiceImpl(string basePath)
    {
        _api = new CommonApi(basePath);
    }

    public GetNonceResponse GetNonce(string address)
    {
        return _api.CommonControllerGetNonce(address);
    }

    public ChainPropertiesResponse GetChainProperties()
    {
        return _api.CommonControllerGetChainProperties();
    }
}