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
    using GustoEmbedded.Models.Requests;
    using GustoEmbedded.Utils;
    using Newtonsoft.Json;
    
    public class PostV1ContractorsContractorUuidBankAccountsRequestBody
    {

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; } = default!;

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; } = default!;

        [JsonProperty("account_type")]
        public PostV1ContractorsContractorUuidBankAccountsAccountType AccountType { get; set; } = default!;
    }
}