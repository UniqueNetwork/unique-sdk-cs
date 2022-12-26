using Network.Unique.API.Api;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service.Impl.Collection;

public class SetPermissionsMutationServiceImpl : MutationService<SetCollectionPermissionsBody>
{
    private readonly CollectionsApi _api;

    public SetPermissionsMutationServiceImpl(CollectionsApi api)
    {
        _api = api;
    }

    public SetPermissionsMutationServiceImpl(string basePath)
    {
        _api = new CollectionsApi(basePath);
    }

    public override UnsignedTxPayloadResponse Build(SetCollectionPermissionsBody args)
    {
        var request = new SetPermissionsRequest(args);
        var response = _api.SetPermissions(request, "build", true);
        return response.GetUnsignedTxPayloadResponse();
    }

    public override FeeResponse GetFee(SetCollectionPermissionsBody args)
    {
        var request = new SetPermissionsRequest(args);
        var response = _api.SetPermissions(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(UnsignedTxPayloadResponse args)
    {
        var request = new SetPermissionsRequest(
            new UnsignedTxPayloadBody(
                args.SignerPayloadJSON,
                args.SignerPayloadRaw,
                args.SignerPayloadHex
            )
        );
        var response = _api.SetPermissions(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(SubmitTxBody args)
    {
        var request = new SetPermissionsRequest(args);
        var response = _api.SetPermissions(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override SubmitTxBody Sign(SetCollectionPermissionsBody args)
    {
        var signPayload = Build(args);
        return Sign(signPayload);
    }

    public override SubmitTxBody Sign(UnsignedTxPayloadResponse args)
    {
        var signature = UniqueSdk.SignerWrapper.Sign(args.SignerPayloadRaw.Data);
        return new SubmitTxBody(args.SignerPayloadJSON, signature);
    }

    public override SubmitResultResponse Submit(SetCollectionPermissionsBody args)
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
        var request = new SetPermissionsRequest(args);
        var response = _api.SetPermissions(request, "submit");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }

    public override SubmitResultResponse SubmitWatch(SetCollectionPermissionsBody args)
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
        var request = new SetPermissionsRequest(args);
        var response = _api.SetPermissions(request, "submitWatch");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }
}