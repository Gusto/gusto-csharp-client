# ExternalPayrollTaxSuggestions

The representation of an external payroll with minimal information.


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `EmployeeUuid`                                                    | *string*                                                          | :heavy_minus_sign:                                                | The UUID of the employee.                                         |
| `TaxSuggestions`                                                  | List<[TaxSuggestions](../../Models/Components/TaxSuggestions.md)> | :heavy_minus_sign:                                                | Possible tax liabilities selections.                              |