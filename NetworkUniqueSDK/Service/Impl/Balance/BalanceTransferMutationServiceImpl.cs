using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Signer;

namespace Network.Unique.SDK.Service.Impl.Balance;

public class BalanceTransferMutationServiceImpl : MutationService<BalanceTransferBody>
{
    private SignerWrapper _signerWrapper;
    private BalanceApi _api;

    public BalanceTransferMutationServiceImpl(SignerWrapper signerWrapper, BalanceApi api)
    {
        this._signerWrapper = signerWrapper;
        this._api = api;
    }

    public BalanceTransferMutationServiceImpl(SignerWrapper signerWrapper, string basePath)
    {
        this._signerWrapper = signerWrapper;
        this._api = new BalanceApi(basePath);
    }

    public override UnsignedTxPayloadResponse Build(BalanceTransferBody args)
    {
        var request = new TransferMutationRequest(args);
        var response = _api.TransferMutation(request, "build", true);
        return response.GetUnsignedTxPayloadResponse();
    }

    public override FeeResponse GetFee(BalanceTransferBody args)
    {
        var request = new TransferMutationRequest(args);
        var response = _api.TransferMutation(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(UnsignedTxPayloadResponse args)
    {
        var request = new TransferMutationRequest(
            new UnsignedTxPayloadBody(
                args.SignerPayloadJSON,
                args.SignerPayloadRaw,
                args.SignerPayloadHex
            )
        );
        var response = _api.TransferMutation(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(SubmitTxBody args)
    {
        var request = new TransferMutationRequest(args);
        var response = _api.TransferMutation(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override SubmitTxBody Sign(BalanceTransferBody args)
    {
        var signPayload = Build(args);
        return Sign(signPayload);
    }

    public override SubmitTxBody Sign(UnsignedTxPayloadResponse args)
    {
        var signature = _signerWrapper.Sign(args.SignerPayloadRaw.Data);
        return new SubmitTxBody(args.SignerPayloadJSON, signature);
    }

    public override SubmitResultResponse Submit(BalanceTransferBody args)
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
        var request = new TransferMutationRequest(args);
        var response = _api.TransferMutation(request, "submit");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }

    public override SubmitResultResponse SubmitWatch(BalanceTransferBody args)
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
        var request = new TransferMutationRequest(args);
        var response = _api.TransferMutation(request, "submitWatch");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }
}