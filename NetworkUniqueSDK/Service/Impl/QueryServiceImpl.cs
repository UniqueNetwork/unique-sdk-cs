using Network.Unique.API.Api;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service.Impl;

public class QueryServiceImpl : IQueryService
{
    
    private QueryApi _api;

    public QueryServiceImpl(String basePath)
    {
        this._api = new QueryApi(basePath);
    }
    
    public object GetPolkadotParameter(string endpoint, string module, string method)
    {
        return _api.QueryControllerGet(endpoint, module, method);
    }

    public object CallPolkadotMethod(string endpoint, string module, string method, ApiRequestBody body)
    {
        return _api.QueryControllerQuery(endpoint, module, method, body);
    }
}