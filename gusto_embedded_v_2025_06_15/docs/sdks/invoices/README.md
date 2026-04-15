# Invoices
(*Invoices*)

## Overview

### Available Operations

* [Get](#get) - Retrieve invoicing data for companies

## Get

Retrieve data for active companies used to calculate invoices for Gusto Embedded Payroll. A company is considered active for an invoice period if they are an active partner managed company, have run payroll or created contractor payments since becoming a partner managed company, and are not suspended at any point during the invoice period.  This endpoint forces pagination, with 100 results returned at a time. You can learn more about our pagination here: [pagination guide](https://docs.gusto.com/embedded-payroll/docs/pagination) 

> 📘 System Access Authentication
>
> This endpoint uses the [Bearer Auth scheme with the system-level access token in the HTTP Authorization header](https://docs.gusto.com/embedded-payroll/docs/system-access)

scope: `invoices:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto();

GetInvoicesInvoicePeriodRequest req = new GetInvoicesInvoicePeriodRequest() {
    InvoicePeriod = "2020-01",
};

var res = await sdk.Invoices.GetAsync(
    security: new GetInvoicesInvoicePeriodSecurity() {
        SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    request: req
);

// handle response
```

### Parameters

| Parameter                                                                                                                   | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                   | [GetInvoicesInvoicePeriodRequest](../../Models/Requests/GetInvoicesInvoicePeriodRequest.md)                                 | :heavy_check_mark:                                                                                                          | The request object to use for the request.                                                                                  |
| `security`                                                                                                                  | [GustoEmbedded.Models.Requests.GetInvoicesInvoicePeriodSecurity](../../Models/Requests/GetInvoicesInvoicePeriodSecurity.md) | :heavy_check_mark:                                                                                                          | The security requirements to use for the request.                                                                           |

### Response

**[GetInvoicesInvoicePeriodResponse](../../Models/Requests/GetInvoicesInvoicePeriodResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |