# CompanyCustomField

A custom field on a company


## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `Uuid`                                                         | *string*                                                       | :heavy_check_mark:                                             | UUID of the company custom field                               |
| `Name`                                                         | *string*                                                       | :heavy_check_mark:                                             | Name of the company custom field                               |
| `Type`                                                         | [CustomFieldType](../../Models/Components/CustomFieldType.md)  | :heavy_check_mark:                                             | Input type for the custom field.                               |
| `Description`                                                  | *string*                                                       | :heavy_minus_sign:                                             | Description of the company custom field                        |
| `SelectionOptions`                                             | List<*string*>                                                 | :heavy_minus_sign:                                             | An array of options for fields of type radio. Otherwise, null. |