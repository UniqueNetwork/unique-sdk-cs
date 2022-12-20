using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Signer;

namespace Network.Unique.SDK.Service.Impl;

public class ERC721ServiceImpl : IERC721Service
{
    
    private ERC721Api _api;

    public ERC721ServiceImpl(SignerWrapper signerWrapper, string basePath)
    {
        this._api = new ERC721Api(basePath);
    }
    
    public MutationService<CreateERC721CollectionBody> GetCreateERC721Collection()
    {
        throw new NotImplementedException();
    }

    public MutationService<CreateERC721TokenBody> GetCreateERC721Token()
    {
        throw new NotImplementedException();
    }
}