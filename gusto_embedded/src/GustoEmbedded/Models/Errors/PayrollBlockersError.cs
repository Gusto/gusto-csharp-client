//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace GustoEmbedded.Models.Errors
{
    using GustoEmbedded.Models.Components;
    using GustoEmbedded.Models.Errors;
    using GustoEmbedded.Utils;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// Payroll Blockers Error<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// For detailed information, see the <a href="https://docs.gusto.com/embedded-payroll/docs/payroll-blockers">Payroll Blockers guide</a>
    /// </remarks>
    /// </summary>
    public class PayrollBlockersError : Exception
    {

        [JsonProperty("errors")]
        public List<Errors>? Errors { get; set; }

        [JsonProperty("-")]
        public HTTPMetadata HttpMeta { get; set; } = default!;
    }
}