//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace GustoEmbedded.Models.Errors
{
    using GustoEmbedded.Models.Errors;
    using GustoEmbedded.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class GetCompaniesCompanyUuidContractorPaymentsPreviewErrors
    {

        [JsonProperty("base")]
        public List<GetCompaniesCompanyUuidContractorPaymentsPreviewBase>? Base { get; set; }

        [JsonProperty("check_date")]
        public List<CheckDate>? CheckDate { get; set; }
    }
}