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
    
    /// <summary>
    /// Additional child support order details
    /// </summary>
    public class GarnishmentChildSupport
    {

        /// <summary>
        /// The two letter state abbreviation for the state issuing the child support order. Agency data is available in the `GET /v1/garnishments/child_support` API.
        /// </summary>
        [JsonProperty("state")]
        public string? State { get; set; }

        /// <summary>
        /// How often the agency collects the withholding amount. e.g. $500 monthly -&gt; `Monthly`.
        /// </summary>
        [JsonProperty("payment_period")]
        public PaymentPeriod? PaymentPeriod { get; set; }

        /// <summary>
        /// The FIPS code associated with the state or county agency issuing the child support order. Agency data is available in the `GET /v1/garnishments/child_support` API.
        /// </summary>
        [JsonProperty("fips_code")]
        public string? FipsCode { get; set; }

        /// <summary>
        /// Child Support Enforcement Case Number associated with this child support obligation - required for most states. Agency specific requirements are available in the `GET /v1/garnishments/child_support` API.
        /// </summary>
        [JsonProperty("case_number")]
        public string? CaseNumber { get; set; } = null;

        /// <summary>
        /// Order Identifier or Order ID associated with this child support obligation - required for some states. Agency specific requirements are available in the `GET /v1/garnishments/child_support` API.
        /// </summary>
        [JsonProperty("order_number")]
        public string? OrderNumber { get; set; } = null;

        /// <summary>
        /// Child Support Enforcement Remittance ID associated with this child support obligation - required for some states. Agency specific requirements are available in the `GET /v1/garnishments/child_support` API.
        /// </summary>
        [JsonProperty("remittance_number")]
        public string? RemittanceNumber { get; set; } = null;
    }
}