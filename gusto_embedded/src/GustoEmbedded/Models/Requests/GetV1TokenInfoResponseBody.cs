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
    
    /// <summary>
    /// Example response
    /// </summary>
    public class GetV1TokenInfoResponseBody
    {

        /// <summary>
        /// Space delimited string of accessible scopes.
        /// </summary>
        [JsonProperty("scope")]
        public string Scope { get; set; } = default!;

        /// <summary>
        /// Information about the token resource.
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Include)]
        public Resource? Resource { get; set; }

        /// <summary>
        /// Information about the token owner
        /// </summary>
        [JsonProperty("resource_owner", NullValueHandling = NullValueHandling.Include)]
        public ResourceOwner? ResourceOwner { get; set; }
    }
}