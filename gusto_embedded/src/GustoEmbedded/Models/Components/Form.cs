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
    
    /// <summary>
    /// Example response
    /// </summary>
    public class Form
    {

        /// <summary>
        /// The UUID of the form
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// The type identifier of the form
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The title of the form
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The description of the form
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// If the form is in a draft state. E.g. End of year tax forms may be provided in a draft state prior to being finalized.
        /// </summary>
        [JsonProperty("draft")]
        public bool? Draft { get; set; }

        /// <summary>
        /// The year of this form. For some forms, e.g. tax forms, this is the year which the form represents. A W2 for January - December 2022 would be delivered in January 2023 and have a year value of 2022. This value is nullable and will not be present on all forms.
        /// </summary>
        [JsonProperty("year")]
        public long? Year { get; set; } = null;

        /// <summary>
        /// The quarter of this form. For some forms, e.g. tax forms, this is the calendar quarter which this form represents. An Employer&apos;s Quarterly Federal Tax Return (Form 941) for April, May, June 2022 would have a quarter value of 2 (and a year value of 2022). This value is nullable and will not be present on all forms.
        /// </summary>
        [JsonProperty("quarter")]
        public long? Quarter { get; set; } = null;

        /// <summary>
        /// A boolean flag that indicates whether the form needs signing or not. Note that this value will change after the form is signed.
        /// </summary>
        [JsonProperty("requires_signing")]
        public bool? RequiresSigning { get; set; }

        /// <summary>
        /// The content type of the associated document. Most forms are PDFs with a content type of `application/pdf`. Some tax file packages will be zip files (containing PDFs) with a content type of `application/zip`. This attribute will be `null` when the document has not been prepared.
        /// </summary>
        [JsonProperty("document_content_type")]
        public string? DocumentContentType { get; set; } = null;
    }
}