using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Service.Impl.Collection;
using Network.Unique.SDK.Signer;

namespace Network.Unique.SDK.Service.Impl;

public class CollectionServiceImpl : ICollectionService
{
    
    private CollectionsApi _api;
    private MutationService<AddCollectionAdminBody> _addCollectionAdmin;
    private MutationService<AddToAllowListBody> _addToAllowList;
    private MutationService<ConfirmSponsorshipBody> _confirmSponsorship;
    private MutationService<CreateCollectionBody> _createCollection;
    private MutationService<DeleteCollectionPropertiesBody> _deleteCollectionProperties;
    private MutationService<DestroyCollectionBody> _destroyCollection;
    private MutationService<RemoveCollectionAdminBody> _removeCollectionAdmin;
    private MutationService<RemoveFromAllowListBody> _removeFromAllowList;
    private MutationService<RemoveSponsorshipBody> _removeSponsorship;
    private MutationService<SetCollectionLimitsBody> _setCollectionLimits;
    private MutationService<SetCollectionPermissionsBody> _setCollectionPermissions;
    private MutationService<SetCollectionPropertiesBody> _setCollectionProperties;
    private MutationService<SetPropertyPermissionsBody> _setPropertyPermissions;
    private MutationService<SetSponsorshipBody> _setSponsorship;
    private MutationService<SetTransfersEnabledBody> _setTransfersEnabled;
    private MutationService<TransferCollectionBody> _transferCollection;

    public CollectionServiceImpl(SignerWrapper signerWrapper, String basePath)
    {
        this._api = new CollectionsApi(basePath);
        this._addCollectionAdmin = new AddCollectionAdminMutationServiceImpl(signerWrapper, _api);
        this._addToAllowList = new AddToAllowListMutationServiceImpl(signerWrapper, _api);
        this._confirmSponsorship = new ConfirmSponsorshipMutationServiceImpl(signerWrapper, _api);
        this._createCollection = new CreateCollectionMutationMutationServiceImpl(signerWrapper, _api);
        this._deleteCollectionProperties = new DeleteCollectionPropertiesMutationServiceImpl(signerWrapper, _api);
        this._destroyCollection = new DestroyMutationServiceImpl(signerWrapper, _api);
        this._removeCollectionAdmin = new RemoveAdminMutationServiceImpl(signerWrapper, _api);
        this._removeFromAllowList = new RemoveFromAllowListMutationServiceImpl(signerWrapper, _api);
        this._removeSponsorship = new RemoveSponsorshipMutationServiceImpl(signerWrapper, _api);
        this._setCollectionLimits = new SetCollectionLimitsMutationServiceImpl(signerWrapper, _api);
        this._setCollectionPermissions = new SetPermissionsMutationServiceImpl(signerWrapper, _api);
        this._setCollectionProperties = new SetCollectionPropertiesMutationServiceImpl(signerWrapper, _api);
        this._setPropertyPermissions = new SetPropertyPermissionsMutationServiceImpl(signerWrapper, _api);
        this._setSponsorship = new SetSponsorshipMutationServiceImpl(signerWrapper, _api);
        this._setTransfersEnabled = new SetTransfersEnabledMutationServiceImpl(signerWrapper, _api);
        this._transferCollection = new TransferMutationServiceImpl(signerWrapper, _api);
    }
    
    public CollectionInfoWithSchemaResponse GetCollections(decimal collectionId, string at)
    {
        return _api.CollectionControllerGetCollection(collectionId, at);
    }

    public GetStatsResponse GetStats(string at)
    {
        return _api.CollectionControllerStats(at);
    }

    public EffectiveCollectionLimitsResponse GetLimits(decimal collectionId, string at)
    {
        return _api.CollectionControllerEffectiveCollectionLimits(collectionId, at);
    }

    public CollectionPropertiesResponse GetProperties(decimal collectionId, string at)
    {
        return _api.CollectionControllerCollectionProperties(collectionId, at);
    }

    public GetCollectionTokensResponse GetCollectionTokens(decimal collectionId, string at)
    {
        return _api.CollectionControllerCollectionTokens(collectionId, at);
    }

    public PropertyPermissionsResponse GetCollectionPropertyPermissions(decimal collectionId, List<string> propertyKeys, string at)
    {
        return _api.CollectionControllerPropertyPermissions(collectionId, propertyKeys, at);
    }

    public NextSponsoredResponse GetCollectionNextSponsored(decimal collectionId, string address, decimal tokenId, string at)
    {
        return _api.CollectionControllerNextSponsored(collectionId, address, tokenId, at);
    }

    public LastTokenIdResultDto GetCollectionLastTokenId(decimal collectionId, string at)
    {
        return _api.CollectionControllerLastTokenId(collectionId, at);
    }

    public AllowListBodyResult GetCollectionAllowList(decimal collectionId, string at)
    {
        return _api.CollectionControllerAllowList(collectionId, at);
    }

    public AllowedResponse GetCollectionAllowed(decimal collectionId, string account, string at)
    {
        return _api.CollectionControllerAllowed(collectionId, account, account);
    }

    public AdminlistResponse GetCollectionAdmins(decimal collectionId, string at)
    {
        return _api.CollectionControllerAdmins(collectionId, at);
    }

    public TotalSupplyResponse GetTotalSupply(decimal collectionId, string at)
    {
        return _api.CollectionControllerTotalSupply(collectionId, at);
    }

    public MutationService<AddCollectionAdminBody> GetAddCollectionAdmin()
    {
        return _addCollectionAdmin;
    }

    public MutationService<AddToAllowListBody> GetAddToAllowList()
    {
        return _addToAllowList;
    }

    public MutationService<ConfirmSponsorshipBody> GetConfirmSponsorship()
    {
        return _confirmSponsorship;
    }

    public MutationService<CreateCollectionBody> GetCreateCollection()
    {
        return _createCollection;
    }

    public MutationService<DestroyCollectionBody> GetDestroyCollection()
    {
        return _destroyCollection;
    }

    public MutationService<DeleteCollectionPropertiesBody> GetDeleteCollectionProperties()
    {
        return _deleteCollectionProperties;
    }

    public MutationService<RemoveCollectionAdminBody> GetRemoveCollectionAdmin()
    {
        return _removeCollectionAdmin;
    }

    public MutationService<RemoveFromAllowListBody> GetRemoveFromAllowList()
    {
        return _removeFromAllowList;
    }

    public MutationService<RemoveSponsorshipBody> GetRemoveSponsorship()
    {
        return _removeSponsorship;
    }

    public MutationService<SetCollectionLimitsBody> GetSetCollectionLimits()
    {
        return _setCollectionLimits;
    }

    public MutationService<SetCollectionPermissionsBody> GetSetCollectionPermissions()
    {
        return _setCollectionPermissions;
    }

    public MutationService<SetCollectionPropertiesBody> GetSetCollectionProperties()
    {
        return _setCollectionProperties;
    }

    public MutationService<SetPropertyPermissionsBody> GetSetPropertyPermissions()
    {
        return _setPropertyPermissions;
    }

    public MutationService<SetSponsorshipBody> GetSetSponsorship()
    {
        return _setSponsorship;
    }

    public MutationService<SetTransfersEnabledBody> GetSetTransfersEnabled()
    {
        return _setTransfersEnabled;
    }

    public MutationService<TransferCollectionBody> GetTransferCollection()
    {
        return _transferCollection;
    }
}