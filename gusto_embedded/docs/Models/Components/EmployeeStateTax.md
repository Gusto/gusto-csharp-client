# EmployeeStateTax

Example response


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `EmployeeUuid`                                                                        | *string*                                                                              | :heavy_check_mark:                                                                    | The employee's uuid                                                                   |
| `State`                                                                               | *string*                                                                              | :heavy_check_mark:                                                                    | Two letter US state abbreviation                                                      |
| `FileNewHireReport`                                                                   | *bool*                                                                                | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `IsWorkState`                                                                         | *bool*                                                                                | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `Questions`                                                                           | List<[EmployeeStateTaxQuestion](../../Models/Components/EmployeeStateTaxQuestion.md)> | :heavy_check_mark:                                                                    | N/A                                                                                   |