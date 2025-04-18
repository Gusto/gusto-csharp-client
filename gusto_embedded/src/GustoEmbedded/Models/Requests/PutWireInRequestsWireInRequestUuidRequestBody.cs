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
    
    public class PutWireInRequestsWireInRequestUuidRequestBody
    {

        /// <summary>
        /// The date the wire was sent
        /// </summary>
        [JsonProperty("date_sent")]
        public string DateSent { get; set; } = default!;

        /// <summary>
        /// Name of the bank sending the wire
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; } = default!;

        /// <summary>
        /// Amount of money sent
        /// </summary>
        [JsonProperty("amount_sent")]
        public string AmountSent { get; set; } = default!;

        /// <summary>
        /// Additional notes
        /// </summary>
        [JsonProperty("additional_notes")]
        public string? AdditionalNotes { get; set; }
    }
}