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
    using NodaTime;
    
    /// <summary>
    /// Representation of a Minimum Wage
    /// </summary>
    public class MinimumWage
    {

        /// <summary>
        /// unique identifier of a minimum wage
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// The wage rate for a minimum wage record. Represented as a float, e.g. &quot;15.0&quot;.
        /// </summary>
        [JsonProperty("wage")]
        public string Wage { get; set; } = default!;

        /// <summary>
        /// The type of wage the minimum wage applies to, e.g. &quot;Regular&quot;, &quot;Regular-Industry-Specific&quot;.
        /// </summary>
        [JsonProperty("wage_type")]
        public string WageType { get; set; } = default!;

        /// <summary>
        /// The date the minimum wage rule is effective on.
        /// </summary>
        [JsonProperty("effective_date")]
        public LocalDate EffectiveDate { get; set; } = default!;

        /// <summary>
        /// The governing authority that created the minimum wage, e.g. &quot;City&quot;, &quot;State&quot;, or &quot;Federal&quot;.
        /// </summary>
        [JsonProperty("authority")]
        public string Authority { get; set; } = default!;

        /// <summary>
        /// Description of parties the minimum wage applies to.
        /// </summary>
        [JsonProperty("notes")]
        public string? Notes { get; set; }
    }
}