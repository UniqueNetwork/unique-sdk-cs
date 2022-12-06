using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Service.Impl.Balance;
using Network.Unique.SDK.Signer;

namespace Network.Unique.SDK.Service.Impl;

public class BalanceServiceImpl : IBalanceService
{

    private BalanceApi _api;
    private MutationService<BalanceTransferBody> _balanceTransferService;

    public BalanceServiceImpl(SignerWrapper signerWrapper, String basePath)
    {
        this._api = new BalanceApi(basePath);
        this._balanceTransferService = new BalanceTransferMutationServiceImpl(signerWrapper, _api);
    }

    public AllBalancesResponse GetBalance(string address)
    {
        return _api.BalanceControllerGetBalance(address);
    }

    public MutationService<BalanceTransferBody> GetTransferMutationService()
    {
        return _balanceTransferService;
    }
}