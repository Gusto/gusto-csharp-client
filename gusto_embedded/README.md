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

var res = await sdk.Introspection.GetInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

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

var res = await sdk.Introspection.GetInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

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
* [Get](docs/sdks/bankaccounts/README.md#get) - Get all company bank accounts
* [Verify](docs/sdks/bankaccounts/README.md#verify) - Verify a company bank account
* [CreateFromPlaidToken](docs/sdks/bankaccounts/README.md#createfromplaidtoken) - Create a bank account from a plaid processor token

### [Companies](docs/sdks/companies/README.md)

* [CreatePartnerManaged](docs/sdks/companies/README.md#createpartnermanaged) - Create a partner managed company
* [Get](docs/sdks/companies/README.md#get) - Get a company
* [Update](docs/sdks/companies/README.md#update) - Update a company
* [Migrate](docs/sdks/companies/README.md#migrate) - Migrate company to embedded payroll
* [AcceptTermsOfService](docs/sdks/companies/README.md#accepttermsofservice) - Accept terms of service for a company user
* [RetrieveTermsOfService](docs/sdks/companies/README.md#retrievetermsofservice) - Retrieve terms of service status for a company user
* [CreateAdmin](docs/sdks/companies/README.md#createadmin) - Create an admin for the company
* [ListAdmins](docs/sdks/companies/README.md#listadmins) - Get all the admins at a company
* [GetOnboardingStatus](docs/sdks/companies/README.md#getonboardingstatus) - Get the company's onboarding status
* [FinishOnboarding](docs/sdks/companies/README.md#finishonboarding) - Finish company onboarding
* [GetCustomFields](docs/sdks/companies/README.md#getcustomfields) - Get the custom fields of a company

### [CompanyAttachment](docs/sdks/companyattachment/README.md)

* [GetDownloadUrl](docs/sdks/companyattachment/README.md#getdownloadurl) - Get a temporary url to download the Company Attachment file

### [CompanyAttachments](docs/sdks/companyattachments/README.md)

* [GetDetails](docs/sdks/companyattachments/README.md#getdetails) - Get Company Attachment Details
* [GetList](docs/sdks/companyattachments/README.md#getlist) - Get List of Company Attachments
* [Create](docs/sdks/companyattachments/README.md#create) - Create Company Attachment and Upload File

### [CompanyBenefits](docs/sdks/companybenefits/README.md)

* [Create](docs/sdks/companybenefits/README.md#create) - Create a company benefit
* [List](docs/sdks/companybenefits/README.md#list) - Get benefits for a company
* [Get](docs/sdks/companybenefits/README.md#get) - Get a company benefit
* [Update](docs/sdks/companybenefits/README.md#update) - Update a company benefit
* [Delete](docs/sdks/companybenefits/README.md#delete) - Delete a company benefit
* [GetAll](docs/sdks/companybenefits/README.md#getall) - Get all benefits supported by Gusto
* [GetSupported](docs/sdks/companybenefits/README.md#getsupported) - Get a supported benefit by ID
* [GetSummary](docs/sdks/companybenefits/README.md#getsummary) - Get company benefit summary by company benefit id.
* [GetEmployeeBenefits](docs/sdks/companybenefits/README.md#getemployeebenefits) - Get all employee benefits for a company benefit
* [UpdateEmployeeBenefits](docs/sdks/companybenefits/README.md#updateemployeebenefits) - Bulk update employee benefits for a company benefit
* [GetRequirements](docs/sdks/companybenefits/README.md#getrequirements) - Get benefit fields requirements by ID

### [CompanyForms](docs/sdks/companyforms/README.md)

* [GetAll](docs/sdks/companyforms/README.md#getall) - Get all company forms
* [Get](docs/sdks/companyforms/README.md#get) - Get a company form
* [GetPdf](docs/sdks/companyforms/README.md#getpdf) - Get a company form pdf
* [Sign](docs/sdks/companyforms/README.md#sign) - Sign a company form

### [ContractorDocuments](docs/sdks/contractordocuments/README.md)

* [GetAll](docs/sdks/contractordocuments/README.md#getall) - Get all contractor documents
* [Get](docs/sdks/contractordocuments/README.md#get) - Get a contractor document
* [GetPdf](docs/sdks/contractordocuments/README.md#getpdf) - Get the contractor document pdf
* [Sign](docs/sdks/contractordocuments/README.md#sign) - Sign a contractor document

### [ContractorForms](docs/sdks/contractorforms/README.md)

* [List](docs/sdks/contractorforms/README.md#list) - Get all contractor forms
* [Get](docs/sdks/contractorforms/README.md#get) - Get a contractor form
* [GetPdf](docs/sdks/contractorforms/README.md#getpdf) - Get the contractor form pdf
* [Generate1099](docs/sdks/contractorforms/README.md#generate1099) - Generate a 1099 form [DEMO]

### [ContractorPaymentGroups](docs/sdks/contractorpaymentgroups/README.md)

* [Create](docs/sdks/contractorpaymentgroups/README.md#create) - Create a contractor payment group
* [GetList](docs/sdks/contractorpaymentgroups/README.md#getlist) - Get contractor payment groups for a company
* [Preview](docs/sdks/contractorpaymentgroups/README.md#preview) - Preview a contractor payment group
* [Get](docs/sdks/contractorpaymentgroups/README.md#get) - Fetch a contractor payment group
* [Delete](docs/sdks/contractorpaymentgroups/README.md#delete) - Cancel a contractor payment group
* [Fund](docs/sdks/contractorpaymentgroups/README.md#fund) - Fund a contractor payment group [DEMO]

### [ContractorPaymentMethod](docs/sdks/contractorpaymentmethod/README.md)

* [GetBankAccounts](docs/sdks/contractorpaymentmethod/README.md#getbankaccounts) - Get all contractor bank accounts
* [Get](docs/sdks/contractorpaymentmethod/README.md#get) - Get a contractor's payment method
* [Update](docs/sdks/contractorpaymentmethod/README.md#update) - Update a contractor's payment method

### [ContractorPaymentMethods](docs/sdks/contractorpaymentmethods/README.md)

* [CreateBankAccount](docs/sdks/contractorpaymentmethods/README.md#createbankaccount) - Create a contractor bank account

### [ContractorPayments](docs/sdks/contractorpayments/README.md)

* [GetReceipt](docs/sdks/contractorpayments/README.md#getreceipt) - Get a single contractor payment receipt
* [Fund](docs/sdks/contractorpayments/README.md#fund) - Fund a contractor payment [DEMO]
* [Create](docs/sdks/contractorpayments/README.md#create) - Create a contractor payment
* [List](docs/sdks/contractorpayments/README.md#list) - Get contractor payments for a company
* [Get](docs/sdks/contractorpayments/README.md#get) - Get a single contractor payment
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

### [Departments](docs/sdks/departments/README.md)

* [Create](docs/sdks/departments/README.md#create) - Create a department
* [GetAll](docs/sdks/departments/README.md#getall) - Get all departments of a company
* [Get](docs/sdks/departments/README.md#get) - Get a department
* [Update](docs/sdks/departments/README.md#update) - Update a department
* [Delete](docs/sdks/departments/README.md#delete) - Delete a department
* [AddPeople](docs/sdks/departments/README.md#addpeople) - Add people to a department
* [RemovePeople](docs/sdks/departments/README.md#removepeople) - Remove people from a department

### [EarningTypes](docs/sdks/earningtypes/README.md)

* [Create](docs/sdks/earningtypes/README.md#create) - Create a custom earning type
* [List](docs/sdks/earningtypes/README.md#list) - Get all earning types for a company
* [Update](docs/sdks/earningtypes/README.md#update) - Update an earning type
* [Delete](docs/sdks/earningtypes/README.md#delete) - Deactivate an earning type

### [EmployeeAddresses](docs/sdks/employeeaddresses/README.md)

* [Get](docs/sdks/employeeaddresses/README.md#get) - Get an employee's home addresses
* [Create](docs/sdks/employeeaddresses/README.md#create) - Create an employee's home address
* [RetrieveHomeAddress](docs/sdks/employeeaddresses/README.md#retrievehomeaddress) - Get an employee's home address
* [Update](docs/sdks/employeeaddresses/README.md#update) - Update an employee's home address
* [Delete](docs/sdks/employeeaddresses/README.md#delete) - Delete an employee's home address
* [GetWorkAddresses](docs/sdks/employeeaddresses/README.md#getworkaddresses) - Get an employee's work addresses
* [CreateWorkAddress](docs/sdks/employeeaddresses/README.md#createworkaddress) - Create an employee work address
* [RetrieveWorkAddress](docs/sdks/employeeaddresses/README.md#retrieveworkaddress) - Get an employee work address
* [UpdateWorkAddress](docs/sdks/employeeaddresses/README.md#updateworkaddress) - Update an employee work address
* [DeleteWorkAddress](docs/sdks/employeeaddresses/README.md#deleteworkaddress) - Delete an employee's work address

### [EmployeeBenefits](docs/sdks/employeebenefits/README.md)

* [Create](docs/sdks/employeebenefits/README.md#create) - Create an employee benefit
* [Get](docs/sdks/employeebenefits/README.md#get) - Get all benefits for an employee
* [Retrieve](docs/sdks/employeebenefits/README.md#retrieve) - Get an employee benefit
* [Update](docs/sdks/employeebenefits/README.md#update) - Update an employee benefit
* [Delete](docs/sdks/employeebenefits/README.md#delete) - Delete an employee benefit
* [GetYtdBenefitAmountsFromDifferentCompany](docs/sdks/employeebenefits/README.md#getytdbenefitamountsfromdifferentcompany) - Get year-to-date benefit amounts from a different company
* [CreateYtdBenefitAmountsFromDifferentCompany](docs/sdks/employeebenefits/README.md#createytdbenefitamountsfromdifferentcompany) - Create year-to-date benefit amounts from a different company

### [EmployeeEmployments](docs/sdks/employeeemployments/README.md)

* [CreateTermination](docs/sdks/employeeemployments/README.md#createtermination) - Create an employee termination
* [GetTerminations](docs/sdks/employeeemployments/README.md#getterminations) - Get terminations for an employee
* [DeleteTermination](docs/sdks/employeeemployments/README.md#deletetermination) - Delete an employee termination
* [UpdateTermination](docs/sdks/employeeemployments/README.md#updatetermination) - Update an employee termination
* [CreateRehire](docs/sdks/employeeemployments/README.md#createrehire) - Create an employee rehire
* [Rehire](docs/sdks/employeeemployments/README.md#rehire) - Update an employee rehire
* [GetRehire](docs/sdks/employeeemployments/README.md#getrehire) - Get an employee rehire
* [DeleteRehire](docs/sdks/employeeemployments/README.md#deleterehire) - Delete an employee rehire
* [GetHistory](docs/sdks/employeeemployments/README.md#gethistory) - Get employment history for an employee

### [EmployeeForms](docs/sdks/employeeforms/README.md)

* [GenerateW2](docs/sdks/employeeforms/README.md#generatew2) - Generate a W2 form [DEMO]
* [List](docs/sdks/employeeforms/README.md#list) - Get all employee forms
* [Get](docs/sdks/employeeforms/README.md#get) - Get an employee form
* [GetPdf](docs/sdks/employeeforms/README.md#getpdf) - Get the employee form pdf
* [Sign](docs/sdks/employeeforms/README.md#sign) - Sign an employee form

### [EmployeePaymentMethod](docs/sdks/employeepaymentmethod/README.md)

* [Create](docs/sdks/employeepaymentmethod/README.md#create) - Create an employee bank account
* [DeleteBankAccount](docs/sdks/employeepaymentmethod/README.md#deletebankaccount) - Delete an employee bank account
* [UpdateBankAccount](docs/sdks/employeepaymentmethod/README.md#updatebankaccount) - Update an employee bank account
* [Get](docs/sdks/employeepaymentmethod/README.md#get) - Get an employee's payment method
* [Update](docs/sdks/employeepaymentmethod/README.md#update) - Update an employee's payment method

### [EmployeePaymentMethods](docs/sdks/employeepaymentmethods/README.md)

* [GetBankAccounts](docs/sdks/employeepaymentmethods/README.md#getbankaccounts) - Get all employee bank accounts

### [Employees](docs/sdks/employees/README.md)

* [Create](docs/sdks/employees/README.md#create) - Create an employee
* [List](docs/sdks/employees/README.md#list) - Get employees of a company
* [CreateHistorical](docs/sdks/employees/README.md#createhistorical) - Create a historical employee
* [Get](docs/sdks/employees/README.md#get) - Get an employee
* [Update](docs/sdks/employees/README.md#update) - Update an employee
* [Delete](docs/sdks/employees/README.md#delete) - Delete an onboarding employee
* [GetCustomFields](docs/sdks/employees/README.md#getcustomfields) - Get an employee's custom fields
* [UpdateOnboardingDocumentsConfig](docs/sdks/employees/README.md#updateonboardingdocumentsconfig) - Update an employee's onboarding documents config
* [GetOnboardingStatus](docs/sdks/employees/README.md#getonboardingstatus) - Get the employee's onboarding status
* [UpdateOnboardingStatus](docs/sdks/employees/README.md#updateonboardingstatus) - Update the employee's onboarding status
* [GetTimeOffActivities](docs/sdks/employees/README.md#gettimeoffactivities) - Get employee time off activities

### [EmployeeTaxSetup](docs/sdks/employeetaxsetup/README.md)

* [GetFederalTaxes](docs/sdks/employeetaxsetup/README.md#getfederaltaxes) - Get an employee's federal taxes
* [UpdateFederalTaxes](docs/sdks/employeetaxsetup/README.md#updatefederaltaxes) - Update an employee's federal taxes
* [GetStateTaxes](docs/sdks/employeetaxsetup/README.md#getstatetaxes) - Get an employee's state taxes
* [UpdateStateTaxes](docs/sdks/employeetaxsetup/README.md#updatestatetaxes) - Update an employee's state taxes

### [Events](docs/sdks/events/README.md)

* [Get](docs/sdks/events/README.md#get) - Get all events

### [ExternalPayrolls](docs/sdks/externalpayrolls/README.md)

* [Create](docs/sdks/externalpayrolls/README.md#create) - Create a new external payroll for a company
* [Get](docs/sdks/externalpayrolls/README.md#get) - Get external payrolls for a company
* [Retrieve](docs/sdks/externalpayrolls/README.md#retrieve) - Get an external payroll
* [Delete](docs/sdks/externalpayrolls/README.md#delete) - Delete an external payroll
* [Update](docs/sdks/externalpayrolls/README.md#update) - Update an external payroll
* [CalculateTaxes](docs/sdks/externalpayrolls/README.md#calculatetaxes) - Get tax suggestions for an external payroll
* [ListTaxLiabilities](docs/sdks/externalpayrolls/README.md#listtaxliabilities) - Get tax liabilities
* [UpdateTaxLiabilities](docs/sdks/externalpayrolls/README.md#updatetaxliabilities) - Update tax liabilities
* [FinalizeTaxLiabilities](docs/sdks/externalpayrolls/README.md#finalizetaxliabilities) - Finalize tax liabilities options and convert into processed payrolls

### [FederalTaxDetails](docs/sdks/federaltaxdetails/README.md)

* [Get](docs/sdks/federaltaxdetails/README.md#get) - Get Federal Tax Details
* [Update](docs/sdks/federaltaxdetails/README.md#update) - Update Federal Tax Details

### [Flows](docs/sdks/flows/README.md)

* [Create](docs/sdks/flows/README.md#create) - Create a flow

### [Garnishments](docs/sdks/garnishments/README.md)

* [Create](docs/sdks/garnishments/README.md#create) - Create a garnishment
* [List](docs/sdks/garnishments/README.md#list) - Get garnishments for an employee
* [Get](docs/sdks/garnishments/README.md#get) - Get a garnishment
* [Update](docs/sdks/garnishments/README.md#update) - Update a garnishment
* [GetChildSupportData](docs/sdks/garnishments/README.md#getchildsupportdata) - Get child support garnishment data

### [GeneratedDocuments](docs/sdks/generateddocuments/README.md)

* [Get](docs/sdks/generateddocuments/README.md#get) - Get a generated document


### [HistoricalEmployees](docs/sdks/historicalemployees/README.md)

* [Update](docs/sdks/historicalemployees/README.md#update) - Update a historical employee

### [HolidayPayPolicies](docs/sdks/holidaypaypolicies/README.md)

* [Get](docs/sdks/holidaypaypolicies/README.md#get) - Get a company's holiday pay policy
* [Create](docs/sdks/holidaypaypolicies/README.md#create) - Create a holiday pay policy for a company
* [Update](docs/sdks/holidaypaypolicies/README.md#update) - Update a company's holiday pay policy
* [Delete](docs/sdks/holidaypaypolicies/README.md#delete) - Delete a company's holiday pay policy
* [AddEmployees](docs/sdks/holidaypaypolicies/README.md#addemployees) - Add employees to a company's holiday pay policy
* [RemoveEmployees](docs/sdks/holidaypaypolicies/README.md#removeemployees) - Remove employees from a company's holiday pay policy
* [PreviewPaidHolidays](docs/sdks/holidaypaypolicies/README.md#previewpaidholidays) - Preview a company's paid holidays

### [I9Verification](docs/sdks/i9verification/README.md)

* [GetAuthorization](docs/sdks/i9verification/README.md#getauthorization) - Get an employee's I-9 authorization
* [Update](docs/sdks/i9verification/README.md#update) - Create or update an employee's I-9 authorization
* [GetDocumentOptions](docs/sdks/i9verification/README.md#getdocumentoptions) - Get an employee's I-9 verification document options
* [GetDocuments](docs/sdks/i9verification/README.md#getdocuments) - Get an employee's I-9 verification documents
* [CreateDocuments](docs/sdks/i9verification/README.md#createdocuments) - Create an employee's I-9 authorization verification documents
* [DeleteDocument](docs/sdks/i9verification/README.md#deletedocument) - Delete an employee's I-9 verification document
* [EmployerSign](docs/sdks/i9verification/README.md#employersign) - Employer sign an employee's Form I-9

### [IndustrySelection](docs/sdks/industryselection/README.md)

* [Get](docs/sdks/industryselection/README.md#get) - Get a company industry selection
* [Update](docs/sdks/industryselection/README.md#update) - Update a company industry selection

### [Introspection](docs/sdks/introspection/README.md)

* [GetInfo](docs/sdks/introspection/README.md#getinfo) - Get info about the current access token
* [RefreshToken](docs/sdks/introspection/README.md#refreshtoken) - Refresh access token

### [Invoices](docs/sdks/invoices/README.md)

* [Get](docs/sdks/invoices/README.md#get) - Retrieve invoicing data for companies

### [JobsAndCompensations](docs/sdks/jobsandcompensations/README.md)

* [CreateJob](docs/sdks/jobsandcompensations/README.md#createjob) - Create a job
* [GetJobs](docs/sdks/jobsandcompensations/README.md#getjobs) - Get jobs for an employee
* [GetJob](docs/sdks/jobsandcompensations/README.md#getjob) - Get a job
* [Update](docs/sdks/jobsandcompensations/README.md#update) - Update a job
* [Delete](docs/sdks/jobsandcompensations/README.md#delete) - Delete an individual job
* [GetCompensations](docs/sdks/jobsandcompensations/README.md#getcompensations) - Get compensations for a job
* [CreateCompensation](docs/sdks/jobsandcompensations/README.md#createcompensation) - Create a compensation
* [GetCompensation](docs/sdks/jobsandcompensations/README.md#getcompensation) - Get a compensation
* [UpdateCompensation](docs/sdks/jobsandcompensations/README.md#updatecompensation) - Update a compensation
* [DeleteCompensation](docs/sdks/jobsandcompensations/README.md#deletecompensation) - Delete a compensation

### [Locations](docs/sdks/locations/README.md)

* [Create](docs/sdks/locations/README.md#create) - Create a company location
* [Get](docs/sdks/locations/README.md#get) - Get company locations
* [Retrieve](docs/sdks/locations/README.md#retrieve) - Get a location
* [Update](docs/sdks/locations/README.md#update) - Update a location
* [GetMinimumWages](docs/sdks/locations/README.md#getminimumwages) - Get minimum wages for a location

### [Notifications](docs/sdks/notifications/README.md)

* [GetDetails](docs/sdks/notifications/README.md#getdetails) - Get a notification's details

### [PaymentConfigs](docs/sdks/paymentconfigs/README.md)

* [Get](docs/sdks/paymentconfigs/README.md#get) - Get a company's payment configs
* [Update](docs/sdks/paymentconfigs/README.md#update) - Update a company's payment configs

### [Payrolls](docs/sdks/payrolls/README.md)

* [CreateOffCycle](docs/sdks/payrolls/README.md#createoffcycle) - Create an off-cycle payroll
* [List](docs/sdks/payrolls/README.md#list) - Get all payrolls for a company
* [GetApprovedReversals](docs/sdks/payrolls/README.md#getapprovedreversals) - Get approved payroll reversals
* [Get](docs/sdks/payrolls/README.md#get) - Get a single payroll
* [Update](docs/sdks/payrolls/README.md#update) - Update a payroll by ID
* [Delete](docs/sdks/payrolls/README.md#delete) - Delete a payroll
* [Prepare](docs/sdks/payrolls/README.md#prepare) - Prepare a payroll for update
* [GetReceipt](docs/sdks/payrolls/README.md#getreceipt) - Get a single payroll receipt
* [GetBlockers](docs/sdks/payrolls/README.md#getblockers) - Get all payroll blockers for a company
* [Skip](docs/sdks/payrolls/README.md#skip) - Skip a payroll
* [CalculateGrossUp](docs/sdks/payrolls/README.md#calculategrossup) - Calculate gross up
* [Calculate](docs/sdks/payrolls/README.md#calculate) - Calculate a payroll
* [Submit](docs/sdks/payrolls/README.md#submit) - Submit payroll
* [Cancel](docs/sdks/payrolls/README.md#cancel) - Cancel a payroll
* [GetPayStub](docs/sdks/payrolls/README.md#getpaystub) - Get an employee pay stub (pdf)
* [GetPayStubs](docs/sdks/payrolls/README.md#getpaystubs) - Get an employee's pay stubs
* [GeneratePrintableChecks](docs/sdks/payrolls/README.md#generateprintablechecks) - Generate printable payroll checks (pdf)

### [PaySchedules](docs/sdks/payschedules/README.md)

* [Create](docs/sdks/payschedules/README.md#create) - Create a new pay schedule
* [GetAll](docs/sdks/payschedules/README.md#getall) - Get the pay schedules for a company
* [GetPreview](docs/sdks/payschedules/README.md#getpreview) - Preview pay schedule dates
* [Get](docs/sdks/payschedules/README.md#get) - Get a pay schedule
* [Update](docs/sdks/payschedules/README.md#update) - Update a pay schedule
* [GetPayPeriods](docs/sdks/payschedules/README.md#getpayperiods) - Get pay periods for a company
* [GetUnprocessedTerminationPeriods](docs/sdks/payschedules/README.md#getunprocessedterminationperiods) - Get termination pay periods for a company
* [GetAssignments](docs/sdks/payschedules/README.md#getassignments) - Get pay schedule assignments for a company
* [PreviewAssignment](docs/sdks/payschedules/README.md#previewassignment) - Preview pay schedule assignments for a company
* [Assign](docs/sdks/payschedules/README.md#assign) - Assign pay schedules for a company

### [RecoveryCases](docs/sdks/recoverycases/README.md)

* [Get](docs/sdks/recoverycases/README.md#get) - Get all recovery cases for a company
* [Redebit](docs/sdks/recoverycases/README.md#redebit) - Initiate a redebit for a recovery case

### [Reports](docs/sdks/reports/README.md)

* [CreateCustom](docs/sdks/reports/README.md#createcustom) - Create a custom report
* [Get](docs/sdks/reports/README.md#get) - Get a report
* [GetTemplate](docs/sdks/reports/README.md#gettemplate) - Get a report template

### [Signatories](docs/sdks/signatories/README.md)

* [Create](docs/sdks/signatories/README.md#create) - Create a signatory
* [List](docs/sdks/signatories/README.md#list) - Get all company signatories
* [Invite](docs/sdks/signatories/README.md#invite) - Invite a signatory
* [Update](docs/sdks/signatories/README.md#update) - Update a signatory
* [Delete](docs/sdks/signatories/README.md#delete) - Delete a signatory

### [TaxRequirements](docs/sdks/taxrequirements/README.md)

* [Get](docs/sdks/taxrequirements/README.md#get) - Get State Tax Requirements
* [UpdateState](docs/sdks/taxrequirements/README.md#updatestate) - Update State Tax Requirements
* [GetAll](docs/sdks/taxrequirements/README.md#getall) - Get All Tax Requirement States

### [TimeOffPolicies](docs/sdks/timeoffpolicies/README.md)

* [CalculateAccruingTimeOffHours](docs/sdks/timeoffpolicies/README.md#calculateaccruingtimeoffhours) - Calculate accruing time off hours
* [Get](docs/sdks/timeoffpolicies/README.md#get) - Get a time off policy
* [Update](docs/sdks/timeoffpolicies/README.md#update) - Update a time off policy
* [GetAll](docs/sdks/timeoffpolicies/README.md#getall) - Get all time off policies
* [Create](docs/sdks/timeoffpolicies/README.md#create) - Create a time off policy
* [AddEmployees](docs/sdks/timeoffpolicies/README.md#addemployees) - Add employees to a time off policy
* [RemoveEmployees](docs/sdks/timeoffpolicies/README.md#removeemployees) - Remove employees from a time off policy
* [UpdateBalance](docs/sdks/timeoffpolicies/README.md#updatebalance) - Update employee time off hour balances
* [Deactivate](docs/sdks/timeoffpolicies/README.md#deactivate) - Deactivate a time off policy

### [Webhooks](docs/sdks/webhooks/README.md)

* [CreateSubscription](docs/sdks/webhooks/README.md#createsubscription) - Create a webhook subscription
* [ListSubscriptions](docs/sdks/webhooks/README.md#listsubscriptions) - List webhook subscriptions
* [UpdateSubscription](docs/sdks/webhooks/README.md#updatesubscription) - Update a webhook subscription
* [GetSubscription](docs/sdks/webhooks/README.md#getsubscription) - Get a webhook subscription
* [DeleteSubscription](docs/sdks/webhooks/README.md#deletesubscription) - Delete a webhook subscription
* [Verify](docs/sdks/webhooks/README.md#verify) - Verify the webhook subscription
* [RequestVerificationToken](docs/sdks/webhooks/README.md#requestverificationtoken) - Request the webhook subscription verification_token

### [WireInRequests](docs/sdks/wireinrequests/README.md)

* [Get](docs/sdks/wireinrequests/README.md#get) - Get a single Wire In Request
* [Submit](docs/sdks/wireinrequests/README.md#submit) - Submit a wire in request
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

| Name   | Server                       | Description |
| ------ | ---------------------------- | ----------- |
| `demo` | `https://api.gusto-demo.com` | Demo        |
| `prod` | `https://api.gusto.com`      | Prod        |

#### Example

```csharp
using GustoEmbedded;
using GustoEmbedded.Models.Components;

var sdk = new Gusto(
    server: "prod",
    companyAccessAuth: "<YOUR_BEARER_TOKEN_HERE>"
);

var res = await sdk.Introspection.GetInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

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

var res = await sdk.Introspection.GetInfoAsync(xGustoAPIVersion: VersionHeader.TwoThousandAndTwentyFour0401);

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
