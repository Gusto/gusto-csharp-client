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
    using GustoEmbedded.Utils;
    using Newtonsoft.Json;
    
    public class Taxes
    {

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("employer")]
        public bool Employer { get; set; } = default!;

        [JsonProperty("amount")]
        public double Amount { get; set; } = default!;
    }
}