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
    
    /// <summary>
    /// Information for the user who will be the primary payroll administrator for the new company.
    /// </summary>
    public class User
    {

        /// <summary>
        /// The first name of the user who will be the primary payroll admin.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; } = default!;

        /// <summary>
        /// The last name of the user who will be the primary payroll admin.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; } = default!;

        /// <summary>
        /// The email of the user who will be the primary payroll admin.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; } = default!;

        /// <summary>
        /// The phone number of the user who will be the primary payroll admin.
        /// </summary>
        [JsonProperty("phone")]
        public string? Phone { get; set; }
    }
}