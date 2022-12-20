﻿// using Network.Unique.API.Api;
// using Network.Unique.API.Model;
// using Network.Unique.SDK.Signer;
//
// namespace Network.Unique.SDK.Service.Impl.Collection;
// TODO
// public class CreateERC721CollectionMutationServiceImpl : MutationService<CreateERC721CollectionBody>
// {
//     private SignerWrapper _signerWrapper;
//     private ERC721Api _api;
//
//     public CreateERC721CollectionMutationServiceImpl(SignerWrapper signerWrapper, ERC721Api api)
//     {
//         this._signerWrapper = signerWrapper;
//         this._api = api;
//     }
//
//     public CreateERC721CollectionMutationServiceImpl(SignerWrapper signerWrapper, string basePath)
//     {
//         this._signerWrapper = signerWrapper;
//         this._api = new ERC721Api(basePath);
//     }
//
//     public override UnsignedTxPayloadResponse Build(CreateERC721CollectionBody args)
//     {
//         var response = _api.ERC721ControllerCreateCollection(args, "build", true);
//         return response.GetUnsignedTxPayloadResponse();
//     }
//
//     public override FeeResponse GetFee(CreateERC721CollectionBody args)
//     {
//         var response = _api.ERC721ControllerCreateCollection(args, "build", true);
//         return response.GetFeeBodyResponse().Fee;
//     }
//
//     public override FeeResponse GetFee(UnsignedTxPayloadResponse args)
//     {
//         var request = new CreateERC721CollectionBody(
//             new UnsignedTxPayloadBody(
//                 args.SignerPayloadJSON,
//                 args.SignerPayloadRaw,
//                 args.SignerPayloadHex
//             )
//         );
//         var response = _api.ERC721ControllerCreateCollection(request, "build", true);
//         return response.GetFeeBodyResponse().Fee;
//     }
//
//     public override FeeResponse GetFee(SubmitTxBody args)
//     {
//         var request = new ERC721ControllerCreateCollectionRequest(args);
//         var response = _api.ERC721ControllerCreateCollection(request, "build", true);
//         return response.GetFeeBodyResponse().Fee;
//     }
//
//     public override SubmitTxBody Sign(CreateERC721CollectionBody args)
//     {
//         var signPayload = Build(args);
//         return Sign(signPayload);
//     }
//
//     public override SubmitTxBody Sign(UnsignedTxPayloadResponse args)
//     {
//         var signature = _signerWrapper.Sign(args.SignerPayloadRaw.Data);
//         return new SubmitTxBody(args.SignerPayloadJSON, signature);
//     }
//
//     public override SubmitResultResponse Submit(CreateERC721CollectionBody args)
//     {
//         var signedBody = Sign(args);
//         return Submit(signedBody);
//     }
//
//     public override SubmitResultResponse Submit(UnsignedTxPayloadResponse args)
//     {
//         var signedBody = Sign(args);
//         return Submit(signedBody);
//     }
//
//     public override SubmitResultResponse Submit(SubmitTxBody args)
//     {
//         var request = new ERC721ControllerCreateCollectionRequest(args);
//         var response = _api.ERC721ControllerCreateCollection(request, "submit");
//         return new SubmitResultResponse(response.GetSubmitResponse().Hash);
//     }
//
//     public override SubmitResultResponse SubmitWatch(CreateERC721CollectionBody args)
//     {
//         var signedBody = Sign(args);
//         return SubmitWatch(signedBody);
//     }
//
//     public override SubmitResultResponse SubmitWatch(UnsignedTxPayloadResponse args)
//     {
//         var signedBody = Sign(args);
//         return SubmitWatch(signedBody);
//     }
//
//     public override SubmitResultResponse SubmitWatch(SubmitTxBody args)
//     {
//         var request = new ERC721ControllerCreateCollectionRequest(args);
//         var response = _api.ERC721ControllerCreateCollection(request, "submitWatch");
//         return new SubmitResultResponse(response.GetSubmitResponse().Hash);
//     }
// }