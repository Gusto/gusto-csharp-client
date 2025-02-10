# Employees
(*Employees*)

## Overview

### Available Operations

* [PostV1Employees](#postv1employees) - Create an employee
* [List](#list) - Get employees of a company
* [PostV1HistoricalEmployees](#postv1historicalemployees) - Create a historical employee
* [PutV1HistoricalEmployees](#putv1historicalemployees) - Update a historical employee
* [Get](#get) - Get an employee
* [PutV1Employees](#putv1employees) - Update an employee
* [DeleteV1Employee](#deletev1employee) - Delete an onboarding employee
* [GetV1EmployeesEmployeeIdCustomFields](#getv1employeesemployeeidcustomfields) - Get an employee's custom fields
* [PutV1EmployeesEmployeeIdOnboardingDocumentsConfig](#putv1employeesemployeeidonboardingdocumentsconfig) - Update an employee's onboarding documents config
* [GetV1EmployeesEmployeeIdOnboardingStatus](#getv1employeesemployeeidonboardingstatus) - Get the employee's onboarding status
* [PutV1EmployeesEmployeeIdOnboardingStatus](#putv1employeesemployeeidonboardingstatus) - Update the employee's onboarding status
* [GetVersionEmployeesTimeOffActivities](#getversionemployeestimeoffactivities) - Get employee time off activities
* [GetTerminations](#getterminations) - Get terminations for an employee
* [DeleteV1EmployeesEmployeeIdBankAccountsBankAccountId](#deletev1employeesemployeeidbankaccountsbankaccountid) - Delete an employee bank account
* [PostV1JobsJobId](#postv1jobsjobid) - Create a job
* [GetGarnishments](#getgarnishments) - Get garnishments for an employee

## PostV1Employees

Create an employee.

scope: `employees:manage`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Employees.PostV1EmployeesAsync(
    companyId: "<id>",
    requestBody: new PostV1EmployeesRequestBody() {
        FirstName = "Carmine",
        LastName = "McLaughlin",
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyId`                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company                                                                                                                                                                                                      |
| `RequestBody`                                                                                                                                                                                                                | [PostV1EmployeesRequestBody](../../Models/Requests/PostV1EmployeesRequestBody.md)                                                                                                                                            | :heavy_check_mark:                                                                                                                                                                                                           | Create an employee.                                                                                                                                                                                                          |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PostV1EmployeesResponse](../../Models/Requests/PostV1EmployeesResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## List

Get all of the employees, onboarding, active and terminated, for a given company.

scope: `employees:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

GetV1CompaniesCompanyIdEmployeesRequest req = new GetV1CompaniesCompanyIdEmployeesRequest() {
    CompanyId = "<id>",
};

var res = await sdk.Employees.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [GetV1CompaniesCompanyIdEmployeesRequest](../../Models/Requests/GetV1CompaniesCompanyIdEmployeesRequest.md) | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |

### Response

**[GetV1CompaniesCompanyIdEmployeesResponse](../../Models/Requests/GetV1CompaniesCompanyIdEmployeesResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## PostV1HistoricalEmployees

Create a historical employee, an employee that was previously dismissed from the company in the current year.

scope: `employees:manage`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Employees.PostV1HistoricalEmployeesAsync(
    companyUuid: "<id>",
    historicalEmployeeBody: new HistoricalEmployeeBody() {
        FirstName = "Pinkie",
        LastName = "Torp",
        DateOfBirth = "1987-04-22",
        Ssn = "<value>",
        WorkAddress = new Models.Components.WorkAddress() {},
        HomeAddress = new HistoricalEmployeeBodyHomeAddress() {
            Street1 = "<value>",
            City = "Cronintown",
            State = "Nevada",
            Zip = "50684",
        },
        Termination = new HistoricalEmployeeBodyTermination() {},
        Job = new HistoricalEmployeeBodyJob() {},
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyUuid`                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company                                                                                                                                                                                                      |
| `HistoricalEmployeeBody`                                                                                                                                                                                                     | [HistoricalEmployeeBody](../../Models/Components/HistoricalEmployeeBody.md)                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                           | Create a historical employee.                                                                                                                                                                                                |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PostV1HistoricalEmployeesResponse](../../Models/Requests/PostV1HistoricalEmployeesResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## PutV1HistoricalEmployees

Update a historical employee, an employee that was previously dismissed from the company in the current year.

scope: `employees:manage`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Employees.PutV1HistoricalEmployeesAsync(
    companyUuid: "<id>",
    historicalEmployeeUuid: "<id>",
    requestBody: new PutV1HistoricalEmployeesRequestBody() {
        Version = "<value>",
        FirstName = "Nicolette",
        LastName = "Klocko",
        DateOfBirth = "1957-01-09",
        Ssn = "<value>",
        WorkAddress = new Models.Requests.WorkAddress() {},
        HomeAddress = new PutV1HistoricalEmployeesHomeAddress() {
            Street1 = "<value>",
            City = "New Devante",
            State = "Colorado",
            Zip = "16406",
        },
        Termination = new Models.Requests.Termination() {},
        Job = new Models.Requests.Job() {},
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyUuid`                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company                                                                                                                                                                                                      |
| `HistoricalEmployeeUuid`                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the historical employee                                                                                                                                                                                          |
| `RequestBody`                                                                                                                                                                                                                | [PutV1HistoricalEmployeesRequestBody](../../Models/Requests/PutV1HistoricalEmployeesRequestBody.md)                                                                                                                          | :heavy_check_mark:                                                                                                                                                                                                           | Update a historical employee.                                                                                                                                                                                                |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PutV1HistoricalEmployeesResponse](../../Models/Requests/PutV1HistoricalEmployeesResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## Get

Get an employee.

scope: `employees:read`


### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;
using System.Collections.Generic;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Employees.GetAsync(
    employeeId: "<id>",
    include: new List<QueryParamInclude>() {
        QueryParamInclude.CustomFields,
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                     | Type                                                                                                                                                                                                                                                                                          | Required                                                                                                                                                                                                                                                                                      | Description                                                                                                                                                                                                                                                                                   |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `EmployeeId`                                                                                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                                                                                      | :heavy_check_mark:                                                                                                                                                                                                                                                                            | The UUID of the employee                                                                                                                                                                                                                                                                      |
| `Include`                                                                                                                                                                                                                                                                                     | List<[QueryParamInclude](../../Models/Requests/QueryParamInclude.md)>                                                                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                                                                                                            | Include the requested attribute(s) in each employee response, multiple options are comma separated. Available options:<br/>- all_compensations: Include all effective dated compensations for each job instead of only the current compensation<br/>- custom_fields: Include employees' custom fields |
| `XGustoAPIVersion`                                                                                                                                                                                                                                                                            | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                            | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used.                                                                  |

### Response

**[GetV1EmployeesResponse](../../Models/Requests/GetV1EmployeesResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## PutV1Employees

Update an employee.

scope: `employees:write`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Employees.PutV1EmployeesAsync(
    employeeId: "<id>",
    requestBody: new PutV1EmployeesRequestBody() {
        Version = "<value>",
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `EmployeeId`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the employee                                                                                                                                                                                                     |
| `RequestBody`                                                                                                                                                                                                                | [PutV1EmployeesRequestBody](../../Models/Requests/PutV1EmployeesRequestBody.md)                                                                                                                                              | :heavy_check_mark:                                                                                                                                                                                                           | Update an employee.                                                                                                                                                                                                          |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PutV1EmployeesResponse](../../Models/Requests/PutV1EmployeesResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## DeleteV1Employee

Use this endpoint to delete an employee who is in onboarding. Deleting
an onboarded employee is not allowed and will return a 422 response. Please check out the Terminations api
if you need to terminate an onboarded employee.

scope: `employees:manage`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Employees.DeleteV1EmployeeAsync(
    employeeId: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `EmployeeId`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the employee                                                                                                                                                                                                     |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[DeleteV1EmployeeResponse](../../Models/Requests/DeleteV1EmployeeResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## GetV1EmployeesEmployeeIdCustomFields

Returns a list of the employee's custom fields.

scope: `employees:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Employees.GetV1EmployeesEmployeeIdCustomFieldsAsync(
    employeeId: "<id>",
    page: 6617.63D,
    per: 9193.31D,
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `EmployeeId`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the employee                                                                                                                                                                                                     |
| `Page`                                                                                                                                                                                                                       | *double*                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                           | The page that is requested. When unspecified, will load all objects unless endpoint forces pagination.                                                                                                                       |
| `Per`                                                                                                                                                                                                                        | *double*                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                           | Number of objects per page. For majority of endpoints will default to 25                                                                                                                                                     |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1EmployeesEmployeeIdCustomFieldsResponse](../../Models/Requests/GetV1EmployeesEmployeeIdCustomFieldsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## PutV1EmployeesEmployeeIdOnboardingDocumentsConfig

Indicate whether to include the Form I-9 for an employee during the onboarding process.

scope: `employees:manage`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Employees.PutV1EmployeesEmployeeIdOnboardingDocumentsConfigAsync(
    employeeId: "<id>",
    requestBody: new PutV1EmployeesEmployeeIdOnboardingDocumentsConfigRequestBody() {},
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `EmployeeId`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the employee                                                                                                                                                                                                     |
| `RequestBody`                                                                                                                                                                                                                | [PutV1EmployeesEmployeeIdOnboardingDocumentsConfigRequestBody](../../Models/Requests/PutV1EmployeesEmployeeIdOnboardingDocumentsConfigRequestBody.md)                                                                        | :heavy_check_mark:                                                                                                                                                                                                           | N/A                                                                                                                                                                                                                          |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PutV1EmployeesEmployeeIdOnboardingDocumentsConfigResponse](../../Models/Requests/PutV1EmployeesEmployeeIdOnboardingDocumentsConfigResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## GetV1EmployeesEmployeeIdOnboardingStatus

# Description
Retrieves an employee's onboarding status. The data returned helps inform the required onboarding steps and respective completion status.

scope: `employees:read`

## onboarding_status

### Admin-facilitated onboarding
| onboarding_status | Description |
|:------------------|------------:|
| `admin_onboarding_incomplete` | Admin needs to complete the full employee-onboarding. |
| `onboarding_completed` | Employee has been fully onboarded and verified. |

### Employee self-onboarding
| onboarding_status | Description |
|:------------------|------------:|
| `admin_onboarding_incomplete` | Admin needs to enter basic information about the employee. |
| `self_onboarding_pending_invite` | Admin has the intention to invite the employee to self-onboard (e.g., marking a checkbox), but the system has not yet sent the invitation. |
| `self_onboarding_invited` | Employee has been sent an invitation to self-onboard. |
| `self_onboarding_invited_started` | Employee has started the self-onboarding process. |
| `self_onboarding_invited_overdue` | Employee's start date has passed, and employee has still not completed self-onboarding. |
| `self_onboarding_completed_by_employee` | Employee has completed entering in their information. The status should be updated via API to "self_onboarding_awaiting_admin_review" from here, once the Admin has started reviewing. |
| `self_onboarding_awaiting_admin_review` | Admin has started to verify the employee's information. |
| `onboarding_completed` | Employee has been fully onboarded and verified. |

## onboarding_steps

| onboarding_steps | Requirement(s) to be completed |
|:-----------------|-------------------------------:|
| `personal_details` | Add employee's first name, last name, email, date of birth, social security number |
| `compensation_details` | Associate employee to a job & compensation. |
| `add_work_address` | Add employee work address. |
| `add_home_address` | Add employee home address. |
| `federal_tax_setup` | Set up federal tax withholdings. |
| `state_tax_setup` | Set up state tax withholdings. |
| `direct_deposit_setup` | (optional) Set up employee's direct deposit. |
| `employee_form_signing` | Employee forms (e.g., W4, direct deposit authorization) are generated & signed. |
| `file_new_hire_report` | File a new hire report for this employee. |
| `admin_review` | Admin reviews & confirms employee details (only required for Employee self-onboarding) |

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Employees.GetV1EmployeesEmployeeIdOnboardingStatusAsync(
    employeeId: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `EmployeeId`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the employee                                                                                                                                                                                                     |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1EmployeesEmployeeIdOnboardingStatusResponse](../../Models/Requests/GetV1EmployeesEmployeeIdOnboardingStatusResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## PutV1EmployeesEmployeeIdOnboardingStatus

scope: `employees:manage`

Updates an employee's onboarding status.
Below is a list of valid onboarding status changes depending on the intended action to be performed on behalf of the employee.

| Action | current onboarding_status | new onboarding_status |
|:------------------|:------------:|----------:|
| Mark an employee as self-onboarding | `admin_onboarding_incomplete` | `self_onboarding_pending_invite` |
| Invite an employee to self-onboard | `admin_onboarding_incomplete` or `self_onboarding_pending_invite` | `self_onboarding_invited` |
| Cancel an employee's self-onboarding | `self_onboarding_invited` or `self_onboarding_pending_invite` | `admin_onboarding_incomplete` |
| Review an employee's self-onboarded info | `self_onboarding_completed_by_employee` | `self_onboarding_awaiting_admin_review` |
| Finish an employee's onboarding | `admin_onboarding_incomplete` or `self_onboarding_awaiting_admin_review` | `onboarding_completed` |

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Employees.PutV1EmployeesEmployeeIdOnboardingStatusAsync(
    employeeId: "<id>",
    requestBody: new PutV1EmployeesEmployeeIdOnboardingStatusRequestBody() {
        OnboardingStatus = "<value>",
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `EmployeeId`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the employee                                                                                                                                                                                                     |
| `RequestBody`                                                                                                                                                                                                                | [PutV1EmployeesEmployeeIdOnboardingStatusRequestBody](../../Models/Requests/PutV1EmployeesEmployeeIdOnboardingStatusRequestBody.md)                                                                                          | :heavy_check_mark:                                                                                                                                                                                                           | N/A                                                                                                                                                                                                                          |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PutV1EmployeesEmployeeIdOnboardingStatusResponse](../../Models/Requests/PutV1EmployeesEmployeeIdOnboardingStatusResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## GetVersionEmployeesTimeOffActivities

Get employee time off activities.

scope: `employee_time_off_activities:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Employees.GetVersionEmployeesTimeOffActivitiesAsync(
    employeeUuid: "<id>",
    timeOffType: "<value>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `EmployeeUuid`                                                                                                                                                                                                               | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the employee                                                                                                                                                                                                     |
| `TimeOffType`                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The time off type name you want to query data for. ex: 'sick' or 'vacation'                                                                                                                                                  |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetVersionEmployeesTimeOffActivitiesResponse](../../Models/Requests/GetVersionEmployeesTimeOffActivitiesResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## GetTerminations

Terminations are created whenever an employee is scheduled to leave the company. The only things required are an effective date (their last day of work) and whether they should receive their wages in a one-off termination payroll or with the rest of the company.

Note that some states require employees to receive their final wages within 24 hours (unless they consent otherwise,) in which case running a one-off payroll may be the only option.

scope: `employments:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Employees.GetTerminationsAsync(
    employeeId: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `EmployeeId`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the employee                                                                                                                                                                                                     |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1EmployeesEmployeeIdTerminationsResponse](../../Models/Requests/GetV1EmployeesEmployeeIdTerminationsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## DeleteV1EmployeesEmployeeIdBankAccountsBankAccountId

Deletes an employee bank account. To update an employee's bank
account details, delete the bank account first and create a new one.

scope: `employee_payment_methods:write`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Employees.DeleteV1EmployeesEmployeeIdBankAccountsBankAccountIdAsync(
    employeeId: "<id>",
    bankAccountUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `EmployeeId`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the employee                                                                                                                                                                                                     |
| `BankAccountUuid`                                                                                                                                                                                                            | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the bank account                                                                                                                                                                                                 |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[DeleteV1EmployeesEmployeeIdBankAccountsBankAccountIdResponse](../../Models/Requests/DeleteV1EmployeesEmployeeIdBankAccountsBankAccountIdResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## PostV1JobsJobId

Create a job.

scope: `jobs:write`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Employees.PostV1JobsJobIdAsync(
    employeeId: "<id>",
    requestBody: new PostV1JobsJobIdRequestBody() {
        Title = "<value>",
        HireDate = "<value>",
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `EmployeeId`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the employee                                                                                                                                                                                                     |
| `RequestBody`                                                                                                                                                                                                                | [PostV1JobsJobIdRequestBody](../../Models/Requests/PostV1JobsJobIdRequestBody.md)                                                                                                                                            | :heavy_check_mark:                                                                                                                                                                                                           | Create a job.                                                                                                                                                                                                                |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PostV1JobsJobIdResponse](../../Models/Requests/PostV1JobsJobIdResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |

## GetGarnishments

Garnishments, or employee deductions, are fixed amounts or percentages deducted from an employee’s pay. They can be deducted a specific number of times or on a recurring basis. Garnishments can also have maximum deductions on a yearly or per-pay-period bases. Common uses for garnishments are court-ordered payments for child support or back taxes. Some companies provide loans to their employees that are repaid via garnishments.

scope: `garnishments:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Employees.GetGarnishmentsAsync(
    employeeId: "<id>",
    page: 9674.16D,
    per: 2968.44D,
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `EmployeeId`                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the employee                                                                                                                                                                                                     |
| `Page`                                                                                                                                                                                                                       | *double*                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                           | The page that is requested. When unspecified, will load all objects unless endpoint forces pagination.                                                                                                                       |
| `Per`                                                                                                                                                                                                                        | *double*                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                           | Number of objects per page. For majority of endpoints will default to 25                                                                                                                                                     |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1EmployeesEmployeeIdGarnishmentsResponse](../../Models/Requests/GetV1EmployeesEmployeeIdGarnishmentsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |