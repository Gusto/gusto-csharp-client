<!-- Start SDK Example Usage [usage] -->
```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Introspection.GetInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

// handle response
```
<!-- End SDK Example Usage [usage] -->