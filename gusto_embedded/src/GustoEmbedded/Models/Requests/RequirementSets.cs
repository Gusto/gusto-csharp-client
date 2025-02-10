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
    using GustoEmbedded.Models.Requests;
    using GustoEmbedded.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class RequirementSets
    {

        /// <summary>
        /// An identifier for a set of requirements. A list of requirement sets can contain multiple sets with the same `key` and different `effective_from` values.
        /// </summary>
        [JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// An ISO 8601 formatted date representing the date values became effective. Some requirement sets are effective dated, while others are not. Multiple requirement sets for the same state/key can/will exist with unique effective dates. If a requirement set is has an `effective_from` value, all requirement sets with the same key will also have an `effective_from` value.
        /// </summary>
        [JsonProperty("effective_from")]
        public string? EffectiveFrom { get; set; } = null;

        /// <summary>
        /// One of the two-letter state abbreviations for the fifty United States and the District of Columbia (DC)
        /// </summary>
        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("requirements")]
        public List<Models.Requests.Requirements>? Requirements { get; set; }
    }
}