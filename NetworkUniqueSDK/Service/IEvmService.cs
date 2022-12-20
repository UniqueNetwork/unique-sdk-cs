using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service;

public interface IEvmService
{

    EvmContractExistsResponseDto IsContractExists(string contractAddress);

    object Call(EvmCallArgumentsDto body);

    MutationService<EvmSendArgumentsDto> GetEvmSend();

}