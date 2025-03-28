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
    
    public class GetV1JobsJobIdRequest
    {

        /// <summary>
        /// The UUID of the job
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=job_id")]
        public string JobId { get; set; } = default!;

        /// <summary>
        /// Available options:<br/>
        /// 
        /// <remarks>
        /// - all_compensations: Include all effective dated compensations for the job instead of only the current compensation
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=include")]
        public GetV1JobsJobIdQueryParamInclude? Include { get; set; }

        /// <summary>
        /// Determines the date-based API version associated with your API call. If none is provided, your application&apos;s <a href="https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version">minimum API version</a> is used.
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=X-Gusto-API-Version")]
        public VersionHeader? XGustoAPIVersion { get; set; } = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01;
    }
}