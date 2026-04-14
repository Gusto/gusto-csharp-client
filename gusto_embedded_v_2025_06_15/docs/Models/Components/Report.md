# Report

Example response


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `RequestUuid`                                                                         | *string*                                                                              | :heavy_minus_sign:                                                                    | A unique identifier of the report request                                             |
| `Status`                                                                              | *string*                                                                              | :heavy_minus_sign:                                                                    | Current status of the report, possible values are 'succeeded', 'pending', or 'failed' |
| `ReportUrls`                                                                          | List<*string*>                                                                        | :heavy_minus_sign:                                                                    | The array of urls to access the report                                                |