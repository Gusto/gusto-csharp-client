//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace GustoEmbedded
{
    using GustoEmbedded.Hooks;
    using GustoEmbedded.Models.Components;
    using GustoEmbedded.Models.Errors;
    using GustoEmbedded.Utils;
    using GustoEmbedded.Utils.Retries;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// Gusto API: Welcome to Gusto&apos;s Embedded Payroll API documentation!
    /// </summary>
    public interface IGusto
    {
        public IIntrospection Introspection { get; }
        public ICompanies Companies { get; }
        public IInvoices Invoices { get; }
        public ICompanyAttachments CompanyAttachments { get; }
        public ICompanyAttachment CompanyAttachment { get; }
        public IFederalTaxDetails FederalTaxDetails { get; }
        public IIndustrySelection IndustrySelection { get; }
        public ISignatories Signatories { get; }
        public IFlows Flows { get; }
        public ILocations Locations { get; }
        public IBankAccounts BankAccounts { get; }
        public IExternalPayrolls ExternalPayrolls { get; }
        public IPaymentConfigs PaymentConfigs { get; }
        public IPaySchedules PaySchedules { get; }
        public IEmployees Employees { get; }
        public IHistoricalEmployees HistoricalEmployees { get; }
        public IDepartments Departments { get; }
        public IEmployeeEmployments EmployeeEmployments { get; }
        public IEmployeeAddresses EmployeeAddresses { get; }
        public IEmployeeTaxSetup EmployeeTaxSetup { get; }
        public IEmployeePaymentMethod EmployeePaymentMethod { get; }
        public IEmployeePaymentMethods EmployeePaymentMethods { get; }
        public IJobsAndCompensations JobsAndCompensations { get; }
        public IEarningTypes EarningTypes { get; }
        public IContractors Contractors { get; }
        public IContractorPaymentMethods ContractorPaymentMethods { get; }
        public IContractorPaymentMethod ContractorPaymentMethod { get; }
        public IWebhooks Webhooks { get; }
        public IContractorForms ContractorForms { get; }
        public IContractorDocuments ContractorDocuments { get; }
        public IEmployeeForms EmployeeForms { get; }
        public IPayrolls Payrolls { get; }
        public ITimeOffPolicies TimeOffPolicies { get; }
        public IContractorPayments ContractorPayments { get; }
        public IContractorPaymentGroups ContractorPaymentGroups { get; }
        public ICompanyForms CompanyForms { get; }
        public IGeneratedDocuments GeneratedDocuments { get; }
        public IReports Reports { get; }
        public ICompanyBenefits CompanyBenefits { get; }
        public IEmployeeBenefits EmployeeBenefits { get; }
        public IGarnishments Garnishments { get; }
        public II9Verification I9Verification { get; }
        public ITaxRequirements TaxRequirements { get; }
        public IHolidayPayPolicies HolidayPayPolicies { get; }
        public INotifications Notifications { get; }
        public IEvents Events { get; }
        public IRecoveryCases RecoveryCases { get; }
        public IAchTransactions AchTransactions { get; }
        public IWireInRequests WireInRequests { get; }
    }

    public class SDKConfig
    {
        /// <summary>
        /// Server identifiers available to the SDK.
        /// </summary>
        public enum Server {
        Demo,
        Prod,
        }

        /// <summary>
        /// Server URLs available to the SDK.
        /// </summary>
        public static readonly Dictionary<Server, string> ServerMap = new Dictionary<Server, string>()
        {
            { Server.Demo, "https://api.gusto-demo.com" },
            { Server.Prod, "https://api.gusto.com" },
        };

        public string ServerUrl = "";
        public Server? ServerName = null;
        public SDKHooks Hooks = new SDKHooks();
        public RetryConfig? RetryConfig = null;

        public string GetTemplatedServerUrl()
        {
            if (!String.IsNullOrEmpty(this.ServerUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.ServerUrl, "/"), new Dictionary<string, string>());
            }
            if (this.ServerName is null)
            {
                this.ServerName = SDKConfig.Server.Demo;
            }
            else if (!SDKConfig.ServerMap.ContainsKey(this.ServerName.Value))
            {
                throw new Exception($"Invalid server \"{this.ServerName.Value}\"");
            }

            Dictionary<string, string> serverDefault = new Dictionary<string, string>();

            return Utilities.TemplateUrl(SDKConfig.ServerMap[this.ServerName.Value], serverDefault);
        }

        public ISpeakeasyHttpClient InitHooks(ISpeakeasyHttpClient client)
        {
            string preHooksUrl = GetTemplatedServerUrl();
            var (postHooksUrl, postHooksClient) = this.Hooks.SDKInit(preHooksUrl, client);
            if (preHooksUrl != postHooksUrl)
            {
                this.ServerUrl = postHooksUrl;
            }
            return postHooksClient;
        }
    }

    /// <summary>
    /// Gusto API: Welcome to Gusto&apos;s Embedded Payroll API documentation!
    /// </summary>
    public class Gusto: IGusto
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.11";
        private const string _sdkGenVersion = "2.539.1";
        private const string _openapiDocVersion = "2024-04-01";
        private const string _userAgent = "speakeasy-sdk/csharp 0.0.11 2.539.1 2024-04-01 GustoEmbedded";
        private string _serverUrl = "";
        private SDKConfig.Server? _server = null;
        private ISpeakeasyHttpClient _client;
        private Func<GustoEmbedded.Models.Components.Security>? _securitySource;
        public IIntrospection Introspection { get; private set; }
        public ICompanies Companies { get; private set; }
        public IInvoices Invoices { get; private set; }
        public ICompanyAttachments CompanyAttachments { get; private set; }
        public ICompanyAttachment CompanyAttachment { get; private set; }
        public IFederalTaxDetails FederalTaxDetails { get; private set; }
        public IIndustrySelection IndustrySelection { get; private set; }
        public ISignatories Signatories { get; private set; }
        public IFlows Flows { get; private set; }
        public ILocations Locations { get; private set; }
        public IBankAccounts BankAccounts { get; private set; }
        public IExternalPayrolls ExternalPayrolls { get; private set; }
        public IPaymentConfigs PaymentConfigs { get; private set; }
        public IPaySchedules PaySchedules { get; private set; }
        public IEmployees Employees { get; private set; }
        public IHistoricalEmployees HistoricalEmployees { get; private set; }
        public IDepartments Departments { get; private set; }
        public IEmployeeEmployments EmployeeEmployments { get; private set; }
        public IEmployeeAddresses EmployeeAddresses { get; private set; }
        public IEmployeeTaxSetup EmployeeTaxSetup { get; private set; }
        public IEmployeePaymentMethod EmployeePaymentMethod { get; private set; }
        public IEmployeePaymentMethods EmployeePaymentMethods { get; private set; }
        public IJobsAndCompensations JobsAndCompensations { get; private set; }
        public IEarningTypes EarningTypes { get; private set; }
        public IContractors Contractors { get; private set; }
        public IContractorPaymentMethods ContractorPaymentMethods { get; private set; }
        public IContractorPaymentMethod ContractorPaymentMethod { get; private set; }
        public IWebhooks Webhooks { get; private set; }
        public IContractorForms ContractorForms { get; private set; }
        public IContractorDocuments ContractorDocuments { get; private set; }
        public IEmployeeForms EmployeeForms { get; private set; }
        public IPayrolls Payrolls { get; private set; }
        public ITimeOffPolicies TimeOffPolicies { get; private set; }
        public IContractorPayments ContractorPayments { get; private set; }
        public IContractorPaymentGroups ContractorPaymentGroups { get; private set; }
        public ICompanyForms CompanyForms { get; private set; }
        public IGeneratedDocuments GeneratedDocuments { get; private set; }
        public IReports Reports { get; private set; }
        public ICompanyBenefits CompanyBenefits { get; private set; }
        public IEmployeeBenefits EmployeeBenefits { get; private set; }
        public IGarnishments Garnishments { get; private set; }
        public II9Verification I9Verification { get; private set; }
        public ITaxRequirements TaxRequirements { get; private set; }
        public IHolidayPayPolicies HolidayPayPolicies { get; private set; }
        public INotifications Notifications { get; private set; }
        public IEvents Events { get; private set; }
        public IRecoveryCases RecoveryCases { get; private set; }
        public IAchTransactions AchTransactions { get; private set; }
        public IWireInRequests WireInRequests { get; private set; }

        public Gusto(string? companyAccessAuth = null, Func<string>? companyAccessAuthSource = null, SDKConfig.Server? server = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null, RetryConfig? retryConfig = null)
        {
            if (server != null)
            {
              _server = server;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _client = client ?? new SpeakeasyHttpClient();

            if(companyAccessAuthSource != null)
            {
                _securitySource = () => new GustoEmbedded.Models.Components.Security() { CompanyAccessAuth = companyAccessAuthSource() };
            }
            else if(companyAccessAuth != null)
            {
                _securitySource = () => new GustoEmbedded.Models.Components.Security() { CompanyAccessAuth = companyAccessAuth };
            }

            SDKConfiguration = new SDKConfig()
            {
                ServerName = _server,
                ServerUrl = _serverUrl,
                RetryConfig = retryConfig
            };

            _client = SDKConfiguration.InitHooks(_client);


            Introspection = new Introspection(_client, _securitySource, _serverUrl, SDKConfiguration);


            Companies = new Companies(_client, _securitySource, _serverUrl, SDKConfiguration);


            Invoices = new Invoices(_client, _securitySource, _serverUrl, SDKConfiguration);


            CompanyAttachments = new CompanyAttachments(_client, _securitySource, _serverUrl, SDKConfiguration);


            CompanyAttachment = new CompanyAttachment(_client, _securitySource, _serverUrl, SDKConfiguration);


            FederalTaxDetails = new FederalTaxDetails(_client, _securitySource, _serverUrl, SDKConfiguration);


            IndustrySelection = new IndustrySelection(_client, _securitySource, _serverUrl, SDKConfiguration);


            Signatories = new Signatories(_client, _securitySource, _serverUrl, SDKConfiguration);


            Flows = new Flows(_client, _securitySource, _serverUrl, SDKConfiguration);


            Locations = new Locations(_client, _securitySource, _serverUrl, SDKConfiguration);


            BankAccounts = new BankAccounts(_client, _securitySource, _serverUrl, SDKConfiguration);


            ExternalPayrolls = new ExternalPayrolls(_client, _securitySource, _serverUrl, SDKConfiguration);


            PaymentConfigs = new PaymentConfigs(_client, _securitySource, _serverUrl, SDKConfiguration);


            PaySchedules = new PaySchedules(_client, _securitySource, _serverUrl, SDKConfiguration);


            Employees = new Employees(_client, _securitySource, _serverUrl, SDKConfiguration);


            HistoricalEmployees = new HistoricalEmployees(_client, _securitySource, _serverUrl, SDKConfiguration);


            Departments = new Departments(_client, _securitySource, _serverUrl, SDKConfiguration);


            EmployeeEmployments = new EmployeeEmployments(_client, _securitySource, _serverUrl, SDKConfiguration);


            EmployeeAddresses = new EmployeeAddresses(_client, _securitySource, _serverUrl, SDKConfiguration);


            EmployeeTaxSetup = new EmployeeTaxSetup(_client, _securitySource, _serverUrl, SDKConfiguration);


            EmployeePaymentMethod = new EmployeePaymentMethod(_client, _securitySource, _serverUrl, SDKConfiguration);


            EmployeePaymentMethods = new EmployeePaymentMethods(_client, _securitySource, _serverUrl, SDKConfiguration);


            JobsAndCompensations = new JobsAndCompensations(_client, _securitySource, _serverUrl, SDKConfiguration);


            EarningTypes = new EarningTypes(_client, _securitySource, _serverUrl, SDKConfiguration);


            Contractors = new Contractors(_client, _securitySource, _serverUrl, SDKConfiguration);


            ContractorPaymentMethods = new ContractorPaymentMethods(_client, _securitySource, _serverUrl, SDKConfiguration);


            ContractorPaymentMethod = new ContractorPaymentMethod(_client, _securitySource, _serverUrl, SDKConfiguration);


            Webhooks = new Webhooks(_client, _securitySource, _serverUrl, SDKConfiguration);


            ContractorForms = new ContractorForms(_client, _securitySource, _serverUrl, SDKConfiguration);


            ContractorDocuments = new ContractorDocuments(_client, _securitySource, _serverUrl, SDKConfiguration);


            EmployeeForms = new EmployeeForms(_client, _securitySource, _serverUrl, SDKConfiguration);


            Payrolls = new Payrolls(_client, _securitySource, _serverUrl, SDKConfiguration);


            TimeOffPolicies = new TimeOffPolicies(_client, _securitySource, _serverUrl, SDKConfiguration);


            ContractorPayments = new ContractorPayments(_client, _securitySource, _serverUrl, SDKConfiguration);


            ContractorPaymentGroups = new ContractorPaymentGroups(_client, _securitySource, _serverUrl, SDKConfiguration);


            CompanyForms = new CompanyForms(_client, _securitySource, _serverUrl, SDKConfiguration);


            GeneratedDocuments = new GeneratedDocuments(_client, _securitySource, _serverUrl, SDKConfiguration);


            Reports = new Reports(_client, _securitySource, _serverUrl, SDKConfiguration);


            CompanyBenefits = new CompanyBenefits(_client, _securitySource, _serverUrl, SDKConfiguration);


            EmployeeBenefits = new EmployeeBenefits(_client, _securitySource, _serverUrl, SDKConfiguration);


            Garnishments = new Garnishments(_client, _securitySource, _serverUrl, SDKConfiguration);


            I9Verification = new I9Verification(_client, _securitySource, _serverUrl, SDKConfiguration);


            TaxRequirements = new TaxRequirements(_client, _securitySource, _serverUrl, SDKConfiguration);


            HolidayPayPolicies = new HolidayPayPolicies(_client, _securitySource, _serverUrl, SDKConfiguration);


            Notifications = new Notifications(_client, _securitySource, _serverUrl, SDKConfiguration);


            Events = new Events(_client, _securitySource, _serverUrl, SDKConfiguration);


            RecoveryCases = new RecoveryCases(_client, _securitySource, _serverUrl, SDKConfiguration);


            AchTransactions = new AchTransactions(_client, _securitySource, _serverUrl, SDKConfiguration);


            WireInRequests = new WireInRequests(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}