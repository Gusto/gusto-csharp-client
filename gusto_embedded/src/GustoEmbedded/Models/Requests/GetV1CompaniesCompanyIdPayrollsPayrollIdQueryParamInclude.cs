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
    
    public enum GetV1CompaniesCompanyIdPayrollsPayrollIdQueryParamInclude
    {
        [JsonProperty("benefits")]
        Benefits,
        [JsonProperty("deductions")]
        Deductions,
        [JsonProperty("taxes")]
        Taxes,
        [JsonProperty("payroll_status_meta")]
        PayrollStatusMeta,
    }

    public static class GetV1CompaniesCompanyIdPayrollsPayrollIdQueryParamIncludeExtension
    {
        public static string Value(this GetV1CompaniesCompanyIdPayrollsPayrollIdQueryParamInclude value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static GetV1CompaniesCompanyIdPayrollsPayrollIdQueryParamInclude ToEnum(this string value)
        {
            foreach(var field in typeof(GetV1CompaniesCompanyIdPayrollsPayrollIdQueryParamInclude).GetFields())
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

                    if (enumVal is GetV1CompaniesCompanyIdPayrollsPayrollIdQueryParamInclude)
                    {
                        return (GetV1CompaniesCompanyIdPayrollsPayrollIdQueryParamInclude)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum GetV1CompaniesCompanyIdPayrollsPayrollIdQueryParamInclude");
        }
    }

}