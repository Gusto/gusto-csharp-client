# Notifications
(*Notifications*)

## Overview

### Available Operations

* [GetNotificationsNotificationUuid](#getnotificationsnotificationuuid) - Get a notification's details

## GetNotificationsNotificationUuid

Upon receiving a notification webhook event, use this endpoint to fetch the notification's details. The notification details include basic suggested content that can help you build notifications in your platform.

Note: partners are responsible for the delivery and any custom state management of notifications in their application. Refer to our [partner notification guide](https://docs.gusto.com/embedded-payroll/docs/partner-notifications) for more details.

If the notification UUID is not found, the response will be 404 Not Found. If the notification's supporting data is no longer valid, the response will be 422 Unprocessable Entity.

scope: `notifications:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Notifications.GetNotificationsNotificationUuidAsync(
    notificationUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `NotificationUuid`                                                                                                                                                                                                           | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The notification entity_uuid                                                                                                                                                                                                 |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetNotificationsNotificationUuidResponse](../../Models/Requests/GetNotificationsNotificationUuidResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |