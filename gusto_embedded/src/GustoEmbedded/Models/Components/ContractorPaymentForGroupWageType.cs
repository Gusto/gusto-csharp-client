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
    /// The wage type for the payment.
    /// </summary>
    public enum ContractorPaymentForGroupWageType
    {
        [JsonProperty("Hourly")]
        Hourly,
        [JsonProperty("Fixed")]
        Fixed,
    }

    public static class ContractorPaymentForGroupWageTypeExtension
    {
        public static string Value(this ContractorPaymentForGroupWageType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ContractorPaymentForGroupWageType ToEnum(this string value)
        {
            foreach(var field in typeof(ContractorPaymentForGroupWageType).GetFields())
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

                    if (enumVal is ContractorPaymentForGroupWageType)
                    {
                        return (ContractorPaymentForGroupWageType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ContractorPaymentForGroupWageType");
        }
    }

}