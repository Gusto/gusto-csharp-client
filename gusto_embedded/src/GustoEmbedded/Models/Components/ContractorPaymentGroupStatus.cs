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
    /// The status of the contractor payment group.  Will be `Funded` if all payments that should be funded (i.e. have `Direct Deposit` for payment method) are funded.  A group can have status `Funded` while having associated payments that have status `Unfunded`, i.e. payment with `Check` payment method.
    /// </summary>
    public enum ContractorPaymentGroupStatus
    {
        [JsonProperty("Unfunded")]
        Unfunded,
        [JsonProperty("Funded")]
        Funded,
    }

    public static class ContractorPaymentGroupStatusExtension
    {
        public static string Value(this ContractorPaymentGroupStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ContractorPaymentGroupStatus ToEnum(this string value)
        {
            foreach(var field in typeof(ContractorPaymentGroupStatus).GetFields())
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

                    if (enumVal is ContractorPaymentGroupStatus)
                    {
                        return (ContractorPaymentGroupStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ContractorPaymentGroupStatus");
        }
    }

}