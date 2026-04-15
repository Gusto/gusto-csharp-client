# GetV1TokenInfoResponseBody

Example response


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `Scope`                                                 | *string*                                                | :heavy_check_mark:                                      | Space delimited string of accessible scopes.            |
| `Resource`                                              | [Resource](../../Models/Requests/Resource.md)           | :heavy_check_mark:                                      | Information about the token resource.                   |
| `ResourceOwner`                                         | [ResourceOwner](../../Models/Requests/ResourceOwner.md) | :heavy_check_mark:                                      | Information about the token owner                       |