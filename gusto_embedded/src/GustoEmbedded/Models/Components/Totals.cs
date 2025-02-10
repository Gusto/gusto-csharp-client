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
    /// The subtotals for the payroll.
    /// </summary>
    public class Totals
    {

        /// <summary>
        /// The total company debit for the payroll.
        /// </summary>
        [JsonProperty("company_debit")]
        public string? CompanyDebit { get; set; }

        /// <summary>
        /// The total company net pay for the payroll.
        /// </summary>
        [JsonProperty("net_pay_debit")]
        public string? NetPayDebit { get; set; }

        /// <summary>
        /// The total child support debit for the payroll.
        /// </summary>
        [JsonProperty("child_support_debit")]
        public string? ChildSupportDebit { get; set; }

        /// <summary>
        /// The total reimbursements for the payroll.
        /// </summary>
        [JsonProperty("reimbursement_debit")]
        public string? ReimbursementDebit { get; set; }

        /// <summary>
        /// The total tax debit for the payroll.
        /// </summary>
        [JsonProperty("tax_debit")]
        public string? TaxDebit { get; set; }
    }
}