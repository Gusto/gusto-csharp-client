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
    
    public class PutV1TerminationsEmployeeIdRequestBody
    {

        /// <summary>
        /// The current version of the object. See the <a href="https://docs.gusto.com/embedded-payroll/docs/idempotency">versioning guide</a> for information on how to use this field.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; } = default!;

        /// <summary>
        /// The employee&apos;s last day of work.
        /// </summary>
        [JsonProperty("effective_date")]
        public string EffectiveDate { get; set; } = default!;

        /// <summary>
        /// If true, the employee should receive their final wages via an off-cycle payroll. If false, they should receive their final wages on their current pay schedule.
        /// </summary>
        [JsonProperty("run_termination_payroll")]
        public bool? RunTerminationPayroll { get; set; }
    }
}