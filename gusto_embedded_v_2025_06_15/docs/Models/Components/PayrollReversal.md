# PayrollReversal

Example response


## Fields

| Field                                                    | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ReversedPayrollUuid`                                    | *string*                                                 | :heavy_minus_sign:                                       | The UUID for the payroll run being reversed.             |
| `ReversalPayrollUuid`                                    | *string*                                                 | :heavy_minus_sign:                                       | The UUID of the payroll where the reversal was applied.  |
| `Reason`                                                 | *string*                                                 | :heavy_minus_sign:                                       | A reason provided by the admin who created the reversal. |
| `ApprovedAt`                                             | *string*                                                 | :heavy_minus_sign:                                       | Timestamp of when the reversal was approved.             |
| `Category`                                               | *string*                                                 | :heavy_minus_sign:                                       | Category chosen by the admin who requested the reversal. |
| `ReversedEmployeeUuids`                                  | List<*string*>                                           | :heavy_minus_sign:                                       | Array of affected employee UUIDs.                        |