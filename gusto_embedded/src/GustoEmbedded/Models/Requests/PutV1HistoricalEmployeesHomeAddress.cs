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
    
    public class PutV1HistoricalEmployeesHomeAddress
    {

        [JsonProperty("street_1")]
        public string Street1 { get; set; } = default!;

        [JsonProperty("street_2")]
        public string? Street2 { get; set; } = null;

        [JsonProperty("city")]
        public string City { get; set; } = default!;

        [JsonProperty("state")]
        public string State { get; set; } = default!;

        [JsonProperty("zip")]
        public string Zip { get; set; } = default!;
    }
}