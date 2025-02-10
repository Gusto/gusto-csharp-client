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
    
    public class PostV1PayrollsPayrollUuidGeneratedDocumentsPrintablePayrollChecksRequestBody
    {

        /// <summary>
        /// The type of check stock being printed. Check the &quot;Types of check stock&quot; section in this <a href="https://support.gusto.com/article/999877761000000/Pay-your-team-by-check">link</a> for more info on check types
        /// </summary>
        [JsonProperty("printing_format")]
        public PrintingFormat PrintingFormat { get; set; } = default!;

        /// <summary>
        /// The starting check number we will start generating checks from. Use to override the sequence that will be used to generate check numbers.
        /// </summary>
        [JsonProperty("starting_check_number")]
        public long? StartingCheckNumber { get; set; }
    }
}