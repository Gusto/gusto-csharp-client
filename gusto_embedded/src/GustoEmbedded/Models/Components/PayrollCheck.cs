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
    
    /// <summary>
    /// Example response
    /// </summary>
    public class PayrollCheck
    {

        /// <summary>
        /// A unique identifier of the payroll.
        /// </summary>
        [JsonProperty("payroll_uuid")]
        public string? PayrollUuid { get; set; }

        /// <summary>
        /// The format the checks will be printed.
        /// </summary>
        [JsonProperty("printing_format")]
        public string? PrintingFormat { get; set; }

        /// <summary>
        /// The starting check number for the checks being printed.
        /// </summary>
        [JsonProperty("starting_check_number")]
        public string? StartingCheckNumber { get; set; }

        /// <summary>
        /// A unique identifier of the Generated Document request
        /// </summary>
        [JsonProperty("request_uuid")]
        public string? RequestUuid { get; set; }

        /// <summary>
        /// Current status of the Generated Document
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// An array of mapping employee uuids to their check numbers
        /// </summary>
        [JsonProperty("employee_check_number_mapping")]
        public List<EmployeeCheckNumberMapping>? EmployeeCheckNumberMapping { get; set; }
    }
}