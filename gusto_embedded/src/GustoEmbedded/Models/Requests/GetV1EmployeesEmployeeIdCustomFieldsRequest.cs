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
    
    public class GetV1EmployeesEmployeeIdCustomFieldsRequest
    {

        /// <summary>
        /// The UUID of the employee
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=employee_id")]
        public string EmployeeId { get; set; } = default!;

        /// <summary>
        /// The page that is requested. When unspecified, will load all objects unless endpoint forces pagination.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=page")]
        public double? Page { get; set; }

        /// <summary>
        /// Number of objects per page. For majority of endpoints will default to 25
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=per")]
        public double? Per { get; set; }

        /// <summary>
        /// Determines the date-based API version associated with your API call. If none is provided, your application&apos;s <a href="https://docs.gusto.com/embedded-payroll/docs/api-versioning#minimum-api-version">minimum API version</a> is used.
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=X-Gusto-API-Version")]
        public VersionHeader? XGustoAPIVersion { get; set; }
    }
}