//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace GustoEmbedded.Models.Requests
{
    using GustoEmbedded.Utils;
    using Newtonsoft.Json;
    
    /// <summary>
    /// An array of benefits for the employee. Depends on your company selections, benefits include 401k, health insurance and more.
    /// </summary>
    public class Benefits
    {

        /// <summary>
        /// Company contribution amount towards the benefit
        /// </summary>
        [JsonProperty("company_contribution_amount")]
        public string? CompanyContributionAmount { get; set; }

        /// <summary>
        /// Employee deduction amount towards the benefit
        /// </summary>
        [JsonProperty("employee_deduction_amount")]
        public string? EmployeeDeductionAmount { get; set; }

        /// <summary>
        /// The ID of the benefit.
        /// </summary>
        [JsonProperty("benefit_id")]
        public long? BenefitId { get; set; }
    }
}