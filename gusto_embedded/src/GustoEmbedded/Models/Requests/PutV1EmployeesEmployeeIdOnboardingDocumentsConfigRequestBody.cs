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
    
    public class PutV1EmployeesEmployeeIdOnboardingDocumentsConfigRequestBody
    {

        /// <summary>
        /// Whether to include Form I-9 for an employee during onboarding
        /// </summary>
        [JsonProperty("i9_document")]
        public bool? I9Document { get; set; }
    }
}