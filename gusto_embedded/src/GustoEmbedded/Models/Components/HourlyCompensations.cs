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
    
    public class HourlyCompensations
    {

        /// <summary>
        /// The name of the compensation. This also serves as the unique, immutable identifier for this compensation.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The number of hours to be compensated for this pay period.
        /// </summary>
        [JsonProperty("hours")]
        public string? Hours { get; set; }

        /// <summary>
        /// The amount of the compensation. This field is only available after the payroll is calculated and cannot be used for updating hourly compensations.
        /// </summary>
        [JsonProperty("amount")]
        public string? Amount { get; set; }

        /// <summary>
        /// The UUID of the job for the compensation.
        /// </summary>
        [JsonProperty("job_uuid")]
        public string? JobUuid { get; set; }

        /// <summary>
        /// The amount multiplied by the base rate to calculate total compensation per hour worked.
        /// </summary>
        [JsonProperty("compensation_multiplier")]
        public double? CompensationMultiplier { get; set; }

        /// <summary>
        /// The FLSA Status of the employee&apos;s primary job compensation
        /// </summary>
        [JsonProperty("flsa_status")]
        public string? FlsaStatus { get; set; }
    }
}