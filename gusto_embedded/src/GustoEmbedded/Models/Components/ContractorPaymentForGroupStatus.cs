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
    /// The status of the contractor payment.  Will transition to `Funded` during payments processing if the payment should be funded, i.e. has `Direct Deposit` for payment method. Contractors payments with `Check` payment method will remain `Unfunded`.
    /// </summary>
    public enum ContractorPaymentForGroupStatus
    {
        [JsonProperty("Funded")]
        Funded,
        [JsonProperty("Unfunded")]
        Unfunded,
    }

    public static class ContractorPaymentForGroupStatusExtension
    {
        public static string Value(this ContractorPaymentForGroupStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ContractorPaymentForGroupStatus ToEnum(this string value)
        {
            foreach(var field in typeof(ContractorPaymentForGroupStatus).GetFields())
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

                    if (enumVal is ContractorPaymentForGroupStatus)
                    {
                        return (ContractorPaymentForGroupStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ContractorPaymentForGroupStatus");
        }
    }

}