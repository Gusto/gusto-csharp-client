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
    
    public class PostV1CompaniesCompanyIdEarningTypesRequestBody
    {

        /// <summary>
        /// The name of the custom earning type.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;
    }
}