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
    /// The payment schedule tax rate the payroll is based on. Only included for off-cycle payrolls.
    /// </summary>
    public enum PayrollWithholdingPayPeriodType
    {
        [JsonProperty("Every week")]
        EveryWeek,
        [JsonProperty("Every other week")]
        EveryOtherWeek,
        [JsonProperty("Twice per month")]
        TwicePerMonth,
        [JsonProperty("Monthly")]
        Monthly,
        [JsonProperty("Quarterly")]
        Quarterly,
        [JsonProperty("Semiannually")]
        Semiannually,
        [JsonProperty("Annually")]
        Annually,
    }

    public static class PayrollWithholdingPayPeriodTypeExtension
    {
        public static string Value(this PayrollWithholdingPayPeriodType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PayrollWithholdingPayPeriodType ToEnum(this string value)
        {
            foreach(var field in typeof(PayrollWithholdingPayPeriodType).GetFields())
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

                    if (enumVal is PayrollWithholdingPayPeriodType)
                    {
                        return (PayrollWithholdingPayPeriodType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PayrollWithholdingPayPeriodType");
        }
    }

}