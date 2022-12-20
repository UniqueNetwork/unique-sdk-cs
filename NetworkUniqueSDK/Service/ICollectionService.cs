using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service;

public interface ICollectionService
{
    CollectionInfoWithSchemaResponse GetCollections(decimal collectionId, string at);

    GetStatsResponse GetStats(string at);

    EffectiveCollectionLimitsResponse GetLimits(decimal collectionId, string at);

    CollectionPropertiesResponse GetProperties(decimal collectionId, string at);

    GetCollectionTokensResponse GetCollectionTokens(decimal collectionId, string at);

    PropertyPermissionsResponse GetCollectionPropertyPermissions(
        decimal collectionId,
        List<string> propertyKeys,
        string at
    );

    NextSponsoredResponse GetCollectionNextSponsored(decimal collectionId, string address, decimal tokenId, string at);

    LastTokenIdResultDto GetCollectionLastTokenId(decimal collectionId, string at);

    AllowListBodyResult GetCollectionAllowList(decimal collectionId, string at);

    AllowedResponse GetCollectionAllowed(decimal collectionId, string account, string at);

    AdminlistResponse GetCollectionAdmins(decimal collectionId, string at);

    TotalSupplyResponse GetTotalSupply(decimal collectionId, string at);

    MutationService<AddCollectionAdminBody> GetAddCollectionAdmin();

    MutationService<AddToAllowListBody> GetAddToAllowList();

    MutationService<ConfirmSponsorshipBody> GetConfirmSponsorship();

    MutationService<CreateCollectionBody> GetCreateCollection();

    MutationService<DestroyCollectionBody> GetDestroyCollection();

    MutationService<DeleteCollectionPropertiesBody> GetDeleteCollectionProperties();

    MutationService<RemoveCollectionAdminBody> GetRemoveCollectionAdmin();

    MutationService<RemoveFromAllowListBody> GetRemoveFromAllowList();

    MutationService<RemoveSponsorshipBody> GetRemoveSponsorship();

    MutationService<SetCollectionLimitsBody> GetSetCollectionLimits();

    MutationService<SetCollectionPermissionsBody> GetSetCollectionPermissions();

    MutationService<SetCollectionPropertiesBody> GetSetCollectionProperties();

    MutationService<SetPropertyPermissionsBody> GetSetPropertyPermissions();

    MutationService<SetSponsorshipBody> GetSetSponsorship();

    MutationService<SetTransfersEnabledBody> GetSetTransfersEnabled();

    MutationService<TransferCollectionBody> GetTransferCollection();
}