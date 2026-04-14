# EmployeeStateTaxInputQuestionFormat


## Fields

| Field                                                                 | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `Type`                                                                | *string*                                                              | :heavy_check_mark:                                                    | Describes the type of question - Text, Number, Select, Currency, Date |
| `Options`                                                             | List<[Options](../../Models/Components/Options.md)>                   | :heavy_minus_sign:                                                    | For "Select" type questions, the allowed values and display labels.   |