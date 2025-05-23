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
    /// One of the &quot;onboarding_status&quot; enum values.
    /// </summary>
    public enum ContractorOnboardingStatusOnboardingStatus
    {
        [JsonProperty("onboarding_completed")]
        OnboardingCompleted,
        [JsonProperty("admin_onboarding_review")]
        AdminOnboardingReview,
        [JsonProperty("admin_onboarding_incomplete")]
        AdminOnboardingIncomplete,
    }

    public static class ContractorOnboardingStatusOnboardingStatusExtension
    {
        public static string Value(this ContractorOnboardingStatusOnboardingStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ContractorOnboardingStatusOnboardingStatus ToEnum(this string value)
        {
            foreach(var field in typeof(ContractorOnboardingStatusOnboardingStatus).GetFields())
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

                    if (enumVal is ContractorOnboardingStatusOnboardingStatus)
                    {
                        return (ContractorOnboardingStatusOnboardingStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ContractorOnboardingStatusOnboardingStatus");
        }
    }

}