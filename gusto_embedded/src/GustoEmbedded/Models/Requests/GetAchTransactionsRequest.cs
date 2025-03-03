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
    
    public class GetAchTransactionsRequest
    {

        /// <summary>
        /// The UUID of the company
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=company_uuid")]
        public string CompanyUuid { get; set; } = default!;

        /// <summary>
        /// The UUID of the contractor payment
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=contractor_payment_uuid")]
        public string? ContractorPaymentUuid { get; set; }

        /// <summary>
        /// The UUID of the payroll
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=payroll_uuid")]
        public string? PayrollUuid { get; set; }

        /// <summary>
        /// Used to filter the ACH transactions to only include those with a specific transaction type, such as &quot;Credit employee pay&quot;.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=transaction_type")]
        public string? TransactionType { get; set; }

        /// <summary>
        /// Used to filter the ACH transactions to only include those with a specific payment direction, either &quot;credit&quot; or &quot;debit&quot;.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=payment_direction")]
        public string? PaymentDirection { get; set; }

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
        public VersionHeader? XGustoAPIVersion { get; set; }
    }
}