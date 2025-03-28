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
    using System.Collections.Generic;
    
    public class GetV1CompaniesCompanyIdEmployeesRequest
    {

        /// <summary>
        /// The UUID of the company
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=company_id")]
        public string CompanyId { get; set; } = default!;

        /// <summary>
        /// Filters employees by the provided boolean
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=terminated")]
        public bool? Terminated { get; set; }

        /// <summary>
        /// Include the requested attribute(s) in each employee response, multiple options are comma separated. Available options:<br/>
        /// 
        /// <remarks>
        /// - all_compensations: Include all effective dated compensations for each job instead of only the current compensation<br/>
        /// - custom_fields: Include employees&apos; custom fields
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=false,name=include")]
        public List<Include>? Include { get; set; }

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
        /// A string to search for in the object&apos;s names
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=search_term")]
        public string? SearchTerm { get; set; }

        /// <summary>
        /// Determines the date-based API version associated with your API call. If none is provided, your application&apos;s <a href="https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version">minimum API version</a> is used.
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=X-Gusto-API-Version")]
        public VersionHeader? XGustoAPIVersion { get; set; } = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01;
    }
}