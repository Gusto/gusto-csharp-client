# Garnishments
(*Garnishments*)

## Overview

### Available Operations

* [Create](#create) - Create a garnishment
* [List](#list) - Get garnishments for an employee
* [Get](#get) - Get a garnishment
* [Update](#update) - Update a garnishment
* [GetChildSupportData](#getchildsupportdata) - Get child support garnishment data

## Create

Garnishments, or employee deductions, are fixed amounts or percentages deducted from an employee’s pay. They can be deducted a specific number of times or on a recurring basis. Garnishments can also have maximum deductions on a yearly or per-pay-period bases. Common uses for garnishments are court-ordered payments for child support or back taxes. Some companies provide loans to their employees that are repaid via garnishments.

scope: `garnishments:write`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Garnishments.CreateAsync(
    employeeId: "<id>",
    requestBody: new PostV1EmployeesEmployeeIdGarnishmentsRequestBody() {
        Amount = "<value>",
        CourtOrdered = false,
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `EmployeeId`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the employee                                                                                                                                                                                                     |
| `RequestBody`                                                                                                                                                                                                                | [PostV1EmployeesEmployeeIdGarnishmentsRequestBody](../../Models/Requests/PostV1EmployeesEmployeeIdGarnishmentsRequestBody.md)                                                                                                | :heavy_check_mark:                                                                                                                                                                                                           | N/A                                                                                                                                                                                                                          |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PostV1EmployeesEmployeeIdGarnishmentsResponse](../../Models/Requests/PostV1EmployeesEmployeeIdGarnishmentsResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## List

Garnishments, or employee deductions, are fixed amounts or percentages deducted from an employee’s pay. They can be deducted a specific number of times or on a recurring basis. Garnishments can also have maximum deductions on a yearly or per-pay-period bases. Common uses for garnishments are court-ordered payments for child support or back taxes. Some companies provide loans to their employees that are repaid via garnishments.

scope: `garnishments:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Garnishments.ListAsync(
    employeeId: "<id>",
    page: 768578,
    per: 547272,
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `EmployeeId`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the employee                                                                                                                                                                                                     |
| `Page`                                                                                                                                                                                                                       | *long*                                                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                                                           | The page that is requested. When unspecified, will load all objects unless endpoint forces pagination.                                                                                                                       |
| `Per`                                                                                                                                                                                                                        | *long*                                                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                                                           | Number of objects per page. For majority of endpoints will default to 25                                                                                                                                                     |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1EmployeesEmployeeIdGarnishmentsResponse](../../Models/Requests/GetV1EmployeesEmployeeIdGarnishmentsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## Get

Garnishments, or employee deductions, are fixed amounts or percentages deducted from an employee’s pay. They can be deducted a specific number of times or on a recurring basis. Garnishments can also have maximum deductions on a yearly or per-pay-period bases. Common uses for garnishments are court-ordered payments for child support or back taxes. Some companies provide loans to their employees that are repaid via garnishments.

scope: `garnishments:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Garnishments.GetAsync(
    garnishmentId: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `GarnishmentId`                                                                                                                                                                                                              | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the garnishment                                                                                                                                                                                                  |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1GarnishmentsGarnishmentIdResponse](../../Models/Requests/GetV1GarnishmentsGarnishmentIdResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## Update

Garnishments, or employee deductions, are fixed amounts or percentages deducted from an employee’s pay. They can be deducted a specific number of times or on a recurring basis. Garnishments can also have maximum deductions on a yearly or per-pay-period bases. Common uses for garnishments are court-ordered payments for child support or back taxes. Some companies provide loans to their employees that are repaid via garnishments.

scope: `garnishments:write`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Garnishments.UpdateAsync(
    garnishmentId: "<id>",
    requestBody: new PutV1GarnishmentsGarnishmentIdRequestBody() {
        Version = "<value>",
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `GarnishmentId`                                                                                                                                                                                                              | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the garnishment                                                                                                                                                                                                  |
| `RequestBody`                                                                                                                                                                                                                | [PutV1GarnishmentsGarnishmentIdRequestBody](../../Models/Requests/PutV1GarnishmentsGarnishmentIdRequestBody.md)                                                                                                              | :heavy_check_mark:                                                                                                                                                                                                           | N/A                                                                                                                                                                                                                          |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PutV1GarnishmentsGarnishmentIdResponse](../../Models/Requests/PutV1GarnishmentsGarnishmentIdResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## GetChildSupportData

Agency data and requirements to be used for creating child support garnishments

scope: `garnishments:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Garnishments.GetChildSupportDataAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1GarnishmentsChildSupportResponse](../../Models/Requests/GetV1GarnishmentsChildSupportResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |