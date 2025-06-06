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
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    

    public class TaxRequirementValueType
    {
        private TaxRequirementValueType(string value) { Value = value; }

        public string Value { get; private set; }
        public static TaxRequirementValueType Boolean { get { return new TaxRequirementValueType("boolean"); } }
        
        public static TaxRequirementValueType Str { get { return new TaxRequirementValueType("str"); } }
        
        public static TaxRequirementValueType Number { get { return new TaxRequirementValueType("number"); } }
        
        public static TaxRequirementValueType Null { get { return new TaxRequirementValueType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(TaxRequirementValueType v) { return v.Value; }
        public static TaxRequirementValueType FromString(string v) {
            switch(v) {
                case "boolean": return Boolean;
                case "str": return Str;
                case "number": return Number;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for TaxRequirementValueType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((TaxRequirementValueType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// The required value of the requirement identified by `key`
    /// </summary>
    [JsonConverter(typeof(TaxRequirementValue.TaxRequirementValueConverter))]
    public class TaxRequirementValue {
        public TaxRequirementValue(TaxRequirementValueType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        public TaxRequirementValueType Type { get; set; }


        public static TaxRequirementValue CreateBoolean(bool boolean) {
            TaxRequirementValueType typ = TaxRequirementValueType.Boolean;

            TaxRequirementValue res = new TaxRequirementValue(typ);
            res.Boolean = boolean;
            return res;
        }

        public static TaxRequirementValue CreateStr(string str) {
            TaxRequirementValueType typ = TaxRequirementValueType.Str;

            TaxRequirementValue res = new TaxRequirementValue(typ);
            res.Str = str;
            return res;
        }

        public static TaxRequirementValue CreateNumber(double number) {
            TaxRequirementValueType typ = TaxRequirementValueType.Number;

            TaxRequirementValue res = new TaxRequirementValue(typ);
            res.Number = number;
            return res;
        }

        public static TaxRequirementValue CreateNull() {
            TaxRequirementValueType typ = TaxRequirementValueType.Null;
            return new TaxRequirementValue(typ);
        }

        public class TaxRequirementValueConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(TaxRequirementValue);

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
                    var converted = Convert.ToBoolean(json);
                    return new TaxRequirementValue(TaxRequirementValueType.Boolean)
                    {
                        Boolean = converted
                    };
                }
                catch (System.FormatException)
                {
                    // try next option
                }

                if (json[0] == '"' && json[^1] == '"'){
                    return new TaxRequirementValue(TaxRequirementValueType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new TaxRequirementValue(TaxRequirementValueType.Number)
                    {
                        Number = converted
                    };
                }
                catch (System.FormatException)
                {
                    // try next option
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
                TaxRequirementValue res = (TaxRequirementValue)value;
                if (TaxRequirementValueType.FromString(res.Type).Equals(TaxRequirementValueType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Boolean != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Boolean));
                    return;
                }
                if (res.Str != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Str));
                    return;
                }
                if (res.Number != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Number));
                    return;
                }

            }

        }

    }
}