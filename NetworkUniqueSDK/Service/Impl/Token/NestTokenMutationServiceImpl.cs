using Network.Unique.API.Api;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service.Impl.Collection;

public class NestTokenTokenMutationServiceImpl : MutationService<NestTokenBody>
{
    private readonly TokensApi _api;

    public NestTokenTokenMutationServiceImpl(TokensApi api)
    {
        _api = api;
    }

    public NestTokenTokenMutationServiceImpl(string basePath)
    {
        _api = new TokensApi(basePath);
    }

    public override UnsignedTxPayloadResponse Build(NestTokenBody args)
    {
        var request = new NestTokenRequest(args);
        var response = _api.NestToken(request, "build", true);
        return response.GetUnsignedTxPayloadResponse();
    }

    public override FeeResponse GetFee(NestTokenBody args)
    {
        var request = new NestTokenRequest(args);
        var response = _api.NestToken(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(UnsignedTxPayloadResponse args)
    {
        var request = new NestTokenRequest(
            new UnsignedTxPayloadBody(
                args.SignerPayloadJSON,
                args.SignerPayloadRaw,
                args.SignerPayloadHex
            )
        );
        var response = _api.NestToken(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(SubmitTxBody args)
    {
        var request = new NestTokenRequest(args);
        var response = _api.NestToken(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override SubmitTxBody Sign(NestTokenBody args)
    {
        var signPayload = Build(args);
        return Sign(signPayload);
    }

    public override SubmitTxBody Sign(UnsignedTxPayloadResponse args)
    {
        var signature = UniqueSdk.SignerWrapper.Sign(args.SignerPayloadRaw.Data);
        return new SubmitTxBody(args.SignerPayloadJSON, signature);
    }

    public override SubmitResultResponse Submit(NestTokenBody args)
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
        var request = new NestTokenRequest(args);
        var response = _api.NestToken(request, "submit");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }

    public override SubmitResultResponse SubmitWatch(NestTokenBody args)
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
        var request = new NestTokenRequest(args);
        var response = _api.NestToken(request, "submitWatch");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }
}