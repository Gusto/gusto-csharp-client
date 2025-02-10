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
    /// An object representing the type and value of the company contribution.
    /// </summary>
    public class CompanyBenefitWithEmployeeBenefitsContribution
    {

        /// <summary>
        /// The company contribution scheme.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// &quot;amount&quot;: The company contributes a fixed amount per payroll. If elective is true, the contribution is matching, dollar-for-dollar.<br/>
        /// <br/>
        /// &quot;percentage&quot;: The company contributes a percentage of the payroll amount per payroll period. If elective is true, the contribution is matching, dollar-for-dollar.<br/>
        /// <br/>
        /// &quot;tiered&quot;: The company contribution varies according to the size of the employee deduction.
        /// </remarks>
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// For the `amount` and `percentage` contribution types, the value of the corresponding amount or percentage.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// For the `tiered` contribution type, an array of tiers.
        /// </remarks>
        /// </summary>
        [JsonProperty("value")]
        public CompanyBenefitWithEmployeeBenefitsValue? Value { get; set; }
    }
}