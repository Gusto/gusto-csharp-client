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
    
    public class Company
    {

        /// <summary>
        /// The legal name of the company.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The name of the company.
        /// </summary>
        [JsonProperty("trade_name")]
        public string? TradeName { get; set; }

        /// <summary>
        /// The employer identification number (EIN) of the company.
        /// </summary>
        [JsonProperty("ein")]
        public string? Ein { get; set; }

        /// <summary>
        /// Whether the company only supports contractors. Should be set to true if the company has no W-2 employees. If not passed, will default to false (i.e. the company will support both contractors and employees).
        /// </summary>
        [JsonProperty("contractor_only")]
        public bool? ContractorOnly { get; set; }
    }
}