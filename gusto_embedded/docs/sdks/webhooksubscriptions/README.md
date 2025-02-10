# WebhookSubscriptions
(*WebhookSubscriptions*)

## Overview

### Available Operations

* [Create](#create) - Create a webhook subscription
* [GetV1WebhookSubscriptionVerificationTokenUuid](#getv1webhooksubscriptionverificationtokenuuid) - Request the webhook subscription verification_token

## Create

Create a webhook subscription to receive events of the specified subscription_types whenever there is a state change.

> 📘 System Access Authentication
>
> This endpoint uses the [Bearer Auth scheme with the system-level access token in the HTTP Authorization header](https://docs.gusto.com/embedded-payroll/docs/system-access).

scope: `webhook_subscriptions:write`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;
using System.Collections.Generic;

var sdk = new Gusto();

var res = await sdk.WebhookSubscriptions.CreateAsync(
    security: new PostV1WebhookSubscriptionSecurity() {
        SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    requestBody: new PostV1WebhookSubscriptionRequestBody() {
        Url = "https://probable-heating.com/",
        SubscriptionTypes = new List<Models.Requests.SubscriptionTypes>() {
            SubscriptionTypes.Company,
        },
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                   | [GustoEmbedded.Models.Requests.PostV1WebhookSubscriptionSecurity](../../Models/Requests/PostV1WebhookSubscriptionSecurity.md)                                                                                                | :heavy_check_mark:                                                                                                                                                                                                           | The security requirements to use for the request.                                                                                                                                                                            |
| `RequestBody`                                                                                                                                                                                                                | [PostV1WebhookSubscriptionRequestBody](../../Models/Requests/PostV1WebhookSubscriptionRequestBody.md)                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                           | N/A                                                                                                                                                                                                                          |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PostV1WebhookSubscriptionResponse](../../Models/Requests/PostV1WebhookSubscriptionResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## GetV1WebhookSubscriptionVerificationTokenUuid

Request that the webhook subscription `verification_token` be POSTed to the Subscription URL.

> 📘 System Access Authentication
>
> This endpoint uses the [Bearer Auth scheme with the system-level access token in the HTTP Authorization header](https://docs.gusto.com/embedded-payroll/docs/system-access).

scope: `webhook_subscriptions:read`


### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto();

var res = await sdk.WebhookSubscriptions.GetV1WebhookSubscriptionVerificationTokenUuidAsync(
    security: new GetV1WebhookSubscriptionVerificationTokenUuidSecurity() {
        SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    webhookSubscriptionUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                   | [GustoEmbedded.Models.Requests.GetV1WebhookSubscriptionVerificationTokenUuidSecurity](../../Models/Requests/GetV1WebhookSubscriptionVerificationTokenUuidSecurity.md)                                                        | :heavy_check_mark:                                                                                                                                                                                                           | The security requirements to use for the request.                                                                                                                                                                            |
| `WebhookSubscriptionUuid`                                                                                                                                                                                                    | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The webhook subscription UUID.                                                                                                                                                                                               |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1WebhookSubscriptionVerificationTokenUuidResponse](../../Models/Requests/GetV1WebhookSubscriptionVerificationTokenUuidResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |