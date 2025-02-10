# Events
(*Events*)

## Overview

### Available Operations

* [List](#list) - Get all events

## List

Fetch all events, going back up to 30 days, that your partner application has the required scopes for. Note that a partner does NOT have to have verified webhook subscriptions in order to utilize this endpoint.

> 📘 System Access Authentication
>
> This endpoint uses the [Bearer Auth scheme with the system-level access token in the HTTP Authorization header](https://docs.gusto.com/embedded-payroll/docs/system-access).

scope: `events:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto();

GetEventsRequest req = new GetEventsRequest() {
    SortOrder = SortOrder.Asc,
};

var res = await sdk.Events.ListAsync(
    security: new GetEventsSecurity() {
        SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetEventsRequest](../../Models/Requests/GetEventsRequest.md)                                 | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |
| `security`                                                                                    | [GustoEmbedded.Models.Requests.GetEventsSecurity](../../Models/Requests/GetEventsSecurity.md) | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |

### Response

**[GetEventsResponse](../../Models/Requests/GetEventsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |