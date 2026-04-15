# CompanyOnboardingStatus

The representation of a company's onboarding status


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Uuid`                                                            | *string*                                                          | :heavy_check_mark:                                                | the UUID of the company                                           |
| `OnboardingCompleted`                                             | *bool*                                                            | :heavy_minus_sign:                                                | a boolean flag for the company's onboarding status                |
| `OnboardingSteps`                                                 | List<[OnboardingStep](../../Models/Components/OnboardingStep.md)> | :heavy_minus_sign:                                                | a list of company onboarding steps                                |