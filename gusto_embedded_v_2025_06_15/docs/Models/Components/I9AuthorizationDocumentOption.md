# I9AuthorizationDocumentOption

An employee's I-9 verification document option based on the authorization status


## Fields

| Field                                                                             | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `Section`                                                                         | [Section](../../Models/Components/Section.md)                                     | :heavy_check_mark:                                                                | The document option's section in the list of acceptable documents on the Form I-9 |
| `Description`                                                                     | *string*                                                                          | :heavy_check_mark:                                                                | The document option's description                                                 |
| `DocumentType`                                                                    | *string*                                                                          | :heavy_check_mark:                                                                | The document option's document type                                               |
| `DocumentTitle`                                                                   | List<*string*>                                                                    | :heavy_check_mark:                                                                | The document option's document titles                                             |
| `CommonChoice`                                                                    | *bool*                                                                            | :heavy_check_mark:                                                                | Whether the document is a common choice for I-9 verification                      |