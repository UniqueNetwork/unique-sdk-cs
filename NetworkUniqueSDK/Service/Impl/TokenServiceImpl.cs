using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Service.Impl.Collection;
using Network.Unique.SDK.Signer;

namespace Network.Unique.SDK.Service.Impl;

public class TokenServiceImpl : ITokenService
{
    
    private TokensApi _api;
    private MutationService<ApproveTokenBody> _approveToken;
    private MutationService<BurnTokenBody> _burnToken;
    private MutationService<CreateMultipleTokensBody> _createMultipleTokens;
    private MutationService<CreateTokenBody> _createToken;
    private MutationService<DeleteTokenPropertiesBody> _deleteTokenProperties;
    private MutationService<NestTokenBody> _nestToken;
    private MutationService<SetTokenPropertiesBody> _setTokenProperties;
    private MutationService<TransferTokenBody> _transferToken;
    private MutationService<UnnestTokenBody> _unnestToken;

    public TokenServiceImpl(SignerWrapper signerWrapper, String basePath)
    {
        this._api = new TokensApi(basePath);
        this._approveToken = new ApproveTokenMutationServiceImpl(signerWrapper, _api);
        this._burnToken = new BurnTokenTokenMutationServiceImpl(signerWrapper, _api);
        this._createMultipleTokens = new CreateMultipleTokensMutationTokenMutationServiceImpl(signerWrapper, _api);
        this._createToken = new CreateNewTokenMutationTokenMutationServiceImpl(signerWrapper, _api);
        this._deleteTokenProperties = new DeleteTokenPropertiesTokenMutationServiceImpl(signerWrapper, _api);
        this._nestToken = new NestTokenTokenMutationServiceImpl(signerWrapper, _api);
        this._setTokenProperties = new SetTokenPropertiesTokenMutationServiceImpl(signerWrapper, _api);
        this._transferToken = new TransferTokenTokenMutationServiceImpl(signerWrapper, _api);
        this._unnestToken = new UnnestTokenTokenMutationServiceImpl(signerWrapper, _api);
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

    public AllowanceResultResponse TokenIsAllowed(decimal tokenId, decimal collectionId, string from, string to, string at)
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