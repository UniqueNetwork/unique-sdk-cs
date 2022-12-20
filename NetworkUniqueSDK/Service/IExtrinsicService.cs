using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service;

public interface IExtrinsicService
{
    UnsignedTxPayloadResponse BuildTx(TxBuildBody body);

    SignTxResultResponse SignTx(UnsignedTxPayloadBody body, string seed);

    VerificationResultResponse VerifySign(SubmitTxBody body);

    SubmitResultResponse Submit(SubmitTxBody body);

    FeeResponse CalculateFee(ExtrinsicsControllerCalculateFeeRequest body);

    ExtrinsicResultResponse GetExtrinsicStatus(string hash);

    GetExtrinsicResponse GetExtrinsic(string blockHashOrNumber, string extrinsicHash);
}