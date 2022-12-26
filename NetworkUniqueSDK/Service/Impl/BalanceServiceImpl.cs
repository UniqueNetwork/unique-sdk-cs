using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Service.Impl.Balance;

namespace Network.Unique.SDK.Service.Impl;

public class BalanceServiceImpl : IBalanceService
{
    private readonly BalanceApi _api;
    private readonly MutationService<BalanceTransferBody> _balanceTransferService;

    public BalanceServiceImpl(string basePath)
    {
        _api = new BalanceApi(basePath);
        _balanceTransferService = new BalanceTransferMutationServiceImpl(_api);
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