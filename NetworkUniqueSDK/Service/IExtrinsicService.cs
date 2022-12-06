using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service;

public interface IExtrinsicService
{
    ExtrinsicResultResponse getExtrinsicStatus(string hash);
}