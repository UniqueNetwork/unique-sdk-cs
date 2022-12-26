using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Service.Impl.Collection;

namespace Network.Unique.SDK.Service.Impl;

public class CollectionServiceImpl : ICollectionService
{
    private readonly MutationService<AddCollectionAdminBody> _addCollectionAdmin;
    private readonly MutationService<AddToAllowListBody> _addToAllowList;

    private readonly CollectionsApi _api;
    private readonly MutationService<ConfirmSponsorshipBody> _confirmSponsorship;
    private readonly MutationService<CreateCollectionBody> _createCollection;
    private readonly MutationService<DeleteCollectionPropertiesBody> _deleteCollectionProperties;
    private readonly MutationService<DestroyCollectionBody> _destroyCollection;
    private readonly MutationService<RemoveCollectionAdminBody> _removeCollectionAdmin;
    private readonly MutationService<RemoveFromAllowListBody> _removeFromAllowList;
    private readonly MutationService<RemoveSponsorshipBody> _removeSponsorship;
    private readonly MutationService<SetCollectionLimitsBody> _setCollectionLimits;
    private readonly MutationService<SetCollectionPermissionsBody> _setCollectionPermissions;
    private readonly MutationService<SetCollectionPropertiesBody> _setCollectionProperties;
    private readonly MutationService<SetPropertyPermissionsBody> _setPropertyPermissions;
    private readonly MutationService<SetSponsorshipBody> _setSponsorship;
    private readonly MutationService<SetTransfersEnabledBody> _setTransfersEnabled;
    private readonly MutationService<TransferCollectionBody> _transferCollection;

    public CollectionServiceImpl(string basePath)
    {
        _api = new CollectionsApi(basePath);
        _addCollectionAdmin = new AddCollectionAdminMutationServiceImpl(_api);
        _addToAllowList = new AddToAllowListMutationServiceImpl(_api);
        _confirmSponsorship = new ConfirmSponsorshipMutationServiceImpl(_api);
        _createCollection = new CreateCollectionMutationMutationServiceImpl(_api);
        _deleteCollectionProperties = new DeleteCollectionPropertiesMutationServiceImpl(_api);
        _destroyCollection = new DestroyMutationServiceImpl(_api);
        _removeCollectionAdmin = new RemoveAdminMutationServiceImpl(_api);
        _removeFromAllowList = new RemoveFromAllowListMutationServiceImpl(_api);
        _removeSponsorship = new RemoveSponsorshipMutationServiceImpl(_api);
        _setCollectionLimits = new SetCollectionLimitsMutationServiceImpl(_api);
        _setCollectionPermissions = new SetPermissionsMutationServiceImpl(_api);
        _setCollectionProperties = new SetCollectionPropertiesMutationServiceImpl(_api);
        _setPropertyPermissions = new SetPropertyPermissionsMutationServiceImpl(_api);
        _setSponsorship = new SetSponsorshipMutationServiceImpl(_api);
        _setTransfersEnabled = new SetTransfersEnabledMutationServiceImpl(_api);
        _transferCollection = new TransferMutationServiceImpl(_api);
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

    public PropertyPermissionsResponse GetCollectionPropertyPermissions(decimal collectionId, List<string> propertyKeys,
        string at)
    {
        return _api.CollectionControllerPropertyPermissions(collectionId, propertyKeys, at);
    }

    public NextSponsoredResponse GetCollectionNextSponsored(decimal collectionId, string address, decimal tokenId,
        string at)
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