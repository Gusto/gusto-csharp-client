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
    /// Gusto Embedded supports three payment speeds (1-day, 2-day, and 4-day). For next-day payments, funds are deposited in your team&apos;s bank account by the end of the next business day. Most people will see the funds arrive the next afternoon, but payments may arrive as late as the end of the business day.
    /// </summary>
    public enum PaymentSpeedParam
    {
        [JsonProperty("1-day")]
        OneDay,
        [JsonProperty("2-day")]
        TwoDay,
        [JsonProperty("4-day")]
        FourDay,
    }

    public static class PaymentSpeedParamExtension
    {
        public static string Value(this PaymentSpeedParam value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PaymentSpeedParam ToEnum(this string value)
        {
            foreach(var field in typeof(PaymentSpeedParam).GetFields())
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

                    if (enumVal is PaymentSpeedParam)
                    {
                        return (PaymentSpeedParam)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PaymentSpeedParam");
        }
    }

}