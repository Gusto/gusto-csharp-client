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
    
    /// <summary>
    /// An object containing federal holiday objects, each containing a boolean selected property.
    /// </summary>
    public class FederalHolidays
    {

        [JsonProperty("new_years_day")]
        public Models.Requests.NewYearsDay? NewYearsDay { get; set; }

        [JsonProperty("mlk_day")]
        public Models.Requests.MlkDay? MlkDay { get; set; }

        [JsonProperty("presidents_day")]
        public Models.Requests.PresidentsDay? PresidentsDay { get; set; }

        [JsonProperty("memorial_day")]
        public Models.Requests.MemorialDay? MemorialDay { get; set; }

        [JsonProperty("juneteenth")]
        public Models.Requests.Juneteenth? Juneteenth { get; set; }

        [JsonProperty("independence_day")]
        public Models.Requests.IndependenceDay? IndependenceDay { get; set; }

        [JsonProperty("labor_day")]
        public Models.Requests.LaborDay? LaborDay { get; set; }

        [JsonProperty("columbus_day")]
        public Models.Requests.ColumbusDay? ColumbusDay { get; set; }

        [JsonProperty("veterans_day")]
        public Models.Requests.VeteransDay? VeteransDay { get; set; }

        [JsonProperty("thanksgiving")]
        public Models.Requests.Thanksgiving? Thanksgiving { get; set; }

        [JsonProperty("christmas_day")]
        public ChristmasDay? ChristmasDay { get; set; }
    }
}