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
    using GustoEmbedded.Utils;
    using Newtonsoft.Json;
    
    public class GetCompaniesCompanyUuidContractorPaymentsPreviewContractorPayments
    {

        [JsonProperty("bonus")]
        public long? Bonus { get; set; }

        [JsonProperty("contractor_uuid")]
        public string? ContractorUuid { get; set; }

        [JsonProperty("date")]
        public string? Date { get; set; }

        [JsonProperty("hourly_rate")]
        public long? HourlyRate { get; set; }

        [JsonProperty("hours")]
        public long? Hours { get; set; }

        [JsonProperty("payment_method")]
        public string? PaymentMethod { get; set; }

        [JsonProperty("reimbursement")]
        public long? Reimbursement { get; set; }

        [JsonProperty("wage")]
        public long? Wage { get; set; }
    }
}