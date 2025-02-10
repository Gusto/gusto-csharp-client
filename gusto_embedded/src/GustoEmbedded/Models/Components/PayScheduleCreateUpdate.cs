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
    
    /// <summary>
    /// The representation of a pay schedule.
    /// </summary>
    public class PayScheduleCreateUpdate
    {

        /// <summary>
        /// The unique identifier of the pay schedule in Gusto.
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// The frequency that employees on this pay schedule are paid with Gusto.
        /// </summary>
        [JsonProperty("frequency")]
        public PayScheduleFrequencyCreateUpdate? Frequency { get; set; }

        /// <summary>
        /// The first date that employees on this pay schedule are paid with Gusto.
        /// </summary>
        [JsonProperty("anchor_pay_date")]
        public string? AnchorPayDate { get; set; }

        /// <summary>
        /// The last date of the first pay period. This can be the same date as the anchor pay date.
        /// </summary>
        [JsonProperty("anchor_end_of_pay_period")]
        public string? AnchorEndOfPayPeriod { get; set; }

        /// <summary>
        /// An integer between 1 and 31 indicating the first day of the month that employees are paid. This field is only relevant for pay schedules with the “Twice per month” and “Monthly” frequencies. It will be null for pay schedules with other frequencies.
        /// </summary>
        [JsonProperty("day_1")]
        public long? Day1 { get; set; } = null;

        /// <summary>
        /// An integer between 1 and 31 indicating the second day of the month that employees are paid. This field is the second pay date for pay schedules with the &quot;Twice per month&quot; frequency. For semi-monthly pay schedules, this field should be set to 31. For months shorter than 31 days, we will set the second pay date to the last day of the month. It will be null for pay schedules with other frequencies.
        /// </summary>
        [JsonProperty("day_2")]
        public long? Day2 { get; set; } = null;

        /// <summary>
        /// This field will be hourly when the pay schedule is for hourly employees, salaried when the pay schedule is for salaried employees, the department name if pay schedule is by department, and null when the pay schedule is for all employees.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        /// <summary>
        /// A custom name for a pay schedule, defaults to the pay frequency description.
        /// </summary>
        [JsonProperty("custom_name")]
        public string? CustomName { get; set; }

        /// <summary>
        /// With Autopilot® enabled, payroll will run automatically one day before your payroll deadlines.
        /// </summary>
        [JsonProperty("auto_pilot")]
        public bool? AutoPilot { get; set; }

        /// <summary>
        /// Whether this pay schedule is associated with any employees. A pay schedule is inactive when it&apos;s unassigned.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }
    }
}