# PayrollProcessingRequest


## Fields

| Field                                                                                       | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `Status`                                                                                    | [PayrollProcessingRequestStatus](../../Models/Components/PayrollProcessingRequestStatus.md) | :heavy_minus_sign:                                                                          | The status of the payroll processing request                                                |
| `Errors`                                                                                    | List<[EntityErrorObject](../../Models/Components/EntityErrorObject.md)>                     | :heavy_minus_sign:                                                                          | Errors that occurred during async payroll processing                                        |