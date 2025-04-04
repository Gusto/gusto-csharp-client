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
    
    /// <summary>
    /// Representation of a recovery case
    /// </summary>
    public class RecoveryCase
    {

        /// <summary>
        /// Unique identifier of an recovery case
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the company to which the recovery case belongs
        /// </summary>
        [JsonProperty("company_uuid")]
        public string? CompanyUuid { get; set; }

        /// <summary>
        /// Status of the recovery case
        /// </summary>
        [JsonProperty("status")]
        public RecoveryCaseStatus? Status { get; set; }

        /// <summary>
        /// The latest bank error code for the recovery case. See <a href="https://docs.gusto.com/embedded-payroll/docs/ach-codes-and-transaction-types">this doc</a> for a list of common ACH return codes.
        /// </summary>
        [JsonProperty("latest_error_code")]
        public string? LatestErrorCode { get; set; }

        /// <summary>
        /// Date when funds were originally debited from the company&apos;s bank account
        /// </summary>
        [JsonProperty("original_debit_date")]
        public string? OriginalDebitDate { get; set; }

        /// <summary>
        /// Check date for the associated payroll or contractor payments
        /// </summary>
        [JsonProperty("check_date")]
        public string? CheckDate { get; set; }

        /// <summary>
        /// The uuid of the associated payroll for which the recovery case was created. If the recovery case was created for a contractor payment, this field will be null.
        /// </summary>
        [JsonProperty("payroll_uuid")]
        public string? PayrollUuid { get; set; }

        /// <summary>
        /// The uuids of the associated contractor payments for which the recovery case was created. If the recovery case was created for a payroll, this field will be null.
        /// </summary>
        [JsonProperty("contractor_payment_uuids")]
        public List<string>? ContractorPaymentUuids { get; set; }

        /// <summary>
        /// Amount outstanding for the recovery case
        /// </summary>
        [JsonProperty("amount_outstanding")]
        public string? AmountOutstanding { get; set; }

        /// <summary>
        /// Total amount to be debited from the payroll or contractor payments
        /// </summary>
        [JsonProperty("event_total_amount")]
        public string? EventTotalAmount { get; set; }
    }
}