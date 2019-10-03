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
    /// Dialect are options to change the default CSV output format; https://www.w3.org/TR/2015/REC-tabular-metadata-20151217/#dialect-descriptions
    /// </summary>
    [DataContract]
    public partial class Dialect :  IEquatable<Dialect>
    {
        /// <summary>
        /// Defines Annotations
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AnnotationsEnum
        {
            /// <summary>
            /// Enum Group for value: group
            /// </summary>
            [EnumMember(Value = "group")]
            Group = 1,

            /// <summary>
            /// Enum Datatype for value: datatype
            /// </summary>
            [EnumMember(Value = "datatype")]
            Datatype = 2,

            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 3

        }


        /// <summary>
        /// Https://www.w3.org/TR/2015/REC-tabular-data-model-20151217/#columns
        /// </summary>
        /// <value>Https://www.w3.org/TR/2015/REC-tabular-data-model-20151217/#columns</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        public List<AnnotationsEnum> Annotations { get; set; }
        /// <summary>
        /// Format of timestamps
        /// </summary>
        /// <value>Format of timestamps</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DateTimeFormatEnum
        {
            /// <summary>
            /// Enum RFC3339 for value: RFC3339
            /// </summary>
            [EnumMember(Value = "RFC3339")]
            RFC3339 = 1,

            /// <summary>
            /// Enum RFC3339Nano for value: RFC3339Nano
            /// </summary>
            [EnumMember(Value = "RFC3339Nano")]
            RFC3339Nano = 2

        }

        /// <summary>
        /// Format of timestamps
        /// </summary>
        /// <value>Format of timestamps</value>
        [DataMember(Name="dateTimeFormat", EmitDefaultValue=false)]
        public DateTimeFormatEnum? DateTimeFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Dialect" /> class.
        /// </summary>
        /// <param name="header">If true, the results will contain a header row (default to true).</param>
        /// <param name="delimiter">Separator between cells; the default is , (default to &quot;,&quot;).</param>
        /// <param name="annotations">Https://www.w3.org/TR/2015/REC-tabular-data-model-20151217/#columns.</param>
        /// <param name="commentPrefix">Character prefixed to comment strings (default to &quot;#&quot;).</param>
        /// <param name="dateTimeFormat">Format of timestamps (default to DateTimeFormatEnum.RFC3339).</param>
        public Dialect(bool? header = true, string delimiter = ",", List<AnnotationsEnum> annotations = default(List<AnnotationsEnum>), string commentPrefix = "#", DateTimeFormatEnum? dateTimeFormat = DateTimeFormatEnum.RFC3339)
        {
            // use default value if no "header" provided
            if (header == null)
            {
                this.Header = true;
            }
            else
            {
                this.Header = header;
            }
            // use default value if no "delimiter" provided
            if (delimiter == null)
            {
                this.Delimiter = ",";
            }
            else
            {
                this.Delimiter = delimiter;
            }
            this.Annotations = annotations;
            // use default value if no "commentPrefix" provided
            if (commentPrefix == null)
            {
                this.CommentPrefix = "#";
            }
            else
            {
                this.CommentPrefix = commentPrefix;
            }
            // use default value if no "dateTimeFormat" provided
            if (dateTimeFormat == null)
            {
                this.DateTimeFormat = DateTimeFormatEnum.RFC3339;
            }
            else
            {
                this.DateTimeFormat = dateTimeFormat;
            }
        }

        /// <summary>
        /// If true, the results will contain a header row
        /// </summary>
        /// <value>If true, the results will contain a header row</value>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public bool? Header { get; set; }

        /// <summary>
        /// Separator between cells; the default is ,
        /// </summary>
        /// <value>Separator between cells; the default is ,</value>
        [DataMember(Name="delimiter", EmitDefaultValue=false)]
        public string Delimiter { get; set; }


        /// <summary>
        /// Character prefixed to comment strings
        /// </summary>
        /// <value>Character prefixed to comment strings</value>
        [DataMember(Name="commentPrefix", EmitDefaultValue=false)]
        public string CommentPrefix { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dialect {\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Delimiter: ").Append(Delimiter).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  CommentPrefix: ").Append(CommentPrefix).Append("\n");
            sb.Append("  DateTimeFormat: ").Append(DateTimeFormat).Append("\n");
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
            return this.Equals(input as Dialect);
        }

        /// <summary>
        /// Returns true if Dialect instances are equal
        /// </summary>
        /// <param name="input">Instance of Dialect to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dialect input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
                ) && 
                (
                    this.Delimiter == input.Delimiter ||
                    (this.Delimiter != null &&
                    this.Delimiter.Equals(input.Delimiter))
                ) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && 
                (
                    this.CommentPrefix == input.CommentPrefix ||
                    (this.CommentPrefix != null &&
                    this.CommentPrefix.Equals(input.CommentPrefix))
                ) && 
                (
                    this.DateTimeFormat == input.DateTimeFormat ||
                    (this.DateTimeFormat != null &&
                    this.DateTimeFormat.Equals(input.DateTimeFormat))
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
                if (this.Header != null)
                    hashCode = hashCode * 59 + this.Header.GetHashCode();
                if (this.Delimiter != null)
                    hashCode = hashCode * 59 + this.Delimiter.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.CommentPrefix != null)
                    hashCode = hashCode * 59 + this.CommentPrefix.GetHashCode();
                if (this.DateTimeFormat != null)
                    hashCode = hashCode * 59 + this.DateTimeFormat.GetHashCode();
                return hashCode;
            }
        }

    }

}
