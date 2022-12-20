using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service;

public interface IERC721Service
{

    MutationService<CreateERC721CollectionBody> GetCreateERC721Collection();

    MutationService<CreateERC721TokenBody> GetCreateERC721Token();

}