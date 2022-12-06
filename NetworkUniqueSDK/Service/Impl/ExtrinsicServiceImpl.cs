using Network.Unique.API.Api;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service.Impl;

public class ExtrinsicServiceImpl : IExtrinsicService
{
    private ExtrinsicApi _api;

    public ExtrinsicServiceImpl(string basePath)
    {
        this._api = new ExtrinsicApi(basePath);
    }

    public ExtrinsicResultResponse getExtrinsicStatus(string hash)
    {
        return _api.ExtrinsicsControllerGetStatus(hash);
    }
}