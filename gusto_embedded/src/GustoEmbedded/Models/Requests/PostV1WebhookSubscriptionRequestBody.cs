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
    using GustoEmbedded.Models.Requests;
    using GustoEmbedded.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class PostV1WebhookSubscriptionRequestBody
    {

        [JsonProperty("url")]
        public string Url { get; set; } = default!;

        [JsonProperty("subscription_types")]
        public List<Models.Requests.SubscriptionTypes> SubscriptionTypes { get; set; } = default!;
    }
}