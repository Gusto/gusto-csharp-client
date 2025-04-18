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
    
    /// <summary>
    /// Available options:<br/>
    /// 
    /// <remarks>
    /// - all_compensations: Include all effective dated compensations for each job instead of only the current compensation
    /// </remarks>
    /// </summary>
    public enum GetV1EmployeesEmployeeIdJobsQueryParamInclude
    {
        [JsonProperty("all_compensations")]
        AllCompensations,
    }

    public static class GetV1EmployeesEmployeeIdJobsQueryParamIncludeExtension
    {
        public static string Value(this GetV1EmployeesEmployeeIdJobsQueryParamInclude value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static GetV1EmployeesEmployeeIdJobsQueryParamInclude ToEnum(this string value)
        {
            foreach(var field in typeof(GetV1EmployeesEmployeeIdJobsQueryParamInclude).GetFields())
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

                    if (enumVal is GetV1EmployeesEmployeeIdJobsQueryParamInclude)
                    {
                        return (GetV1EmployeesEmployeeIdJobsQueryParamInclude)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum GetV1EmployeesEmployeeIdJobsQueryParamInclude");
        }
    }

}