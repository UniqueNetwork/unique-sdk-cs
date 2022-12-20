using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Service.Impl.Balance;
using Network.Unique.SDK.Service.Impl.Collection;
using Network.Unique.SDK.Signer;

namespace Network.Unique.SDK.Service.Impl;

public class EvmServiceImpl : IEvmService
{
    
    private EvmApi _api;
    private MutationService<EvmSendArgumentsDto> _evmSend;

    public EvmServiceImpl(SignerWrapper signerWrapper, String basePath)
    {
        this._api = new EvmApi(basePath);
        this._evmSend = new EvmSendServiceImpl(signerWrapper, _api);
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