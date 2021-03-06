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
    /// RunManually
    /// </summary>
    [DataContract]
    public partial class RunManually :  IEquatable<RunManually>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunManually" /> class.
        /// </summary>
        /// <param name="scheduledFor">Time used for run&#39;s \&quot;now\&quot; option, RFC3339.  Default is the server&#39;s now time..</param>
        public RunManually(DateTime? scheduledFor = default(DateTime?))
        {
            this.ScheduledFor = scheduledFor;
        }

        /// <summary>
        /// Time used for run&#39;s \&quot;now\&quot; option, RFC3339.  Default is the server&#39;s now time.
        /// </summary>
        /// <value>Time used for run&#39;s \&quot;now\&quot; option, RFC3339.  Default is the server&#39;s now time.</value>
        [DataMember(Name="scheduledFor", EmitDefaultValue=false)]
        public DateTime? ScheduledFor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunManually {\n");
            sb.Append("  ScheduledFor: ").Append(ScheduledFor).Append("\n");
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
            return this.Equals(input as RunManually);
        }

        /// <summary>
        /// Returns true if RunManually instances are equal
        /// </summary>
        /// <param name="input">Instance of RunManually to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunManually input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScheduledFor == input.ScheduledFor ||
                    (this.ScheduledFor != null &&
                    this.ScheduledFor.Equals(input.ScheduledFor))
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
                if (this.ScheduledFor != null)
                    hashCode = hashCode * 59 + this.ScheduledFor.GetHashCode();
                return hashCode;
            }
        }

    }

}
