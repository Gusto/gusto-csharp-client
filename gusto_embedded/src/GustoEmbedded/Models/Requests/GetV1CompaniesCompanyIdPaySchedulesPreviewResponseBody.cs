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
    
    /// <summary>
    /// Pay schedule preview
    /// </summary>
    public class GetV1CompaniesCompanyIdPaySchedulesPreviewResponseBody
    {

        /// <summary>
        /// A list of pay periods for the previewed pay schedule
        /// </summary>
        [JsonProperty("pay_periods")]
        public List<PayPeriods>? PayPeriods { get; set; }

        /// <summary>
        /// A list of dates for bank closures
        /// </summary>
        [JsonProperty("holidays")]
        public List<string>? Holidays { get; set; }
    }
}