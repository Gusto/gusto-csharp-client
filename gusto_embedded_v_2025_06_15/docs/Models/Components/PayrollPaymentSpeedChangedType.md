# PayrollPaymentSpeedChangedType

Only applicable when a payroll is moved to four day processing instead of fast ach.


## Fields

| Field                                            | Type                                             | Required                                         | Description                                      |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| `OriginalCheckDate`                              | *string*                                         | :heavy_minus_sign:                               | Original check date when fast ach applies.       |
| `CurrentCheckDate`                               | *string*                                         | :heavy_minus_sign:                               | Current check date.                              |
| `OriginalDebitDate`                              | *string*                                         | :heavy_minus_sign:                               | Original debit date when fast ach applies.       |
| `CurrentDebitDate`                               | *string*                                         | :heavy_minus_sign:                               | Current debit date.                              |
| `Reason`                                         | *string*                                         | :heavy_minus_sign:                               | The reason why the payroll is moved to four day. |