using Network.Unique.API.Api;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service.Impl;

public class AddressUtilsServiceImpl : IAddressUtilsService
{
    
    private AddressUtilsApi _api;

    public AddressUtilsServiceImpl(String basePath)
    {
        this._api = new AddressUtilsApi(basePath);
    }
    
    public NestingAddressDto IdsToAddress(decimal collectionId, decimal tokenId, string at)
    {
        return _api.AddressUtilsControllerNestingTokenIdToAddress(collectionId, tokenId, at);
    }

    public TokenIdQuery AddressToIds(string address)
    {
        return _api.AddressUtilsControllerNestingAddressToCollection(address);
    }

    public EthereumAddressDto SubstrateToEthereum(string address)
    {
        return _api.AddressUtilsControllerSubstrateToEthereum(address);
    }

    public AddressDto EthereumToSubstrate(string address)
    {
        return _api.AddressUtilsControllerEthereumToSubstrate(address);
    }

    public AddressDto Normalize(string address, decimal ss58prefix)
    {
        return _api.AddressUtilsControllerNormalize(address, ss58prefix);
    }
}