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
    
    public class PostPartnerManagedCompaniesCompanyUuidAcceptTermsOfServiceRequestBody
    {

        /// <summary>
        /// The user&apos;s email address on Gusto. You can retrieve the user&apos;s email via company&apos;s `/admins`, `/employees`, `/signatories`, and `/contractors` endpoints.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; } = default!;

        /// <summary>
        /// The IP address of the user who viewed and accepted the Terms of Service.
        /// </summary>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; } = default!;

        /// <summary>
        /// The user ID on your platform.
        /// </summary>
        [JsonProperty("external_user_id")]
        public string ExternalUserId { get; set; } = default!;
    }
}