# GeneratedDocuments
(*GeneratedDocuments*)

## Overview

### Available Operations

* [Get](#get) - Get a generated document

## Get

Get a document given the request_uuid. The response will include the generation request's status and urls to the document. A list of urls is returned as certain document types require several urls.

scope: `generated_documents:read`

### Example Usage

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.GeneratedDocuments.GetAsync(
    documentType: DocumentType.PrintablePayrollChecks,
    requestUuid: "<id>",
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFourMinus04Minus01
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `DocumentType`                                                                                                                                                                                                               | [Models.Components.DocumentType](../../Models/Components/DocumentType.md)                                                                                                                                                    | :heavy_check_mark:                                                                                                                                                                                                           | The type of document being generated                                                                                                                                                                                         |
| `RequestUuid`                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                           | The UUID of the request to generate a document. Generate document endpoints return request_uuids to be used with the GET generated document endpoint.                                                                        |
| `XGustoAPIVersion`                                                                                                                                                                                                           | [VersionHeader](../../Models/Components/VersionHeader.md)                                                                                                                                                                    | :heavy_minus_sign:                                                                                                                                                                                                           | Determines the date-based API version associated with your API call. If none is provided, your application's [minimum API version](https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version) is used. |

### Response

**[GetV1GeneratedDocumentsDocumentTypeRequestUuidResponse](../../Models/Requests/GetV1GeneratedDocumentsDocumentTypeRequestUuidResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| GustoEmbedded.Models.Errors.APIException | 4XX, 5XX                                 | \*/\*                                    |