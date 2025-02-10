# ACHTransactions
(*ACHTransactions*)

## Overview

### Available Operations

* [GetAll](#getall) - Get all ACH transactions for a company

## GetAll

Fetches all ACH transactions for a company.

scope: `ach_transactions:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetAchTransactionsRequest req = new GetAchTransactionsRequest() {
    CompanyUuid = "<id>",
};

var res = await sdk.ACHTransactions.GetAllAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetAchTransactionsRequest](../../Models/Requests/GetAchTransactionsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[GetAchTransactionsResponse](../../Models/Requests/GetAchTransactionsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |