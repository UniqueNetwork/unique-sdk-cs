﻿using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Signer;

namespace Network.Unique.SDK.Service.Impl.Collection;

public class RemoveSponsorshipMutationServiceImpl : MutationService<RemoveSponsorshipBody>
{
    private SignerWrapper _signerWrapper;
    private CollectionsApi _api;

    public RemoveSponsorshipMutationServiceImpl(SignerWrapper signerWrapper, CollectionsApi api)
    {
        this._signerWrapper = signerWrapper;
        this._api = api;
    }

    public RemoveSponsorshipMutationServiceImpl(SignerWrapper signerWrapper, string basePath)
    {
        this._signerWrapper = signerWrapper;
        this._api = new CollectionsApi(basePath);
    }

    public override UnsignedTxPayloadResponse Build(RemoveSponsorshipBody args)
    {
        var request = new RemoveSponsorshipRequest(args);
        var response = _api.RemoveSponsorship(request, "build", true);
        return response.GetUnsignedTxPayloadResponse();
    }

    public override FeeResponse GetFee(RemoveSponsorshipBody args)
    {
        var request = new RemoveSponsorshipRequest(args);
        var response = _api.RemoveSponsorship(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(UnsignedTxPayloadResponse args)
    {
        var request = new RemoveSponsorshipRequest(
            new UnsignedTxPayloadBody(
                args.SignerPayloadJSON,
                args.SignerPayloadRaw,
                args.SignerPayloadHex
            )
        );
        var response = _api.RemoveSponsorship(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override FeeResponse GetFee(SubmitTxBody args)
    {
        var request = new RemoveSponsorshipRequest(args);
        var response = _api.RemoveSponsorship(request, "build", true);
        return response.GetFeeBodyResponse().Fee;
    }

    public override SubmitTxBody Sign(RemoveSponsorshipBody args)
    {
        var signPayload = Build(args);
        return Sign(signPayload);
    }

    public override SubmitTxBody Sign(UnsignedTxPayloadResponse args)
    {
        var signature = _signerWrapper.Sign(args.SignerPayloadRaw.Data);
        return new SubmitTxBody(args.SignerPayloadJSON, signature);
    }

    public override SubmitResultResponse Submit(RemoveSponsorshipBody args)
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
        var request = new RemoveSponsorshipRequest(args);
        var response = _api.RemoveSponsorship(request, "submit");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }

    public override SubmitResultResponse SubmitWatch(RemoveSponsorshipBody args)
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
        var request = new RemoveSponsorshipRequest(args);
        var response = _api.RemoveSponsorship(request, "submitWatch");
        return new SubmitResultResponse(response.GetSubmitResponse().Hash);
    }
}