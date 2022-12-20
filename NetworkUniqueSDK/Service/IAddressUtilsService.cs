using System.Numerics;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service;

public interface IAddressUtilsService
{

    NestingAddressDto IdsToAddress(decimal collectionId, decimal tokenId, string at);

    TokenIdQuery AddressToIds(string address);

    EthereumAddressDto SubstrateToEthereum(string address);

    AddressDto EthereumToSubstrate(string address);

    AddressDto Normalize(string address, decimal ss58prefix);

}