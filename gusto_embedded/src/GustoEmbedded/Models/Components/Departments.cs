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
    
    public class Departments
    {

        /// <summary>
        /// Department UUID
        /// </summary>
        [JsonProperty("department_uuid")]
        public string? DepartmentUuid { get; set; }

        /// <summary>
        /// Pay schedule UUID
        /// </summary>
        [JsonProperty("pay_schedule_uuid")]
        public string? PayScheduleUuid { get; set; }
    }
}