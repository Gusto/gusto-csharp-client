# Webhooks
(*Webhooks*)

## Overview

### Available Operations

* [CreateSubscription](#createsubscription) - Create a webhook subscription
* [ListSubscriptions](#listsubscriptions) - List webhook subscriptions
* [UpdateSubscription](#updatesubscription) - Update a webhook subscription
* [GetSubscription](#getsubscription) - Get a webhook subscription
* [DeleteSubscription](#deletesubscription) - Delete a webhook subscription
* [Verify](#verify) - Verify the webhook subscription
* [RequestVerificationToken](#requestverificationtoken) - Request the webhook subscription verification_token

## CreateSubscription

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

var res = await sdk.Webhooks.CreateSubscriptionAsync(
    security: new PostV1WebhookSubscriptionSecurity() {
        SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    requestBody: new PostV1WebhookSubscriptionRequestBody() {
        Url = "https://dense-bidet.name/",
        SubscriptionTypes = new List<Models.Requests.SubscriptionTypes>() {
            SubscriptionTypes.Employee,
        },
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01
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

## ListSubscriptions

Returns all webhook subscriptions associated with the provided Partner API token.

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

var res = await sdk.Webhooks.ListSubscriptionsAsync(
    security: new GetV1WebhookSubscriptionsSecurity() {
        SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                   | [GustoEmbedded.Models.Requests.GetV1WebhookSubscriptionsSecurity](../../Models/Requests/GetV1WebhookSubscriptionsSecurity.md)                                                                                                | :heavy_check_mark:                                                                                                                                                                                                           | The security requirements to use for the request.                                                                                                                                                                            |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1WebhookSubscriptionsResponse](../../Models/Requests/GetV1WebhookSubscriptionsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## UpdateSubscription

Updates the Webhook Subscription associated with the provided UUID.

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

var res = await sdk.Webhooks.UpdateSubscriptionAsync(
    security: new PutV1WebhookSubscriptionUuidSecurity() {
        SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    webhookSubscriptionUuid: "<id>",
    requestBody: new PutV1WebhookSubscriptionUuidRequestBody() {
        SubscriptionTypes = new List<PutV1WebhookSubscriptionUuidSubscriptionTypes>() {
            PutV1WebhookSubscriptionUuidSubscriptionTypes.PaySchedule,
        },
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                   | [GustoEmbedded.Models.Requests.PutV1WebhookSubscriptionUuidSecurity](../../Models/Requests/PutV1WebhookSubscriptionUuidSecurity.md)                                                                                          | :heavy_check_mark:                                                                                                                                                                                                           | The security requirements to use for the request.                                                                                                                                                                            |
| `WebhookSubscriptionUuid`                                                                                                                                                                                                    | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The webhook subscription UUID.                                                                                                                                                                                               |
| `RequestBody`                                                                                                                                                                                                                | [PutV1WebhookSubscriptionUuidRequestBody](../../Models/Requests/PutV1WebhookSubscriptionUuidRequestBody.md)                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                           | N/A                                                                                                                                                                                                                          |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PutV1WebhookSubscriptionUuidResponse](../../Models/Requests/PutV1WebhookSubscriptionUuidResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## GetSubscription

Returns the Webhook Subscription associated with the provided UUID.

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

var res = await sdk.Webhooks.GetSubscriptionAsync(
    security: new GetV1WebhookSubscriptionUuidSecurity() {
        SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    webhookSubscriptionUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                   | [GustoEmbedded.Models.Requests.GetV1WebhookSubscriptionUuidSecurity](../../Models/Requests/GetV1WebhookSubscriptionUuidSecurity.md)                                                                                          | :heavy_check_mark:                                                                                                                                                                                                           | The security requirements to use for the request.                                                                                                                                                                            |
| `WebhookSubscriptionUuid`                                                                                                                                                                                                    | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The webhook subscription UUID.                                                                                                                                                                                               |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1WebhookSubscriptionUuidResponse](../../Models/Requests/GetV1WebhookSubscriptionUuidResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## DeleteSubscription

Deletes the Webhook Subscription associated with the provided UUID.

> 📘 System Access Authentication
>
> This endpoint uses the [Bearer Auth scheme with the system-level access token in the HTTP Authorization header](https://docs.gusto.com/embedded-payroll/docs/system-access).

scope: `webhook_subscriptions:write`


### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto();

var res = await sdk.Webhooks.DeleteSubscriptionAsync(
    security: new DeleteV1WebhookSubscriptionUuidSecurity() {
        SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    webhookSubscriptionUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                   | [GustoEmbedded.Models.Requests.DeleteV1WebhookSubscriptionUuidSecurity](../../Models/Requests/DeleteV1WebhookSubscriptionUuidSecurity.md)                                                                                    | :heavy_check_mark:                                                                                                                                                                                                           | The security requirements to use for the request.                                                                                                                                                                            |
| `WebhookSubscriptionUuid`                                                                                                                                                                                                    | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The webhook subscription UUID.                                                                                                                                                                                               |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[DeleteV1WebhookSubscriptionUuidResponse](../../Models/Requests/DeleteV1WebhookSubscriptionUuidResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## Verify

When a webhook subscription is created, a `verification_token` is POSTed to the registered webhook subscription URL. This `verify` endpoint needs to be called with `verification_token` before webhook events can be sent to the registered webhook URL.

Use the /v1/webhook_subscriptions/{webhook_subscription_uuid}/request_verification_token API to resend the `verification_token` to the Subscriber.

> 📘 System Access Authentication
>
> This endpoint uses the [Bearer Auth scheme with the system-level access token in the HTTP Authorization header](https://docs.gusto.com/embedded-payroll/docs/system-access).

scope: `webhook_subscriptions:write`


### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto();

var res = await sdk.Webhooks.VerifyAsync(
    security: new PutV1VerifyWebhookSubscriptionUuidSecurity() {
        SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    webhookSubscriptionUuid: "<id>",
    requestBody: new PutV1VerifyWebhookSubscriptionUuidRequestBody() {
        VerificationToken = "<value>",
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                                                                                                                   | [GustoEmbedded.Models.Requests.PutV1VerifyWebhookSubscriptionUuidSecurity](../../Models/Requests/PutV1VerifyWebhookSubscriptionUuidSecurity.md)                                                                              | :heavy_check_mark:                                                                                                                                                                                                           | The security requirements to use for the request.                                                                                                                                                                            |
| `WebhookSubscriptionUuid`                                                                                                                                                                                                    | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The webhook subscription UUID.                                                                                                                                                                                               |
| `RequestBody`                                                                                                                                                                                                                | [PutV1VerifyWebhookSubscriptionUuidRequestBody](../../Models/Requests/PutV1VerifyWebhookSubscriptionUuidRequestBody.md)                                                                                                      | :heavy_check_mark:                                                                                                                                                                                                           | N/A                                                                                                                                                                                                                          |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PutV1VerifyWebhookSubscriptionUuidResponse](../../Models/Requests/PutV1VerifyWebhookSubscriptionUuidResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## RequestVerificationToken

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

var res = await sdk.Webhooks.RequestVerificationTokenAsync(
    security: new GetV1WebhookSubscriptionVerificationTokenUuidSecurity() {
        SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    webhookSubscriptionUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01
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