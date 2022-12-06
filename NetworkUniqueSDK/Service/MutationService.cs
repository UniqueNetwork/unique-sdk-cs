using Network.Unique.API.Model;

namespace Network.Unique.SDK.Service
{
    public abstract class MutationService<TA>
    {
        public abstract UnsignedTxPayloadResponse Build(TA args);

        public abstract FeeResponse GetFee(TA args);

        public abstract FeeResponse GetFee(UnsignedTxPayloadResponse args);

        public abstract FeeResponse GetFee(SubmitTxBody args);

        public abstract SubmitTxBody Sign(TA args);

        public abstract SubmitTxBody Sign(UnsignedTxPayloadResponse args);

        public abstract SubmitResultResponse Submit(TA args);

        public abstract SubmitResultResponse Submit(UnsignedTxPayloadResponse args);

        public abstract SubmitResultResponse Submit(SubmitTxBody args);

        public abstract SubmitResultResponse SubmitWatch(TA args);

        public abstract SubmitResultResponse SubmitWatch(UnsignedTxPayloadResponse args);

        public abstract SubmitResultResponse SubmitWatch(SubmitTxBody args);
    }
}