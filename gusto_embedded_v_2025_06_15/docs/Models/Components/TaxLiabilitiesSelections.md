# TaxLiabilitiesSelections

Example response


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `TaxId`                                                                     | *long*                                                                      | :heavy_minus_sign:                                                          | The ID of the tax.                                                          |
| `TaxName`                                                                   | *string*                                                                    | :heavy_minus_sign:                                                          | The name of the tax.                                                        |
| `LastUnpaidExternalPayrollUuid`                                             | *string*                                                                    | :heavy_minus_sign:                                                          | The UUID of last unpaid external payroll.                                   |
| `PossibleLiabilities`                                                       | List<[PossibleLiabilities](../../Models/Components/PossibleLiabilities.md)> | :heavy_minus_sign:                                                          | Possible tax liabilities selections.                                        |