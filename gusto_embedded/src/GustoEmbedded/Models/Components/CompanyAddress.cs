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
    /// The representation of a company&apos;s address in Gusto.
    /// </summary>
    public class CompanyAddress
    {

        [JsonProperty("street_1")]
        public string? Street1 { get; set; }

        [JsonProperty("street_2")]
        public string? Street2 { get; set; } = null;

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("zip")]
        public string? Zip { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; } = "USA";

        /// <summary>
        /// The status of the location. Inactive locations have been deleted, but may still have historical data associated with them.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }
    }
}