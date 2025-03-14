//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace GustoEmbedded.Models.Errors
{
    using GustoEmbedded.Models.Errors;
    using GustoEmbedded.Utils;
    using Newtonsoft.Json;
    
    public class Errors
    {

        /// <summary>
        /// The string &quot;base&quot;
        /// </summary>
        [JsonProperty("error_key")]
        public string? ErrorKey { get; set; }

        /// <summary>
        /// The string &quot;payroll_blocker&quot;
        /// </summary>
        [JsonProperty("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Human readable description of the payroll blocker
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("metadata")]
        public Models.Errors.Metadata? Metadata { get; set; }
    }
}