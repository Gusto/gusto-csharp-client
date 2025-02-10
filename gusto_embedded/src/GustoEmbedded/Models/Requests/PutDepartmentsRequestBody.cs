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
    
    public class PutDepartmentsRequestBody
    {

        /// <summary>
        /// The current version of the object. See the <a href="https://docs.gusto.com/embedded-payroll/docs/versioning#object-layer">versioning guide</a> for information on how to use this field.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; } = default!;

        [JsonProperty("title")]
        public string? Title { get; set; }
    }
}