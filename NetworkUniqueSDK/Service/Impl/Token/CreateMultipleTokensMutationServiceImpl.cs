using Network.Unique.API.Api;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service.Impl.Collection;

public class CreateMultipleTokensMutationTokenMutationServiceImpl : MutationService<CreateMultipleTokensBody>
{
    private readonly TokensApi _api;

    public CreateMultipleTokensMutationTokenMutationServiceImpl(TokensApi api)
    {
        _api = api;
    }

    public CreateMultipleTokensMutationTokenMutationServiceImpl(string basePath)
    {
        _api = new TokensApi(basePath);
    }

    public override UnsignedTxPayloadResponse Build(CreateMultipleTokensBody args)
    {
        var request = new CreateMultipleTokensMutationRequest(args);
        var response = _api.CreateMultipleTokensMutation(request, "build", true);
        return response.GetUnsignedTxPayloadResponse();
    }

    public override FeeResponse GetFee(CreateMultipleTokensBody args)
    {
        var request = new CreateMultipleTokensMutationRequest(args);
        var response = _api.CreateMultipleTokensMutation(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(UnsignedTxPayloadResponse args)
    {
        var request = new CreateMultipleTokensMutationRequest(
            new UnsignedTxPayloadBody(
                args.SignerPayloadJSON,
                args.SignerPayloadRaw,
                args.SignerPayloadHex
            )
        );
        var response = _api.CreateMultipleTokensMutation(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(SubmitTxBody args)
    {
        var request = new CreateMultipleTokensMutationRequest(args);
        var response = _api.CreateMultipleTokensMutation(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override SubmitTxBody Sign(CreateMultipleTokensBody args)
    {
        var signPayload = Build(args);
        return Sign(signPayload);
    }

    public override SubmitTxBody Sign(UnsignedTxPayloadResponse args)
    {
        var signature = UniqueSdk.SignerWrapper.Sign(args.SignerPayloadRaw.Data);
        return new SubmitTxBody(args.SignerPayloadJSON, signature);
    }

    public override SubmitResultResponse Submit(CreateMultipleTokensBody args)
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
        var request = new CreateMultipleTokensMutationRequest(args);
        var response = _api.CreateMultipleTokensMutation(request, "submit");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }

    public override SubmitResultResponse SubmitWatch(CreateMultipleTokensBody args)
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
        var request = new CreateMultipleTokensMutationRequest(args);
        var response = _api.CreateMultipleTokensMutation(request, "submitWatch");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }
}