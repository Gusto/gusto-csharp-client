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
    /// The maximum company contribution amount per year. A null value signifies no limit.
    /// </summary>
    public class CompanyContributionAnnualMaximum
    {

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("editable")]
        public bool? Editable { get; set; }

        [JsonProperty("default_value")]
        public BenefitTypeRequirementsCompanyContributionAnnualMaximumDefaultValue? DefaultValue { get; set; }

        [JsonProperty("choices")]
        public List<string>? Choices { get; set; }
    }
}