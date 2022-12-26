using Network.Unique.API.Api;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service.Impl.Collection;

public class SetTokenPropertiesTokenMutationServiceImpl : MutationService<SetTokenPropertiesBody>
{
    private readonly TokensApi _api;

    public SetTokenPropertiesTokenMutationServiceImpl(TokensApi api)
    {
        _api = api;
    }

    public SetTokenPropertiesTokenMutationServiceImpl(string basePath)
    {
        _api = new TokensApi(basePath);
    }

    public override UnsignedTxPayloadResponse Build(SetTokenPropertiesBody args)
    {
        var request = new SetTokenPropertiesRequest(args);
        var response = _api.SetTokenProperties(request, "build", true);
        return response.GetUnsignedTxPayloadResponse();
    }

    public override FeeResponse GetFee(SetTokenPropertiesBody args)
    {
        var request = new SetTokenPropertiesRequest(args);
        var response = _api.SetTokenProperties(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(UnsignedTxPayloadResponse args)
    {
        var request = new SetTokenPropertiesRequest(
            new UnsignedTxPayloadBody(
                args.SignerPayloadJSON,
                args.SignerPayloadRaw,
                args.SignerPayloadHex
            )
        );
        var response = _api.SetTokenProperties(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(SubmitTxBody args)
    {
        var request = new SetTokenPropertiesRequest(args);
        var response = _api.SetTokenProperties(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override SubmitTxBody Sign(SetTokenPropertiesBody args)
    {
        var signPayload = Build(args);
        return Sign(signPayload);
    }

    public override SubmitTxBody Sign(UnsignedTxPayloadResponse args)
    {
        var signature = UniqueSdk.SignerWrapper.Sign(args.SignerPayloadRaw.Data);
        return new SubmitTxBody(args.SignerPayloadJSON, signature);
    }

    public override SubmitResultResponse Submit(SetTokenPropertiesBody args)
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
        var request = new SetTokenPropertiesRequest(args);
        var response = _api.SetTokenProperties(request, "submit");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }

    public override SubmitResultResponse SubmitWatch(SetTokenPropertiesBody args)
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
        var request = new SetTokenPropertiesRequest(args);
        var response = _api.SetTokenProperties(request, "submitWatch");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }
}