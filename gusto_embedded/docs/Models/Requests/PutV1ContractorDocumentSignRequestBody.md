# PutV1ContractorDocumentSignRequestBody


## Fields

| Field                                                           | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `Fields`                                                        | List<[Models.Requests.Fields](../../Models/Requests/Fields.md)> | :heavy_check_mark:                                              | List of fields and the values they will be set to.              |
| `Agree`                                                         | *bool*                                                          | :heavy_check_mark:                                              | Whether you agree to sign electronically                        |
| `SignedByIpAddress`                                             | *string*                                                        | :heavy_check_mark:                                              | The IP address of the signatory who signed the form.            |