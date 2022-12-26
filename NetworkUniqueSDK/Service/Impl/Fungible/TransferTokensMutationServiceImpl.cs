using Network.Unique.API.Api;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service.Impl.Collection;

public class TransferTokensMutationServiceImpl : MutationService<TransferTokensArgsDto>
{
    private readonly FungibleApi _api;

    public TransferTokensMutationServiceImpl(FungibleApi api)
    {
        _api = api;
    }

    public TransferTokensMutationServiceImpl(string basePath)
    {
        _api = new FungibleApi(basePath);
    }

    public override UnsignedTxPayloadResponse Build(TransferTokensArgsDto args)
    {
        var request = new TransferTokensMutationRequest(args);
        var response = _api.TransferTokensMutation(request, "build", true);
        return response.GetUnsignedTxPayloadResponse();
    }

    public override FeeResponse GetFee(TransferTokensArgsDto args)
    {
        var request = new TransferTokensMutationRequest(args);
        var response = _api.TransferTokensMutation(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(UnsignedTxPayloadResponse args)
    {
        var request = new TransferTokensMutationRequest(
            new UnsignedTxPayloadBody(
                args.SignerPayloadJSON,
                args.SignerPayloadRaw,
                args.SignerPayloadHex
            )
        );
        var response = _api.TransferTokensMutation(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(SubmitTxBody args)
    {
        var request = new TransferTokensMutationRequest(args);
        var response = _api.TransferTokensMutation(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override SubmitTxBody Sign(TransferTokensArgsDto args)
    {
        var signPayload = Build(args);
        return Sign(signPayload);
    }

    public override SubmitTxBody Sign(UnsignedTxPayloadResponse args)
    {
        var signature = UniqueSdk.SignerWrapper.Sign(args.SignerPayloadRaw.Data);
        return new SubmitTxBody(args.SignerPayloadJSON, signature);
    }

    public override SubmitResultResponse Submit(TransferTokensArgsDto args)
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
        var request = new TransferTokensMutationRequest(args);
        var response = _api.TransferTokensMutation(request, "submit");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }

    public override SubmitResultResponse SubmitWatch(TransferTokensArgsDto args)
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
        var request = new TransferTokensMutationRequest(args);
        var response = _api.TransferTokensMutation(request, "submitWatch");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }
}