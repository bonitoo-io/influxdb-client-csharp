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
    /// ShardManifest
    /// </summary>
    [DataContract]
    public partial class ShardManifest :  IEquatable<ShardManifest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShardManifest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShardManifest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShardManifest" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="shardOwners">shardOwners (required).</param>
        public ShardManifest(long? id = default(long?), List<ShardOwner> shardOwners = default(List<ShardOwner>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ShardManifest and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "shardOwners" is required (not null)
            if (shardOwners == null)
            {
                throw new InvalidDataException("shardOwners is a required property for ShardManifest and cannot be null");
            }
            else
            {
                this.ShardOwners = shardOwners;
            }
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ShardOwners
        /// </summary>
        [DataMember(Name="shardOwners", EmitDefaultValue=false)]
        public List<ShardOwner> ShardOwners { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShardManifest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ShardOwners: ").Append(ShardOwners).Append("\n");
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
            return this.Equals(input as ShardManifest);
        }

        /// <summary>
        /// Returns true if ShardManifest instances are equal
        /// </summary>
        /// <param name="input">Instance of ShardManifest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShardManifest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ShardOwners == input.ShardOwners ||
                    this.ShardOwners != null &&
                    this.ShardOwners.SequenceEqual(input.ShardOwners)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ShardOwners != null)
                    hashCode = hashCode * 59 + this.ShardOwners.GetHashCode();
                return hashCode;
            }
        }

    }

}
