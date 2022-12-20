﻿using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Signer;

namespace Network.Unique.SDK.Service.Impl.Collection;

public class UnnestTokenTokenMutationServiceImpl : MutationService<UnnestTokenBody>
{
    private SignerWrapper _signerWrapper;
    private TokensApi _api;

    public UnnestTokenTokenMutationServiceImpl(SignerWrapper signerWrapper, TokensApi api)
    {
        this._signerWrapper = signerWrapper;
        this._api = api;
    }

    public UnnestTokenTokenMutationServiceImpl(SignerWrapper signerWrapper, string basePath)
    {
        this._signerWrapper = signerWrapper;
        this._api = new TokensApi(basePath);
    }

    public override UnsignedTxPayloadResponse Build(UnnestTokenBody args)
    {
        var request = new UnnestTokenRequest(args);
        var response = _api.UnnestToken(request, "build", true);
        return response.GetUnsignedTxPayloadResponse();
    }

    public override FeeResponse GetFee(UnnestTokenBody args)
    {
        var request = new UnnestTokenRequest(args);
        var response = _api.UnnestToken(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(UnsignedTxPayloadResponse args)
    {
        var request = new UnnestTokenRequest(
            new UnsignedTxPayloadBody(
                args.SignerPayloadJSON,
                args.SignerPayloadRaw,
                args.SignerPayloadHex
            )
        );
        var response = _api.UnnestToken(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(SubmitTxBody args)
    {
        var request = new UnnestTokenRequest(args);
        var response = _api.UnnestToken(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override SubmitTxBody Sign(UnnestTokenBody args)
    {
        var signPayload = Build(args);
        return Sign(signPayload);
    }

    public override SubmitTxBody Sign(UnsignedTxPayloadResponse args)
    {
        var signature = _signerWrapper.Sign(args.SignerPayloadRaw.Data);
        return new SubmitTxBody(args.SignerPayloadJSON, signature);
    }

    public override SubmitResultResponse Submit(UnnestTokenBody args)
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
        var request = new UnnestTokenRequest(args);
        var response = _api.UnnestToken(request, "submit");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }

    public override SubmitResultResponse SubmitWatch(UnnestTokenBody args)
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
        var request = new UnnestTokenRequest(args);
        var response = _api.UnnestToken(request, "submitWatch");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }
}