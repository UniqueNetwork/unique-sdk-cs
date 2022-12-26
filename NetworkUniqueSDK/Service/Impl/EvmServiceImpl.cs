using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Service.Impl.Collection;

namespace Network.Unique.SDK.Service.Impl;

public class EvmServiceImpl : IEvmService
{
    private readonly EvmApi _api;
    private readonly MutationService<EvmSendArgumentsDto> _evmSend;

    public EvmServiceImpl(string basePath)
    {
        _api = new EvmApi(basePath);
        _evmSend = new EvmSendServiceImpl(_api);
    }

    public EvmContractExistsResponseDto IsContractExists(string contractAddress)
    {
        return _api.EvmControllerEvmExist(contractAddress);
    }

    public object Call(EvmCallArgumentsDto body)
    {
        return _api.EvmControllerEvmCall(body);
    }

    public MutationService<EvmSendArgumentsDto> GetEvmSend()
    {
        return _evmSend;
    }
}