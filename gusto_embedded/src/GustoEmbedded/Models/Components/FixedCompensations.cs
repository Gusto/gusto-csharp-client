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
    
    public class FixedCompensations
    {

        /// <summary>
        /// The name of the compensation. This also serves as the unique, immutable identifier for this compensation.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The amount of the compensation for the pay period.
        /// </summary>
        [JsonProperty("amount")]
        public string? Amount { get; set; }

        /// <summary>
        /// The UUID of the job for the compensation.
        /// </summary>
        [JsonProperty("job_uuid")]
        public string? JobUuid { get; set; }
    }
}