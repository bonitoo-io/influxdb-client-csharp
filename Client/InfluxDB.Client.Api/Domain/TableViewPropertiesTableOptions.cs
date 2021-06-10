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
    /// TableViewPropertiesTableOptions
    /// </summary>
    [DataContract]
    public partial class TableViewPropertiesTableOptions :  IEquatable<TableViewPropertiesTableOptions>
    {
        /// <summary>
        /// Wrapping describes the text wrapping style to be used in table views
        /// </summary>
        /// <value>Wrapping describes the text wrapping style to be used in table views</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WrappingEnum
        {
            /// <summary>
            /// Enum Truncate for value: truncate
            /// </summary>
            [EnumMember(Value = "truncate")]
            Truncate = 1,

            /// <summary>
            /// Enum Wrap for value: wrap
            /// </summary>
            [EnumMember(Value = "wrap")]
            Wrap = 2,

            /// <summary>
            /// Enum SingleLine for value: single-line
            /// </summary>
            [EnumMember(Value = "single-line")]
            SingleLine = 3

        }

        /// <summary>
        /// Wrapping describes the text wrapping style to be used in table views
        /// </summary>
        /// <value>Wrapping describes the text wrapping style to be used in table views</value>
        [DataMember(Name="wrapping", EmitDefaultValue=false)]
        public WrappingEnum? Wrapping { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewPropertiesTableOptions" /> class.
        /// </summary>
        /// <param name="verticalTimeAxis">verticalTimeAxis describes the orientation of the table by indicating whether the time axis will be displayed vertically.</param>
        /// <param name="sortBy">sortBy.</param>
        /// <param name="wrapping">Wrapping describes the text wrapping style to be used in table views.</param>
        /// <param name="fixFirstColumn">fixFirstColumn indicates whether the first column of the table should be locked.</param>
        public TableViewPropertiesTableOptions(bool? verticalTimeAxis = default(bool?), RenamableField sortBy = default(RenamableField), WrappingEnum? wrapping = default(WrappingEnum?), bool? fixFirstColumn = default(bool?))
        {
            this.VerticalTimeAxis = verticalTimeAxis;
            this.SortBy = sortBy;
            this.Wrapping = wrapping;
            this.FixFirstColumn = fixFirstColumn;
        }

        /// <summary>
        /// verticalTimeAxis describes the orientation of the table by indicating whether the time axis will be displayed vertically
        /// </summary>
        /// <value>verticalTimeAxis describes the orientation of the table by indicating whether the time axis will be displayed vertically</value>
        [DataMember(Name="verticalTimeAxis", EmitDefaultValue=false)]
        public bool? VerticalTimeAxis { get; set; }

        /// <summary>
        /// Gets or Sets SortBy
        /// </summary>
        [DataMember(Name="sortBy", EmitDefaultValue=false)]
        public RenamableField SortBy { get; set; }


        /// <summary>
        /// fixFirstColumn indicates whether the first column of the table should be locked
        /// </summary>
        /// <value>fixFirstColumn indicates whether the first column of the table should be locked</value>
        [DataMember(Name="fixFirstColumn", EmitDefaultValue=false)]
        public bool? FixFirstColumn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableViewPropertiesTableOptions {\n");
            sb.Append("  VerticalTimeAxis: ").Append(VerticalTimeAxis).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  Wrapping: ").Append(Wrapping).Append("\n");
            sb.Append("  FixFirstColumn: ").Append(FixFirstColumn).Append("\n");
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
            return this.Equals(input as TableViewPropertiesTableOptions);
        }

        /// <summary>
        /// Returns true if TableViewPropertiesTableOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of TableViewPropertiesTableOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableViewPropertiesTableOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VerticalTimeAxis == input.VerticalTimeAxis ||
                    (this.VerticalTimeAxis != null &&
                    this.VerticalTimeAxis.Equals(input.VerticalTimeAxis))
                ) && 
                (
                    
                    (this.SortBy != null &&
                    this.SortBy.Equals(input.SortBy))
                ) && 
                (
                    this.Wrapping == input.Wrapping ||
                    (this.Wrapping != null &&
                    this.Wrapping.Equals(input.Wrapping))
                ) && 
                (
                    this.FixFirstColumn == input.FixFirstColumn ||
                    (this.FixFirstColumn != null &&
                    this.FixFirstColumn.Equals(input.FixFirstColumn))
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
                if (this.VerticalTimeAxis != null)
                    hashCode = hashCode * 59 + this.VerticalTimeAxis.GetHashCode();
                if (this.SortBy != null)
                    hashCode = hashCode * 59 + this.SortBy.GetHashCode();
                if (this.Wrapping != null)
                    hashCode = hashCode * 59 + this.Wrapping.GetHashCode();
                if (this.FixFirstColumn != null)
                    hashCode = hashCode * 59 + this.FixFirstColumn.GetHashCode();
                return hashCode;
            }
        }

    }

}
