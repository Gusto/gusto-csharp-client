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
    /// The frequency that employees on this pay schedule are paid with Gusto.
    /// </summary>
    public enum PayScheduleFrequencyCreateUpdate
    {
        [JsonProperty("Every week")]
        EveryWeek,
        [JsonProperty("Every other week")]
        EveryOtherWeek,
        [JsonProperty("Twice per month")]
        TwicePerMonth,
        [JsonProperty("Monthly")]
        Monthly,
    }

    public static class PayScheduleFrequencyCreateUpdateExtension
    {
        public static string Value(this PayScheduleFrequencyCreateUpdate value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PayScheduleFrequencyCreateUpdate ToEnum(this string value)
        {
            foreach(var field in typeof(PayScheduleFrequencyCreateUpdate).GetFields())
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

                    if (enumVal is PayScheduleFrequencyCreateUpdate)
                    {
                        return (PayScheduleFrequencyCreateUpdate)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PayScheduleFrequencyCreateUpdate");
        }
    }

}