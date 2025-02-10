# ContractorPayments
(*ContractorPayments*)

## Overview

### Available Operations

* [GetV1ContractorPaymentsContractorPaymentUuidReceipt](#getv1contractorpaymentscontractorpaymentuuidreceipt) - Get a single contractor payment receipt
* [GetV1ContractorPaymentsContractorPaymentUuidFund](#getv1contractorpaymentscontractorpaymentuuidfund) - Fund a contractor payment [DEMO]
* [PostV1CompaniesCompanyIdContractorPayments](#postv1companiescompanyidcontractorpayments) - Create a contractor payment
* [Get](#get) - Get contractor payments for a company
* [GetById](#getbyid) - Get a single contractor payment
* [Delete](#delete) - Cancel a contractor payment
* [GetCompaniesCompanyUuidContractorPaymentsPreview](#getcompaniescompanyuuidcontractorpaymentspreview) - Preview contractor payment debit date

## GetV1ContractorPaymentsContractorPaymentUuidReceipt

Returns a contractor payment receipt.

Notes:
* Receipts are only available for direct deposit payments and are only available once those payments have been funded.
* Payroll Receipt requests for payrolls which do not have receipts available (e.g. payment by check) will return a 404 status.
* Hour and dollar amounts are returned as string representations of numeric decimals.
* Dollar amounts are represented to the cent.
* If no data has yet be inserted for a given field, it defaults to “0.00” (for fixed amounts).

scope: `payrolls:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ContractorPayments.GetV1ContractorPaymentsContractorPaymentUuidReceiptAsync(
    contractorPaymentUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ContractorPaymentUuid`                                                                                                                                                                                                      | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the contractor payment                                                                                                                                                                                           |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1ContractorPaymentsContractorPaymentUuidReceiptResponse](../../Models/Requests/GetV1ContractorPaymentsContractorPaymentUuidReceiptResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## GetV1ContractorPaymentsContractorPaymentUuidFund

> 🚧 Demo action
>
> This action is only available in the Demo environment

Simulate funding a contractor payment. Funding only occurs automatically in the production environment when bank transactions are generated. Use this action in the demo environment to transition a contractor payment's `status` from `Unfunded` to `Funded`. A `Funded` status is required for generating a contractor payment receipt.

scope: `payrolls:run`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ContractorPayments.GetV1ContractorPaymentsContractorPaymentUuidFundAsync(
    contractorPaymentUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ContractorPaymentUuid`                                                                                                                                                                                                      | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the contractor payment                                                                                                                                                                                           |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1ContractorPaymentsContractorPaymentUuidFundResponse](../../Models/Requests/GetV1ContractorPaymentsContractorPaymentUuidFundResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## PostV1CompaniesCompanyIdContractorPayments

Pay a contractor. Information needed depends on the contractor's wage type (hourly vs fixed)

scope: `payrolls:run`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;
using NodaTime;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ContractorPayments.PostV1CompaniesCompanyIdContractorPaymentsAsync(
    companyId: "<id>",
    requestBody: new PostV1CompaniesCompanyIdContractorPaymentsRequestBody() {
        ContractorUuid = "<id>",
        Date = LocalDate.FromDateTime(System.DateTime.Parse("2020-01-01")),
        Wage = 5000D,
        Hours = 40D,
        Bonus = 500D,
        Reimbursement = 20D,
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyId`                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company                                                                                                                                                                                                      |
| `RequestBody`                                                                                                                                                                                                                | [PostV1CompaniesCompanyIdContractorPaymentsRequestBody](../../Models/Requests/PostV1CompaniesCompanyIdContractorPaymentsRequestBody.md)                                                                                      | :heavy_check_mark:                                                                                                                                                                                                           | N/A                                                                                                                                                                                                                          |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PostV1CompaniesCompanyIdContractorPaymentsResponse](../../Models/Requests/PostV1CompaniesCompanyIdContractorPaymentsResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## Get

Returns an object containing individual contractor payments, within a given time period, including totals.

scope: `payrolls:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetV1CompaniesCompanyIdContractorPaymentsRequest req = new GetV1CompaniesCompanyIdContractorPaymentsRequest() {
    CompanyId = "<id>",
    StartDate = "2020-01-01",
    EndDate = "2020-12-31",
};

var res = await sdk.ContractorPayments.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                     | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                     | [GetV1CompaniesCompanyIdContractorPaymentsRequest](../../Models/Requests/GetV1CompaniesCompanyIdContractorPaymentsRequest.md) | :heavy_check_mark:                                                                                                            | The request object to use for the request.                                                                                    |

### Response

**[GetV1CompaniesCompanyIdContractorPaymentsResponse](../../Models/Requests/GetV1CompaniesCompanyIdContractorPaymentsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## GetById

Returns a single contractor payment.
scope: `payrolls:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ContractorPayments.GetByIdAsync(
    companyId: "<id>",
    contractorPaymentId: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyId`                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company                                                                                                                                                                                                      |
| `ContractorPaymentId`                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the contractor payment                                                                                                                                                                                           |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1CompaniesCompanyIdContractorPaymentContractorPaymentResponse](../../Models/Requests/GetV1CompaniesCompanyIdContractorPaymentContractorPaymentResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## Delete

Cancels and deletes a contractor payment. If the contractor payment has already started processing ("may_cancel": true), the payment cannot be cancelled.

scope: `payrolls:run`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ContractorPayments.DeleteAsync(
    companyId: "<id>",
    contractorPaymentId: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyId`                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company                                                                                                                                                                                                      |
| `ContractorPaymentId`                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the contractor payment                                                                                                                                                                                           |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[DeleteV1CompaniesCompanyIdContractorPaymentContractorPaymentResponse](../../Models/Requests/DeleteV1CompaniesCompanyIdContractorPaymentContractorPaymentResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## GetCompaniesCompanyUuidContractorPaymentsPreview

Returns a debit_date dependent on the ACH payment speed of the company.

If the payment method is Check or Historical payment, the debit_date will be the same as the check_date.

scope: `payrolls:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;
using System.Collections.Generic;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ContractorPayments.GetCompaniesCompanyUuidContractorPaymentsPreviewAsync(
    companyUuid: "<id>",
    requestBody: new GetCompaniesCompanyUuidContractorPaymentsPreviewRequestBody() {
        ContractorPayments = new List<GetCompaniesCompanyUuidContractorPaymentsPreviewContractorPayments>() {
            new GetCompaniesCompanyUuidContractorPaymentsPreviewContractorPayments() {},
        },
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyUuid`                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company                                                                                                                                                                                                      |
| `RequestBody`                                                                                                                                                                                                                | [GetCompaniesCompanyUuidContractorPaymentsPreviewRequestBody](../../Models/Requests/GetCompaniesCompanyUuidContractorPaymentsPreviewRequestBody.md)                                                                          | :heavy_check_mark:                                                                                                                                                                                                           | a list of contractor payments.                                                                                                                                                                                               |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetCompaniesCompanyUuidContractorPaymentsPreviewResponse](../../Models/Requests/GetCompaniesCompanyUuidContractorPaymentsPreviewResponse.md)**

### Errors

| Error Type                                                                               | Status Code                                                                              | Content Type                                                                             |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| GustoEmbedded.Models.Errors.GetCompaniesCompanyUuidContractorPaymentsPreviewResponseBody | 422                                                                                      | application/json                                                                         |
| GustoEmbedded.Models.Errors.APIException                                                 | 4XX, 5XX                                                                                 | \*/\*                                                                                    |