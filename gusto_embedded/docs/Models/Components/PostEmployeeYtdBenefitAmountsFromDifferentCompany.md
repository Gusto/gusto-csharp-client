# PostEmployeeYtdBenefitAmountsFromDifferentCompany


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `BenefitType`                                                           | *double*                                                                | :heavy_minus_sign:                                                      | The benefit type supported by Gusto.                                    |
| `TaxYear`                                                               | *double*                                                                | :heavy_check_mark:                                                      | The tax year for which this amount applies.                             |
| `YtdEmployeeDeductionAmount`                                            | *string*                                                                | :heavy_minus_sign:                                                      | The year-to-date employee deduction made outside the current company.   |
| `YtdCompanyContributionAmount`                                          | *string*                                                                | :heavy_minus_sign:                                                      | The year-to-date company contribution made outside the current company. |