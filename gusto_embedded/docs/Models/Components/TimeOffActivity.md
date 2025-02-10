# TimeOffActivity

Representation of a Time Off Activity


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `PolicyUuid`                                                        | *string*                                                            | :heavy_minus_sign:                                                  | unique identifier of a time off policy                              |
| `TimeOffType`                                                       | [TimeOffType](../../Models/Components/TimeOffType.md)               | :heavy_minus_sign:                                                  | Type of the time off activity                                       |
| `PolicyName`                                                        | *string*                                                            | :heavy_minus_sign:                                                  | The name of the time off policy for this activity                   |
| `EventType`                                                         | *string*                                                            | :heavy_minus_sign:                                                  | The type of the time off event/activity                             |
| `EventDescription`                                                  | *string*                                                            | :heavy_minus_sign:                                                  | A description for the time off event/activity                       |
| `EffectiveTime`                                                     | *string*                                                            | :heavy_minus_sign:                                                  | The datetime of the time off activity                               |
| `Balance`                                                           | *string*                                                            | :heavy_minus_sign:                                                  | The time off balance at the time of the activity                    |
| `BalanceChange`                                                     | *string*                                                            | :heavy_minus_sign:                                                  | The amount the time off balance changed as a result of the activity |