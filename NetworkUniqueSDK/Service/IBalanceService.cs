using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service;

public interface IBalanceService
{
    AllBalancesResponse GetBalance(string address);

    MutationService<BalanceTransferBody> GetTransferMutationService();
}