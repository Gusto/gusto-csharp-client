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
    /// A single tier of a tiered matching scheme.
    /// </summary>
    public class Two
    {

        /// <summary>
        /// The percentage of employee deduction within this tier the company contribution will match.
        /// </summary>
        [JsonProperty("rate")]
        public string? Rate { get; set; }

        /// <summary>
        /// The percentage threshold at which this tier ends (inclusive).<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// For example, a value of &quot;5&quot; means the company contribution will match employee deductions from the previous tier&apos;s threshold up to and including 5% of payroll.<br/>
        /// <br/>
        /// If this is the first tier, a value of &quot;5&quot; means the company contribution will match employee deductions from 0% up to and including 5% of payroll.
        /// </remarks>
        /// </summary>
        [JsonProperty("threshold")]
        public string? Threshold { get; set; }
    }
}