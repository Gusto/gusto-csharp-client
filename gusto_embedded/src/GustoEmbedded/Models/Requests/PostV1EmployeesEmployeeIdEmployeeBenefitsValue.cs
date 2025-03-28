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
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    

    public class PostV1EmployeesEmployeeIdEmployeeBenefitsValueType
    {
        private PostV1EmployeesEmployeeIdEmployeeBenefitsValueType(string value) { Value = value; }

        public string Value { get; private set; }
        public static PostV1EmployeesEmployeeIdEmployeeBenefitsValueType Str { get { return new PostV1EmployeesEmployeeIdEmployeeBenefitsValueType("str"); } }
        
        public static PostV1EmployeesEmployeeIdEmployeeBenefitsValueType ArrayOf2 { get { return new PostV1EmployeesEmployeeIdEmployeeBenefitsValueType("arrayOf2"); } }
        
        public static PostV1EmployeesEmployeeIdEmployeeBenefitsValueType Null { get { return new PostV1EmployeesEmployeeIdEmployeeBenefitsValueType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(PostV1EmployeesEmployeeIdEmployeeBenefitsValueType v) { return v.Value; }
        public static PostV1EmployeesEmployeeIdEmployeeBenefitsValueType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "arrayOf2": return ArrayOf2;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for PostV1EmployeesEmployeeIdEmployeeBenefitsValueType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((PostV1EmployeesEmployeeIdEmployeeBenefitsValueType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// For the `amount` and `percentage` contribution types, the value of the corresponding amount or percentage.<br/>
    /// 
    /// <remarks>
    /// <br/>
    /// For the `tiered` contribution type, an array of tiers.
    /// </remarks>
    /// </summary>
    [JsonConverter(typeof(PostV1EmployeesEmployeeIdEmployeeBenefitsValue.PostV1EmployeesEmployeeIdEmployeeBenefitsValueConverter))]
    public class PostV1EmployeesEmployeeIdEmployeeBenefitsValue {
        public PostV1EmployeesEmployeeIdEmployeeBenefitsValue(PostV1EmployeesEmployeeIdEmployeeBenefitsValueType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<Models.Requests.Two>? ArrayOf2 { get; set; }

        public PostV1EmployeesEmployeeIdEmployeeBenefitsValueType Type { get; set; }


        public static PostV1EmployeesEmployeeIdEmployeeBenefitsValue CreateStr(string str) {
            PostV1EmployeesEmployeeIdEmployeeBenefitsValueType typ = PostV1EmployeesEmployeeIdEmployeeBenefitsValueType.Str;

            PostV1EmployeesEmployeeIdEmployeeBenefitsValue res = new PostV1EmployeesEmployeeIdEmployeeBenefitsValue(typ);
            res.Str = str;
            return res;
        }

        public static PostV1EmployeesEmployeeIdEmployeeBenefitsValue CreateArrayOf2(List<Models.Requests.Two> arrayOf2) {
            PostV1EmployeesEmployeeIdEmployeeBenefitsValueType typ = PostV1EmployeesEmployeeIdEmployeeBenefitsValueType.ArrayOf2;

            PostV1EmployeesEmployeeIdEmployeeBenefitsValue res = new PostV1EmployeesEmployeeIdEmployeeBenefitsValue(typ);
            res.ArrayOf2 = arrayOf2;
            return res;
        }

        public static PostV1EmployeesEmployeeIdEmployeeBenefitsValue CreateNull() {
            PostV1EmployeesEmployeeIdEmployeeBenefitsValueType typ = PostV1EmployeesEmployeeIdEmployeeBenefitsValueType.Null;
            return new PostV1EmployeesEmployeeIdEmployeeBenefitsValue(typ);
        }

        public class PostV1EmployeesEmployeeIdEmployeeBenefitsValueConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(PostV1EmployeesEmployeeIdEmployeeBenefitsValue);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var json = JRaw.Create(reader).ToString();
                if (json == "null")
                {
                    return null;
                }

                var fallbackCandidates = new List<(System.Type, object, string)>();

                if (json[0] == '"' && json[^1] == '"'){
                    return new PostV1EmployeesEmployeeIdEmployeeBenefitsValue(PostV1EmployeesEmployeeIdEmployeeBenefitsValueType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    return new PostV1EmployeesEmployeeIdEmployeeBenefitsValue(PostV1EmployeesEmployeeIdEmployeeBenefitsValueType.ArrayOf2)
                    {
                        ArrayOf2 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<Models.Requests.Two>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<Models.Requests.Two>), new PostV1EmployeesEmployeeIdEmployeeBenefitsValue(PostV1EmployeesEmployeeIdEmployeeBenefitsValueType.ArrayOf2), "ArrayOf2"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                if (fallbackCandidates.Count > 0)
                {
                    fallbackCandidates.Sort((a, b) => ResponseBodyDeserializer.CompareFallbackCandidates(a.Item1, b.Item1, json));
                    foreach(var (deserializationType, returnObject, propertyName) in fallbackCandidates)
                    {
                        try
                        {
                            return ResponseBodyDeserializer.DeserializeUndiscriminatedUnionFallback(deserializationType, returnObject, propertyName, json);
                        }
                        catch (ResponseBodyDeserializer.DeserializationException)
                        {
                            // try next fallback option
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                PostV1EmployeesEmployeeIdEmployeeBenefitsValue res = (PostV1EmployeesEmployeeIdEmployeeBenefitsValue)value;
                if (PostV1EmployeesEmployeeIdEmployeeBenefitsValueType.FromString(res.Type).Equals(PostV1EmployeesEmployeeIdEmployeeBenefitsValueType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Str != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Str));
                    return;
                }
                if (res.ArrayOf2 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOf2));
                    return;
                }

            }

        }

    }
}