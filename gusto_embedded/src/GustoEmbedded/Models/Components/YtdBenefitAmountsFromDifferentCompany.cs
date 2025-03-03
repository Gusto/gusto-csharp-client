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
    using GustoEmbedded.Utils;
    using Newtonsoft.Json;
    
    /// <summary>
    /// Ytd Benefit Amounts From Different Company
    /// </summary>
    public class YtdBenefitAmountsFromDifferentCompany
    {

        /// <summary>
        /// The unique identifier for this benefit amount record.
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// The benefit type supported by Gusto. See <a href="https://docs.gusto.com/embedded-payroll/reference/get-v1-benefits">Benefit Types</a> for more information.
        /// </summary>
        [JsonProperty("benefit_type")]
        public long BenefitType { get; set; } = default!;

        /// <summary>
        /// The year-to-date employee deduction made outside the current company.
        /// </summary>
        [JsonProperty("ytd_employee_deduction_amount")]
        public string YtdEmployeeDeductionAmount { get; set; } = default!;

        /// <summary>
        /// The year-to-date company contribution made outside the current company.
        /// </summary>
        [JsonProperty("ytd_company_contribution_amount")]
        public string YtdCompanyContributionAmount { get; set; } = default!;
    }
}