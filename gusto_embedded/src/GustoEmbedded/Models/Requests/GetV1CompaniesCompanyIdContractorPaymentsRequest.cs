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
    
    public class GetV1CompaniesCompanyIdContractorPaymentsRequest
    {

        /// <summary>
        /// The UUID of the company
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=company_id")]
        public string CompanyId { get; set; } = default!;

        /// <summary>
        /// The time period for which to retrieve contractor payments
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=start_date")]
        public string StartDate { get; set; } = default!;

        /// <summary>
        /// The time period for which to retrieve contractor payments. If left empty, defaults to today&apos;s date.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=end_date")]
        public string EndDate { get; set; } = default!;

        /// <summary>
        /// The UUID of the contractor. When specified, will load all payments for that contractor.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=contractor_uuid")]
        public string? ContractorUuid { get; set; }

        /// <summary>
        /// Display contractor payments results group by check date if set to true.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=group_by_date")]
        public bool? GroupByDate { get; set; }

        /// <summary>
        /// The page that is requested. When unspecified, will load all objects unless endpoint forces pagination.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=page")]
        public long? Page { get; set; }

        /// <summary>
        /// Number of objects per page. For majority of endpoints will default to 25
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=per")]
        public long? Per { get; set; }

        /// <summary>
        /// Determines the date-based API version associated with your API call. If none is provided, your application&apos;s <a href="https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version">minimum API version</a> is used.
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=X-Gusto-API-Version")]
        public VersionHeader? XGustoAPIVersion { get; set; } = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01;
    }
}