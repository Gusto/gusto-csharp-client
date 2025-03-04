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
    using NodaTime;
    
    public class PutV1HomeAddressesHomeAddressUuidRequestBody
    {

        /// <summary>
        /// The current version of the object. See the <a href="https://docs.gusto.com/embedded-payroll/docs/versioning#object-layer">versioning guide</a> for information on how to use this field.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; } = default!;

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

        [JsonProperty("effective_date")]
        public LocalDate? EffectiveDate { get; set; }

        [JsonProperty("courtesy_withholding")]
        public bool? CourtesyWithholding { get; set; }
    }
}