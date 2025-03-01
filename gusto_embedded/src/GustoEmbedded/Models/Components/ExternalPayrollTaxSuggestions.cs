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
    /// The representation of an external payroll with minimal information.
    /// </summary>
    public class ExternalPayrollTaxSuggestions
    {

        /// <summary>
        /// The UUID of the employee.
        /// </summary>
        [JsonProperty("employee_uuid")]
        public string? EmployeeUuid { get; set; }

        /// <summary>
        /// Possible tax liabilities selections.
        /// </summary>
        [JsonProperty("tax_suggestions")]
        public List<TaxSuggestions>? TaxSuggestions { get; set; }
    }
}