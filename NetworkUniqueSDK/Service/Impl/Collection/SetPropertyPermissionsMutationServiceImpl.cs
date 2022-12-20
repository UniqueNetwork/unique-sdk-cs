﻿using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Signer;

namespace Network.Unique.SDK.Service.Impl.Collection;

public class SetPropertyPermissionsMutationServiceImpl : MutationService<SetPropertyPermissionsBody>
{
    private SignerWrapper _signerWrapper;
    private CollectionsApi _api;

    public SetPropertyPermissionsMutationServiceImpl(SignerWrapper signerWrapper, CollectionsApi api)
    {
        this._signerWrapper = signerWrapper;
        this._api = api;
    }

    public SetPropertyPermissionsMutationServiceImpl(SignerWrapper signerWrapper, string basePath)
    {
        this._signerWrapper = signerWrapper;
        this._api = new CollectionsApi(basePath);
    }

    public override UnsignedTxPayloadResponse Build(SetPropertyPermissionsBody args)
    {
        var request = new SetPropertyPermissionsRequest(args);
        var response = _api.SetPropertyPermissions(request, "build", true);
        return response.GetUnsignedTxPayloadResponse();
    }

    public override FeeResponse GetFee(SetPropertyPermissionsBody args)
    {
        var request = new SetPropertyPermissionsRequest(args);
        var response = _api.SetPropertyPermissions(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(UnsignedTxPayloadResponse args)
    {
        var request = new SetPropertyPermissionsRequest(
            new UnsignedTxPayloadBody(
                args.SignerPayloadJSON,
                args.SignerPayloadRaw,
                args.SignerPayloadHex
            )
        );
        var response = _api.SetPropertyPermissions(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(SubmitTxBody args)
    {
        var request = new SetPropertyPermissionsRequest(args);
        var response = _api.SetPropertyPermissions(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override SubmitTxBody Sign(SetPropertyPermissionsBody args)
    {
        var signPayload = Build(args);
        return Sign(signPayload);
    }

    public override SubmitTxBody Sign(UnsignedTxPayloadResponse args)
    {
        var signature = _signerWrapper.Sign(args.SignerPayloadRaw.Data);
        return new SubmitTxBody(args.SignerPayloadJSON, signature);
    }

    public override SubmitResultResponse Submit(SetPropertyPermissionsBody args)
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
        var request = new SetPropertyPermissionsRequest(args);
        var response = _api.SetPropertyPermissions(request, "submit");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }

    public override SubmitResultResponse SubmitWatch(SetPropertyPermissionsBody args)
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
        var request = new SetPropertyPermissionsRequest(args);
        var response = _api.SetPropertyPermissions(request, "submitWatch");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }
}