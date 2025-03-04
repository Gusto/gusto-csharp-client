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
    
    public class OnboardingStep
    {

        /// <summary>
        /// The display name of the onboarding step
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The string identifier for each onboarding step
        /// </summary>
        [JsonProperty("id")]
        public Id? Id { get; set; }

        /// <summary>
        /// The boolean flag indicating whether the step is required or optional
        /// </summary>
        [JsonProperty("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// The boolean flag indicating whether the step is completed or not.
        /// </summary>
        [JsonProperty("completed")]
        public bool? Completed { get; set; }

        /// <summary>
        /// The boolean flag indicating whether the step can be skipped or not.
        /// </summary>
        [JsonProperty("skippable")]
        public bool? Skippable { get; set; }

        /// <summary>
        /// A list of onboarding step that are required to be completed in order to proceed with the current onboarding step.
        /// </summary>
        [JsonProperty("requirements")]
        public List<Models.Components.Requirements>? Requirements { get; set; }
    }
}