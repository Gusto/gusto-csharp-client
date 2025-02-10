# TimeOffPolicies
(*TimeOffPolicies*)

## Overview

### Available Operations

* [PostV1PayrollsPayrollIdCalculateAccruingTimeOffHours](#postv1payrollspayrollidcalculateaccruingtimeoffhours) - Calculate accruing time off hours
* [Get](#get) - Get a time off policy
* [PutTimeOffPoliciesTimeOffPolicyUuid](#puttimeoffpoliciestimeoffpolicyuuid) - Update a time off policy
* [List](#list) - Get all time off policies
* [PostCompaniesCompanyUuidTimeOffPolicies](#postcompaniescompanyuuidtimeoffpolicies) - Create a time off policy
* [PutVersionTimeOffPoliciesTimeOffPolicyUuidAddEmployees](#putversiontimeoffpoliciestimeoffpolicyuuidaddemployees) - Add employees to a time off policy
* [PutV1TimeOffPoliciesTimeOffPolicyUuidRemoveEmployees](#putv1timeoffpoliciestimeoffpolicyuuidremoveemployees) - Remove employees from a time off policy
* [PutVersionTimeOffPoliciesTimeOffPolicyUuidBalance](#putversiontimeoffpoliciestimeoffpolicyuuidbalance) - Update employee time off hour balances
* [PutV1TimeOffPoliciesTimeOffPolicyUuidDeactivate](#putv1timeoffpoliciestimeoffpolicyuuiddeactivate) - Deactivate a time off policy

## PostV1PayrollsPayrollIdCalculateAccruingTimeOffHours

Returns a list of accruing time off for each time off policy associated with the employee.

Factors affecting the accrued hours:
  * the time off policy accrual method (whether they get pay per hour worked, per hour paid, with / without overtime, accumulate time off based on pay period / calendar year / anniversary)
  * how many hours of work during this pay period
  * how many hours of PTO / sick hours taken during this pay period (for per hour paid policies only)
  * company pay schedule frequency (for per pay period)

If none of the parameters is passed in, the accrued time off hour will be 0.

scope: `payrolls:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.TimeOffPolicies.PostV1PayrollsPayrollIdCalculateAccruingTimeOffHoursAsync(
    payrollId: "<id>",
    employeeId: "<id>",
    requestBody: new PostV1PayrollsPayrollIdCalculateAccruingTimeOffHoursRequestBody() {},
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `PayrollId`                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the payroll                                                                                                                                                                                                      |
| `EmployeeId`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the employee                                                                                                                                                                                                     |
| `RequestBody`                                                                                                                                                                                                                | [PostV1PayrollsPayrollIdCalculateAccruingTimeOffHoursRequestBody](../../Models/Requests/PostV1PayrollsPayrollIdCalculateAccruingTimeOffHoursRequestBody.md)                                                                  | :heavy_check_mark:                                                                                                                                                                                                           | N/A                                                                                                                                                                                                                          |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PostV1PayrollsPayrollIdCalculateAccruingTimeOffHoursResponse](../../Models/Requests/PostV1PayrollsPayrollIdCalculateAccruingTimeOffHoursResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## Get

Get a time off policy

scope: `time_off_policies:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.TimeOffPolicies.GetAsync(
    timeOffPolicyUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `TimeOffPolicyUuid`                                                                                                                                                                                                          | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company time off policy                                                                                                                                                                                      |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetTimeOffPoliciesTimeOffPolicyUuidResponse](../../Models/Requests/GetTimeOffPoliciesTimeOffPolicyUuidResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## PutTimeOffPoliciesTimeOffPolicyUuid

Update a time off policy

scope: `time_off_policies:write`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.TimeOffPolicies.PutTimeOffPoliciesTimeOffPolicyUuidAsync(
    timeOffPolicyUuid: "<id>",
    requestBody: new PutTimeOffPoliciesTimeOffPolicyUuidRequestBody() {},
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `TimeOffPolicyUuid`                                                                                                                                                                                                          | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company time off policy                                                                                                                                                                                      |
| `RequestBody`                                                                                                                                                                                                                | [PutTimeOffPoliciesTimeOffPolicyUuidRequestBody](../../Models/Requests/PutTimeOffPoliciesTimeOffPolicyUuidRequestBody.md)                                                                                                    | :heavy_check_mark:                                                                                                                                                                                                           | Can update any attributes of the time off policy except policy_type, is_active, complete & employees                                                                                                                         |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PutTimeOffPoliciesTimeOffPolicyUuidResponse](../../Models/Requests/PutTimeOffPoliciesTimeOffPolicyUuidResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## List

Get all time off policies for a company

scope: `time_off_policies:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.TimeOffPolicies.ListAsync(
    companyUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyUuid`                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company                                                                                                                                                                                                      |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetCompaniesCompanyUuidTimeOffPoliciesResponse](../../Models/Requests/GetCompaniesCompanyUuidTimeOffPoliciesResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## PostCompaniesCompanyUuidTimeOffPolicies

Create a time off policy

scope: `time_off_policies:write`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.TimeOffPolicies.PostCompaniesCompanyUuidTimeOffPoliciesAsync(
    companyUuid: "<id>",
    requestBody: new PostCompaniesCompanyUuidTimeOffPoliciesRequestBody() {
        Name = "<value>",
        PolicyType = "<value>",
        AccrualMethod = PostCompaniesCompanyUuidTimeOffPoliciesAccrualMethod.PerAnniversaryYear,
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyUuid`                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company                                                                                                                                                                                                      |
| `RequestBody`                                                                                                                                                                                                                | [PostCompaniesCompanyUuidTimeOffPoliciesRequestBody](../../Models/Requests/PostCompaniesCompanyUuidTimeOffPoliciesRequestBody.md)                                                                                            | :heavy_check_mark:                                                                                                                                                                                                           | Requires a policy name, a policy_type, and an accrual_method                                                                                                                                                                 |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PostCompaniesCompanyUuidTimeOffPoliciesResponse](../../Models/Requests/PostCompaniesCompanyUuidTimeOffPoliciesResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## PutVersionTimeOffPoliciesTimeOffPolicyUuidAddEmployees

Add employees to a time off policy. Employees are required to have at least one job to be added to a time off policy. Accepts starting balances for non-unlimited policies

scope: `time_off_policies:write`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.TimeOffPolicies.PutVersionTimeOffPoliciesTimeOffPolicyUuidAddEmployeesAsync(
    timeOffPolicyUuid: "<id>",
    requestBody: new PutVersionTimeOffPoliciesTimeOffPolicyUuidAddEmployeesRequestBody() {},
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `TimeOffPolicyUuid`                                                                                                                                                                                                          | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company time off policy                                                                                                                                                                                      |
| `RequestBody`                                                                                                                                                                                                                | [PutVersionTimeOffPoliciesTimeOffPolicyUuidAddEmployeesRequestBody](../../Models/Requests/PutVersionTimeOffPoliciesTimeOffPolicyUuidAddEmployeesRequestBody.md)                                                              | :heavy_check_mark:                                                                                                                                                                                                           | A list of employee objects containing the employee uuid                                                                                                                                                                      |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PutVersionTimeOffPoliciesTimeOffPolicyUuidAddEmployeesResponse](../../Models/Requests/PutVersionTimeOffPoliciesTimeOffPolicyUuidAddEmployeesResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## PutV1TimeOffPoliciesTimeOffPolicyUuidRemoveEmployees

Remove employees from a time off policy

scope: `time_off_policies:write`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.TimeOffPolicies.PutV1TimeOffPoliciesTimeOffPolicyUuidRemoveEmployeesAsync(
    timeOffPolicyUuid: "<id>",
    requestBody: new PutV1TimeOffPoliciesTimeOffPolicyUuidRemoveEmployeesRequestBody() {},
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `TimeOffPolicyUuid`                                                                                                                                                                                                          | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company time off policy                                                                                                                                                                                      |
| `RequestBody`                                                                                                                                                                                                                | [PutV1TimeOffPoliciesTimeOffPolicyUuidRemoveEmployeesRequestBody](../../Models/Requests/PutV1TimeOffPoliciesTimeOffPolicyUuidRemoveEmployeesRequestBody.md)                                                                  | :heavy_check_mark:                                                                                                                                                                                                           | A list of employee objects containing the employee uuid                                                                                                                                                                      |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PutV1TimeOffPoliciesTimeOffPolicyUuidRemoveEmployeesResponse](../../Models/Requests/PutV1TimeOffPoliciesTimeOffPolicyUuidRemoveEmployeesResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## PutVersionTimeOffPoliciesTimeOffPolicyUuidBalance

Updates time off hours balances for employees for a time off policy

scope: `time_off_policies:write`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.TimeOffPolicies.PutVersionTimeOffPoliciesTimeOffPolicyUuidBalanceAsync(
    timeOffPolicyUuid: "<id>",
    requestBody: new PutVersionTimeOffPoliciesTimeOffPolicyUuidBalanceRequestBody() {},
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `TimeOffPolicyUuid`                                                                                                                                                                                                          | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company time off policy                                                                                                                                                                                      |
| `RequestBody`                                                                                                                                                                                                                | [PutVersionTimeOffPoliciesTimeOffPolicyUuidBalanceRequestBody](../../Models/Requests/PutVersionTimeOffPoliciesTimeOffPolicyUuidBalanceRequestBody.md)                                                                        | :heavy_check_mark:                                                                                                                                                                                                           | A list of employee objects containing the employee uuid and time off hours balance                                                                                                                                           |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PutVersionTimeOffPoliciesTimeOffPolicyUuidBalanceResponse](../../Models/Requests/PutVersionTimeOffPoliciesTimeOffPolicyUuidBalanceResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## PutV1TimeOffPoliciesTimeOffPolicyUuidDeactivate

Deactivate a time off policy

scope: `time_off_policies:write`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.TimeOffPolicies.PutV1TimeOffPoliciesTimeOffPolicyUuidDeactivateAsync(
    timeOffPolicyUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `TimeOffPolicyUuid`                                                                                                                                                                                                          | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company time off policy                                                                                                                                                                                      |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PutV1TimeOffPoliciesTimeOffPolicyUuidDeactivateResponse](../../Models/Requests/PutV1TimeOffPoliciesTimeOffPolicyUuidDeactivateResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |