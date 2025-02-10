# EmployeePayStub

The representation of an employee pay stub information.


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Uuid`                                                            | *string*                                                          | :heavy_check_mark:                                                | The UUID of the employee pay stub.                                |
| `CheckDate`                                                       | *string*                                                          | :heavy_minus_sign:                                                | The check date of the pay stub.                                   |
| `GrossPay`                                                        | *string*                                                          | :heavy_minus_sign:                                                | The gross pay amount for the pay stub.                            |
| `NetPay`                                                          | *string*                                                          | :heavy_minus_sign:                                                | The net pay amount for the pay stub.                              |
| `PayrollUuid`                                                     | *string*                                                          | :heavy_minus_sign:                                                | A unique identifier of the payroll to which the pay stub belongs. |
| `CheckAmount`                                                     | *string*                                                          | :heavy_minus_sign:                                                | The check amount for the pay stub.                                |