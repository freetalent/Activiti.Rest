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
    /// JobResponse
    /// </summary>
    [DataContract]
    public partial class JobResponse :  IEquatable<JobResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobResponse" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Url">Url.</param>
        /// <param name="ProcessInstanceId">ProcessInstanceId.</param>
        /// <param name="ProcessInstanceUrl">ProcessInstanceUrl.</param>
        /// <param name="ProcessDefinitionId">ProcessDefinitionId.</param>
        /// <param name="ProcessDefinitionUrl">ProcessDefinitionUrl.</param>
        /// <param name="ExecutionId">ExecutionId.</param>
        /// <param name="ExecutionUrl">ExecutionUrl.</param>
        /// <param name="Retries">Retries.</param>
        /// <param name="ExceptionMessage">ExceptionMessage.</param>
        /// <param name="DueDate">DueDate.</param>
        /// <param name="TenantId">TenantId.</param>
        public JobResponse(string Id = default(string), string Url = default(string), string ProcessInstanceId = default(string), string ProcessInstanceUrl = default(string), string ProcessDefinitionId = default(string), string ProcessDefinitionUrl = default(string), string ExecutionId = default(string), string ExecutionUrl = default(string), int? Retries = default(int?), string ExceptionMessage = default(string), DateTime? DueDate = default(DateTime?), string TenantId = default(string))
        {
            this.Id = Id;
            this.Url = Url;
            this.ProcessInstanceId = ProcessInstanceId;
            this.ProcessInstanceUrl = ProcessInstanceUrl;
            this.ProcessDefinitionId = ProcessDefinitionId;
            this.ProcessDefinitionUrl = ProcessDefinitionUrl;
            this.ExecutionId = ExecutionId;
            this.ExecutionUrl = ExecutionUrl;
            this.Retries = Retries;
            this.ExceptionMessage = ExceptionMessage;
            this.DueDate = DueDate;
            this.TenantId = TenantId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

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
        /// Gets or Sets ProcessDefinitionId
        /// </summary>
        [DataMember(Name="processDefinitionId", EmitDefaultValue=false)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// Gets or Sets ProcessDefinitionUrl
        /// </summary>
        [DataMember(Name="processDefinitionUrl", EmitDefaultValue=false)]
        public string ProcessDefinitionUrl { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionId
        /// </summary>
        [DataMember(Name="executionId", EmitDefaultValue=false)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionUrl
        /// </summary>
        [DataMember(Name="executionUrl", EmitDefaultValue=false)]
        public string ExecutionUrl { get; set; }

        /// <summary>
        /// Gets or Sets Retries
        /// </summary>
        [DataMember(Name="retries", EmitDefaultValue=false)]
        public int? Retries { get; set; }

        /// <summary>
        /// Gets or Sets ExceptionMessage
        /// </summary>
        [DataMember(Name="exceptionMessage", EmitDefaultValue=false)]
        public string ExceptionMessage { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name="dueDate", EmitDefaultValue=false)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ProcessInstanceUrl: ").Append(ProcessInstanceUrl).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionUrl: ").Append(ProcessDefinitionUrl).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  ExecutionUrl: ").Append(ExecutionUrl).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
            sb.Append("  ExceptionMessage: ").Append(ExceptionMessage).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as JobResponse);
        }

        /// <summary>
        /// Returns true if JobResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of JobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobResponse input)
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
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                ) && 
                (
                    this.ProcessDefinitionId == input.ProcessDefinitionId ||
                    (this.ProcessDefinitionId != null &&
                    this.ProcessDefinitionId.Equals(input.ProcessDefinitionId))
                ) && 
                (
                    this.ProcessDefinitionUrl == input.ProcessDefinitionUrl ||
                    (this.ProcessDefinitionUrl != null &&
                    this.ProcessDefinitionUrl.Equals(input.ProcessDefinitionUrl))
                ) && 
                (
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.ExecutionUrl == input.ExecutionUrl ||
                    (this.ExecutionUrl != null &&
                    this.ExecutionUrl.Equals(input.ExecutionUrl))
                ) && 
                (
                    this.Retries == input.Retries ||
                    (this.Retries != null &&
                    this.Retries.Equals(input.Retries))
                ) && 
                (
                    this.ExceptionMessage == input.ExceptionMessage ||
                    (this.ExceptionMessage != null &&
                    this.ExceptionMessage.Equals(input.ExceptionMessage))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ProcessInstanceUrl != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceUrl.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessDefinitionUrl != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionUrl.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.ExecutionUrl != null)
                    hashCode = hashCode * 59 + this.ExecutionUrl.GetHashCode();
                if (this.Retries != null)
                    hashCode = hashCode * 59 + this.Retries.GetHashCode();
                if (this.ExceptionMessage != null)
                    hashCode = hashCode * 59 + this.ExceptionMessage.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
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