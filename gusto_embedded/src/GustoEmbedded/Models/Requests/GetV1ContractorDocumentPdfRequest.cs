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
    using GustoEmbedded.Utils;
    
    public class GetV1ContractorDocumentPdfRequest
    {

        /// <summary>
        /// The ID or UUID of the document
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=document_uuid")]
        public string DocumentUuid { get; set; } = default!;

        /// <summary>
        /// Determines the date-based API version associated with your API call. If none is provided, your application&apos;s <a href="https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version">minimum API version</a> is used.
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=X-Gusto-API-Version")]
        public VersionHeader? XGustoAPIVersion { get; set; } = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFour0401;
    }
}