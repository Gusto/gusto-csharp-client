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
    using NodaTime;
    
    public class EmployeeAddress
    {

        /// <summary>
        /// The current version of the object. See the <a href="https://docs.gusto.com/embedded-payroll/docs/idempotency">versioning guide</a> for information on how to use this field.
        /// </summary>
        [JsonProperty("version")]
        public string? Version { get; set; }

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

        /// <summary>
        /// The UUID of the employee address
        /// </summary>
        [JsonProperty("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// The UUID of the employee
        /// </summary>
        [JsonProperty("employee_uuid")]
        public string? EmployeeUuid { get; set; }

        /// <summary>
        /// The date the employee started living at the address.
        /// </summary>
        [JsonProperty("effective_date")]
        public LocalDate? EffectiveDate { get; set; }

        /// <summary>
        /// Determines if home taxes should be withheld and paid for employee.
        /// </summary>
        [JsonProperty("courtesy_withholding")]
        public bool? CourtesyWithholding { get; set; }
    }
}