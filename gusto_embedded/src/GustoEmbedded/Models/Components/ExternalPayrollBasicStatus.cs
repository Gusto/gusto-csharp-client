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
    /// The status of the external payroll. The status will be `unprocessed` when the external payroll is created and transition to `processed` once tax liabilities are entered and finalized.  Once in the `processed` status all actions that can edit an external payroll will be disabled.
    /// </summary>
    public enum ExternalPayrollBasicStatus
    {
        [JsonProperty("unprocessed")]
        Unprocessed,
        [JsonProperty("processed")]
        Processed,
    }

    public static class ExternalPayrollBasicStatusExtension
    {
        public static string Value(this ExternalPayrollBasicStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ExternalPayrollBasicStatus ToEnum(this string value)
        {
            foreach(var field in typeof(ExternalPayrollBasicStatus).GetFields())
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

                    if (enumVal is ExternalPayrollBasicStatus)
                    {
                        return (ExternalPayrollBasicStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ExternalPayrollBasicStatus");
        }
    }

}