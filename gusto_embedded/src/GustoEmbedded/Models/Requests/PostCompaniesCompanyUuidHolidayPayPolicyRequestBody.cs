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
    
    public class PostCompaniesCompanyUuidHolidayPayPolicyRequestBody
    {

        /// <summary>
        /// An object containing federal holiday objects, each containing a boolean selected property.
        /// </summary>
        [JsonProperty("federal_holidays")]
        public Models.Requests.FederalHolidays? FederalHolidays { get; set; }
    }
}