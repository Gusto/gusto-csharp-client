# PayrollPayrollStatusMetaType

Information about the payroll's status and expected dates


## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `Cancellable`                                                                    | *bool*                                                                           | :heavy_minus_sign:                                                               | true if the payroll may be cancelled.                                            |
| `ExpectedCheckDate`                                                              | *string*                                                                         | :heavy_minus_sign:                                                               | The date an employee will be paid if the payroll is submitted now.               |
| `InitialCheckDate`                                                               | *string*                                                                         | :heavy_minus_sign:                                                               | The normal check date for the associated pay period.                             |
| `ExpectedDebitTime`                                                              | *string*                                                                         | :heavy_minus_sign:                                                               | The time the employer's account will be debited if the payroll is submitted now. |
| `PayrollLate`                                                                    | *bool*                                                                           | :heavy_minus_sign:                                                               | expected_check_date > initial_check_date.                                        |
| `InitialDebitCutoffTime`                                                         | *string*                                                                         | :heavy_minus_sign:                                                               | Payroll must be submitted at or before this time to avoid late payroll.          |