# CompanyAttachments
(*CompanyAttachments*)

## Overview

### Available Operations

* [GetDetails](#getdetails) - Get Company Attachment Details
* [GetList](#getlist) - Get List of Company Attachments
* [Create](#create) - Create Company Attachment and Upload File

## GetDetails

Retrieve the detail of an attachment uploaded by the company.

scope: `company_attachments:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.CompanyAttachments.GetDetailsAsync(
    companyId: "<id>",
    companyAttachmentUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyId`                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company                                                                                                                                                                                                      |
| `CompanyAttachmentUuid`                                                                                                                                                                                                      | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company attachment                                                                                                                                                                                           |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1CompaniesAttachmentResponse](../../Models/Requests/GetV1CompaniesAttachmentResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## GetList

Retrieve a list of all the attachments uploaded by the company.

scope: `company_attachments:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.CompanyAttachments.GetListAsync(
    companyId: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyId`                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company                                                                                                                                                                                                      |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1CompaniesAttachmentsResponse](../../Models/Requests/GetV1CompaniesAttachmentsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |

## Create

Upload a file and create a company attachment. We recommend uploading
PDF files for optimal compatibility. However, the following file types are
allowed: .qbb, .qbm, .gif, .jpg, .png, .pdf, .xls, .xlsx, .doc and .docx. 

scope: `company_attachments:write`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;
using System;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.CompanyAttachments.CreateAsync(
    companyId: "<id>",
    requestBody: new PostV1CompaniesAttachmentRequestBody() {
        Document = new Models.Requests.Document() {
            FileName = "example.file",
            Content = System.Text.Encoding.UTF8.GetBytes("0xae921BE031"),
        },
        Category = Category.Compliance,
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyId`                                                                                                                                                                                                                  | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the company                                                                                                                                                                                                      |
| `RequestBody`                                                                                                                                                                                                                | [PostV1CompaniesAttachmentRequestBody](../../Models/Requests/PostV1CompaniesAttachmentRequestBody.md)                                                                                                                        | :heavy_check_mark:                                                                                                                                                                                                           | N/A                                                                                                                                                                                                                          |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[PostV1CompaniesAttachmentResponse](../../Models/Requests/PostV1CompaniesAttachmentResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422                                                        | application/json                                           |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX                                                   | \*/\*                                                      |