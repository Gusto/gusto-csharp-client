# DocumentType

The type of document an employee holds, based on their authorization status.

  * This is unused for authorization status `citizen` or `noncitizen`.
  * If the authorization status is `permanent_resident`, this must be `uscis_alien_registration_number`.
  * If the authorization status is `alien`, this is required and may be any of the valid values.



## Values

| Name                            | Value                           |
| ------------------------------- | ------------------------------- |
| `UscisAlienRegistrationNumber`  | uscis_alien_registration_number |
| `FormI94`                       | form_i94                        |
| `ForeignPassport`               | foreign_passport                |