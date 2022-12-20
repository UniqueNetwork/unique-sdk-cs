using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Service.Impl.Balance;
using Network.Unique.SDK.Signer;

namespace Network.Unique.SDK.Service.Impl;

public class AccountServiceImpl : IAccountService
{
    
    private AccountApi _api;

    public AccountServiceImpl(String basePath)
    {
        this._api = new AccountApi(basePath);
    }
    
    public AccountDataResponse GetAccount(string mnemonic, string pairType, object meta)
    {
        return _api.AccountControllerGetAccount(mnemonic, pairType, meta);
    }

    public AccountDataResponse GenerateAccount(GenerateAccountDataBody body)
    {
        return _api.AccountControllerGenerate(body);
    }
}