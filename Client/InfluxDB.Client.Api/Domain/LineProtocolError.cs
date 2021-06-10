/* 
 * Influx OSS API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 2.0.0
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
    /// LineProtocolError
    /// </summary>
    [DataContract]
    public partial class LineProtocolError :  IEquatable<LineProtocolError>
    {
        /// <summary>
        /// Code is the machine-readable error code.
        /// </summary>
        /// <value>Code is the machine-readable error code.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum Internalerror for value: internal error
            /// </summary>
            [EnumMember(Value = "internal error")]
            Internalerror = 1,

            /// <summary>
            /// Enum Notfound for value: not found
            /// </summary>
            [EnumMember(Value = "not found")]
            Notfound = 2,

            /// <summary>
            /// Enum Conflict for value: conflict
            /// </summary>
            [EnumMember(Value = "conflict")]
            Conflict = 3,

            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 4,

            /// <summary>
            /// Enum Emptyvalue for value: empty value
            /// </summary>
            [EnumMember(Value = "empty value")]
            Emptyvalue = 5,

            /// <summary>
            /// Enum Unavailable for value: unavailable
            /// </summary>
            [EnumMember(Value = "unavailable")]
            Unavailable = 6

        }

        /// <summary>
        /// Code is the machine-readable error code.
        /// </summary>
        /// <value>Code is the machine-readable error code.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineProtocolError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public LineProtocolError()
        {
        }


        /// <summary>
        /// Message is a human-readable message.
        /// </summary>
        /// <value>Message is a human-readable message.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; private set; }

        /// <summary>
        /// Op describes the logical code operation during error. Useful for debugging.
        /// </summary>
        /// <value>Op describes the logical code operation during error. Useful for debugging.</value>
        [DataMember(Name="op", EmitDefaultValue=false)]
        public string Op { get; private set; }

        /// <summary>
        /// Err is a stack of errors that occurred during processing of the request. Useful for debugging.
        /// </summary>
        /// <value>Err is a stack of errors that occurred during processing of the request. Useful for debugging.</value>
        [DataMember(Name="err", EmitDefaultValue=false)]
        public string Err { get; private set; }

        /// <summary>
        /// First line within sent body containing malformed data
        /// </summary>
        /// <value>First line within sent body containing malformed data</value>
        [DataMember(Name="line", EmitDefaultValue=false)]
        public int? Line { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineProtocolError {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Op: ").Append(Op).Append("\n");
            sb.Append("  Err: ").Append(Err).Append("\n");
            sb.Append("  Line: ").Append(Line).Append("\n");
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
            return this.Equals(input as LineProtocolError);
        }

        /// <summary>
        /// Returns true if LineProtocolError instances are equal
        /// </summary>
        /// <param name="input">Instance of LineProtocolError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineProtocolError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Op == input.Op ||
                    (this.Op != null &&
                    this.Op.Equals(input.Op))
                ) && 
                (
                    this.Err == input.Err ||
                    (this.Err != null &&
                    this.Err.Equals(input.Err))
                ) && 
                (
                    this.Line == input.Line ||
                    (this.Line != null &&
                    this.Line.Equals(input.Line))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Op != null)
                    hashCode = hashCode * 59 + this.Op.GetHashCode();
                if (this.Err != null)
                    hashCode = hashCode * 59 + this.Err.GetHashCode();
                if (this.Line != null)
                    hashCode = hashCode * 59 + this.Line.GetHashCode();
                return hashCode;
            }
        }

    }

}
