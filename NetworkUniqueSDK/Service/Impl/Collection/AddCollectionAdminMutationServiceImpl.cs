using Network.Unique.API.Api;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service.Impl.Collection;

public class AddCollectionAdminMutationServiceImpl : MutationService<AddCollectionAdminBody>
{
    private readonly CollectionsApi _api;

    public AddCollectionAdminMutationServiceImpl(CollectionsApi api)
    {
        _api = api;
    }

    public AddCollectionAdminMutationServiceImpl(string basePath)
    {
        _api = new CollectionsApi(basePath);
    }

    public override UnsignedTxPayloadResponse Build(AddCollectionAdminBody args)
    {
        var request = new AddAdminRequest(args);
        var response = _api.AddAdmin(request, "build", true);
        return response.GetUnsignedTxPayloadResponse();
    }

    public override FeeResponse GetFee(AddCollectionAdminBody args)
    {
        var request = new AddAdminRequest(args);
        var response = _api.AddAdmin(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(UnsignedTxPayloadResponse args)
    {
        var request = new AddAdminRequest(
            new UnsignedTxPayloadBody(
                args.SignerPayloadJSON,
                args.SignerPayloadRaw,
                args.SignerPayloadHex
            )
        );
        var response = _api.AddAdmin(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(SubmitTxBody args)
    {
        var request = new AddAdminRequest(args);
        var response = _api.AddAdmin(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override SubmitTxBody Sign(AddCollectionAdminBody args)
    {
        var signPayload = Build(args);
        return Sign(signPayload);
    }

    public override SubmitTxBody Sign(UnsignedTxPayloadResponse args)
    {
        var signature = UniqueSdk.SignerWrapper.Sign(args.SignerPayloadRaw.Data);
        return new SubmitTxBody(args.SignerPayloadJSON, signature);
    }

    public override SubmitResultResponse Submit(AddCollectionAdminBody args)
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
        var request = new AddAdminRequest(args);
        var response = _api.AddAdmin(request, "submit");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }

    public override SubmitResultResponse SubmitWatch(AddCollectionAdminBody args)
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
        var request = new AddAdminRequest(args);
        var response = _api.AddAdmin(request, "submitWatch");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }
}