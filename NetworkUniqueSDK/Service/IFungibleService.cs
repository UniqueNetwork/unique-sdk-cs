using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service;

public interface IFungibleService
{

    FungibleCollectionInfoDto GetFungibleCollectionInfo(decimal collectionId, string at);

    BalanceResponse GetBalance(decimal collectionId, string address, string at);

    MutationService<AddTokensArgsDto> GetAddTokens();

    MutationService<CreateFungibleCollectionRequest> GetCreateFungibleCollection();

    MutationService<TransferTokensArgsDto> GetTransferTokens();

}