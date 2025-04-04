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
    /// The available company-wide compensation rates for the company.
    /// </summary>
    public class Compensations
    {

        /// <summary>
        /// The available hourly compensation rates for the company.
        /// </summary>
        [JsonProperty("hourly")]
        public List<Hourly>? Hourly { get; set; }

        /// <summary>
        /// The available fixed compensation rates for the company.
        /// </summary>
        [JsonProperty("fixed")]
        public List<Fixed>? Fixed { get; set; }

        /// <summary>
        /// The available types of paid time off for the company.
        /// </summary>
        [JsonProperty("paid_time_off")]
        public List<CompanyPaidTimeOff>? PaidTimeOff { get; set; }
    }
}