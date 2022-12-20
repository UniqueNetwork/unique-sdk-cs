using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service;

public interface IAccountService
{

    AccountDataResponse GetAccount(string mnemonic, string pairType, Object meta);

    AccountDataResponse GenerateAccount(GenerateAccountDataBody body);

}