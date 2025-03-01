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
    /// The representation of an unprocessed termination pay period.
    /// </summary>
    public class AccruingTimeOffHour
    {

        /// <summary>
        /// A unique identifier of the time off policy.
        /// </summary>
        [JsonProperty("time_off_policy_uuid")]
        public string? TimeOffPolicyUuid { get; set; }

        /// <summary>
        /// Hours accrued during this pay period.
        /// </summary>
        [JsonProperty("hours")]
        public string? Hours { get; set; }
    }
}