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
    using System;
    
    /// <summary>
    /// The current employment status of the employee. Full-time employees work 30+ hours per week. Part-time employees are split into two groups: those that work 20-29 hours a week, and those that work under 20 hours a week. Variable employees have hours that vary each week. Seasonal employees are hired for 6 months of the year or less.
    /// </summary>
    public enum CurrentEmploymentStatus
    {
        [JsonProperty("full_time")]
        FullTime,
        [JsonProperty("part_time_under_twenty_hours")]
        PartTimeUnderTwentyHours,
        [JsonProperty("part_time_twenty_plus_hours")]
        PartTimeTwentyPlusHours,
        [JsonProperty("variable")]
        Variable,
        [JsonProperty("seasonal")]
        Seasonal,
    }

    public static class CurrentEmploymentStatusExtension
    {
        public static string Value(this CurrentEmploymentStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static CurrentEmploymentStatus ToEnum(this string value)
        {
            foreach(var field in typeof(CurrentEmploymentStatus).GetFields())
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

                    if (enumVal is CurrentEmploymentStatus)
                    {
                        return (CurrentEmploymentStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum CurrentEmploymentStatus");
        }
    }

}