# UnprocessableEntityErrorObject1

Unprocessable Entity
  
This may happen when the body of your request contains errors such as `invalid_attribute_value`, or the request fails due to an `invalid_operation`. See the [Errors Categories](https://docs.gusto.com/embedded-payroll/docs/error-categories) guide for more details.



## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `Errors`                                                                | List<[EntityErrorObject](../../Models/Components/EntityErrorObject.md)> | :heavy_minus_sign:                                                      | N/A                                                                     |
| `HttpMeta`                                                              | [HTTPMetadata](../../Models/Components/HTTPMetadata.md)                 | :heavy_check_mark:                                                      | N/A                                                                     |