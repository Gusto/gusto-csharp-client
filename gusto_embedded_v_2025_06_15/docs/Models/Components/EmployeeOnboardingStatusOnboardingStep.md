# EmployeeOnboardingStatusOnboardingStep


## Fields

| Field                                                   | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `Title`                                                 | *string*                                                | :heavy_minus_sign:                                      | User-friendly description of the onboarding step.       |
| `Id`                                                    | *string*                                                | :heavy_minus_sign:                                      | String identifier for the onboarding step.              |
| `Required`                                              | *bool*                                                  | :heavy_minus_sign:                                      | When true, this step is required.                       |
| `Completed`                                             | *bool*                                                  | :heavy_minus_sign:                                      | When true, this step has been completed.                |
| `Requirements`                                          | List<*string*>                                          | :heavy_minus_sign:                                      | A list of onboarding steps required to begin this step. |