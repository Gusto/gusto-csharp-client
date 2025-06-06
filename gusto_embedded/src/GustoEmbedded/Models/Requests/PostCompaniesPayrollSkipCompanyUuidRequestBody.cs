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
    using System.Collections.Generic;
    
    public class PostCompaniesPayrollSkipCompanyUuidRequestBody
    {

        /// <summary>
        /// Payroll type
        /// </summary>
        [JsonProperty("payroll_type")]
        public Models.Requests.PayrollType PayrollType { get; set; } = default!;

        /// <summary>
        /// Pay period start date
        /// </summary>
        [JsonProperty("start_date")]
        public string? StartDate { get; set; }

        /// <summary>
        /// Pay period end date. If left empty, defaults to today&apos;s date.
        /// </summary>
        [JsonProperty("end_date")]
        public string? EndDate { get; set; }

        /// <summary>
        /// The UUID of the pay schedule
        /// </summary>
        [JsonProperty("pay_schedule_uuid")]
        public string? PayScheduleUuid { get; set; }

        /// <summary>
        /// An array of employees. This field is only applicable to new hire payroll and termination payroll
        /// </summary>
        [JsonProperty("employee_uuids")]
        public List<string>? EmployeeUuids { get; set; }
    }
}