# Contractors
(*Contractors*)

## Overview

### Available Operations

* [PostV1CompaniesCompanyUuidContractors](#postv1companiescompanyuuidcontractors) - Create a contractor
* [GetV1CompaniesCompanyUuidContractors](#getv1companiescompanyuuidcontractors) - Get contractors of a company
* [GetV1ContractorsContractorUuid](#getv1contractorscontractoruuid) - Get a contractor
* [PutV1ContractorsContractorUuid](#putv1contractorscontractoruuid) - Update a contractor
* [DeleteV1ContractorsContractorUuid](#deletev1contractorscontractoruuid) - Delete a contractor
* [GetV1ContractorsContractorUuidOnboardingStatus](#getv1contractorscontractoruuidonboardingstatus) - Get the contractor's onboarding status
* [PutV1ContractorsContractorUuidOnboardingStatus](#putv1contractorscontractoruuidonboardingstatus) - Change the contractor's onboarding status
* [GetV1ContractorsContractorUuidAddress](#getv1contractorscontractoruuidaddress) - Get a contractor address
* [PutV1ContractorsContractorUuidAddress](#putv1contractorscontractoruuidaddress) - Update a contractor's address
* [GetPaymentMethod](#getpaymentmethod) - Get a contractor's payment method

## PostV1CompaniesCompanyUuidContractors

Create an individual or business contractor.

scope: `contractors:manage`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Contractors.PostV1CompaniesCompanyUuidContractorsAsync(
    companyUuid: "<id>",
    requestBody: new PostV1CompaniesCompanyUuidContractorsRequestBody() {
        WageType = WageType.Fixed,
        StartDate = "2020-01-11",
        HourlyRate = "40.0",
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyUuid`                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company                                                                                                                                                                                                      |
| `RequestBody`                                                                                                                                                                                                                | [PostV1CompaniesCompanyUuidContractorsRequestBody](../../Models/Requests/PostV1CompaniesCompanyUuidContractorsRequestBody.md)                                                                                                | :heavy_check_mark:                                                                                                                                                                                                           | Create an individual or business contractor.                                                                                                                                                                                 |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PostV1CompaniesCompanyUuidContractorsResponse](../../Models/Requests/PostV1CompaniesCompanyUuidContractorsResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## GetV1CompaniesCompanyUuidContractors

Get all contractors, active and inactive, individual and business, for a company.

scope: `contractors:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetV1CompaniesCompanyUuidContractorsRequest req = new GetV1CompaniesCompanyUuidContractorsRequest() {
    CompanyUuid = "<id>",
};

var res = await sdk.Contractors.GetV1CompaniesCompanyUuidContractorsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [GetV1CompaniesCompanyUuidContractorsRequest](../../Models/Requests/GetV1CompaniesCompanyUuidContractorsRequest.md) | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |

### Response

**[GetV1CompaniesCompanyUuidContractorsResponse](../../Models/Requests/GetV1CompaniesCompanyUuidContractorsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## GetV1ContractorsContractorUuid

Get a contractor.

scope: `contractors:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Contractors.GetV1ContractorsContractorUuidAsync(
    contractorUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ContractorUuid`                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the contractor                                                                                                                                                                                                   |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1ContractorsContractorUuidResponse](../../Models/Requests/GetV1ContractorsContractorUuidResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## PutV1ContractorsContractorUuid

Update a contractor.

scope: `contractors:write`

> 🚧 Warning
>
> Watch out when changing a contractor's type (when the contractor is finished onboarding). Specifically, changing contractor type can be dangerous since Gusto won’t recognize and file two separate 1099s if they simply change from business to individual

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Contractors.PutV1ContractorsContractorUuidAsync(
    contractorUuid: "<id>",
    requestBody: new PutV1ContractorsContractorUuidRequestBody() {
        Version = "<value>",
        StartDate = "2020-01-11",
        HourlyRate = "40.0",
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ContractorUuid`                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the contractor                                                                                                                                                                                                   |
| `RequestBody`                                                                                                                                                                                                                | [PutV1ContractorsContractorUuidRequestBody](../../Models/Requests/PutV1ContractorsContractorUuidRequestBody.md)                                                                                                              | :heavy_check_mark:                                                                                                                                                                                                           | N/A                                                                                                                                                                                                                          |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PutV1ContractorsContractorUuidResponse](../../Models/Requests/PutV1ContractorsContractorUuidResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## DeleteV1ContractorsContractorUuid

A contractor can only be deleted when there are no contractor payments.

scope: `contractors:manage`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Contractors.DeleteV1ContractorsContractorUuidAsync(
    contractorUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ContractorUuid`                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the contractor                                                                                                                                                                                                   |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[DeleteV1ContractorsContractorUuidResponse](../../Models/Requests/DeleteV1ContractorsContractorUuidResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## GetV1ContractorsContractorUuidOnboardingStatus

Retrieves a contractor's onboarding status. The data returned helps inform the required onboarding steps and respective completion status.

scope: `contractors:read`

## onboarding_status

### Admin-facilitated onboarding
| onboarding_status | Description |
|:------------------|------------:|
| `admin_onboarding_incomplete` | Admin needs to enter basic information about the contractor. |
| `admin_onboarding_review` | All information has been completed and admin needs to confirm onboarding. |
| `onboarding_completed` | Contractor has been fully onboarded and verified. |

### Contractor self-onboarding

| onboarding_status | Description |
| --- | ----------- |
| `admin_onboarding_incomplete` | Admin needs to enter basic information about the contractor. |
| `self_onboarding_not_invited` | Admin has the intention to invite the contractor to self-onboard (e.g., marking a checkbox), but the system has not yet sent the invitation. |
| `self_onboarding_invited` | Contractor has been sent an invitation to self-onboard. |
| `self_onboarding_started` | Contractor has started the self-onboarding process. |
| `self_onboarding_review` | Admin needs to review contractors's entered information and confirm onboarding. |
| `onboarding_completed` | Contractor has been fully onboarded and verified. |

## onboarding_steps

| onboarding_steps | Requirement(s) to be completed |
|:-----------------|-------------------------------:|
| `basic_details` | Add individual contractor's first name, last name, social security number or Business name and EIN depending on the contractor type |
| `add_address` | Add contractor address. |
| `compensation_details` | Add contractor compensation. |
| `payment_details` | Set up contractor's direct deposit or set to check. |
| `sign_documents` | Contractor forms (e.g., W9) are generated & signed. |
| `file_new_hire_report` | Contractor new hire report is generated. |

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Contractors.GetV1ContractorsContractorUuidOnboardingStatusAsync(
    contractorUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ContractorUuid`                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the contractor                                                                                                                                                                                                   |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1ContractorsContractorUuidOnboardingStatusResponse](../../Models/Requests/GetV1ContractorsContractorUuidOnboardingStatusResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## PutV1ContractorsContractorUuidOnboardingStatus

Updates a contractor's onboarding status.

scope: `contractors:write`

Below is a list of valid onboarding status changes depending on the intended action to be performed on behalf of the contractor.

| Action | current onboarding_status | new onboarding_status |
|:------------------|:------------:|----------:|
| Mark a contractor as self-onboarding | `admin_onboarding_incomplete` | `self_onboarding_not_invited` |
| Invite a contractor to self-onboard | `admin_onboarding_incomplete` or `self_onboarding_not_invited` | `self_onboarding_invited` |
| Cancel a contractor's self-onboarding | `self_onboarding_invited` or `self_onboarding_not_invited` | `admin_onboarding_incomplete` |
| Review a contractor's self-onboarded info | `self_onboarding_started` | `self_onboarding_review` |
| Finish a contractor's onboarding | `admin_onboarding_review` or `self_onboarding_review` | `onboarding_completed` |

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Contractors.PutV1ContractorsContractorUuidOnboardingStatusAsync(
    contractorUuid: "<id>",
    requestBody: new PutV1ContractorsContractorUuidOnboardingStatusRequestBody() {},
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ContractorUuid`                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the contractor                                                                                                                                                                                                   |
| `RequestBody`                                                                                                                                                                                                                | [PutV1ContractorsContractorUuidOnboardingStatusRequestBody](../../Models/Requests/PutV1ContractorsContractorUuidOnboardingStatusRequestBody.md)                                                                              | :heavy_check_mark:                                                                                                                                                                                                           | N/A                                                                                                                                                                                                                          |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PutV1ContractorsContractorUuidOnboardingStatusResponse](../../Models/Requests/PutV1ContractorsContractorUuidOnboardingStatusResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## GetV1ContractorsContractorUuidAddress

The address of a contractor is used to determine certain tax information about them. Addresses are geocoded on create and update to ensure validity.

scope: `contractors:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Contractors.GetV1ContractorsContractorUuidAddressAsync(
    contractorUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ContractorUuid`                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the contractor                                                                                                                                                                                                   |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1ContractorsContractorUuidAddressResponse](../../Models/Requests/GetV1ContractorsContractorUuidAddressResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## PutV1ContractorsContractorUuidAddress

The address of a contractor is used to determine certain tax information about them. Addresses are geocoded on create and update to ensure validity.

scope: `contractors:write`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Contractors.PutV1ContractorsContractorUuidAddressAsync(
    contractorUuid: "<id>",
    requestBody: new PutV1ContractorsContractorUuidAddressRequestBody() {
        Version = "<value>",
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ContractorUuid`                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the contractor                                                                                                                                                                                                   |
| `RequestBody`                                                                                                                                                                                                                | [PutV1ContractorsContractorUuidAddressRequestBody](../../Models/Requests/PutV1ContractorsContractorUuidAddressRequestBody.md)                                                                                                | :heavy_check_mark:                                                                                                                                                                                                           | N/A                                                                                                                                                                                                                          |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PutV1ContractorsContractorUuidAddressResponse](../../Models/Requests/PutV1ContractorsContractorUuidAddressResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## GetPaymentMethod

Fetches a contractor's payment method. A contractor payment method
describes how the payment should be split across the contractor's associated
bank accounts.

scope: `contractor_payment_methods:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Contractors.GetPaymentMethodAsync(
    contractorUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ContractorUuid`                                                                                                                                                                                                             | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the contractor                                                                                                                                                                                                   |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1ContractorsContractorUuidPaymentMethodResponse](../../Models/Requests/GetV1ContractorsContractorUuidPaymentMethodResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |