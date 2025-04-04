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
    using GustoEmbedded.Models.Components;
    using GustoEmbedded.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// The representation of a company&apos;s onboarding status
    /// </summary>
    public class CompanyOnboardingStatus
    {

        /// <summary>
        /// the UUID of the company
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// a boolean flag for the company&apos;s onboarding status
        /// </summary>
        [JsonProperty("onboarding_completed")]
        public bool? OnboardingCompleted { get; set; }

        /// <summary>
        /// a list of company onboarding steps
        /// </summary>
        [JsonProperty("onboarding_steps")]
        public List<OnboardingStep>? OnboardingSteps { get; set; }
    }
}