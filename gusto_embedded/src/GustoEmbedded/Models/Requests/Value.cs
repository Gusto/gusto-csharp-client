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
    

    public class ValueType
    {
        private ValueType(string value) { Value = value; }

        public string Value { get; private set; }
        public static ValueType Str { get { return new ValueType("str"); } }
        
        public static ValueType ArrayOf2 { get { return new ValueType("arrayOf2"); } }
        
        public static ValueType Null { get { return new ValueType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(ValueType v) { return v.Value; }
        public static ValueType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "arrayOf2": return ArrayOf2;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for ValueType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((ValueType)obj).Value);
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
    [JsonConverter(typeof(Value.ValueConverter))]
    public class Value {
        public Value(ValueType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<Models.Requests.Two>? ArrayOf2 { get; set; }

        public ValueType Type { get; set; }


        public static Value CreateStr(string str) {
            ValueType typ = ValueType.Str;

            Value res = new Value(typ);
            res.Str = str;
            return res;
        }

        public static Value CreateArrayOf2(List<Models.Requests.Two> arrayOf2) {
            ValueType typ = ValueType.ArrayOf2;

            Value res = new Value(typ);
            res.ArrayOf2 = arrayOf2;
            return res;
        }

        public static Value CreateNull() {
            ValueType typ = ValueType.Null;
            return new Value(typ);
        }

        public class ValueConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(Value);

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
                    return new Value(ValueType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    return new Value(ValueType.ArrayOf2)
                    {
                        ArrayOf2 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<Models.Requests.Two>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<Models.Requests.Two>), new Value(ValueType.ArrayOf2), "ArrayOf2"));
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
                Value res = (Value)value;
                if (ValueType.FromString(res.Type).Equals(ValueType.Null))
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