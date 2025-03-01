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
    /// The unit accompanying the compensation rate. If the employee is an owner, rate should be &apos;Paycheck&apos;.
    /// </summary>
    public enum PutV1CompensationsCompensationIdPaymentUnit
    {
        [JsonProperty("Hour")]
        Hour,
        [JsonProperty("Week")]
        Week,
        [JsonProperty("Month")]
        Month,
        [JsonProperty("Year")]
        Year,
        [JsonProperty("Paycheck")]
        Paycheck,
    }

    public static class PutV1CompensationsCompensationIdPaymentUnitExtension
    {
        public static string Value(this PutV1CompensationsCompensationIdPaymentUnit value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PutV1CompensationsCompensationIdPaymentUnit ToEnum(this string value)
        {
            foreach(var field in typeof(PutV1CompensationsCompensationIdPaymentUnit).GetFields())
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

                    if (enumVal is PutV1CompensationsCompensationIdPaymentUnit)
                    {
                        return (PutV1CompensationsCompensationIdPaymentUnit)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PutV1CompensationsCompensationIdPaymentUnit");
        }
    }

}