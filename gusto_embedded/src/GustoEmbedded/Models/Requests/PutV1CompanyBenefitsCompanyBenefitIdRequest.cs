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
    
    public class PutV1CompanyBenefitsCompanyBenefitIdRequest
    {

        /// <summary>
        /// The UUID of the company benefit
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=company_benefit_id")]
        public string CompanyBenefitId { get; set; } = default!;

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public PutV1CompanyBenefitsCompanyBenefitIdRequestBody RequestBody { get; set; } = default!;

        /// <summary>
        /// Determines the date-based API version associated with your API call. If none is provided, your application&apos;s <a href="https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version">minimum API version</a> is used.
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=X-Gusto-API-Version")]
        public VersionHeader? XGustoAPIVersion { get; set; } = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFour0401;
    }
}