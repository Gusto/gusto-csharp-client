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
    using GustoEmbedded.Models.Requests;
    using GustoEmbedded.Utils;
    
    public class PutV1ContractorDocumentSignRequest
    {

        /// <summary>
        /// The ID or UUID of the document
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=document_uuid")]
        public string DocumentUuid { get; set; } = default!;

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public PutV1ContractorDocumentSignRequestBody RequestBody { get; set; } = default!;

        /// <summary>
        /// Optional header to supply the IP address. This can be used to supply the IP address for signature endpoints instead of the signed_by_ip_address parameter.
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=x-gusto-client-ip")]
        public string? XGustoClientIp { get; set; }

        /// <summary>
        /// Determines the date-based API version associated with your API call. If none is provided, your application&apos;s <a href="https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version">minimum API version</a> is used.
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=X-Gusto-API-Version")]
        public VersionHeader? XGustoAPIVersion { get; set; } = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFour0401;
    }
}