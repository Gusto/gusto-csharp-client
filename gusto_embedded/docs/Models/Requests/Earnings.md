# Earnings

An array of earnings for the employee. Depends on your company selections, earnings includes wages, hours, bonuses, tips, commission and more.


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Hours`                                                             | *string*                                                            | :heavy_minus_sign:                                                  | The hour of the compensation for the pay period.                    |
| `Amount`                                                            | *string*                                                            | :heavy_minus_sign:                                                  | The amount of the earning.                                          |
| `EarningId`                                                         | *long*                                                              | :heavy_minus_sign:                                                  | The ID of the earning.                                              |
| `EarningType`                                                       | [Models.Requests.EarningType](../../Models/Requests/EarningType.md) | :heavy_minus_sign:                                                  | The earning type for the compensation.                              |