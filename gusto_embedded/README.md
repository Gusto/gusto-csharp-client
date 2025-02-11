# GustoEmbedded

Developer-friendly & type-safe Csharp SDK specifically catered to leverage *GustoEmbedded* API.

<div align="left">
    <a href="https://www.speakeasy.com/?utm_source=gusto-embedded&utm_campaign=csharp"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://opensource.org/licenses/MIT">
        <img src="https://img.shields.io/badge/License-MIT-blue.svg" style="width: 100px; height: 28px;" />
    </a>
</div>


<!-- Start Summary [summary] -->
## Summary

Gusto API: Welcome to Gusto's Embedded Payroll API documentation!
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [GustoEmbedded](#gustoembedded)
  * [SDK Installation](#sdk-installation)
  * [SDK Example Usage](#sdk-example-usage)
  * [Authentication](#authentication)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Error Handling](#error-handling)
  * [Server Selection](#server-selection)
* [Development](#development)
  * [Maturity](#maturity)
  * [Contributions](#contributions)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### NuGet

To add the [NuGet](https://www.nuget.org/) package to a .NET project:
```bash
dotnet add package GustoEmbedded
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference src/GustoEmbedded/GustoEmbedded.csproj
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Introspection.GetV1TokenInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name                | Type | Scheme      |
| ------------------- | ---- | ----------- |
| `CompanyAccessAuth` | http | HTTP Bearer |

To authenticate with the API the `CompanyAccessAuth` parameter must be set when initializing the SDK client instance. For example:
```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Introspection.GetV1TokenInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

// handle response
```

### Per-Operation Security Schemes

Some operations in this SDK require the security scheme to be specified at the request level. For example:
```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto();

var res = await sdk.Companies.PostV1PartnerManagedCompaniesAsync(
    security: new PostV1PartnerManagedCompaniesSecurity() {
        SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    requestBody: new PostV1PartnerManagedCompaniesRequestBody() {
        User = new User() {
            FirstName = "Khalid",
            LastName = "Haley",
            Email = "Eliane.Watsica38@yahoo.com",
        },
        Company = new Models.Requests.Company() {
            Name = "<value>",
        },
    },
    xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [ACHTransactions](docs/sdks/achtransactions/README.md)

* [GetAll](docs/sdks/achtransactions/README.md#getall) - Get all ACH transactions for a company

### [BankAccounts](docs/sdks/bankaccounts/README.md)

* [PostV1CompaniesCompanyIdBankAccounts](docs/sdks/bankaccounts/README.md#postv1companiescompanyidbankaccounts) - Create a company bank account
* [GetV1CompaniesCompanyIdBankAccounts](docs/sdks/bankaccounts/README.md#getv1companiescompanyidbankaccounts) - Get all company bank accounts
* [PutV1CompaniesCompanyIdBankAccountsVerify](docs/sdks/bankaccounts/README.md#putv1companiescompanyidbankaccountsverify) - Verify a company bank account
* [PostV1PlaidProcessorToken](docs/sdks/bankaccounts/README.md#postv1plaidprocessortoken) - Create a bank account from a plaid processor token

### [Benefits](docs/sdks/benefits/README.md)

* [List](docs/sdks/benefits/README.md#list) - Get all benefits supported by Gusto

### [Companies](docs/sdks/companies/README.md)

* [PostV1PartnerManagedCompanies](docs/sdks/companies/README.md#postv1partnermanagedcompanies) - Create a partner managed company
* [GetV1Companies](docs/sdks/companies/README.md#getv1companies) - Get a company
* [PutV1Companies](docs/sdks/companies/README.md#putv1companies) - Update a company
* [PutV1PartnerManagedCompaniesCompanyUuidMigrate](docs/sdks/companies/README.md#putv1partnermanagedcompaniescompanyuuidmigrate) - Migrate company to embedded payroll
* [AcceptTerms](docs/sdks/companies/README.md#acceptterms) - Accept terms of service for a company user
* [PostPartnerManagedCompaniesCompanyUuidRetrieveTermsOfService](docs/sdks/companies/README.md#postpartnermanagedcompaniescompanyuuidretrievetermsofservice) - Retrieve terms of service status for a company user
* [PostV1CompaniesCompanyIdAdmins](docs/sdks/companies/README.md#postv1companiescompanyidadmins) - Create an admin for the company
* [GetV1CompaniesCompanyIdAdmins](docs/sdks/companies/README.md#getv1companiescompanyidadmins) - Get all the admins at a company
* [GetV1CompanyOnboardingStatus](docs/sdks/companies/README.md#getv1companyonboardingstatus) - Get the company's onboarding status
* [GetV1CompanyFinishOnboarding](docs/sdks/companies/README.md#getv1companyfinishonboarding) - Finish company onboarding
* [GetV1CompaniesCompanyIdCustomFields](docs/sdks/companies/README.md#getv1companiescompanyidcustomfields) - Get the custom fields of a company
* [UpdateIndustrySelection](docs/sdks/companies/README.md#updateindustryselection) - Update a company industry selection
* [GetSignatories](docs/sdks/companies/README.md#getsignatories) - Get all company signatories
* [CreateEarningType](docs/sdks/companies/README.md#createearningtype) - Create a custom earning type
* [ListEarningTypes](docs/sdks/companies/README.md#listearningtypes) - Get all earning types for a company
* [ListBenefits](docs/sdks/companies/README.md#listbenefits) - Get benefits for a company

### [CompanyAttachment](docs/sdks/companyattachment/README.md)

* [Get](docs/sdks/companyattachment/README.md#get) - Get Company Attachment Details
* [List](docs/sdks/companyattachment/README.md#list) - Get List of Company Attachments
* [PostV1CompaniesAttachment](docs/sdks/companyattachment/README.md#postv1companiesattachment) - Create Company Attachment and Upload File

### [CompanyAttachments](docs/sdks/companyattachments/README.md)

* [GetV1CompaniesAttachmentUrl](docs/sdks/companyattachments/README.md#getv1companiesattachmenturl) - Get a temporary url to download the Company Attachment file

### [CompanyBenefits](docs/sdks/companybenefits/README.md)

* [PostV1CompaniesCompanyIdCompanyBenefits](docs/sdks/companybenefits/README.md#postv1companiescompanyidcompanybenefits) - Create a company benefit
* [GetV1CompanyBenefitsCompanyBenefitId](docs/sdks/companybenefits/README.md#getv1companybenefitscompanybenefitid) - Get a company benefit
* [PutV1CompanyBenefitsCompanyBenefitId](docs/sdks/companybenefits/README.md#putv1companybenefitscompanybenefitid) - Update a company benefit
* [DeleteV1CompanyBenefitsCompanyBenefitId](docs/sdks/companybenefits/README.md#deletev1companybenefitscompanybenefitid) - Delete a company benefit
* [GetV1BenefitsBenefitId](docs/sdks/companybenefits/README.md#getv1benefitsbenefitid) - Get a supported benefit by ID
* [GetV1BenefitsCompanyBenefitIdSummary](docs/sdks/companybenefits/README.md#getv1benefitscompanybenefitidsummary) - Get company benefit summary by company benefit id.
* [GetV1CompanyBenefitsCompanyBenefitIdEmployeeBenefits](docs/sdks/companybenefits/README.md#getv1companybenefitscompanybenefitidemployeebenefits) - Get all employee benefits for a company benefit
* [UpdateEmployeeBenefits](docs/sdks/companybenefits/README.md#updateemployeebenefits) - Bulk update employee benefits for a company benefit
* [GetV1BenefitsBenefitsIdRequirements](docs/sdks/companybenefits/README.md#getv1benefitsbenefitsidrequirements) - Get benefit fields requirements by ID

### [CompanyForms](docs/sdks/companyforms/README.md)

* [GetV1CompanyForms](docs/sdks/companyforms/README.md#getv1companyforms) - Get all company forms
* [GetV1CompanyForm](docs/sdks/companyforms/README.md#getv1companyform) - Get a company form
* [GetV1CompanyFormPdf](docs/sdks/companyforms/README.md#getv1companyformpdf) - Get a company form pdf
* [PutV1CompanyFormSign](docs/sdks/companyforms/README.md#putv1companyformsign) - Sign a company form

### [Compensations](docs/sdks/compensations/README.md)

* [Delete](docs/sdks/compensations/README.md#delete) - Delete a compensation

### [ContractorBankAccounts](docs/sdks/contractorbankaccounts/README.md)

* [Create](docs/sdks/contractorbankaccounts/README.md#create) - Create a contractor bank account
* [List](docs/sdks/contractorbankaccounts/README.md#list) - Get all contractor bank accounts

### [ContractorDocuments](docs/sdks/contractordocuments/README.md)

* [GetV1ContractorDocuments](docs/sdks/contractordocuments/README.md#getv1contractordocuments) - Get all contractor documents
* [GetV1ContractorDocument](docs/sdks/contractordocuments/README.md#getv1contractordocument) - Get a contractor document
* [GetV1ContractorDocumentPdf](docs/sdks/contractordocuments/README.md#getv1contractordocumentpdf) - Get the contractor document pdf
* [PutV1ContractorDocumentSign](docs/sdks/contractordocuments/README.md#putv1contractordocumentsign) - Sign a contractor document

### [ContractorForms](docs/sdks/contractorforms/README.md)

* [List](docs/sdks/contractorforms/README.md#list) - Get all contractor forms
* [GetV1ContractorFormPdf](docs/sdks/contractorforms/README.md#getv1contractorformpdf) - Get the contractor form pdf
* [PostV1SandboxGenerate1099](docs/sdks/contractorforms/README.md#postv1sandboxgenerate1099) - Generate a 1099 form [DEMO]

### [ContractorPaymentGroups](docs/sdks/contractorpaymentgroups/README.md)

* [PostV1CompaniesCompanyIdContractorPaymentGroups](docs/sdks/contractorpaymentgroups/README.md#postv1companiescompanyidcontractorpaymentgroups) - Create a contractor payment group
* [GetV1CompaniesCompanyIdContractorPaymentGroups](docs/sdks/contractorpaymentgroups/README.md#getv1companiescompanyidcontractorpaymentgroups) - Get contractor payment groups for a company
* [PostV1CompaniesCompanyIdContractorPaymentGroupsPreview](docs/sdks/contractorpaymentgroups/README.md#postv1companiescompanyidcontractorpaymentgroupspreview) - Preview a contractor payment group
* [GetV1ContractorPaymentGroupsContractorPaymentGroupId](docs/sdks/contractorpaymentgroups/README.md#getv1contractorpaymentgroupscontractorpaymentgroupid) - Fetch a contractor payment group
* [DeleteV1ContractorPaymentGroupsContractorPaymentGroupId](docs/sdks/contractorpaymentgroups/README.md#deletev1contractorpaymentgroupscontractorpaymentgroupid) - Cancel a contractor payment group
* [PutV1ContractorPaymentGroupsContractorPaymentGroupIdFund](docs/sdks/contractorpaymentgroups/README.md#putv1contractorpaymentgroupscontractorpaymentgroupidfund) - Fund a contractor payment group [DEMO]

### [ContractorPaymentMethod](docs/sdks/contractorpaymentmethod/README.md)

* [Update](docs/sdks/contractorpaymentmethod/README.md#update) - Update a contractor's payment method

### [ContractorPayments](docs/sdks/contractorpayments/README.md)

* [GetV1ContractorPaymentsContractorPaymentUuidReceipt](docs/sdks/contractorpayments/README.md#getv1contractorpaymentscontractorpaymentuuidreceipt) - Get a single contractor payment receipt
* [GetV1ContractorPaymentsContractorPaymentUuidFund](docs/sdks/contractorpayments/README.md#getv1contractorpaymentscontractorpaymentuuidfund) - Fund a contractor payment [DEMO]
* [PostV1CompaniesCompanyIdContractorPayments](docs/sdks/contractorpayments/README.md#postv1companiescompanyidcontractorpayments) - Create a contractor payment
* [Get](docs/sdks/contractorpayments/README.md#get) - Get contractor payments for a company
* [GetById](docs/sdks/contractorpayments/README.md#getbyid) - Get a single contractor payment
* [Delete](docs/sdks/contractorpayments/README.md#delete) - Cancel a contractor payment
* [GetCompaniesCompanyUuidContractorPaymentsPreview](docs/sdks/contractorpayments/README.md#getcompaniescompanyuuidcontractorpaymentspreview) - Preview contractor payment debit date

### [Contractors](docs/sdks/contractors/README.md)

* [PostV1CompaniesCompanyUuidContractors](docs/sdks/contractors/README.md#postv1companiescompanyuuidcontractors) - Create a contractor
* [GetV1CompaniesCompanyUuidContractors](docs/sdks/contractors/README.md#getv1companiescompanyuuidcontractors) - Get contractors of a company
* [GetV1ContractorsContractorUuid](docs/sdks/contractors/README.md#getv1contractorscontractoruuid) - Get a contractor
* [PutV1ContractorsContractorUuid](docs/sdks/contractors/README.md#putv1contractorscontractoruuid) - Update a contractor
* [DeleteV1ContractorsContractorUuid](docs/sdks/contractors/README.md#deletev1contractorscontractoruuid) - Delete a contractor
* [GetV1ContractorsContractorUuidOnboardingStatus](docs/sdks/contractors/README.md#getv1contractorscontractoruuidonboardingstatus) - Get the contractor's onboarding status
* [PutV1ContractorsContractorUuidOnboardingStatus](docs/sdks/contractors/README.md#putv1contractorscontractoruuidonboardingstatus) - Change the contractor's onboarding status
* [GetV1ContractorsContractorUuidAddress](docs/sdks/contractors/README.md#getv1contractorscontractoruuidaddress) - Get a contractor address
* [PutV1ContractorsContractorUuidAddress](docs/sdks/contractors/README.md#putv1contractorscontractoruuidaddress) - Update a contractor's address
* [GetPaymentMethod](docs/sdks/contractors/README.md#getpaymentmethod) - Get a contractor's payment method

#### [Contractors.Forms](docs/sdks/forms/README.md)

* [GetV1ContractorForm](docs/sdks/forms/README.md#getv1contractorform) - Get a contractor form

### [Departments](docs/sdks/departments/README.md)

* [PostDepartments](docs/sdks/departments/README.md#postdepartments) - Create a department
* [GetCompaniesDepartments](docs/sdks/departments/README.md#getcompaniesdepartments) - Get all departments of a company
* [GetDepartment](docs/sdks/departments/README.md#getdepartment) - Get a department
* [PutDepartments](docs/sdks/departments/README.md#putdepartments) - Update a department
* [DeleteDepartment](docs/sdks/departments/README.md#deletedepartment) - Delete a department
* [PutAddPeopleToDepartment](docs/sdks/departments/README.md#putaddpeopletodepartment) - Add people to a department
* [PutRemovePeopleFromDepartment](docs/sdks/departments/README.md#putremovepeoplefromdepartment) - Remove people from a department

### [EarningTypes](docs/sdks/earningtypes/README.md)

* [PutV1CompaniesCompanyIdEarningTypesEarningTypeUuid](docs/sdks/earningtypes/README.md#putv1companiescompanyidearningtypesearningtypeuuid) - Update an earning type
* [DeleteV1CompaniesCompanyIdEarningTypesEarningTypeUuid](docs/sdks/earningtypes/README.md#deletev1companiescompanyidearningtypesearningtypeuuid) - Deactivate an earning type

### [EmployeeAddresses](docs/sdks/employeeaddresses/README.md)

* [Get](docs/sdks/employeeaddresses/README.md#get) - Get an employee's home addresses
* [PostV1EmployeesEmployeeIdHomeAddresses](docs/sdks/employeeaddresses/README.md#postv1employeesemployeeidhomeaddresses) - Create an employee's home address
* [GetHome](docs/sdks/employeeaddresses/README.md#gethome) - Get an employee's home address
* [Update](docs/sdks/employeeaddresses/README.md#update) - Update an employee's home address
* [RemoveHome](docs/sdks/employeeaddresses/README.md#removehome) - Delete an employee's home address
* [UpdateWork](docs/sdks/employeeaddresses/README.md#updatework) - Update an employee work address
* [DeleteV1WorkAddressesWorkAddressUuid](docs/sdks/employeeaddresses/README.md#deletev1workaddressesworkaddressuuid) - Delete an employee's work address

### [EmployeeBankAccounts](docs/sdks/employeebankaccounts/README.md)

* [Create](docs/sdks/employeebankaccounts/README.md#create) - Create an employee bank account
* [Update](docs/sdks/employeebankaccounts/README.md#update) - Update an employee bank account

### [EmployeeBenefits](docs/sdks/employeebenefits/README.md)

* [Create](docs/sdks/employeebenefits/README.md#create) - Create an employee benefit
* [List](docs/sdks/employeebenefits/README.md#list) - Get all benefits for an employee
* [GetV1EmployeeBenefitsEmployeeBenefitId](docs/sdks/employeebenefits/README.md#getv1employeebenefitsemployeebenefitid) - Get an employee benefit
* [PutV1EmployeeBenefitsEmployeeBenefitId](docs/sdks/employeebenefits/README.md#putv1employeebenefitsemployeebenefitid) - Update an employee benefit
* [DeleteV1EmployeeBenefitsEmployeeBenefitId](docs/sdks/employeebenefits/README.md#deletev1employeebenefitsemployeebenefitid) - Delete an employee benefit
* [CreateYtdAmounts](docs/sdks/employeebenefits/README.md#createytdamounts) - Create year-to-date benefit amounts from a different company
* [GetEmployeeYtdBenefitAmountsFromDifferentCompany](docs/sdks/employeebenefits/README.md#getemployeeytdbenefitamountsfromdifferentcompany) - Get year-to-date benefit amounts from a different company

### [EmployeeEmployments](docs/sdks/employeeemployments/README.md)

* [PostV1EmployeesEmployeeIdTerminations](docs/sdks/employeeemployments/README.md#postv1employeesemployeeidterminations) - Create an employee termination
* [DeleteV1EmployeesEmployeeIdTerminations](docs/sdks/employeeemployments/README.md#deletev1employeesemployeeidterminations) - Delete an employee termination
* [PutV1TerminationsEmployeeId](docs/sdks/employeeemployments/README.md#putv1terminationsemployeeid) - Update an employee termination
* [Rehire](docs/sdks/employeeemployments/README.md#rehire) - Create an employee rehire
* [GetV1EmployeesEmployeeIdRehire](docs/sdks/employeeemployments/README.md#getv1employeesemployeeidrehire) - Get an employee rehire
* [DeleteV1EmployeesEmployeeIdRehire](docs/sdks/employeeemployments/README.md#deletev1employeesemployeeidrehire) - Delete an employee rehire
* [GetV1EmployeesEmployeeIdEmploymentHistory](docs/sdks/employeeemployments/README.md#getv1employeesemployeeidemploymenthistory) - Get employment history for an employee

### [EmployeeFederalTaxes](docs/sdks/employeefederaltaxes/README.md)

* [Update](docs/sdks/employeefederaltaxes/README.md#update) - Update an employee's federal taxes

### [EmployeeForms](docs/sdks/employeeforms/README.md)

* [PostV1SandboxGenerateW2](docs/sdks/employeeforms/README.md#postv1sandboxgeneratew2) - Generate a W2 form [DEMO]
* [List](docs/sdks/employeeforms/README.md#list) - Get all employee forms
* [Get](docs/sdks/employeeforms/README.md#get) - Get an employee form
* [GetV1EmployeeFormPdf](docs/sdks/employeeforms/README.md#getv1employeeformpdf) - Get the employee form pdf
* [PutV1EmployeeFormSign](docs/sdks/employeeforms/README.md#putv1employeeformsign) - Sign an employee form

### [EmployeePaymentMethod](docs/sdks/employeepaymentmethod/README.md)

* [GetV1EmployeesEmployeeIdBankAccounts](docs/sdks/employeepaymentmethod/README.md#getv1employeesemployeeidbankaccounts) - Get all employee bank accounts
* [GetV1EmployeesEmployeeIdPaymentMethod](docs/sdks/employeepaymentmethod/README.md#getv1employeesemployeeidpaymentmethod) - Get an employee's payment method

### [EmployeePaymentMethods](docs/sdks/employeepaymentmethods/README.md)

* [UpdatePaymentMethod](docs/sdks/employeepaymentmethods/README.md#updatepaymentmethod) - Update an employee's payment method

### [EmployeeRehires](docs/sdks/employeerehires/README.md)

* [Update](docs/sdks/employeerehires/README.md#update) - Update an employee rehire

### [Employees](docs/sdks/employees/README.md)

* [PostV1Employees](docs/sdks/employees/README.md#postv1employees) - Create an employee
* [List](docs/sdks/employees/README.md#list) - Get employees of a company
* [PostV1HistoricalEmployees](docs/sdks/employees/README.md#postv1historicalemployees) - Create a historical employee
* [PutV1HistoricalEmployees](docs/sdks/employees/README.md#putv1historicalemployees) - Update a historical employee
* [Get](docs/sdks/employees/README.md#get) - Get an employee
* [PutV1Employees](docs/sdks/employees/README.md#putv1employees) - Update an employee
* [DeleteV1Employee](docs/sdks/employees/README.md#deletev1employee) - Delete an onboarding employee
* [GetV1EmployeesEmployeeIdCustomFields](docs/sdks/employees/README.md#getv1employeesemployeeidcustomfields) - Get an employee's custom fields
* [PutV1EmployeesEmployeeIdOnboardingDocumentsConfig](docs/sdks/employees/README.md#putv1employeesemployeeidonboardingdocumentsconfig) - Update an employee's onboarding documents config
* [GetV1EmployeesEmployeeIdOnboardingStatus](docs/sdks/employees/README.md#getv1employeesemployeeidonboardingstatus) - Get the employee's onboarding status
* [PutV1EmployeesEmployeeIdOnboardingStatus](docs/sdks/employees/README.md#putv1employeesemployeeidonboardingstatus) - Update the employee's onboarding status
* [GetVersionEmployeesTimeOffActivities](docs/sdks/employees/README.md#getversionemployeestimeoffactivities) - Get employee time off activities
* [GetTerminations](docs/sdks/employees/README.md#getterminations) - Get terminations for an employee
* [DeleteV1EmployeesEmployeeIdBankAccountsBankAccountId](docs/sdks/employees/README.md#deletev1employeesemployeeidbankaccountsbankaccountid) - Delete an employee bank account
* [PostV1JobsJobId](docs/sdks/employees/README.md#postv1jobsjobid) - Create a job
* [GetGarnishments](docs/sdks/employees/README.md#getgarnishments) - Get garnishments for an employee

### [EmployeeTaxes](docs/sdks/employeetaxes/README.md)

* [Update](docs/sdks/employeetaxes/README.md#update) - Update an employee's state taxes

### [EmployeeTaxSetup](docs/sdks/employeetaxsetup/README.md)

* [GetV1EmployeesEmployeeIdFederalTaxes](docs/sdks/employeetaxsetup/README.md#getv1employeesemployeeidfederaltaxes) - Get an employee's federal taxes
* [GetV1EmployeesEmployeeIdStateTaxes](docs/sdks/employeetaxsetup/README.md#getv1employeesemployeeidstatetaxes) - Get an employee's state taxes

### [EmployeeWorkAddresses](docs/sdks/employeeworkaddresses/README.md)

* [List](docs/sdks/employeeworkaddresses/README.md#list) - Get an employee's work addresses
* [PostV1EmployeesEmployeeIdWorkAddresses](docs/sdks/employeeworkaddresses/README.md#postv1employeesemployeeidworkaddresses) - Create an employee work address
* [Get](docs/sdks/employeeworkaddresses/README.md#get) - Get an employee work address

### [Events](docs/sdks/events/README.md)

* [GetEvents](docs/sdks/events/README.md#getevents) - Get all events

### [ExternalPayrolls](docs/sdks/externalpayrolls/README.md)

* [PostV1ExternalPayroll](docs/sdks/externalpayrolls/README.md#postv1externalpayroll) - Create a new external payroll for a company
* [GetV1CompanyExternalPayrolls](docs/sdks/externalpayrolls/README.md#getv1companyexternalpayrolls) - Get external payrolls for a company
* [GetV1ExternalPayroll](docs/sdks/externalpayrolls/README.md#getv1externalpayroll) - Get an external payroll
* [DeleteV1ExternalPayroll](docs/sdks/externalpayrolls/README.md#deletev1externalpayroll) - Delete an external payroll
* [PutV1ExternalPayroll](docs/sdks/externalpayrolls/README.md#putv1externalpayroll) - Update an external payroll
* [GetV1ExternalPayrollCalculateTaxes](docs/sdks/externalpayrolls/README.md#getv1externalpayrollcalculatetaxes) - Get tax suggestions for an external payroll
* [GetV1TaxLiabilities](docs/sdks/externalpayrolls/README.md#getv1taxliabilities) - Get tax liabilities
* [PutV1TaxLiabilities](docs/sdks/externalpayrolls/README.md#putv1taxliabilities) - Update tax liabilities
* [PutV1TaxLiabilitiesFinish](docs/sdks/externalpayrolls/README.md#putv1taxliabilitiesfinish) - Finalize tax liabilities options and convert into processed payrolls

### [FederalTaxDetails](docs/sdks/federaltaxdetails/README.md)

* [GetV1CompaniesCompanyIdFederalTaxDetails](docs/sdks/federaltaxdetails/README.md#getv1companiescompanyidfederaltaxdetails) - Get Federal Tax Details
* [PutV1CompaniesCompanyIdFederalTaxDetails](docs/sdks/federaltaxdetails/README.md#putv1companiescompanyidfederaltaxdetails) - Update Federal Tax Details

### [Flows](docs/sdks/flows/README.md)

* [PostV1CompanyFlows](docs/sdks/flows/README.md#postv1companyflows) - Create a flow

### [Garnishments](docs/sdks/garnishments/README.md)

* [PostV1EmployeesEmployeeIdGarnishments](docs/sdks/garnishments/README.md#postv1employeesemployeeidgarnishments) - Create a garnishment
* [Get](docs/sdks/garnishments/README.md#get) - Get a garnishment
* [PutV1GarnishmentsGarnishmentId](docs/sdks/garnishments/README.md#putv1garnishmentsgarnishmentid) - Update a garnishment
* [GetV1GarnishmentsChildSupport](docs/sdks/garnishments/README.md#getv1garnishmentschildsupport) - Get child support garnishment data

### [GeneratedDocuments](docs/sdks/generateddocuments/README.md)

* [GetV1GeneratedDocumentsDocumentTypeRequestUuid](docs/sdks/generateddocuments/README.md#getv1generateddocumentsdocumenttyperequestuuid) - Get a generated document


### [HolidayPayPolicies](docs/sdks/holidaypaypolicies/README.md)

* [GetCompaniesCompanyUuidHolidayPayPolicy](docs/sdks/holidaypaypolicies/README.md#getcompaniescompanyuuidholidaypaypolicy) - Get a company's holiday pay policy
* [PostCompaniesCompanyUuidHolidayPayPolicy](docs/sdks/holidaypaypolicies/README.md#postcompaniescompanyuuidholidaypaypolicy) - Create a holiday pay policy for a company
* [PutCompaniesCompanyUuidHolidayPayPolicy](docs/sdks/holidaypaypolicies/README.md#putcompaniescompanyuuidholidaypaypolicy) - Update a company's holiday pay policy
* [DeleteCompaniesCompanyUuidHolidayPayPolicy](docs/sdks/holidaypaypolicies/README.md#deletecompaniescompanyuuidholidaypaypolicy) - Delete a company's holiday pay policy
* [PutCompaniesCompanyUuidHolidayPayPolicyAdd](docs/sdks/holidaypaypolicies/README.md#putcompaniescompanyuuidholidaypaypolicyadd) - Add employees to a company's holiday pay policy
* [PutCompaniesCompanyUuidHolidayPayPolicyRemove](docs/sdks/holidaypaypolicies/README.md#putcompaniescompanyuuidholidaypaypolicyremove) - Remove employees from a company's holiday pay policy
* [Preview](docs/sdks/holidaypaypolicies/README.md#preview) - Preview a company's paid holidays

### [I9Verification](docs/sdks/i9verification/README.md)

* [GetV1EmployeesEmployeeIdI9AuthorizationDocumentOptions](docs/sdks/i9verification/README.md#getv1employeesemployeeidi9authorizationdocumentoptions) - Get an employee's I-9 verification document options
* [GetEmployeeDocuments](docs/sdks/i9verification/README.md#getemployeedocuments) - Get an employee's I-9 verification documents
* [PutV1EmployeesEmployeeIdI9AuthorizationDocuments](docs/sdks/i9verification/README.md#putv1employeesemployeeidi9authorizationdocuments) - Create an employee's I-9 authorization verification documents
* [DeleteV1EmployeesEmployeeIdI9AuthorizationDocumentsDocumentId](docs/sdks/i9verification/README.md#deletev1employeesemployeeidi9authorizationdocumentsdocumentid) - Delete an employee's I-9 verification document
* [PutV1EmployeesEmployeeIdI9AuthorizationEmployerSign](docs/sdks/i9verification/README.md#putv1employeesemployeeidi9authorizationemployersign) - Employer sign an employee's Form I-9

### [I9Verifications](docs/sdks/i9verifications/README.md)

* [Get](docs/sdks/i9verifications/README.md#get) - Get an employee's I-9 authorization
* [Upsert](docs/sdks/i9verifications/README.md#upsert) - Create or update an employee's I-9 authorization

### [IndustrySelection](docs/sdks/industryselection/README.md)

* [GetV1CompanyIndustry](docs/sdks/industryselection/README.md#getv1companyindustry) - Get a company industry selection

### [Introspection](docs/sdks/introspection/README.md)

* [GetV1TokenInfo](docs/sdks/introspection/README.md#getv1tokeninfo) - Get info about the current access token
* [RefreshAccessToken](docs/sdks/introspection/README.md#refreshaccesstoken) - Refresh access token

### [Invoices](docs/sdks/invoices/README.md)

* [GetInvoicesInvoicePeriod](docs/sdks/invoices/README.md#getinvoicesinvoiceperiod) - Retrieve invoicing data for companies

### [Jobs](docs/sdks/jobs/README.md)

* [List](docs/sdks/jobs/README.md#list) - Get jobs for an employee
* [Get](docs/sdks/jobs/README.md#get) - Get a job
* [Delete](docs/sdks/jobs/README.md#delete) - Delete an individual job
* [PostV1CompensationsCompensationId](docs/sdks/jobs/README.md#postv1compensationscompensationid) - Create a compensation
* [PutV1CompensationsCompensationId](docs/sdks/jobs/README.md#putv1compensationscompensationid) - Update a compensation

### [JobsAndCompensations](docs/sdks/jobsandcompensations/README.md)

* [PutV1JobsJobId](docs/sdks/jobsandcompensations/README.md#putv1jobsjobid) - Update a job
* [ListCompensations](docs/sdks/jobsandcompensations/README.md#listcompensations) - Get compensations for a job
* [GetV1CompensationsCompensationId](docs/sdks/jobsandcompensations/README.md#getv1compensationscompensationid) - Get a compensation

### [Locations](docs/sdks/locations/README.md)

* [PostV1CompaniesCompanyIdLocations](docs/sdks/locations/README.md#postv1companiescompanyidlocations) - Create a company location
* [GetAllCompanyLocations](docs/sdks/locations/README.md#getallcompanylocations) - Get company locations
* [GetV1LocationsLocationId](docs/sdks/locations/README.md#getv1locationslocationid) - Get a location
* [PutV1LocationsLocationId](docs/sdks/locations/README.md#putv1locationslocationid) - Update a location
* [GetV1LocationsLocationUuidMinimumWages](docs/sdks/locations/README.md#getv1locationslocationuuidminimumwages) - Get minimum wages for a location

### [Notifications](docs/sdks/notifications/README.md)

* [GetNotificationsNotificationUuid](docs/sdks/notifications/README.md#getnotificationsnotificationuuid) - Get a notification's details

### [PaymentConfigs](docs/sdks/paymentconfigs/README.md)

* [GetV1CompanyPaymentConfigs](docs/sdks/paymentconfigs/README.md#getv1companypaymentconfigs) - Get a company's payment configs
* [PutV1CompanyPaymentConfigs](docs/sdks/paymentconfigs/README.md#putv1companypaymentconfigs) - Update a company's payment configs

### [Payrolls](docs/sdks/payrolls/README.md)

* [PostV1CompaniesCompanyIdPayrolls](docs/sdks/payrolls/README.md#postv1companiescompanyidpayrolls) - Create an off-cycle payroll
* [List](docs/sdks/payrolls/README.md#list) - Get all payrolls for a company
* [GetV1CompaniesCompanyIdPayrollReversals](docs/sdks/payrolls/README.md#getv1companiescompanyidpayrollreversals) - Get approved payroll reversals
* [GetV1CompaniesCompanyIdPayrollsPayrollId](docs/sdks/payrolls/README.md#getv1companiescompanyidpayrollspayrollid) - Get a single payroll
* [PutV1CompaniesCompanyIdPayrolls](docs/sdks/payrolls/README.md#putv1companiescompanyidpayrolls) - Update a payroll by ID
* [DeleteV1CompaniesCompanyIdPayrolls](docs/sdks/payrolls/README.md#deletev1companiescompanyidpayrolls) - Delete a payroll
* [PutV1CompaniesCompanyIdPayrollsPayrollIdPrepare](docs/sdks/payrolls/README.md#putv1companiescompanyidpayrollspayrollidprepare) - Prepare a payroll for update
* [GetV1PaymentReceiptsPayrollsPayrollUuid](docs/sdks/payrolls/README.md#getv1paymentreceiptspayrollspayrolluuid) - Get a single payroll receipt
* [GetV1CompaniesPayrollBlockersCompanyUuid](docs/sdks/payrolls/README.md#getv1companiespayrollblockerscompanyuuid) - Get all payroll blockers for a company
* [PostCompaniesPayrollSkipCompanyUuid](docs/sdks/payrolls/README.md#postcompaniespayrollskipcompanyuuid) - Skip a payroll
* [PostPayrollsGrossUpPayrollUuid](docs/sdks/payrolls/README.md#postpayrollsgrossuppayrolluuid) - Calculate gross up
* [PutV1CompaniesCompanyIdPayrollsPayrollIdCalculate](docs/sdks/payrolls/README.md#putv1companiescompanyidpayrollspayrollidcalculate) - Calculate a payroll
* [PutV1CompaniesCompanyIdPayrollsPayrollIdSubmit](docs/sdks/payrolls/README.md#putv1companiescompanyidpayrollspayrollidsubmit) - Submit payroll
* [PutApiV1CompaniesCompanyIdPayrollsPayrollIdCancel](docs/sdks/payrolls/README.md#putapiv1companiescompanyidpayrollspayrollidcancel) - Cancel a payroll
* [GetEmployeePayStubPdf](docs/sdks/payrolls/README.md#getemployeepaystubpdf) - Get an employee pay stub (pdf)
* [GetEmployeePayStubs](docs/sdks/payrolls/README.md#getemployeepaystubs) - Get an employee's pay stubs
* [PostV1PayrollsPayrollUuidGeneratedDocumentsPrintablePayrollChecks](docs/sdks/payrolls/README.md#postv1payrollspayrolluuidgenerateddocumentsprintablepayrollchecks) - Generate printable payroll checks (pdf)

### [PayScheduleAssignments](docs/sdks/payscheduleassignments/README.md)

* [Get](docs/sdks/payscheduleassignments/README.md#get) - Get pay schedule assignments for a company

### [PaySchedules](docs/sdks/payschedules/README.md)

* [PostV1CompaniesCompanyIdPaySchedules](docs/sdks/payschedules/README.md#postv1companiescompanyidpayschedules) - Create a new pay schedule
* [Get](docs/sdks/payschedules/README.md#get) - Get the pay schedules for a company
* [GetV1CompaniesCompanyIdPaySchedulesPreview](docs/sdks/payschedules/README.md#getv1companiescompanyidpayschedulespreview) - Preview pay schedule dates
* [GetById](docs/sdks/payschedules/README.md#getbyid) - Get a pay schedule
* [PutV1CompaniesCompanyIdPaySchedulesPayScheduleId](docs/sdks/payschedules/README.md#putv1companiescompanyidpayschedulespayscheduleid) - Update a pay schedule
* [ListPayPeriods](docs/sdks/payschedules/README.md#listpayperiods) - Get pay periods for a company
* [GetV1CompaniesCompanyIdUnprocessedTerminationPayPeriods](docs/sdks/payschedules/README.md#getv1companiescompanyidunprocessedterminationpayperiods) - Get termination pay periods for a company
* [PostV1CompaniesCompanyIdPaySchedulesAssignmentPreview](docs/sdks/payschedules/README.md#postv1companiescompanyidpayschedulesassignmentpreview) - Preview pay schedule assignments for a company
* [PostV1CompaniesCompanyIdPaySchedulesAssign](docs/sdks/payschedules/README.md#postv1companiescompanyidpayschedulesassign) - Assign pay schedules for a company

### [RecoveryCases](docs/sdks/recoverycases/README.md)

* [List](docs/sdks/recoverycases/README.md#list) - Get all recovery cases for a company
* [RedebitRecoveryCase](docs/sdks/recoverycases/README.md#redebitrecoverycase) - Initiate a redebit for a recovery case

### [Reports](docs/sdks/reports/README.md)

* [PostCompaniesCompanyUuidReports](docs/sdks/reports/README.md#postcompaniescompanyuuidreports) - Create a custom report
* [GetReportsReportUuid](docs/sdks/reports/README.md#getreportsreportuuid) - Get a report
* [GetCompaniesCompanyUuidReportTemplatesReportType](docs/sdks/reports/README.md#getcompaniescompanyuuidreporttemplatesreporttype) - Get a report template

### [Signatories](docs/sdks/signatories/README.md)

* [PostV1CompanySignatories](docs/sdks/signatories/README.md#postv1companysignatories) - Create a signatory
* [PostV1CompaniesCompanyUuidSignatoriesInvite](docs/sdks/signatories/README.md#postv1companiescompanyuuidsignatoriesinvite) - Invite a signatory
* [PutV1CompaniesCompanyUuidSignatoriesSignatoryUuid](docs/sdks/signatories/README.md#putv1companiescompanyuuidsignatoriessignatoryuuid) - Update a signatory
* [DeleteV1CompaniesCompanyUuidSignatoriesSignatoryUuid](docs/sdks/signatories/README.md#deletev1companiescompanyuuidsignatoriessignatoryuuid) - Delete a signatory

### [TaxRequirements](docs/sdks/taxrequirements/README.md)

* [GetForState](docs/sdks/taxrequirements/README.md#getforstate) - Get State Tax Requirements
* [UpdateState](docs/sdks/taxrequirements/README.md#updatestate) - Update State Tax Requirements
* [List](docs/sdks/taxrequirements/README.md#list) - Get All Tax Requirement States

### [TimeOffPolicies](docs/sdks/timeoffpolicies/README.md)

* [PostV1PayrollsPayrollIdCalculateAccruingTimeOffHours](docs/sdks/timeoffpolicies/README.md#postv1payrollspayrollidcalculateaccruingtimeoffhours) - Calculate accruing time off hours
* [Get](docs/sdks/timeoffpolicies/README.md#get) - Get a time off policy
* [PutTimeOffPoliciesTimeOffPolicyUuid](docs/sdks/timeoffpolicies/README.md#puttimeoffpoliciestimeoffpolicyuuid) - Update a time off policy
* [List](docs/sdks/timeoffpolicies/README.md#list) - Get all time off policies
* [PostCompaniesCompanyUuidTimeOffPolicies](docs/sdks/timeoffpolicies/README.md#postcompaniescompanyuuidtimeoffpolicies) - Create a time off policy
* [PutVersionTimeOffPoliciesTimeOffPolicyUuidAddEmployees](docs/sdks/timeoffpolicies/README.md#putversiontimeoffpoliciestimeoffpolicyuuidaddemployees) - Add employees to a time off policy
* [PutV1TimeOffPoliciesTimeOffPolicyUuidRemoveEmployees](docs/sdks/timeoffpolicies/README.md#putv1timeoffpoliciestimeoffpolicyuuidremoveemployees) - Remove employees from a time off policy
* [PutVersionTimeOffPoliciesTimeOffPolicyUuidBalance](docs/sdks/timeoffpolicies/README.md#putversiontimeoffpoliciestimeoffpolicyuuidbalance) - Update employee time off hour balances
* [PutV1TimeOffPoliciesTimeOffPolicyUuidDeactivate](docs/sdks/timeoffpolicies/README.md#putv1timeoffpoliciestimeoffpolicyuuiddeactivate) - Deactivate a time off policy

### [Webhooks](docs/sdks/webhooks/README.md)

* [GetV1WebhookSubscriptions](docs/sdks/webhooks/README.md#getv1webhooksubscriptions) - List webhook subscriptions
* [Update](docs/sdks/webhooks/README.md#update) - Update a webhook subscription
* [GetV1WebhookSubscriptionUuid](docs/sdks/webhooks/README.md#getv1webhooksubscriptionuuid) - Get a webhook subscription
* [DeleteV1WebhookSubscriptionUuid](docs/sdks/webhooks/README.md#deletev1webhooksubscriptionuuid) - Delete a webhook subscription
* [Verify](docs/sdks/webhooks/README.md#verify) - Verify the webhook subscription

### [WebhookSubscriptions](docs/sdks/webhooksubscriptions/README.md)

* [Create](docs/sdks/webhooksubscriptions/README.md#create) - Create a webhook subscription
* [GetV1WebhookSubscriptionVerificationTokenUuid](docs/sdks/webhooksubscriptions/README.md#getv1webhooksubscriptionverificationtokenuuid) - Request the webhook subscription verification_token

### [WireInRequests](docs/sdks/wireinrequests/README.md)

* [GetWireInRequestsWireInRequestUuid](docs/sdks/wireinrequests/README.md#getwireinrequestswireinrequestuuid) - Get a single Wire In Request
* [PutWireInRequestsWireInRequestUuid](docs/sdks/wireinrequests/README.md#putwireinrequestswireinrequestuuid) - Submit a wire in request
* [List](docs/sdks/wireinrequests/README.md#list) - Get all Wire In Requests for a company

</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `GustoEmbedded.Models.Errors.APIException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `Request`     | *HttpRequestMessage*  | The HTTP request      |
| `Response`    | *HttpResponseMessage* | The HTTP response     |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `PostV1PartnerManagedCompaniesAsync` method throws the following exceptions:

| Error Type                                                 | Status Code | Content Type     |
| ---------------------------------------------------------- | ----------- | ---------------- |
| GustoEmbedded.Models.Errors.UnprocessableEntityErrorObject | 422         | application/json |
| GustoEmbedded.Models.Errors.APIException                   | 4XX, 5XX    | \*/\*            |

### Example

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Errors;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto();

try
{
    var res = await sdk.Companies.PostV1PartnerManagedCompaniesAsync(
        security: new PostV1PartnerManagedCompaniesSecurity() {
            SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
        },
        requestBody: new PostV1PartnerManagedCompaniesRequestBody() {
            User = new User() {
                FirstName = "Khalid",
                LastName = "Haley",
                Email = "Eliane.Watsica38@yahoo.com",
            },
            Company = new Models.Requests.Company() {
                Name = "<value>",
            },
        },
        xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401
    );

    // handle response
}
catch (Exception ex)
{
    if (ex is UnprocessableEntityErrorObject)
    {
        // Handle exception data
        throw;
    }
    else if (ex is GustoEmbedded.Models.Errors.APIException)
    {
        // Handle default exception
        throw;
    }
}
```
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Name

You can override the default server globally by passing a server name to the `server: string` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the names associated with the available servers:

| Name   | Server                       |
| ------ | ---------------------------- |
| `demo` | `https://api.gusto-demo.com` |
| `prod` | `https://api.gusto.com`      |

#### Example

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(
    server: "prod",
    companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Introspection.GetV1TokenInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

// handle response
```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(
    serverUrl: "https://api.gusto-demo.com",
    companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Introspection.GetV1TokenInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

// handle response
```
<!-- End Server Selection [server] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically. Any manual changes added to internal files will be overwritten on the next generation.
We look forward to hearing your feedback. Feel free to open a PR or an issue with a proof of concept and we'll do our best to include it in a future release.

### SDK Created by [Speakeasy](https://www.speakeasy.com/?utm_source=gusto-embedded&utm_campaign=csharp)
