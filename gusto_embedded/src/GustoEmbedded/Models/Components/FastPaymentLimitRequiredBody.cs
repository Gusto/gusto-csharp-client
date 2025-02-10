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
    
    public class FastPaymentLimitRequiredBody
    {

        /// <summary>
        /// Fast payment limit. This limit is an aggregate of all fast payrolls amount. This limit is only relevant when payment speed is 1-day or 2-day.
        /// </summary>
        [JsonProperty("fast_payment_limit")]
        public string FastPaymentLimit { get; set; } = default!;

        /// <summary>
        /// Gusto Embedded supports three payment speeds (1-day, 2-day, and 4-day). For next-day payments, funds are deposited in your team&apos;s bank account by the end of the next business day. Most people will see the funds arrive the next afternoon, but payments may arrive as late as the end of the business day.
        /// </summary>
        [JsonProperty("payment_speed")]
        public PaymentSpeedParam? PaymentSpeed { get; set; }
    }
}