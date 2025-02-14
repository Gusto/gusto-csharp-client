# HistoricalEmployees
(*HistoricalEmployees*)

## Overview

### Available Operations

* [Update](#update) - Update a historical employee

## Update

Update a historical employee, an employee that was previously dismissed from the company in the current year.

scope: `employees:manage`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.HistoricalEmployees.UpdateAsync(
    companyUuid: "<id>",
    historicalEmployeeUuid: "<id>",
    requestBody: new PutV1HistoricalEmployeesRequestBody() {
        Version = "<value>",
        FirstName = "Ruthe",
        LastName = "Hegmann",
        DateOfBirth = "2006-08-02",
        Ssn = "<value>",
        WorkAddress = new Models.Requests.WorkAddress() {},
        HomeAddress = new PutV1HistoricalEmployeesHomeAddress() {
            Street1 = "<value>",
            City = "Kuhnworth",
            State = "Arizona",
            Zip = "43217-8347",
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