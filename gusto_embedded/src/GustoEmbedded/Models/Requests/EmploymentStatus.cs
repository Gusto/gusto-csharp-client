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
    /// The employee&apos;s employment status. Supplying an invalid option will set the employment_status to *not_set*.
    /// </summary>
    public enum EmploymentStatus
    {
        [JsonProperty("part_time")]
        PartTime,
        [JsonProperty("full_time")]
        FullTime,
        [JsonProperty("part_time_eligible")]
        PartTimeEligible,
        [JsonProperty("variable")]
        Variable,
        [JsonProperty("seasonal")]
        Seasonal,
        [JsonProperty("not_set")]
        NotSet,
    }

    public static class EmploymentStatusExtension
    {
        public static string Value(this EmploymentStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static EmploymentStatus ToEnum(this string value)
        {
            foreach(var field in typeof(EmploymentStatus).GetFields())
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

                    if (enumVal is EmploymentStatus)
                    {
                        return (EmploymentStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum EmploymentStatus");
        }
    }

}