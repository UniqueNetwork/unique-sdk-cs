using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service;

public interface IQueryService
{

    object GetPolkadotParameter(string endpoint, string module, string method);

    object CallPolkadotMethod(string endpoint, string module, string method, ApiRequestBody body);

}