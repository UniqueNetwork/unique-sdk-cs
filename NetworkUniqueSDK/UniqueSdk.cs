using Network.Unique.SDK.Service;
using Network.Unique.SDK.Service.Impl;
using Network.Unique.SDK.Signer;

namespace Network.Unique.SDK;

public class UniqueSdk
{
    
    public static SignerWrapper? SignerWrapper { get; set; }
    
    public IAccountService AccountService { get; set; }
    public IAddressUtilsService AddressUtilsService { get; set; }
    public IBalanceService BalanceService { get; set; }
    public ICollectionService CollectionService { get; set; }
    public ICommonService CommonService { get; set; }
    public IEvmService EvmService { get; set; }
    public IExtrinsicService ExtrinsicService { get; set; }
    public IFungibleService FungibleService { get; set; }
    public IIPFSService IPFSService { get; set; }
    public IQueryService QueryService { get; set; }
    public ITokenService TokenService { get; set; }

    public UniqueSdk(string basePath)
    {
        this.AccountService = new AccountServiceImpl(basePath);
        this.AddressUtilsService = new AddressUtilsServiceImpl(basePath);
        this.BalanceService = new BalanceServiceImpl(basePath);
        this.CollectionService = new CollectionServiceImpl(basePath);
        this.CommonService = new CommonServiceImpl(basePath);
        this.EvmService = new EvmServiceImpl(basePath);
        this.ExtrinsicService = new ExtrinsicServiceImpl(basePath);
        this.FungibleService = new FungibleServiceImpl(basePath);
        this.IPFSService = new IPFSServiceImpl(basePath);
        this.QueryService = new QueryServiceImpl(basePath);
        this.TokenService = new TokenServiceImpl(basePath);
    }

}