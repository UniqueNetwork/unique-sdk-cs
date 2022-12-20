using Network.Unique.API.Api;
using Network.Unique.API.Model;
using Network.Unique.SDK.Signer;

namespace Network.Unique.SDK.Service.Impl;

public class ExtrinsicServiceImpl : IExtrinsicService
{
    private ExtrinsicApi _api;
    private SignerWrapper _signerWrapper;

    public ExtrinsicServiceImpl(SignerWrapper signerWrapper, string basePath)
    {
        this._api = new ExtrinsicApi(basePath);
        this._signerWrapper = signerWrapper;
    }

    public UnsignedTxPayloadResponse BuildTx(TxBuildBody body)
    {
        return _api.ExtrinsicsControllerBuildTx(body);
    }

    public SignTxResultResponse SignTx(UnsignedTxPayloadBody body, string seed)
    {
        var signature = _signerWrapper.Sign(body.SignerPayloadRaw.Data);
        return new SignTxResultResponse(signature, SignTxResultResponse.SignatureTypeEnum.Sr25519);
    }

    public VerificationResultResponse VerifySign(SubmitTxBody body)
    {
        return _api.ExtrinsicsControllerVerifySign(body);
    }

    public SubmitResultResponse Submit(SubmitTxBody body)
    {
        return _api.ExtrinsicsControllerSubmitTx(body);
    }

    public FeeResponse CalculateFee(ExtrinsicsControllerCalculateFeeRequest body)
    {
        return _api.ExtrinsicsControllerCalculateFee(body);
    }

    public ExtrinsicResultResponse GetExtrinsicStatus(string hash)
    {
        return _api.ExtrinsicsControllerGetStatus(hash);
    }

    public GetExtrinsicResponse GetExtrinsic(string blockHashOrNumber, string extrinsicHash)
    {
        return _api.ExtrinsicsControllerGet(blockHashOrNumber, extrinsicHash);
    }
}