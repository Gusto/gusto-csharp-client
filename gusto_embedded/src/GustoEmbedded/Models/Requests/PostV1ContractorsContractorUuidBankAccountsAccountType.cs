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
    
    public enum PostV1ContractorsContractorUuidBankAccountsAccountType
    {
        [JsonProperty("Checking")]
        Checking,
        [JsonProperty("Savings")]
        Savings,
    }

    public static class PostV1ContractorsContractorUuidBankAccountsAccountTypeExtension
    {
        public static string Value(this PostV1ContractorsContractorUuidBankAccountsAccountType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PostV1ContractorsContractorUuidBankAccountsAccountType ToEnum(this string value)
        {
            foreach(var field in typeof(PostV1ContractorsContractorUuidBankAccountsAccountType).GetFields())
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

                    if (enumVal is PostV1ContractorsContractorUuidBankAccountsAccountType)
                    {
                        return (PostV1ContractorsContractorUuidBankAccountsAccountType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PostV1ContractorsContractorUuidBankAccountsAccountType");
        }
    }

}