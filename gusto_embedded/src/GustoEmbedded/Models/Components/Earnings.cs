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
    
    public class Earnings
    {

        [JsonProperty("amount")]
        public string? Amount { get; set; }

        [JsonProperty("hours")]
        public string? Hours { get; set; }

        [JsonProperty("earning_type")]
        public string? EarningType { get; set; }

        [JsonProperty("earning_id")]
        public long? EarningId { get; set; }
    }
}