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
    
    public class GetV1CompaniesCompanyIdCompanyBenefitsRequest
    {

        /// <summary>
        /// The UUID of the company
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=company_id")]
        public string CompanyId { get; set; } = default!;

        /// <summary>
        /// Whether the benefit is currently active
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Whether to return employee enrollment count
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=enrollment_count")]
        public bool? EnrollmentCount { get; set; }

        /// <summary>
        /// Determines the date-based API version associated with your API call. If none is provided, your application&apos;s <a href="https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version">minimum API version</a> is used.
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=X-Gusto-API-Version")]
        public VersionHeader? XGustoAPIVersion { get; set; } = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01;
    }
}