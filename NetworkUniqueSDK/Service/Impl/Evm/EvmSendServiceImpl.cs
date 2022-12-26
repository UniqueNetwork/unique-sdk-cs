using Network.Unique.API.Api;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service.Impl.Collection;

public class EvmSendServiceImpl : MutationService<EvmSendArgumentsDto>
{
    private readonly EvmApi _api;

    public EvmSendServiceImpl(EvmApi api)
    {
        _api = api;
    }

    public EvmSendServiceImpl(string basePath)
    {
        _api = new EvmApi(basePath);
    }

    public override UnsignedTxPayloadResponse Build(EvmSendArgumentsDto args)
    {
        var request = new EvmSendMutationRequest(args);
        var response = _api.EvmSendMutation(request, "build", true);
        return response.GetUnsignedTxPayloadResponse();
    }

    public override FeeResponse GetFee(EvmSendArgumentsDto args)
    {
        var request = new EvmSendMutationRequest(args);
        var response = _api.EvmSendMutation(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(UnsignedTxPayloadResponse args)
    {
        var request = new EvmSendMutationRequest(
            new UnsignedTxPayloadBody(
                args.SignerPayloadJSON,
                args.SignerPayloadRaw,
                args.SignerPayloadHex
            )
        );
        var response = _api.EvmSendMutation(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(SubmitTxBody args)
    {
        var request = new EvmSendMutationRequest(args);
        var response = _api.EvmSendMutation(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override SubmitTxBody Sign(EvmSendArgumentsDto args)
    {
        var signPayload = Build(args);
        return Sign(signPayload);
    }

    public override SubmitTxBody Sign(UnsignedTxPayloadResponse args)
    {
        var signature = UniqueSdk.SignerWrapper.Sign(args.SignerPayloadRaw.Data);
        return new SubmitTxBody(args.SignerPayloadJSON, signature);
    }

    public override SubmitResultResponse Submit(EvmSendArgumentsDto args)
    {
        var signedBody = Sign(args);
        return Submit(signedBody);
    }

    public override SubmitResultResponse Submit(UnsignedTxPayloadResponse args)
    {
        var signedBody = Sign(args);
        return Submit(signedBody);
    }

    public override SubmitResultResponse Submit(SubmitTxBody args)
    {
        var request = new EvmSendMutationRequest(args);
        var response = _api.EvmSendMutation(request, "submit");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }

    public override SubmitResultResponse SubmitWatch(EvmSendArgumentsDto args)
    {
        var signedBody = Sign(args);
        return SubmitWatch(signedBody);
    }

    public override SubmitResultResponse SubmitWatch(UnsignedTxPayloadResponse args)
    {
        var signedBody = Sign(args);
        return SubmitWatch(signedBody);
    }

    public override SubmitResultResponse SubmitWatch(SubmitTxBody args)
    {
        var request = new EvmSendMutationRequest(args);
        var response = _api.EvmSendMutation(request, "submitWatch");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }
}