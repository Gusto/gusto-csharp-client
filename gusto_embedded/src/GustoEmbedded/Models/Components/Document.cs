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
    using System.Collections.Generic;
    
    public class Document
    {

        /// <summary>
        /// The UUID of the document
        /// </summary>
        [JsonProperty("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// The title of the document
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The type identifier of the document
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of recipient associated with the document (will be `Contractor` for Contractor Documents)
        /// </summary>
        [JsonProperty("recipient_type")]
        public RecipientType? RecipientType { get; set; }

        /// <summary>
        /// Unique identifier for the recipient associated with the document
        /// </summary>
        [JsonProperty("recipient_uuid")]
        public string? RecipientUuid { get; set; }

        /// <summary>
        /// List of the document&apos;s pages and associated image URLs. This is only returned for documents with `required_signing` = `true`, and can be used for signing preparation.
        /// </summary>
        [JsonProperty("pages")]
        public List<Pages>? Pages { get; set; }

        /// <summary>
        /// List of the document&apos;s fields and associated data. Values are set for auto-filled fields. This is only returned for documents with `required_signing` = `true`, and can be used for signing preparation.
        /// </summary>
        [JsonProperty("fields")]
        public List<Models.Components.Fields>? Fields { get; set; }

        /// <summary>
        /// When the document was signed (will be `null` if unsigned)
        /// </summary>
        [JsonProperty("signed_at")]
        public string? SignedAt { get; set; } = null;

        /// <summary>
        /// The description of the document
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A boolean flag that indicates whether the document needs signing or not. Note that this value will change after the document is signed.
        /// </summary>
        [JsonProperty("requires_signing")]
        public bool? RequiresSigning { get; set; }

        /// <summary>
        /// If the document is in a draft state
        /// </summary>
        [JsonProperty("draft")]
        public bool? Draft { get; set; }

        /// <summary>
        /// The year of this document. This value is nullable and will not be present on all documents.
        /// </summary>
        [JsonProperty("year")]
        public long? Year { get; set; } = null;

        /// <summary>
        /// The quarter of this document. This value is nullable and will not be present on all documents.
        /// </summary>
        [JsonProperty("quarter")]
        public long? Quarter { get; set; } = null;
    }
}