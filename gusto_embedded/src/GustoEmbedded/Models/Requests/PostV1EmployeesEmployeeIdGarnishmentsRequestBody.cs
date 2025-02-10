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
    using GustoEmbedded.Models.Components;
    using GustoEmbedded.Models.Requests;
    using GustoEmbedded.Utils;
    using Newtonsoft.Json;
    
    public class PostV1EmployeesEmployeeIdGarnishmentsRequestBody
    {

        /// <summary>
        /// Whether or not this garnishment is currently active.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; } = true;

        /// <summary>
        /// The amount of the garnishment. Either a percentage or a fixed dollar amount. Represented as a float, e.g. &quot;8.00&quot;.
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; } = default!;

        /// <summary>
        /// The description of the garnishment.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the garnishment is court ordered.
        /// </summary>
        [JsonProperty("court_ordered")]
        public bool CourtOrdered { get; set; } = default!;

        /// <summary>
        /// The specific type of garnishment for court ordered garnishments.
        /// </summary>
        [JsonProperty("garnishment_type")]
        public Models.Requests.GarnishmentType? GarnishmentType { get; set; } = null;

        /// <summary>
        /// The number of times to apply the garnishment. Ignored if recurring is true.
        /// </summary>
        [JsonProperty("times")]
        public long? Times { get; set; } = null;

        /// <summary>
        /// Whether the garnishment should recur indefinitely.
        /// </summary>
        [JsonProperty("recurring")]
        public bool? Recurring { get; set; } = false;

        /// <summary>
        /// The maximum deduction per annum. A null value indicates no maximum. Represented as a float, e.g. &quot;200.00&quot;.
        /// </summary>
        [JsonProperty("annual_maximum")]
        public string? AnnualMaximum { get; set; } = null;

        /// <summary>
        /// The maximum deduction per pay period. A null value indicates no maximum. Represented as a float, e.g. &quot;16.00&quot;.
        /// </summary>
        [JsonProperty("pay_period_maximum")]
        public string? PayPeriodMaximum { get; set; } = null;

        /// <summary>
        /// Whether the amount should be treated as a percentage to be deducted per pay period.
        /// </summary>
        [JsonProperty("deduct_as_percentage")]
        public bool? DeductAsPercentage { get; set; } = false;

        /// <summary>
        /// A maximum total deduction for the lifetime of this garnishment. A null value indicates no maximum.
        /// </summary>
        [JsonProperty("total_amount")]
        public string? TotalAmount { get; set; }

        /// <summary>
        /// Additional child support order details
        /// </summary>
        [JsonProperty("child_support")]
        public GarnishmentChildSupportInput? ChildSupport { get; set; } = null;
    }
}