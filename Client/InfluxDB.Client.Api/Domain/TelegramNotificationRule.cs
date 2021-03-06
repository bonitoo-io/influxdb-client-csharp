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
    /// TelegramNotificationRule
    /// </summary>
    [DataContract]
    public partial class TelegramNotificationRule : TelegramNotificationRuleBase,  IEquatable<TelegramNotificationRule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelegramNotificationRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TelegramNotificationRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TelegramNotificationRule" /> class.
        /// </summary>
        public TelegramNotificationRule(string endpointID = default(string), string orgID = default(string), string taskID = default(string), TaskStatusType status = default(TaskStatusType), string name = default(string), string sleepUntil = default(string), string every = default(string), string offset = default(string), string runbookLink = default(string), int? limitEvery = default(int?), int? limit = default(int?), List<TagRule> tagRules = default(List<TagRule>), string description = default(string), List<StatusRule> statusRules = default(List<StatusRule>), List<Label> labels = default(List<Label>), NotificationRuleBaseLinks links = default(NotificationRuleBaseLinks), TypeEnum type = TypeEnum.Telegram, string messageTemplate = default(string), ParseModeEnum? parseMode = default(ParseModeEnum?), bool? disableWebPagePreview = default(bool?)) : base(type, messageTemplate, parseMode, disableWebPagePreview, endpointID, orgID, taskID, status, name, sleepUntil, every, offset, runbookLink, limitEvery, limit, tagRules, description, statusRules, labels, links)
        {
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelegramNotificationRule {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
            return this.Equals(input as TelegramNotificationRule);
        }

        /// <summary>
        /// Returns true if TelegramNotificationRule instances are equal
        /// </summary>
        /// <param name="input">Instance of TelegramNotificationRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelegramNotificationRule input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
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
                return hashCode;
            }
        }

    }

}
