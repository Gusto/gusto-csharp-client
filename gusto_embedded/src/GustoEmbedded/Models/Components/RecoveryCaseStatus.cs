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
    /// Status of the recovery case
    /// </summary>
    public enum RecoveryCaseStatus
    {
        [JsonProperty("open")]
        Open,
        [JsonProperty("redebit_initiated")]
        RedebitInitiated,
        [JsonProperty("wire_initiated")]
        WireInitiated,
        [JsonProperty("recovered")]
        Recovered,
        [JsonProperty("lost")]
        Lost,
    }

    public static class RecoveryCaseStatusExtension
    {
        public static string Value(this RecoveryCaseStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static RecoveryCaseStatus ToEnum(this string value)
        {
            foreach(var field in typeof(RecoveryCaseStatus).GetFields())
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

                    if (enumVal is RecoveryCaseStatus)
                    {
                        return (RecoveryCaseStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum RecoveryCaseStatus");
        }
    }

}