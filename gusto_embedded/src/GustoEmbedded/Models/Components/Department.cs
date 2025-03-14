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
    using GustoEmbedded.Models.Components;
    using GustoEmbedded.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class Department
    {

        /// <summary>
        /// The current version of the object. See the <a href="https://docs.gusto.com/embedded-payroll/docs/idempotency">versioning guide</a> for information on how to use this field.
        /// </summary>
        [JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The UUID of the department
        /// </summary>
        [JsonProperty("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// The UUID of the company
        /// </summary>
        [JsonProperty("company_uuid")]
        public string? CompanyUuid { get; set; }

        /// <summary>
        /// Name of the department
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Array of employees assigned to the department.
        /// </summary>
        [JsonProperty("employees")]
        public List<DepartmentEmployees>? Employees { get; set; }

        /// <summary>
        /// Array of contractors assigned to the department.
        /// </summary>
        [JsonProperty("contractors")]
        public List<Models.Components.Contractors>? Contractors { get; set; }
    }
}