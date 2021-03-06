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
    /// DashboardWithViewProperties
    /// </summary>
    [DataContract]
    public partial class DashboardWithViewProperties : CreateDashboardRequest,  IEquatable<DashboardWithViewProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardWithViewProperties" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DashboardWithViewProperties() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardWithViewProperties" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        /// <param name="cells">cells.</param>
        /// <param name="labels">labels.</param>
        public DashboardWithViewProperties(DashboardLinks links = default(DashboardLinks), DashboardMeta meta = default(DashboardMeta), List<CellWithViewProperties> cells = default(List<CellWithViewProperties>), List<Label> labels = default(List<Label>), string orgID = default(string), string name = default(string), string description = default(string)) : base(orgID, name, description)
        {
            this.Links = links;
            this.Meta = meta;
            this.Cells = cells;
            this.Labels = labels;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public DashboardLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public DashboardMeta Meta { get; set; }

        /// <summary>
        /// Gets or Sets Cells
        /// </summary>
        [DataMember(Name="cells", EmitDefaultValue=false)]
        public List<CellWithViewProperties> Cells { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashboardWithViewProperties {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Cells: ").Append(Cells).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as DashboardWithViewProperties);
        }

        /// <summary>
        /// Returns true if DashboardWithViewProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of DashboardWithViewProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardWithViewProperties input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                ) && base.Equals(input) && 
                (
                    this.Cells == input.Cells ||
                    this.Cells != null &&
                    this.Cells.SequenceEqual(input.Cells)
                ) && base.Equals(input) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
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
                int hashCode = base.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.Cells != null)
                    hashCode = hashCode * 59 + this.Cells.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                return hashCode;
            }
        }

    }

}
