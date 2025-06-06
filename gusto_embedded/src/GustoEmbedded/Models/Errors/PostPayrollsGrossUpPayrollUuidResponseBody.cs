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
    using GustoEmbedded.Models.Errors;
    using GustoEmbedded.Utils;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    

    public class PostPayrollsGrossUpPayrollUuidResponseBodyType
    {
        private PostPayrollsGrossUpPayrollUuidResponseBodyType(string value) { Value = value; }

        public string Value { get; private set; }
        public static PostPayrollsGrossUpPayrollUuidResponseBodyType UnprocessableEntityErrorObject1 { get { return new PostPayrollsGrossUpPayrollUuidResponseBodyType("Unprocessable-Entity-Error-Object1"); } }
        
        public static PostPayrollsGrossUpPayrollUuidResponseBodyType PayrollBlockersError { get { return new PostPayrollsGrossUpPayrollUuidResponseBodyType("Payroll-Blockers-Error"); } }
        
        public static PostPayrollsGrossUpPayrollUuidResponseBodyType Null { get { return new PostPayrollsGrossUpPayrollUuidResponseBodyType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(PostPayrollsGrossUpPayrollUuidResponseBodyType v) { return v.Value; }
        public static PostPayrollsGrossUpPayrollUuidResponseBodyType FromString(string v) {
            switch(v) {
                case "Unprocessable-Entity-Error-Object1": return UnprocessableEntityErrorObject1;
                case "Payroll-Blockers-Error": return PayrollBlockersError;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for PostPayrollsGrossUpPayrollUuidResponseBodyType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((PostPayrollsGrossUpPayrollUuidResponseBodyType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// Unprocessable Entity
    /// </summary>
    [JsonConverter(typeof(PostPayrollsGrossUpPayrollUuidResponseBody.PostPayrollsGrossUpPayrollUuidResponseBodyConverter))]
    public class PostPayrollsGrossUpPayrollUuidResponseBody {
        public PostPayrollsGrossUpPayrollUuidResponseBody(PostPayrollsGrossUpPayrollUuidResponseBodyType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public UnprocessableEntityErrorObject1? UnprocessableEntityErrorObject1 { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public PayrollBlockersError? PayrollBlockersError { get; set; }

        public PostPayrollsGrossUpPayrollUuidResponseBodyType Type { get; set; }


        public static PostPayrollsGrossUpPayrollUuidResponseBody CreateUnprocessableEntityErrorObject1(UnprocessableEntityErrorObject1 unprocessableEntityErrorObject1) {
            PostPayrollsGrossUpPayrollUuidResponseBodyType typ = PostPayrollsGrossUpPayrollUuidResponseBodyType.UnprocessableEntityErrorObject1;

            PostPayrollsGrossUpPayrollUuidResponseBody res = new PostPayrollsGrossUpPayrollUuidResponseBody(typ);
            res.UnprocessableEntityErrorObject1 = unprocessableEntityErrorObject1;
            return res;
        }

        public static PostPayrollsGrossUpPayrollUuidResponseBody CreatePayrollBlockersError(PayrollBlockersError payrollBlockersError) {
            PostPayrollsGrossUpPayrollUuidResponseBodyType typ = PostPayrollsGrossUpPayrollUuidResponseBodyType.PayrollBlockersError;

            PostPayrollsGrossUpPayrollUuidResponseBody res = new PostPayrollsGrossUpPayrollUuidResponseBody(typ);
            res.PayrollBlockersError = payrollBlockersError;
            return res;
        }

        public static PostPayrollsGrossUpPayrollUuidResponseBody CreateNull() {
            PostPayrollsGrossUpPayrollUuidResponseBodyType typ = PostPayrollsGrossUpPayrollUuidResponseBodyType.Null;
            return new PostPayrollsGrossUpPayrollUuidResponseBody(typ);
        }

        public class PostPayrollsGrossUpPayrollUuidResponseBodyConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(PostPayrollsGrossUpPayrollUuidResponseBody);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var json = JRaw.Create(reader).ToString();
                if (json == "null")
                {
                    return null;
                }

                var fallbackCandidates = new List<(System.Type, object, string)>();

                try
                {
                    return new PostPayrollsGrossUpPayrollUuidResponseBody(PostPayrollsGrossUpPayrollUuidResponseBodyType.UnprocessableEntityErrorObject1)
                    {
                        UnprocessableEntityErrorObject1 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<UnprocessableEntityErrorObject1>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(UnprocessableEntityErrorObject1), new PostPayrollsGrossUpPayrollUuidResponseBody(PostPayrollsGrossUpPayrollUuidResponseBodyType.UnprocessableEntityErrorObject1), "UnprocessableEntityErrorObject1"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    return new PostPayrollsGrossUpPayrollUuidResponseBody(PostPayrollsGrossUpPayrollUuidResponseBodyType.PayrollBlockersError)
                    {
                        PayrollBlockersError = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<PayrollBlockersError>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(PayrollBlockersError), new PostPayrollsGrossUpPayrollUuidResponseBody(PostPayrollsGrossUpPayrollUuidResponseBodyType.PayrollBlockersError), "PayrollBlockersError"));
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
                PostPayrollsGrossUpPayrollUuidResponseBody res = (PostPayrollsGrossUpPayrollUuidResponseBody)value;
                if (PostPayrollsGrossUpPayrollUuidResponseBodyType.FromString(res.Type).Equals(PostPayrollsGrossUpPayrollUuidResponseBodyType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.UnprocessableEntityErrorObject1 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.UnprocessableEntityErrorObject1));
                    return;
                }
                if (res.PayrollBlockersError != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.PayrollBlockersError));
                    return;
                }

            }

        }

    }
}