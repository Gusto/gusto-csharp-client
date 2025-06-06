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
    
    public class PostV1SandboxGenerateW2RequestBody
    {

        /// <summary>
        /// The employee UUID.
        /// </summary>
        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; } = default!;

        /// <summary>
        /// Must be equal to or more recent than 2015. If not specified, defaults to the previous year.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("year")]
        public long? Year { get; set; }
    }
}