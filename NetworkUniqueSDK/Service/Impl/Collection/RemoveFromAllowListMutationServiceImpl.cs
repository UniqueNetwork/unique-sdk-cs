using Network.Unique.API.Api;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service.Impl.Collection;

public class RemoveFromAllowListMutationServiceImpl : MutationService<RemoveFromAllowListBody>
{
    private readonly CollectionsApi _api;

    public RemoveFromAllowListMutationServiceImpl(CollectionsApi api)
    {
        _api = api;
    }

    public RemoveFromAllowListMutationServiceImpl(string basePath)
    {
        _api = new CollectionsApi(basePath);
    }

    public override UnsignedTxPayloadResponse Build(RemoveFromAllowListBody args)
    {
        var request = new RemoveFromAllowListRequest(args);
        var response = _api.RemoveFromAllowList(request, "build", true);
        return response.GetUnsignedTxPayloadResponse();
    }

    public override FeeResponse GetFee(RemoveFromAllowListBody args)
    {
        var request = new RemoveFromAllowListRequest(args);
        var response = _api.RemoveFromAllowList(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(UnsignedTxPayloadResponse args)
    {
        var request = new RemoveFromAllowListRequest(
            new UnsignedTxPayloadBody(
                args.SignerPayloadJSON,
                args.SignerPayloadRaw,
                args.SignerPayloadHex
            )
        );
        var response = _api.RemoveFromAllowList(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(SubmitTxBody args)
    {
        var request = new RemoveFromAllowListRequest(args);
        var response = _api.RemoveFromAllowList(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override SubmitTxBody Sign(RemoveFromAllowListBody args)
    {
        var signPayload = Build(args);
        return Sign(signPayload);
    }

    public override SubmitTxBody Sign(UnsignedTxPayloadResponse args)
    {
        var signature = UniqueSdk.SignerWrapper.Sign(args.SignerPayloadRaw.Data);
        return new SubmitTxBody(args.SignerPayloadJSON, signature);
    }

    public override SubmitResultResponse Submit(RemoveFromAllowListBody args)
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
        var request = new RemoveFromAllowListRequest(args);
        var response = _api.RemoveFromAllowList(request, "submit");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }

    public override SubmitResultResponse SubmitWatch(RemoveFromAllowListBody args)
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
        var request = new RemoveFromAllowListRequest(args);
        var response = _api.RemoveFromAllowList(request, "submitWatch");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }
}