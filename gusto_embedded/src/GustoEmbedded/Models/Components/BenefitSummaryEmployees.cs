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
    
    public class BenefitSummaryEmployees
    {

        /// <summary>
        /// The UUID of the employee
        /// </summary>
        [JsonProperty("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// The sum of employee deduction for this employee given the period of time and the specific company benefit.
        /// </summary>
        [JsonProperty("company_benefit_deduction")]
        public string? CompanyBenefitDeduction { get; set; }

        /// <summary>
        /// The sum of company contribution for this employee given the period of time and the specific company benefit.
        /// </summary>
        [JsonProperty("company_benefit_contribution")]
        public string? CompanyBenefitContribution { get; set; }

        /// <summary>
        /// The sum of employee benefit deduction for this employee given the period of time and the benefit type.
        /// </summary>
        [JsonProperty("benefit_deduction")]
        public string? BenefitDeduction { get; set; }

        /// <summary>
        /// The sum of company contribution for this employee given the period of time and the benefit type.
        /// </summary>
        [JsonProperty("benefit_contribution")]
        public string? BenefitContribution { get; set; }

        /// <summary>
        /// Gross pay for this employee given the period of time.
        /// </summary>
        [JsonProperty("gross_pay")]
        public string? GrossPay { get; set; }

        /// <summary>
        /// Total imputed pay for this employee given the period of time (not scoped to a benefit type).
        /// </summary>
        [JsonProperty("imputed_pay")]
        public string? ImputedPay { get; set; }

        [JsonProperty("payroll_benefits")]
        public PayrollBenefits? PayrollBenefits { get; set; }
    }
}