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
    /// List of employee work addresses
    /// </summary>
    public class EmployeeWorkAddress
    {

        /// <summary>
        /// The unique identifier of this work address.
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// The date the employee began working at this location.
        /// </summary>
        [JsonProperty("effective_date")]
        public string? EffectiveDate { get; set; }

        /// <summary>
        /// Signifies if this address is the active work address for the current date
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// UUID reference to the company location for this work address.
        /// </summary>
        [JsonProperty("location_uuid")]
        public string? LocationUuid { get; set; }

        /// <summary>
        /// UUID reference to the employee for this work address.
        /// </summary>
        [JsonProperty("employee_uuid")]
        public string? EmployeeUuid { get; set; }

        /// <summary>
        /// The current version of the object. See the <a href="https://docs.gusto.com/embedded-payroll/docs/idempotency">versioning guide</a> for information on how to use this field.
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

        [JsonProperty("country")]
        public string? Country { get; set; } = "USA";
    }
}