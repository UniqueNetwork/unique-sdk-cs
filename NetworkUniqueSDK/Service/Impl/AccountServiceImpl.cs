using Network.Unique.API.Api;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service.Impl;

public class AccountServiceImpl : IAccountService
{
    private readonly AccountApi _api;

    public AccountServiceImpl(string basePath)
    {
        _api = new AccountApi(basePath);
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