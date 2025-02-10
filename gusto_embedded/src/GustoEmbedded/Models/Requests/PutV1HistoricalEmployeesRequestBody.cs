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
    /// Update a historical employee.
    /// </summary>
    public class PutV1HistoricalEmployeesRequestBody
    {

        /// <summary>
        /// The current version of the object. See the <a href="https://docs.gusto.com/embedded-payroll/docs/idempotency">versioning guide</a> for information on how to use this field.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; } = default!;

        [JsonProperty("first_name")]
        public string FirstName { get; set; } = default!;

        [JsonProperty("middle_initial")]
        public string? MiddleInitial { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; } = default!;

        [JsonProperty("preferred_first_name")]
        public string? PreferredFirstName { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; } = default!;

        [JsonProperty("ssn")]
        public string Ssn { get; set; } = default!;

        [JsonProperty("work_address")]
        public Models.Requests.WorkAddress WorkAddress { get; set; } = default!;

        [JsonProperty("home_address")]
        public PutV1HistoricalEmployeesHomeAddress HomeAddress { get; set; } = default!;

        [JsonProperty("termination")]
        public Models.Requests.Termination Termination { get; set; } = default!;

        /// <summary>
        /// Optional. If provided, the email address will be saved to the employee.
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("job")]
        public Models.Requests.Job Job { get; set; } = default!;

        [JsonProperty("employee_state_taxes")]
        public Models.Requests.EmployeeStateTaxes? EmployeeStateTaxes { get; set; }
    }
}