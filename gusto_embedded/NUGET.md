# GustoEmbedded


<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Introspection.GetV1TokenInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name                | Type | Scheme      |
| ------------------- | ---- | ----------- |
| `CompanyAccessAuth` | http | HTTP Bearer |

To authenticate with the API the `CompanyAccessAuth` parameter must be set when initializing the SDK client instance. For example:
```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Introspection.GetV1TokenInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

// handle response
```

### Per-Operation Security Schemes

Some operations in this SDK require the security scheme to be specified at the request level. For example:
```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto();

var res = await sdk.Companies.PostV1PartnerManagedCompaniesAsync(
    security: new PostV1PartnerManagedCompaniesSecurity() {
        SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    requestBody: new PostV1PartnerManagedCompaniesRequestBody() {
        User = new User() {
            FirstName = "Khalid",
            LastName = "Haley",
            Email = "Eliane.Watsica38@yahoo.com",
        },
        Company = new Models.Requests.Company() {
            Name = "<value>",
        },
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `GustoEmbedded.Models.Errors.APIException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `Request`     | *HttpRequestMessage*  | The HTTP request      |
| `Response`    | *HttpResponseMessage* | The HTTP response     |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `PostV1PartnerManagedCompaniesAsync` method throws the following exceptions:

| Error Type                                                 | Status Code | Content Type     |
| ---------------------------------------------------------- | ----------- | ---------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422         | application/json |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX    | \*/\*            |

### Example

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Errors;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto();

try
{
    var res = await sdk.Companies.PostV1PartnerManagedCompaniesAsync(
        security: new PostV1PartnerManagedCompaniesSecurity() {
            SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
        },
        requestBody: new PostV1PartnerManagedCompaniesRequestBody() {
            User = new User() {
                FirstName = "Khalid",
                LastName = "Haley",
                Email = "Eliane.Watsica38@yahoo.com",
            },
            Company = new Models.Requests.Company() {
                Name = "<value>",
            },
        },
        xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
    );

    // handle response
}
catch (Exception ex)
{
    if (ex is UnprocessableEntityErrorObject)
    {
        // Handle exception data
        throw;
    }
    else if (ex is GustoEmbedded.Models.Errors.APIException)
    {
        // Handle default exception
        throw;
    }
}
```
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Name

You can override the default server globally by passing a server name to the `server: string` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the names associated with the available servers:

| Name   | Server                       |
| ------ | ---------------------------- |
| `demo` | `https://api.gusto-demo.com` |
| `prod` | `https://api.gusto.com`      |

#### Example

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(
    server: "prod",
    companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Introspection.GetV1TokenInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

// handle response
```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(
    serverUrl: "https://api.gusto-demo.com",
    companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Introspection.GetV1TokenInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

// handle response
```
<!-- End Server Selection [server] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->