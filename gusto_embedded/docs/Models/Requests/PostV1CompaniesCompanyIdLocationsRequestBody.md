# PostV1CompaniesCompanyIdLocationsRequestBody

Create a company location.


## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `PhoneNumber`                                              | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Street1`                                                  | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Street2`                                                  | *string*                                                   | :heavy_minus_sign:                                         | N/A                                                        |
| `City`                                                     | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `State`                                                    | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `Zip`                                                      | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `MailingAddress`                                           | *bool*                                                     | :heavy_minus_sign:                                         | Specify if this location is the company's mailing address. |
| `FilingAddress`                                            | *bool*                                                     | :heavy_minus_sign:                                         | Specify if this location is the company's filing address.  |