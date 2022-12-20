using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service;

public interface ITokenService
{

    TokenByIdResponse GetToken(decimal tokenId, decimal collectionId, string at);

    TokenChildrenResponse GetTokenChildren(decimal tokenId, decimal collectionId, string at);

    TokenParentResponse GetTokenParent(decimal tokenId, decimal collectionId, string at);

    TokenOwnerResponse GetTokenOwner(decimal tokenId, decimal collectionId, string at);

    TopmostTokenOwnerResponse GetTompostTokenOwner(decimal tokenId, decimal collectionId, string at);

    IsBundleResponse TokenIsBundle(decimal tokenId, decimal collectionId, string at);

    GetBundleResponse GetTokenBundle(decimal tokenId, decimal collectionId, string at);

    TokenPropertiesResponse GetTokenProperties(decimal tokenId, decimal collectionId, string at);

    AccountTokensResponse GetAccountTokens(string address, decimal collectionId, string at);

    TokenExistsResponse TokenIsExists(decimal tokenId, decimal collectionId, string at);

    AllowanceResultResponse TokenIsAllowed(decimal tokenId, decimal collectionId, string from, string to, string at);

    TokenBalanceResponse GetTokenBalance(decimal tokenId, decimal collectionId, string address, string at);

    MutationService<ApproveTokenBody> GetApproveToken();

    MutationService<BurnTokenBody> GetBurnToken();

    MutationService<CreateMultipleTokensBody> GetCreateMultipleTokens();

    MutationService<CreateTokenBody> GetCreateToken();

    MutationService<DeleteTokenPropertiesBody> GetDeleteTokenProperties();

    MutationService<NestTokenBody> GetNestToken();

    MutationService<SetTokenPropertiesBody> GetSetTokenProperties();

    MutationService<TransferTokenBody> GetTransferToken();

    MutationService<UnnestTokenBody> GetUnnestToken();

}