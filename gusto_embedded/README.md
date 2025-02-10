# GustoEmbedded

Developer-friendly & type-safe Csharp SDK specifically catered to leverage *GustoEmbedded* API.

<div align="left">
    <a href="https://www.speakeasy.com/?utm_source=gusto-embedded&utm_campaign=csharp"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://opensource.org/licenses/MIT">
        <img src="https://img.shields.io/badge/License-MIT-blue.svg" style="width: 100px; height: 28px;" />
    </a>
</div>


<br /><br />
> [!IMPORTANT]
> This SDK is not yet ready for production use. To complete setup please follow the steps outlined in your [workspace](https://app.speakeasy.com/org/gusto/ruby-sdk). Delete this section before > publishing to a package manager.

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

var res = await sdk.Introspection.GetTokenInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

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

var res = await sdk.Introspection.GetTokenInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

// handle response
```

### Per-Operation Security Schemes

Some operations in this SDK require the security scheme to be specified at the request level. For example:
```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;
using GustoEmbedded.Models.Requests;

var sdk = new Gusto();

var res = await sdk.Companies.CreatePartnerManagedAsync(
    security: new PostV1PartnerManagedCompaniesSecurity() {
        SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
    },
    requestBody: new PostV1PartnerManagedCompaniesRequestBody() {
        User = new User() {
            FirstName = "Gail",
            LastName = "Stracke",
            Email = "Emanuel.McClure@gmail.com",
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

### [AchTransactions](docs/sdks/achtransactions/README.md)

* [GetAll](docs/sdks/achtransactions/README.md#getall) - Get all ACH transactions for a company

### [BankAccounts](docs/sdks/bankaccounts/README.md)

* [Create](docs/sdks/bankaccounts/README.md#create) - Create a company bank account
* [List](docs/sdks/bankaccounts/README.md#list) - Get all company bank accounts
* [Verify](docs/sdks/bankaccounts/README.md#verify) - Verify a company bank account
* [CreateFromProcessorToken](docs/sdks/bankaccounts/README.md#createfromprocessortoken) - Create a bank account from a plaid processor token

### [Benefits](docs/sdks/benefits/README.md)

* [List](docs/sdks/benefits/README.md#list) - Get all benefits supported by Gusto

### [Companies](docs/sdks/companies/README.md)

* [CreatePartnerManaged](docs/sdks/companies/README.md#createpartnermanaged) - Create a partner managed company
* [Get](docs/sdks/companies/README.md#get) - Get a company
* [Update](docs/sdks/companies/README.md#update) - Update a company
* [Migrate](docs/sdks/companies/README.md#migrate) - Migrate company to embedded payroll
* [AcceptTerms](docs/sdks/companies/README.md#acceptterms) - Accept terms of service for a company user
* [RetrieveTermsOfService](docs/sdks/companies/README.md#retrievetermsofservice) - Retrieve terms of service status for a company user
* [CreateAdmin](docs/sdks/companies/README.md#createadmin) - Create an admin for the company
* [GetAdmins](docs/sdks/companies/README.md#getadmins) - Get all the admins at a company
* [GetOnboardingStatus](docs/sdks/companies/README.md#getonboardingstatus) - Get the company's onboarding status
* [FinishOnboarding](docs/sdks/companies/README.md#finishonboarding) - Finish company onboarding
* [GetCustomFields](docs/sdks/companies/README.md#getcustomfields) - Get the custom fields of a company
* [UpdateIndustrySelection](docs/sdks/companies/README.md#updateindustryselection) - Update a company industry selection
* [GetSignatories](docs/sdks/companies/README.md#getsignatories) - Get all company signatories
* [CreateEarningType](docs/sdks/companies/README.md#createearningtype) - Create a custom earning type
* [ListEarningTypes](docs/sdks/companies/README.md#listearningtypes) - Get all earning types for a company
* [ListBenefits](docs/sdks/companies/README.md#listbenefits) - Get benefits for a company

### [CompanyAttachments](docs/sdks/companyattachments/README.md)

* [Get](docs/sdks/companyattachments/README.md#get) - Get Company Attachment Details
* [GetDownloadUrl](docs/sdks/companyattachments/README.md#getdownloadurl) - Get a temporary url to download the Company Attachment file
* [List](docs/sdks/companyattachments/README.md#list) - Get List of Company Attachments
* [Create](docs/sdks/companyattachments/README.md#create) - Create Company Attachment and Upload File

### [CompanyBenefits](docs/sdks/companybenefits/README.md)

* [Create](docs/sdks/companybenefits/README.md#create) - Create a company benefit
* [Get](docs/sdks/companybenefits/README.md#get) - Get a company benefit
* [Update](docs/sdks/companybenefits/README.md#update) - Update a company benefit
* [Delete](docs/sdks/companybenefits/README.md#delete) - Delete a company benefit
* [GetSupportedBenefit](docs/sdks/companybenefits/README.md#getsupportedbenefit) - Get a supported benefit by ID
* [GetSummary](docs/sdks/companybenefits/README.md#getsummary) - Get company benefit summary by company benefit id.
* [GetEmployeeBenefits](docs/sdks/companybenefits/README.md#getemployeebenefits) - Get all employee benefits for a company benefit
* [UpdateEmployeeBenefits](docs/sdks/companybenefits/README.md#updateemployeebenefits) - Bulk update employee benefits for a company benefit
* [GetRequirements](docs/sdks/companybenefits/README.md#getrequirements) - Get benefit fields requirements by ID

### [CompanyForms](docs/sdks/companyforms/README.md)

* [List](docs/sdks/companyforms/README.md#list) - Get all company forms
* [Get](docs/sdks/companyforms/README.md#get) - Get a company form
* [GetPdf](docs/sdks/companyforms/README.md#getpdf) - Get a company form pdf
* [Sign](docs/sdks/companyforms/README.md#sign) - Sign a company form

### [Compensations](docs/sdks/compensations/README.md)

* [Delete](docs/sdks/compensations/README.md#delete) - Delete a compensation

### [ContractorBankAccounts](docs/sdks/contractorbankaccounts/README.md)

* [Create](docs/sdks/contractorbankaccounts/README.md#create) - Create a contractor bank account
* [List](docs/sdks/contractorbankaccounts/README.md#list) - Get all contractor bank accounts

### [ContractorDocuments](docs/sdks/contractordocuments/README.md)

* [List](docs/sdks/contractordocuments/README.md#list) - Get all contractor documents
* [Get](docs/sdks/contractordocuments/README.md#get) - Get a contractor document
* [GetPdf](docs/sdks/contractordocuments/README.md#getpdf) - Get the contractor document pdf
* [Sign](docs/sdks/contractordocuments/README.md#sign) - Sign a contractor document

### [ContractorForms](docs/sdks/contractorforms/README.md)

* [List](docs/sdks/contractorforms/README.md#list) - Get all contractor forms
* [GetPdf](docs/sdks/contractorforms/README.md#getpdf) - Get the contractor form pdf
* [Generate1099](docs/sdks/contractorforms/README.md#generate1099) - Generate a 1099 form [DEMO]

### [ContractorPaymentGroups](docs/sdks/contractorpaymentgroups/README.md)

* [Create](docs/sdks/contractorpaymentgroups/README.md#create) - Create a contractor payment group
* [List](docs/sdks/contractorpaymentgroups/README.md#list) - Get contractor payment groups for a company
* [Preview](docs/sdks/contractorpaymentgroups/README.md#preview) - Preview a contractor payment group
* [Get](docs/sdks/contractorpaymentgroups/README.md#get) - Fetch a contractor payment group
* [Delete](docs/sdks/contractorpaymentgroups/README.md#delete) - Cancel a contractor payment group
* [Fund](docs/sdks/contractorpaymentgroups/README.md#fund) - Fund a contractor payment group [DEMO]

### [ContractorPaymentMethod](docs/sdks/contractorpaymentmethod/README.md)

* [Update](docs/sdks/contractorpaymentmethod/README.md#update) - Update a contractor's payment method

### [ContractorPayments](docs/sdks/contractorpayments/README.md)

* [GetReceipt](docs/sdks/contractorpayments/README.md#getreceipt) - Get a single contractor payment receipt
* [Fund](docs/sdks/contractorpayments/README.md#fund) - Fund a contractor payment [DEMO]
* [Create](docs/sdks/contractorpayments/README.md#create) - Create a contractor payment
* [Get](docs/sdks/contractorpayments/README.md#get) - Get contractor payments for a company
* [GetById](docs/sdks/contractorpayments/README.md#getbyid) - Get a single contractor payment
* [Delete](docs/sdks/contractorpayments/README.md#delete) - Cancel a contractor payment
* [Preview](docs/sdks/contractorpayments/README.md#preview) - Preview contractor payment debit date

### [Contractors](docs/sdks/contractors/README.md)

* [Create](docs/sdks/contractors/README.md#create) - Create a contractor
* [List](docs/sdks/contractors/README.md#list) - Get contractors of a company
* [Get](docs/sdks/contractors/README.md#get) - Get a contractor
* [Update](docs/sdks/contractors/README.md#update) - Update a contractor
* [Delete](docs/sdks/contractors/README.md#delete) - Delete a contractor
* [GetOnboardingStatus](docs/sdks/contractors/README.md#getonboardingstatus) - Get the contractor's onboarding status
* [UpdateOnboardingStatus](docs/sdks/contractors/README.md#updateonboardingstatus) - Change the contractor's onboarding status
* [GetAddress](docs/sdks/contractors/README.md#getaddress) - Get a contractor address
* [UpdateAddress](docs/sdks/contractors/README.md#updateaddress) - Update a contractor's address
* [GetPaymentMethod](docs/sdks/contractors/README.md#getpaymentmethod) - Get a contractor's payment method

#### [Contractors.Forms](docs/sdks/forms/README.md)

* [Get](docs/sdks/forms/README.md#get) - Get a contractor form

### [Departments](docs/sdks/departments/README.md)

* [Create](docs/sdks/departments/README.md#create) - Create a department
* [List](docs/sdks/departments/README.md#list) - Get all departments of a company
* [Get](docs/sdks/departments/README.md#get) - Get a department
* [Update](docs/sdks/departments/README.md#update) - Update a department
* [Delete](docs/sdks/departments/README.md#delete) - Delete a department
* [AddPeople](docs/sdks/departments/README.md#addpeople) - Add people to a department
* [RemovePeople](docs/sdks/departments/README.md#removepeople) - Remove people from a department

### [EarningTypes](docs/sdks/earningtypes/README.md)

* [Update](docs/sdks/earningtypes/README.md#update) - Update an earning type
* [Deactivate](docs/sdks/earningtypes/README.md#deactivate) - Deactivate an earning type

### [EmployeeAddresses](docs/sdks/employeeaddresses/README.md)

* [Get](docs/sdks/employeeaddresses/README.md#get) - Get an employee's home addresses
* [Create](docs/sdks/employeeaddresses/README.md#create) - Create an employee's home address
* [GetHome](docs/sdks/employeeaddresses/README.md#gethome) - Get an employee's home address
* [Update](docs/sdks/employeeaddresses/README.md#update) - Update an employee's home address
* [RemoveHome](docs/sdks/employeeaddresses/README.md#removehome) - Delete an employee's home address
* [UpdateWork](docs/sdks/employeeaddresses/README.md#updatework) - Update an employee work address
* [Delete](docs/sdks/employeeaddresses/README.md#delete) - Delete an employee's work address

### [EmployeeBankAccounts](docs/sdks/employeebankaccounts/README.md)

* [Create](docs/sdks/employeebankaccounts/README.md#create) - Create an employee bank account
* [Update](docs/sdks/employeebankaccounts/README.md#update) - Update an employee bank account

### [EmployeeBenefits](docs/sdks/employeebenefits/README.md)

* [Create](docs/sdks/employeebenefits/README.md#create) - Create an employee benefit
* [List](docs/sdks/employeebenefits/README.md#list) - Get all benefits for an employee
* [Get](docs/sdks/employeebenefits/README.md#get) - Get an employee benefit
* [Update](docs/sdks/employeebenefits/README.md#update) - Update an employee benefit
* [Delete](docs/sdks/employeebenefits/README.md#delete) - Delete an employee benefit
* [GetEmployeeYtdBenefitAmountsFromDifferentCompany](docs/sdks/employeebenefits/README.md#getemployeeytdbenefitamountsfromdifferentcompany) - Get year-to-date benefit amounts from a different company
* [CreateYtdAmounts](docs/sdks/employeebenefits/README.md#createytdamounts) - Create year-to-date benefit amounts from a different company

### [EmployeeEmployments](docs/sdks/employeeemployments/README.md)

* [CreateTermination](docs/sdks/employeeemployments/README.md#createtermination) - Create an employee termination
* [DeleteTermination](docs/sdks/employeeemployments/README.md#deletetermination) - Delete an employee termination
* [UpdateTermination](docs/sdks/employeeemployments/README.md#updatetermination) - Update an employee termination
* [Rehire](docs/sdks/employeeemployments/README.md#rehire) - Create an employee rehire
* [GetRehire](docs/sdks/employeeemployments/README.md#getrehire) - Get an employee rehire
* [DeleteRehire](docs/sdks/employeeemployments/README.md#deleterehire) - Delete an employee rehire
* [GetHistory](docs/sdks/employeeemployments/README.md#gethistory) - Get employment history for an employee

### [EmployeeFederalTaxes](docs/sdks/employeefederaltaxes/README.md)

* [Update](docs/sdks/employeefederaltaxes/README.md#update) - Update an employee's federal taxes

### [EmployeeForms](docs/sdks/employeeforms/README.md)

* [GenerateW2](docs/sdks/employeeforms/README.md#generatew2) - Generate a W2 form [DEMO]
* [List](docs/sdks/employeeforms/README.md#list) - Get all employee forms
* [Get](docs/sdks/employeeforms/README.md#get) - Get an employee form
* [GetPdf](docs/sdks/employeeforms/README.md#getpdf) - Get the employee form pdf
* [Sign](docs/sdks/employeeforms/README.md#sign) - Sign an employee form

### [EmployeePaymentMethod](docs/sdks/employeepaymentmethod/README.md)

* [Get](docs/sdks/employeepaymentmethod/README.md#get) - Get an employee's payment method

### [EmployeePaymentMethods](docs/sdks/employeepaymentmethods/README.md)

* [GetBankAccounts](docs/sdks/employeepaymentmethods/README.md#getbankaccounts) - Get all employee bank accounts
* [UpdatePaymentMethod](docs/sdks/employeepaymentmethods/README.md#updatepaymentmethod) - Update an employee's payment method

### [EmployeeRehires](docs/sdks/employeerehires/README.md)

* [Update](docs/sdks/employeerehires/README.md#update) - Update an employee rehire

### [Employees](docs/sdks/employees/README.md)

* [Create](docs/sdks/employees/README.md#create) - Create an employee
* [List](docs/sdks/employees/README.md#list) - Get employees of a company
* [CreateHistorical](docs/sdks/employees/README.md#createhistorical) - Create a historical employee
* [UpdateHistorical](docs/sdks/employees/README.md#updatehistorical) - Update a historical employee
* [Get](docs/sdks/employees/README.md#get) - Get an employee
* [Update](docs/sdks/employees/README.md#update) - Update an employee
* [Delete](docs/sdks/employees/README.md#delete) - Delete an onboarding employee
* [GetCustomFields](docs/sdks/employees/README.md#getcustomfields) - Get an employee's custom fields
* [UpdateOnboardingDocumentsConfig](docs/sdks/employees/README.md#updateonboardingdocumentsconfig) - Update an employee's onboarding documents config
* [GetOnboardingStatus](docs/sdks/employees/README.md#getonboardingstatus) - Get the employee's onboarding status
* [UpdateOnboardingStatus](docs/sdks/employees/README.md#updateonboardingstatus) - Update the employee's onboarding status
* [GetTimeOffActivities](docs/sdks/employees/README.md#gettimeoffactivities) - Get employee time off activities
* [GetTerminations](docs/sdks/employees/README.md#getterminations) - Get terminations for an employee
* [DeleteBankAccount](docs/sdks/employees/README.md#deletebankaccount) - Delete an employee bank account
* [CreateJob](docs/sdks/employees/README.md#createjob) - Create a job
* [GetGarnishments](docs/sdks/employees/README.md#getgarnishments) - Get garnishments for an employee

### [EmployeeTaxes](docs/sdks/employeetaxes/README.md)

* [Update](docs/sdks/employeetaxes/README.md#update) - Update an employee's state taxes

### [EmployeeTaxSetup](docs/sdks/employeetaxsetup/README.md)

* [GetFederalTaxes](docs/sdks/employeetaxsetup/README.md#getfederaltaxes) - Get an employee's federal taxes
* [GetStateTaxes](docs/sdks/employeetaxsetup/README.md#getstatetaxes) - Get an employee's state taxes

### [EmployeeWorkAddresses](docs/sdks/employeeworkaddresses/README.md)

* [List](docs/sdks/employeeworkaddresses/README.md#list) - Get an employee's work addresses
* [Create](docs/sdks/employeeworkaddresses/README.md#create) - Create an employee work address
* [Get](docs/sdks/employeeworkaddresses/README.md#get) - Get an employee work address

### [Events](docs/sdks/events/README.md)

* [List](docs/sdks/events/README.md#list) - Get all events

### [ExternalPayrolls](docs/sdks/externalpayrolls/README.md)

* [Create](docs/sdks/externalpayrolls/README.md#create) - Create a new external payroll for a company
* [List](docs/sdks/externalpayrolls/README.md#list) - Get external payrolls for a company
* [Get](docs/sdks/externalpayrolls/README.md#get) - Get an external payroll
* [Delete](docs/sdks/externalpayrolls/README.md#delete) - Delete an external payroll
* [Update](docs/sdks/externalpayrolls/README.md#update) - Update an external payroll
* [GetTaxSuggestions](docs/sdks/externalpayrolls/README.md#gettaxsuggestions) - Get tax suggestions for an external payroll
* [GetTaxLiabilities](docs/sdks/externalpayrolls/README.md#gettaxliabilities) - Get tax liabilities
* [UpdateTaxLiabilities](docs/sdks/externalpayrolls/README.md#updatetaxliabilities) - Update tax liabilities
* [FinalizeTaxLiabilities](docs/sdks/externalpayrolls/README.md#finalizetaxliabilities) - Finalize tax liabilities options and convert into processed payrolls

### [FederalTaxDetails](docs/sdks/federaltaxdetails/README.md)

* [Get](docs/sdks/federaltaxdetails/README.md#get) - Get Federal Tax Details
* [Update](docs/sdks/federaltaxdetails/README.md#update) - Update Federal Tax Details

### [Flows](docs/sdks/flows/README.md)

* [Create](docs/sdks/flows/README.md#create) - Create a flow

### [Garnishments](docs/sdks/garnishments/README.md)

* [Create](docs/sdks/garnishments/README.md#create) - Create a garnishment
* [Get](docs/sdks/garnishments/README.md#get) - Get a garnishment
* [Update](docs/sdks/garnishments/README.md#update) - Update a garnishment
* [GetChildSupport](docs/sdks/garnishments/README.md#getchildsupport) - Get child support garnishment data

### [GeneratedDocuments](docs/sdks/generateddocuments/README.md)

* [Get](docs/sdks/generateddocuments/README.md#get) - Get a generated document


### [HolidayPayPolicies](docs/sdks/holidaypaypolicies/README.md)

* [Get](docs/sdks/holidaypaypolicies/README.md#get) - Get a company's holiday pay policy
* [Create](docs/sdks/holidaypaypolicies/README.md#create) - Create a holiday pay policy for a company
* [Update](docs/sdks/holidaypaypolicies/README.md#update) - Update a company's holiday pay policy
* [Delete](docs/sdks/holidaypaypolicies/README.md#delete) - Delete a company's holiday pay policy
* [AddEmployees](docs/sdks/holidaypaypolicies/README.md#addemployees) - Add employees to a company's holiday pay policy
* [RemoveEmployees](docs/sdks/holidaypaypolicies/README.md#removeemployees) - Remove employees from a company's holiday pay policy
* [Preview](docs/sdks/holidaypaypolicies/README.md#preview) - Preview a company's paid holidays

### [I9Verification](docs/sdks/i9verification/README.md)

* [GetDocumentOptions](docs/sdks/i9verification/README.md#getdocumentoptions) - Get an employee's I-9 verification document options
* [GetEmployeeDocuments](docs/sdks/i9verification/README.md#getemployeedocuments) - Get an employee's I-9 verification documents
* [CreateDocuments](docs/sdks/i9verification/README.md#createdocuments) - Create an employee's I-9 authorization verification documents
* [DeleteDocument](docs/sdks/i9verification/README.md#deletedocument) - Delete an employee's I-9 verification document
* [EmployerSign](docs/sdks/i9verification/README.md#employersign) - Employer sign an employee's Form I-9

### [I9Verifications](docs/sdks/i9verifications/README.md)

* [Get](docs/sdks/i9verifications/README.md#get) - Get an employee's I-9 authorization
* [Upsert](docs/sdks/i9verifications/README.md#upsert) - Create or update an employee's I-9 authorization

### [IndustrySelection](docs/sdks/industryselection/README.md)

* [Get](docs/sdks/industryselection/README.md#get) - Get a company industry selection

### [Introspection](docs/sdks/introspection/README.md)

* [GetTokenInfo](docs/sdks/introspection/README.md#gettokeninfo) - Get info about the current access token
* [RefreshAccessToken](docs/sdks/introspection/README.md#refreshaccesstoken) - Refresh access token

### [Invoices](docs/sdks/invoices/README.md)

* [Get](docs/sdks/invoices/README.md#get) - Retrieve invoicing data for companies

### [Jobs](docs/sdks/jobs/README.md)

* [List](docs/sdks/jobs/README.md#list) - Get jobs for an employee
* [Get](docs/sdks/jobs/README.md#get) - Get a job
* [Delete](docs/sdks/jobs/README.md#delete) - Delete an individual job
* [CreateCompensation](docs/sdks/jobs/README.md#createcompensation) - Create a compensation
* [UpdateCompensation](docs/sdks/jobs/README.md#updatecompensation) - Update a compensation

### [JobsAndCompensations](docs/sdks/jobsandcompensations/README.md)

* [Update](docs/sdks/jobsandcompensations/README.md#update) - Update a job
* [ListCompensations](docs/sdks/jobsandcompensations/README.md#listcompensations) - Get compensations for a job
* [GetCompensation](docs/sdks/jobsandcompensations/README.md#getcompensation) - Get a compensation

### [Locations](docs/sdks/locations/README.md)

* [Create](docs/sdks/locations/README.md#create) - Create a company location
* [GetAllCompanyLocations](docs/sdks/locations/README.md#getallcompanylocations) - Get company locations
* [Get](docs/sdks/locations/README.md#get) - Get a location
* [Update](docs/sdks/locations/README.md#update) - Update a location
* [GetMinimumWages](docs/sdks/locations/README.md#getminimumwages) - Get minimum wages for a location

### [Notifications](docs/sdks/notifications/README.md)

* [Get](docs/sdks/notifications/README.md#get) - Get a notification's details

### [PaymentConfigs](docs/sdks/paymentconfigs/README.md)

* [Get](docs/sdks/paymentconfigs/README.md#get) - Get a company's payment configs
* [Update](docs/sdks/paymentconfigs/README.md#update) - Update a company's payment configs

### [Payrolls](docs/sdks/payrolls/README.md)

* [Create](docs/sdks/payrolls/README.md#create) - Create an off-cycle payroll
* [List](docs/sdks/payrolls/README.md#list) - Get all payrolls for a company
* [GetReversals](docs/sdks/payrolls/README.md#getreversals) - Get approved payroll reversals
* [Get](docs/sdks/payrolls/README.md#get) - Get a single payroll
* [Update](docs/sdks/payrolls/README.md#update) - Update a payroll by ID
* [Delete](docs/sdks/payrolls/README.md#delete) - Delete a payroll
* [PrepareForUpdate](docs/sdks/payrolls/README.md#prepareforupdate) - Prepare a payroll for update
* [GetReceipt](docs/sdks/payrolls/README.md#getreceipt) - Get a single payroll receipt
* [GetBlockers](docs/sdks/payrolls/README.md#getblockers) - Get all payroll blockers for a company
* [Skip](docs/sdks/payrolls/README.md#skip) - Skip a payroll
* [CalculateGrossUp](docs/sdks/payrolls/README.md#calculategrossup) - Calculate gross up
* [Calculate](docs/sdks/payrolls/README.md#calculate) - Calculate a payroll
* [Submit](docs/sdks/payrolls/README.md#submit) - Submit payroll
* [Cancel](docs/sdks/payrolls/README.md#cancel) - Cancel a payroll
* [GetEmployeePayStubPdf](docs/sdks/payrolls/README.md#getemployeepaystubpdf) - Get an employee pay stub (pdf)
* [GetEmployeePayStubs](docs/sdks/payrolls/README.md#getemployeepaystubs) - Get an employee's pay stubs
* [GeneratePrintableChecks](docs/sdks/payrolls/README.md#generateprintablechecks) - Generate printable payroll checks (pdf)

### [PayScheduleAssignments](docs/sdks/payscheduleassignments/README.md)

* [Get](docs/sdks/payscheduleassignments/README.md#get) - Get pay schedule assignments for a company

### [PaySchedules](docs/sdks/payschedules/README.md)

* [Create](docs/sdks/payschedules/README.md#create) - Create a new pay schedule
* [Get](docs/sdks/payschedules/README.md#get) - Get the pay schedules for a company
* [Preview](docs/sdks/payschedules/README.md#preview) - Preview pay schedule dates
* [GetById](docs/sdks/payschedules/README.md#getbyid) - Get a pay schedule
* [Update](docs/sdks/payschedules/README.md#update) - Update a pay schedule
* [ListPayPeriods](docs/sdks/payschedules/README.md#listpayperiods) - Get pay periods for a company
* [ListUnprocessedTerminationPeriods](docs/sdks/payschedules/README.md#listunprocessedterminationperiods) - Get termination pay periods for a company
* [PreviewAssignment](docs/sdks/payschedules/README.md#previewassignment) - Preview pay schedule assignments for a company
* [Assign](docs/sdks/payschedules/README.md#assign) - Assign pay schedules for a company

### [RecoveryCases](docs/sdks/recoverycases/README.md)

* [List](docs/sdks/recoverycases/README.md#list) - Get all recovery cases for a company
* [Redebit](docs/sdks/recoverycases/README.md#redebit) - Initiate a redebit for a recovery case

### [Reports](docs/sdks/reports/README.md)

* [Create](docs/sdks/reports/README.md#create) - Create a custom report
* [Get](docs/sdks/reports/README.md#get) - Get a report
* [GetTemplate](docs/sdks/reports/README.md#gettemplate) - Get a report template

### [Signatories](docs/sdks/signatories/README.md)

* [Create](docs/sdks/signatories/README.md#create) - Create a signatory
* [Invite](docs/sdks/signatories/README.md#invite) - Invite a signatory
* [Update](docs/sdks/signatories/README.md#update) - Update a signatory
* [Delete](docs/sdks/signatories/README.md#delete) - Delete a signatory

### [TaxRequirements](docs/sdks/taxrequirements/README.md)

* [GetForState](docs/sdks/taxrequirements/README.md#getforstate) - Get State Tax Requirements
* [UpdateState](docs/sdks/taxrequirements/README.md#updatestate) - Update State Tax Requirements
* [List](docs/sdks/taxrequirements/README.md#list) - Get All Tax Requirement States

### [TimeOffPolicies](docs/sdks/timeoffpolicies/README.md)

* [CalculateAccruingHours](docs/sdks/timeoffpolicies/README.md#calculateaccruinghours) - Calculate accruing time off hours
* [Get](docs/sdks/timeoffpolicies/README.md#get) - Get a time off policy
* [Update](docs/sdks/timeoffpolicies/README.md#update) - Update a time off policy
* [List](docs/sdks/timeoffpolicies/README.md#list) - Get all time off policies
* [Create](docs/sdks/timeoffpolicies/README.md#create) - Create a time off policy
* [AddEmployees](docs/sdks/timeoffpolicies/README.md#addemployees) - Add employees to a time off policy
* [RemoveEmployees](docs/sdks/timeoffpolicies/README.md#removeemployees) - Remove employees from a time off policy
* [UpdateBalance](docs/sdks/timeoffpolicies/README.md#updatebalance) - Update employee time off hour balances
* [Deactivate](docs/sdks/timeoffpolicies/README.md#deactivate) - Deactivate a time off policy

### [Webhooks](docs/sdks/webhooks/README.md)

* [ListSubscriptions](docs/sdks/webhooks/README.md#listsubscriptions) - List webhook subscriptions
* [Update](docs/sdks/webhooks/README.md#update) - Update a webhook subscription
* [Get](docs/sdks/webhooks/README.md#get) - Get a webhook subscription
* [Delete](docs/sdks/webhooks/README.md#delete) - Delete a webhook subscription
* [Verify](docs/sdks/webhooks/README.md#verify) - Verify the webhook subscription

### [WebhookSubscriptions](docs/sdks/webhooksubscriptions/README.md)

* [Create](docs/sdks/webhooksubscriptions/README.md#create) - Create a webhook subscription
* [RequestVerificationToken](docs/sdks/webhooksubscriptions/README.md#requestverificationtoken) - Request the webhook subscription verification_token

### [WireInRequests](docs/sdks/wireinrequests/README.md)

* [Get](docs/sdks/wireinrequests/README.md#get) - Get a single Wire In Request
* [SubmitRequest](docs/sdks/wireinrequests/README.md#submitrequest) - Submit a wire in request
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

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `CreatePartnerManagedAsync` method throws the following exceptions:

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
    var res = await sdk.Companies.CreatePartnerManagedAsync(
        security: new PostV1PartnerManagedCompaniesSecurity() {
            SystemAccessAuth = "<YOUR_BEARER_TOKEN_HERE>",
        },
        requestBody: new PostV1PartnerManagedCompaniesRequestBody() {
            User = new User() {
                FirstName = "Gail",
                LastName = "Stracke",
                Email = "Emanuel.McClure@gmail.com",
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

var res = await sdk.Introspection.GetTokenInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

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

var res = await sdk.Introspection.GetTokenInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

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
