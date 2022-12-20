using Network.Unique.SDK.Service;
using Network.Unique.SDK.Service.Impl;
using Network.Unique.SDK.Signer;

namespace Network.Unique.SDK;

public class UniqueSdk
{
    
    public IAccountService AccountService { get; set; }
    public IAddressUtilsService AddressUtilsService { get; set; }
    public IBalanceService BalanceService { get; set; }
    public ICollectionService CollectionService { get; set; }
    public ICommonService CommonService { get; set; }
    public IERC721Service ERC721Service { get; set; }
    public IEvmService EvmService { get; set; }
    public IExtrinsicService ExtrinsicService { get; set; }
    public IFungibleService FungibleService { get; set; }
    public IIPFSService IPFSService { get; set; }
    public IQueryService QueryService { get; set; }
    public ITokenService TokenService { get; set; }

    public UniqueSdk(SignerWrapper signerWrapper, string basePath)
    {
        this.AccountService = new AccountServiceImpl(basePath);
        this.AddressUtilsService = new AddressUtilsServiceImpl(basePath);
        this.BalanceService = new BalanceServiceImpl(signerWrapper, basePath);
        this.CollectionService = new CollectionServiceImpl(signerWrapper, basePath);
        this.CommonService = new CommonServiceImpl(basePath);
        this.ERC721Service = new ERC721ServiceImpl(signerWrapper, basePath);
        this.EvmService = new EvmServiceImpl(signerWrapper, basePath);
        this.ExtrinsicService = new ExtrinsicServiceImpl(signerWrapper, basePath);
        this.FungibleService = new FungibleServiceImpl(signerWrapper, basePath);
        this.IPFSService = new IPFSServiceImpl(basePath);
        this.QueryService = new QueryServiceImpl(basePath);
        this.TokenService = new TokenServiceImpl(signerWrapper, basePath);
    }

}