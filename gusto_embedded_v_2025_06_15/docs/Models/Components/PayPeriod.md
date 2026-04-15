# PayPeriod

The representation of a pay period.


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `StartDate`                                                              | *string*                                                                 | :heavy_minus_sign:                                                       | The start date, inclusive, of the pay period.                            |
| `EndDate`                                                                | *string*                                                                 | :heavy_minus_sign:                                                       | The end date, inclusive, of the pay period.                              |
| `PayScheduleUuid`                                                        | *string*                                                                 | :heavy_minus_sign:                                                       | A unique identifier of the pay schedule to which the pay period belongs. |
| `Payroll`                                                                | [PayPeriodPayroll](../../Models/Components/PayPeriodPayroll.md)          | :heavy_minus_sign:                                                       | Information about the payroll for the pay period.                        |