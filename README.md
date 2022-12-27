# Unique SKD C#


Unique SDK C# is a C# library for dealing with polkadot blockchains.

## Installation

Use the NuGet to download Network.Unique.SDK and Network.Unique.API.

### Network.Unique.SDK
```
https://www.nuget.org/packages/Network.Unique.SDK
```
### Network.Unique.API
```
https://www.nuget.org/packages/Network.Unique.API
```

## Usage

### Network.Unique.SDK
First of all, create Signer and SDK Object

```csharp
// Create signer from suri and password
Sr25519SignerWrapper signerWrapper = new Sr25519SignerWrapper(suri, suriPassword, false);
// Or generate signer with password
Sr25519SignerWrapper signerWrapper = new Sr25519SignerWrapper(null, suriPassword, true);
// Or generate signer without password
Sr25519SignerWrapper signerWrapper = new Sr25519SignerWrapper(null, null, true);

// create SDK god object. First parameter - base url of backend of blockchain
UniqueSdk uniqueSdk = new UniqueSdk("https://rest.opal.uniquenetwork.dev");

// Assign static signer to SDK
UniqueSdk.SignerWrapper = signerWrapper;
```

Signer has ```sign``` function for payload signing. When you using ```UniqueSdk``` methods they automatically use inner signer passed by parameter.

After we can use inner services of SDK

```kotlin
// Getting balance service for balance reading or manipulation
IBalanceService balanceService = uniqueSdk.BalanceService;
```

Some methods of service can be used with many parameters based on template, which we named ```Mutation```.
One of these mutations is balance transfering.

```kotlin
/// Getting balance transfering mutation
MutationService<BalanceTransferBody> transferMutationService = balanceService.GetTransferMutationService();
```

```Mutation``` has three main methods for executing:
- Build
- Sign
- Submit

Let's see how it's working
```csharp
// Creating payload for balance transfering
var transferBody = new BalanceTransferBody(
    //from
    "5DnUE1uV7iW25bUriWVPHY67KMm2t6g5v23GzVbZCUc8fyBD",
    //to
    "unjKJQJrRd238pkUZZvzDQrfKuM39zBSnQ5zjAGAGcdRhaJTx",
    //amount
    0.01m
);

// Build transaction
var transferResponse = transferMutationService.Build(transferBody);

var signBody = new UnsignedTxPayloadResponse(
    transferResponse.SignerPayloadJSON,
    transferResponse.SignerPayloadRaw,
    transferResponse.SignerPayloadHex
);

// Sign transaction via inner signer
var signResponse = transferMutationService.Sign(signBody);

var submitBody = new SubmitTxBody(signResponse.SignerPayloadJSON, signResponse.Signature);

// Submit transaction and track result with web server
var submitResponse = transferMutationService.SubmitWatch(submitBody);
```

After all executions we can see transaction hash

```csharp
Console.WriteLine(submitResponse.Hash);
```

## Contributing

Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License

[MIT](https://choosealicense.com/licenses/mit/)