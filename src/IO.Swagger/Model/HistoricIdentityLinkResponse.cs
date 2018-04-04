/* 
 * Activiti REST API
 *
 * # activiti     - Activiti is battle-tested Business Process Management. Organizations across the world depend on the open source platform in a huge range of demanding situations. It supports open standards with BPMN and DMN so you can create processes that suit you.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Activiti.Rest.Client.SwaggerDateConverter;

namespace Activiti.Rest.Model
{
    /// <summary>
    /// HistoricIdentityLinkResponse
    /// </summary>
    [DataContract]
    public partial class HistoricIdentityLinkResponse :  IEquatable<HistoricIdentityLinkResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricIdentityLinkResponse" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="GroupId">GroupId.</param>
        /// <param name="TaskId">TaskId.</param>
        /// <param name="TaskUrl">TaskUrl.</param>
        /// <param name="ProcessInstanceId">ProcessInstanceId.</param>
        /// <param name="ProcessInstanceUrl">ProcessInstanceUrl.</param>
        public HistoricIdentityLinkResponse(string Type = default(string), string UserId = default(string), string GroupId = default(string), string TaskId = default(string), string TaskUrl = default(string), string ProcessInstanceId = default(string), string ProcessInstanceUrl = default(string))
        {
            this.Type = Type;
            this.UserId = UserId;
            this.GroupId = GroupId;
            this.TaskId = TaskId;
            this.TaskUrl = TaskUrl;
            this.ProcessInstanceId = ProcessInstanceId;
            this.ProcessInstanceUrl = ProcessInstanceUrl;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or Sets TaskId
        /// </summary>
        [DataMember(Name="taskId", EmitDefaultValue=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// Gets or Sets TaskUrl
        /// </summary>
        [DataMember(Name="taskUrl", EmitDefaultValue=false)]
        public string TaskUrl { get; set; }

        /// <summary>
        /// Gets or Sets ProcessInstanceId
        /// </summary>
        [DataMember(Name="processInstanceId", EmitDefaultValue=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets ProcessInstanceUrl
        /// </summary>
        [DataMember(Name="processInstanceUrl", EmitDefaultValue=false)]
        public string ProcessInstanceUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricIdentityLinkResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  TaskUrl: ").Append(TaskUrl).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ProcessInstanceUrl: ").Append(ProcessInstanceUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as HistoricIdentityLinkResponse);
        }

        /// <summary>
        /// Returns true if HistoricIdentityLinkResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricIdentityLinkResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricIdentityLinkResponse input)
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
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.TaskUrl == input.TaskUrl ||
                    (this.TaskUrl != null &&
                    this.TaskUrl.Equals(input.TaskUrl))
                ) && 
                (
                    this.ProcessInstanceId == input.ProcessInstanceId ||
                    (this.ProcessInstanceId != null &&
                    this.ProcessInstanceId.Equals(input.ProcessInstanceId))
                ) && 
                (
                    this.ProcessInstanceUrl == input.ProcessInstanceUrl ||
                    (this.ProcessInstanceUrl != null &&
                    this.ProcessInstanceUrl.Equals(input.ProcessInstanceUrl))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskUrl != null)
                    hashCode = hashCode * 59 + this.TaskUrl.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ProcessInstanceUrl != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceUrl.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
