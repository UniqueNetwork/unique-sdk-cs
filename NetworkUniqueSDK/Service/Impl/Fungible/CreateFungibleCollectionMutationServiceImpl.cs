using Network.Unique.API.Api;
using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service.Impl.Collection;

public class CreateFungibleCollectionMutationServiceImpl : MutationService<CreateFungibleCollectionRequest>
{
    private readonly FungibleApi _api;

    public CreateFungibleCollectionMutationServiceImpl(FungibleApi api)
    {
        _api = api;
    }

    public CreateFungibleCollectionMutationServiceImpl(string basePath)
    {
        _api = new FungibleApi(basePath);
    }

    public override UnsignedTxPayloadResponse Build(CreateFungibleCollectionRequest args)
    {
        var request = new CreateFungibleCollectionMutationRequest(args);
        var response = _api.CreateFungibleCollectionMutation(request, "build", true);
        return response.GetUnsignedTxPayloadResponse();
    }

    public override FeeResponse GetFee(CreateFungibleCollectionRequest args)
    {
        var request = new CreateFungibleCollectionMutationRequest(args);
        var response = _api.CreateFungibleCollectionMutation(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(UnsignedTxPayloadResponse args)
    {
        var request = new CreateFungibleCollectionMutationRequest(
            new UnsignedTxPayloadBody(
                args.SignerPayloadJSON,
                args.SignerPayloadRaw,
                args.SignerPayloadHex
            )
        );
        var response = _api.CreateFungibleCollectionMutation(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(SubmitTxBody args)
    {
        var request = new CreateFungibleCollectionMutationRequest(args);
        var response = _api.CreateFungibleCollectionMutation(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override SubmitTxBody Sign(CreateFungibleCollectionRequest args)
    {
        var signPayload = Build(args);
        return Sign(signPayload);
    }

    public override SubmitTxBody Sign(UnsignedTxPayloadResponse args)
    {
        var signature = UniqueSdk.SignerWrapper.Sign(args.SignerPayloadRaw.Data);
        return new SubmitTxBody(args.SignerPayloadJSON, signature);
    }

    public override SubmitResultResponse Submit(CreateFungibleCollectionRequest args)
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
        var request = new CreateFungibleCollectionMutationRequest(args);
        var response = _api.CreateFungibleCollectionMutation(request, "submit");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }

    public override SubmitResultResponse SubmitWatch(CreateFungibleCollectionRequest args)
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
        var request = new CreateFungibleCollectionMutationRequest(args);
        var response = _api.CreateFungibleCollectionMutation(request, "submitWatch");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }
}