# Event

Representation of an Event


## Fields

| Field                                                                           | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `Uuid`                                                                          | *string*                                                                        | :heavy_check_mark:                                                              | Unique identifier for the event.                                                |
| `EventType`                                                                     | *string*                                                                        | :heavy_minus_sign:                                                              | Description of the event (e.g., payroll.submitted, or company.form.signed).     |
| `ResourceType`                                                                  | [ResourceType](../../Models/Components/ResourceType.md)                         | :heavy_minus_sign:                                                              | Name of the parent resource of the described entity.                            |
| `ResourceUuid`                                                                  | *string*                                                                        | :heavy_minus_sign:                                                              | Unique identifier for the parent resource.                                      |
| `EntityType`                                                                    | *string*                                                                        | :heavy_minus_sign:                                                              | Name of the entity that the event corresponds to.                               |
| `EntityUuid`                                                                    | *string*                                                                        | :heavy_minus_sign:                                                              | Unique identifier for the entity.                                               |
| `Timestamp`                                                                     | *long*                                                                          | :heavy_minus_sign:                                                              | Time at which this event was created. Measured in seconds since the Unix epoch. |