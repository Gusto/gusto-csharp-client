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
    /// The payment method type. If type is Direct Deposit, the contractor is required to have a bank account.<br/>
    /// 
    /// <remarks>
    /// see <a href="./post-v1-contractors-contractor_uuid-bank_accounts">Bank account endpoint</a>
    /// </remarks>
    /// </summary>
    public enum PutV1ContractorsContractorIdPaymentMethodType
    {
        [JsonProperty("Direct Deposit")]
        DirectDeposit,
        [JsonProperty("Check")]
        Check,
    }

    public static class PutV1ContractorsContractorIdPaymentMethodTypeExtension
    {
        public static string Value(this PutV1ContractorsContractorIdPaymentMethodType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PutV1ContractorsContractorIdPaymentMethodType ToEnum(this string value)
        {
            foreach(var field in typeof(PutV1ContractorsContractorIdPaymentMethodType).GetFields())
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

                    if (enumVal is PutV1ContractorsContractorIdPaymentMethodType)
                    {
                        return (PutV1ContractorsContractorIdPaymentMethodType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PutV1ContractorsContractorIdPaymentMethodType");
        }
    }

}