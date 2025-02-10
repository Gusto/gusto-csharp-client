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
    
    public class EmployeeStateTaxes
    {

        /// <summary>
        /// Whether this job is eligible for workers&apos; compensation coverage in the states of Washington (WA) or Wyoming (WY).
        /// </summary>
        [JsonProperty("wc_covered")]
        public bool? WcCovered { get; set; }

        /// <summary>
        /// The risk class code for workers&apos; compensation in Washington or Wyoming state. For Washington, visit <a href="https://www.lni.wa.gov/insurance/rates-risk-classes/risk-classes-for-workers-compensation/risk-class-lookup#/">Washington state&apos;s Risk Class page</a> to learn more. For Wyoming you can search for the code online using <a href="https://dws.wyo.gov/dws-division/workers-compensation/">WY Workforce Services website</a> or call the agency at (307) 235-3217.
        /// </summary>
        [JsonProperty("wc_class_code")]
        public string? WcClassCode { get; set; }
    }
}