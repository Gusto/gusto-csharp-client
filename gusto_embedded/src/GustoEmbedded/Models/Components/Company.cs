//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace GustoEmbedded.Models.Components
{
    using GustoEmbedded.Models.Components;
    using GustoEmbedded.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// The representation of a company in Gusto.
    /// </summary>
    public class Company
    {

        /// <summary>
        /// The Federal Employer Identification Number of the company.
        /// </summary>
        [JsonProperty("ein")]
        public string? Ein { get; set; }

        /// <summary>
        /// The tax payer type of the company.
        /// </summary>
        [JsonProperty("entity_type")]
        public Models.Components.EntityType? EntityType { get; set; } = null;

        /// <summary>
        /// Whether the company only supports contractors.
        /// </summary>
        [JsonProperty("contractor_only")]
        public bool? ContractorOnly { get; set; }

        /// <summary>
        /// The Gusto product tier of the company (not applicable to Embedded partner managed companies).
        /// </summary>
        [JsonProperty("tier")]
        public Tier? Tier { get; set; } = null;

        /// <summary>
        /// Whether or not the company is suspended in Gusto. Suspended companies may not run payroll.
        /// </summary>
        [JsonProperty("is_suspended")]
        public bool? IsSuspended { get; set; }

        /// <summary>
        /// The status of the company in Gusto. &quot;Approved&quot; companies are approved to run payroll from a risk and compliance perspective. However, an approved company may still need to resolve other <a href="https://docs.gusto.com/embedded-payroll/docs/payroll-blockers">payroll blockers</a> to be able to run payroll. &quot;Not Approved&quot; companies may not yet run payroll with Gusto and may need to complete onboarding or contact support. &quot;Suspended&quot; companies may not run payroll with Gusto. In order to unsuspend their account, the company must contact support.
        /// </summary>
        [JsonProperty("company_status")]
        public CompanyStatus? CompanyStatus { get; set; }

        /// <summary>
        /// A unique identifier of the company in Gusto.
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// The name of the company.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The slug of the name of the company.
        /// </summary>
        [JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// The trade name of the company.
        /// </summary>
        [JsonProperty("trade_name")]
        public string? TradeName { get; set; } = null;

        /// <summary>
        /// Whether the company is fully managed by a partner via the API
        /// </summary>
        [JsonProperty("is_partner_managed")]
        public bool? IsPartnerManaged { get; set; }

        /// <summary>
        /// The pay schedule assignment type.
        /// </summary>
        [JsonProperty("pay_schedule_type")]
        public PayScheduleType? PayScheduleType { get; set; } = null;

        /// <summary>
        /// Company&apos;s first invoiceable event date
        /// </summary>
        [JsonProperty("join_date")]
        public string? JoinDate { get; set; } = null;

        /// <summary>
        /// Company&apos;s default funding type
        /// </summary>
        [JsonProperty("funding_type")]
        public FundingType? FundingType { get; set; } = null;

        /// <summary>
        /// The locations of the company.
        /// </summary>
        [JsonProperty("locations")]
        public List<CompanyAddress>? Locations { get; set; }

        /// <summary>
        /// The available company-wide compensation rates for the company.
        /// </summary>
        [JsonProperty("compensations")]
        public Models.Components.Compensations? Compensations { get; set; }

        /// <summary>
        /// The primary signatory of the company.
        /// </summary>
        [JsonProperty("primary_signatory")]
        public PrimarySignatory? PrimarySignatory { get; set; } = null;

        /// <summary>
        /// The primary payroll admin of the company.
        /// </summary>
        [JsonProperty("primary_payroll_admin")]
        public PrimaryPayrollAdmin? PrimaryPayrollAdmin { get; set; }
    }
}