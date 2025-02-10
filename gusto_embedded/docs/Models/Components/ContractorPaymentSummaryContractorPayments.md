# ContractorPaymentSummaryContractorPayments


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `ContractorUuid`                                                        | *double*                                                                | :heavy_minus_sign:                                                      | The UUID of the contractor.                                             |
| `ReimbursementTotal`                                                    | *string*                                                                | :heavy_minus_sign:                                                      | The total reimbursements for the contractor within a given time period. |
| `WageTotal`                                                             | *string*                                                                | :heavy_minus_sign:                                                      | The total wages for the contractor within a given time period.          |
| `Payments`                                                              | List<[ContractorPayment](../../Models/Components/ContractorPayment.md)> | :heavy_minus_sign:                                                      | The contractor’s payments within a given time period.<br/>              |