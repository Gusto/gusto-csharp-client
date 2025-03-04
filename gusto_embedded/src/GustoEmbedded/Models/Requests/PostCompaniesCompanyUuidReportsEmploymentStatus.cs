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
    using System;
    
    /// <summary>
    /// Employee employment status to filter by
    /// </summary>
    public enum PostCompaniesCompanyUuidReportsEmploymentStatus
    {
        [JsonProperty("active_full_time")]
        ActiveFullTime,
        [JsonProperty("active_part_time")]
        ActivePartTime,
        [JsonProperty("active_part_time_eligible")]
        ActivePartTimeEligible,
        [JsonProperty("active_variable")]
        ActiveVariable,
        [JsonProperty("active_seasonal")]
        ActiveSeasonal,
        [JsonProperty("active")]
        Active,
        [JsonProperty("dismissed")]
        Dismissed,
    }

    public static class PostCompaniesCompanyUuidReportsEmploymentStatusExtension
    {
        public static string Value(this PostCompaniesCompanyUuidReportsEmploymentStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PostCompaniesCompanyUuidReportsEmploymentStatus ToEnum(this string value)
        {
            foreach(var field in typeof(PostCompaniesCompanyUuidReportsEmploymentStatus).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is PostCompaniesCompanyUuidReportsEmploymentStatus)
                    {
                        return (PostCompaniesCompanyUuidReportsEmploymentStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PostCompaniesCompanyUuidReportsEmploymentStatus");
        }
    }

}