/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// Object property assignment
    /// </summary>
    [DataContract]
    public partial class MemberAssignment :  IEquatable<MemberAssignment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberAssignment" /> class.
        /// </summary>
        /// <param name="type">Type of AST node.</param>
        /// <param name="member">member.</param>
        /// <param name="init">init.</param>
        public MemberAssignment(string type = default(string), MemberExpression member = default(MemberExpression), Expression init = default(Expression))
        {
            this.Type = type;
            this.Member = member;
            this.Init = init;
        }

        /// <summary>
        /// Type of AST node
        /// </summary>
        /// <value>Type of AST node</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Member
        /// </summary>
        [DataMember(Name="member", EmitDefaultValue=false)]
        public MemberExpression Member { get; set; }

        /// <summary>
        /// Gets or Sets Init
        /// </summary>
        [DataMember(Name="init", EmitDefaultValue=false)]
        [JsonConverter(typeof(MemberAssignmentInitAdapter))]
        public Expression Init { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberAssignment {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Member: ").Append(Member).Append("\n");
            sb.Append("  Init: ").Append(Init).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MemberAssignment);
        }

        /// <summary>
        /// Returns true if MemberAssignment instances are equal
        /// </summary>
        /// <param name="input">Instance of MemberAssignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberAssignment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    
                    (this.Member != null &&
                    this.Member.Equals(input.Member))
                ) && 
                (
                    
                    (this.Init != null &&
                    this.Init.Equals(input.Init))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Member != null)
                    hashCode = hashCode * 59 + this.Member.GetHashCode();
                if (this.Init != null)
                    hashCode = hashCode * 59 + this.Init.GetHashCode();
                return hashCode;
            }
        }

    public class MemberAssignmentInitAdapter : JsonConverter
    {
        private static readonly Dictionary<string[], Type> Types = new Dictionary<string[], Type>(new Client.DiscriminatorComparer<string>())
        {
            {new []{ "ArrayExpression" }, typeof(ArrayExpression)},
            {new []{ "FunctionExpression" }, typeof(FunctionExpression)},
            {new []{ "BinaryExpression" }, typeof(BinaryExpression)},
            {new []{ "CallExpression" }, typeof(CallExpression)},
            {new []{ "ConditionalExpression" }, typeof(ConditionalExpression)},
            {new []{ "LogicalExpression" }, typeof(LogicalExpression)},
            {new []{ "MemberExpression" }, typeof(MemberExpression)},
            {new []{ "IndexExpression" }, typeof(IndexExpression)},
            {new []{ "ObjectExpression" }, typeof(ObjectExpression)},
            {new []{ "ParenExpression" }, typeof(ParenExpression)},
            {new []{ "PipeExpression" }, typeof(PipeExpression)},
            {new []{ "UnaryExpression" }, typeof(UnaryExpression)},
            {new []{ "BooleanLiteral" }, typeof(BooleanLiteral)},
            {new []{ "DateTimeLiteral" }, typeof(DateTimeLiteral)},
            {new []{ "DurationLiteral" }, typeof(DurationLiteral)},
            {new []{ "FloatLiteral" }, typeof(FloatLiteral)},
            {new []{ "IntegerLiteral" }, typeof(IntegerLiteral)},
            {new []{ "PipeLiteral" }, typeof(PipeLiteral)},
            {new []{ "RegexpLiteral" }, typeof(RegexpLiteral)},
            {new []{ "StringLiteral" }, typeof(StringLiteral)},
            {new []{ "UnsignedIntegerLiteral" }, typeof(UnsignedIntegerLiteral)},
            {new []{ "Identifier" }, typeof(Identifier)},
        };

        public override bool CanConvert(Type objectType)
        {
            return false;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return Deserialize(reader, objectType, serializer);
        }

        private object Deserialize(JsonReader reader, Type objectType, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:

                    var jObject = Newtonsoft.Json.Linq.JObject.Load(reader);

                    var discriminator = new []{ "type" }.Select(key => jObject[key].ToString()).ToArray();

                    Types.TryGetValue(discriminator, out var type);

                    return serializer.Deserialize(jObject.CreateReader(), type);

                case JsonToken.StartArray:
                    return DeserializeArray(reader, objectType, serializer);

                default:
                    return serializer.Deserialize(reader, objectType);
            }
        }

        private IList DeserializeArray(JsonReader reader, Type targetType, JsonSerializer serializer)
        {
            var elementType = targetType.GenericTypeArguments.FirstOrDefault();

            var list = (IList) Activator.CreateInstance(targetType);
            while (reader.Read() && reader.TokenType != JsonToken.EndArray)
            {
                list.Add(Deserialize(reader, elementType, serializer));
            }

            return list;
        }
    }
    }

}
