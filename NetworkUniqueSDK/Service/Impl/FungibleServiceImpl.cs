using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Service.Impl.Collection;

namespace Network.Unique.SDK.Service.Impl;

public class FungibleServiceImpl : IFungibleService
{
    private readonly MutationService<AddTokensArgsDto> _addTokens;

    private readonly FungibleApi _api;
    private readonly MutationService<CreateFungibleCollectionRequest> _createFungibleCollection;
    private readonly MutationService<TransferTokensArgsDto> _transferTokens;

    public FungibleServiceImpl(string basePath)
    {
        _api = new FungibleApi(basePath);
        _addTokens = new AddTokensMutationServiceImpl(_api);
        _createFungibleCollection = new CreateFungibleCollectionMutationServiceImpl(_api);
        _transferTokens = new TransferTokensMutationServiceImpl(_api);
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