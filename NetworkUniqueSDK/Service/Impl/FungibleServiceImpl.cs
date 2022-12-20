using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Service.Impl.Collection;
using Network.Unique.SDK.Signer;

namespace Network.Unique.SDK.Service.Impl;

public class FungibleServiceImpl : IFungibleService
{
    
    private FungibleApi _api;
    private MutationService<AddTokensArgsDto> _addTokens;
    private MutationService<CreateFungibleCollectionRequest> _createFungibleCollection;
    private MutationService<TransferTokensArgsDto> _transferTokens;

    public FungibleServiceImpl(SignerWrapper signerWrapper, String basePath)
    {
        this._api = new FungibleApi(basePath);
        this._addTokens = new AddTokensMutationServiceImpl(signerWrapper, _api);
        this._createFungibleCollection = new CreateFungibleCollectionMutationServiceImpl(signerWrapper, _api);
        this._transferTokens = new TransferTokensMutationServiceImpl(signerWrapper, _api);
    }
    
    public FungibleCollectionInfoDto GetFungibleCollectionInfo(decimal collectionId, string at)
    {
        return _api.FungibleControllerGetCollection(collectionId, at);
    }

    public BalanceResponse GetBalance(decimal collectionId, string address, string at)
    {
        return _api.FungibleControllerGetBalance(address, collectionId, address);
    }

    public MutationService<AddTokensArgsDto> GetAddTokens()
    {
        return _addTokens;
    }

    public MutationService<CreateFungibleCollectionRequest> GetCreateFungibleCollection()
    {
        return _createFungibleCollection;
    }

    public MutationService<TransferTokensArgsDto> GetTransferTokens()
    {
        return _transferTokens;
    }
}