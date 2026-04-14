# RefreshAccessTokenRequestBody


## Fields

| Field                                                        | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `ClientId`                                                   | *string*                                                     | :heavy_check_mark:                                           | Your client id                                               |
| `ClientSecret`                                               | *string*                                                     | :heavy_check_mark:                                           | Your client secret                                           |
| `RedirectUri`                                                | *string*                                                     | :heavy_minus_sign:                                           | The redirect URI you set up via the Developer Portal         |
| `RefreshToken`                                               | *string*                                                     | :heavy_check_mark:                                           | The `refresh_token` being exchanged for an access token code |
| `GrantType`                                                  | *string*                                                     | :heavy_check_mark:                                           | this should be the literal string 'refresh_token'            |