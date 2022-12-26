using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Service.Impl.Collection;

namespace Network.Unique.SDK.Service.Impl;

public class TokenServiceImpl : ITokenService
{
    private readonly TokensApi _api;
    private readonly MutationService<ApproveTokenBody> _approveToken;
    private readonly MutationService<BurnTokenBody> _burnToken;
    private readonly MutationService<CreateMultipleTokensBody> _createMultipleTokens;
    private readonly MutationService<CreateTokenBody> _createToken;
    private readonly MutationService<DeleteTokenPropertiesBody> _deleteTokenProperties;
    private readonly MutationService<NestTokenBody> _nestToken;
    private readonly MutationService<SetTokenPropertiesBody> _setTokenProperties;
    private readonly MutationService<TransferTokenBody> _transferToken;
    private readonly MutationService<UnnestTokenBody> _unnestToken;

    public TokenServiceImpl(string basePath)
    {
        _api = new TokensApi(basePath);
        _approveToken = new ApproveTokenMutationServiceImpl(_api);
        _burnToken = new BurnTokenTokenMutationServiceImpl(_api);
        _createMultipleTokens = new CreateMultipleTokensMutationTokenMutationServiceImpl(_api);
        _createToken = new CreateNewTokenMutationTokenMutationServiceImpl(_api);
        _deleteTokenProperties = new DeleteTokenPropertiesTokenMutationServiceImpl(_api);
        _nestToken = new NestTokenTokenMutationServiceImpl(_api);
        _setTokenProperties = new SetTokenPropertiesTokenMutationServiceImpl(_api);
        _transferToken = new TransferTokenTokenMutationServiceImpl(_api);
        _unnestToken = new UnnestTokenTokenMutationServiceImpl(_api);
    }

    public TokenByIdResponse GetToken(decimal tokenId, decimal collectionId, string at)
    {
        return _api.NewTokenControllerGetTokenNew(collectionId, tokenId, at);
    }

    public TokenChildrenResponse GetTokenChildren(decimal tokenId, decimal collectionId, string at)
    {
        return _api.NewTokenControllerTokenChildren(collectionId, tokenId, at);
    }

    public TokenParentResponse GetTokenParent(decimal tokenId, decimal collectionId, string at)
    {
        return _api.NewTokenControllerTokenParent(collectionId, tokenId, at);
    }

    public TokenOwnerResponse GetTokenOwner(decimal tokenId, decimal collectionId, string at)
    {
        return _api.NewTokenControllerTokenOwner(collectionId, tokenId, at);
    }

    public TopmostTokenOwnerResponse GetTompostTokenOwner(decimal tokenId, decimal collectionId, string at)
    {
        return _api.NewTokenControllerTopmostTokenOwner(collectionId, tokenId, at);
    }

    public IsBundleResponse TokenIsBundle(decimal tokenId, decimal collectionId, string at)
    {
        return _api.NewTokenControllerIsBundle(collectionId, tokenId, at);
    }

    public GetBundleResponse GetTokenBundle(decimal tokenId, decimal collectionId, string at)
    {
        return _api.NewTokenControllerGetBundle(collectionId, tokenId, at);
    }

    public TokenPropertiesResponse GetTokenProperties(decimal tokenId, decimal collectionId, string at)
    {
        return _api.NewTokenControllerTokenProperties(collectionId, tokenId, at);
    }

    public AccountTokensResponse GetAccountTokens(string address, decimal collectionId, string at)
    {
        return _api.NewTokenControllerGetAccountTokens(address, collectionId, at);
    }

    public TokenExistsResponse TokenIsExists(decimal tokenId, decimal collectionId, string at)
    {
        return _api.NewTokenControllerGetTokensExists(collectionId, tokenId, at);
    }

    public AllowanceResultResponse TokenIsAllowed(decimal tokenId, decimal collectionId, string from, string to,
        string at)
    {
        return _api.NewTokenControllerAllowance(collectionId, tokenId, from, to, at);
    }

    public TokenBalanceResponse GetTokenBalance(decimal tokenId, decimal collectionId, string address, string at)
    {
        return _api.NewTokenControllerGetBalance(collectionId, tokenId, address, at);
    }

    public MutationService<ApproveTokenBody> GetApproveToken()
    {
        return _approveToken;
    }

    public MutationService<BurnTokenBody> GetBurnToken()
    {
        return _burnToken;
    }

    public MutationService<CreateMultipleTokensBody> GetCreateMultipleTokens()
    {
        return _createMultipleTokens;
    }

    public MutationService<CreateTokenBody> GetCreateToken()
    {
        return _createToken;
    }

    public MutationService<DeleteTokenPropertiesBody> GetDeleteTokenProperties()
    {
        return _deleteTokenProperties;
    }

    public MutationService<NestTokenBody> GetNestToken()
    {
        return _nestToken;
    }

    public MutationService<SetTokenPropertiesBody> GetSetTokenProperties()
    {
        return _setTokenProperties;
    }

    public MutationService<TransferTokenBody> GetTransferToken()
    {
        return _transferToken;
    }

    public MutationService<UnnestTokenBody> GetUnnestToken()
    {
        return _unnestToken;
    }
}