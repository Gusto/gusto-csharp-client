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
    /// Whether the employee deduction reduces taxable income or not. Only valid for Group Term Life benefits. Note: when the value is not &quot;unset&quot;, coverage amount and coverage salary multiplier are ignored.
    /// </summary>
    public enum EmployeeBenefitForCompanyBenefitDeductionReducesTaxableIncome
    {
        [JsonProperty("unset")]
        Unset,
        [JsonProperty("reduces_taxable_income")]
        ReducesTaxableIncome,
        [JsonProperty("does_not_reduce_taxable_income")]
        DoesNotReduceTaxableIncome,
    }

    public static class EmployeeBenefitForCompanyBenefitDeductionReducesTaxableIncomeExtension
    {
        public static string Value(this EmployeeBenefitForCompanyBenefitDeductionReducesTaxableIncome value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static EmployeeBenefitForCompanyBenefitDeductionReducesTaxableIncome ToEnum(this string value)
        {
            foreach(var field in typeof(EmployeeBenefitForCompanyBenefitDeductionReducesTaxableIncome).GetFields())
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

                    if (enumVal is EmployeeBenefitForCompanyBenefitDeductionReducesTaxableIncome)
                    {
                        return (EmployeeBenefitForCompanyBenefitDeductionReducesTaxableIncome)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum EmployeeBenefitForCompanyBenefitDeductionReducesTaxableIncome");
        }
    }

}