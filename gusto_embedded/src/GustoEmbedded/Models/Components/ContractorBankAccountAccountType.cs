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
    /// Bank account type
    /// </summary>
    public enum ContractorBankAccountAccountType
    {
        [JsonProperty("Checking")]
        Checking,
        [JsonProperty("Savings")]
        Savings,
    }

    public static class ContractorBankAccountAccountTypeExtension
    {
        public static string Value(this ContractorBankAccountAccountType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ContractorBankAccountAccountType ToEnum(this string value)
        {
            foreach(var field in typeof(ContractorBankAccountAccountType).GetFields())
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

                    if (enumVal is ContractorBankAccountAccountType)
                    {
                        return (ContractorBankAccountAccountType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ContractorBankAccountAccountType");
        }
    }

}