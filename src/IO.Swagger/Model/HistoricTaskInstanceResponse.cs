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
    /// HistoricTaskInstanceResponse
    /// </summary>
    [DataContract]
    public partial class HistoricTaskInstanceResponse :  IEquatable<HistoricTaskInstanceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricTaskInstanceResponse" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="ProcessDefinitionId">ProcessDefinitionId.</param>
        /// <param name="ProcessDefinitionUrl">ProcessDefinitionUrl.</param>
        /// <param name="ProcessInstanceId">ProcessInstanceId.</param>
        /// <param name="ProcessInstanceUrl">ProcessInstanceUrl.</param>
        /// <param name="ExecutionId">ExecutionId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="DeleteReason">DeleteReason.</param>
        /// <param name="Owner">Owner.</param>
        /// <param name="Assignee">Assignee.</param>
        /// <param name="StartTime">StartTime.</param>
        /// <param name="EndTime">EndTime.</param>
        /// <param name="DurationInMillis">DurationInMillis.</param>
        /// <param name="WorkTimeInMillis">WorkTimeInMillis.</param>
        /// <param name="ClaimTime">ClaimTime.</param>
        /// <param name="TaskDefinitionKey">TaskDefinitionKey.</param>
        /// <param name="FormKey">FormKey.</param>
        /// <param name="Priority">Priority.</param>
        /// <param name="DueDate">DueDate.</param>
        /// <param name="ParentTaskId">ParentTaskId.</param>
        /// <param name="Url">Url.</param>
        /// <param name="Variables">Variables.</param>
        /// <param name="TenantId">TenantId.</param>
        /// <param name="Category">Category.</param>
        public HistoricTaskInstanceResponse(string Id = default(string), string ProcessDefinitionId = default(string), string ProcessDefinitionUrl = default(string), string ProcessInstanceId = default(string), string ProcessInstanceUrl = default(string), string ExecutionId = default(string), string Name = default(string), string Description = default(string), string DeleteReason = default(string), string Owner = default(string), string Assignee = default(string), DateTime? StartTime = default(DateTime?), DateTime? EndTime = default(DateTime?), long? DurationInMillis = default(long?), long? WorkTimeInMillis = default(long?), DateTime? ClaimTime = default(DateTime?), string TaskDefinitionKey = default(string), string FormKey = default(string), int? Priority = default(int?), DateTime? DueDate = default(DateTime?), string ParentTaskId = default(string), string Url = default(string), List<RestVariable> Variables = default(List<RestVariable>), string TenantId = default(string), string Category = default(string))
        {
            this.Id = Id;
            this.ProcessDefinitionId = ProcessDefinitionId;
            this.ProcessDefinitionUrl = ProcessDefinitionUrl;
            this.ProcessInstanceId = ProcessInstanceId;
            this.ProcessInstanceUrl = ProcessInstanceUrl;
            this.ExecutionId = ExecutionId;
            this.Name = Name;
            this.Description = Description;
            this.DeleteReason = DeleteReason;
            this.Owner = Owner;
            this.Assignee = Assignee;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.DurationInMillis = DurationInMillis;
            this.WorkTimeInMillis = WorkTimeInMillis;
            this.ClaimTime = ClaimTime;
            this.TaskDefinitionKey = TaskDefinitionKey;
            this.FormKey = FormKey;
            this.Priority = Priority;
            this.DueDate = DueDate;
            this.ParentTaskId = ParentTaskId;
            this.Url = Url;
            this.Variables = Variables;
            this.TenantId = TenantId;
            this.Category = Category;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

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
        /// Gets or Sets ExecutionId
        /// </summary>
        [DataMember(Name="executionId", EmitDefaultValue=false)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DeleteReason
        /// </summary>
        [DataMember(Name="deleteReason", EmitDefaultValue=false)]
        public string DeleteReason { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or Sets Assignee
        /// </summary>
        [DataMember(Name="assignee", EmitDefaultValue=false)]
        public string Assignee { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or Sets DurationInMillis
        /// </summary>
        [DataMember(Name="durationInMillis", EmitDefaultValue=false)]
        public long? DurationInMillis { get; set; }

        /// <summary>
        /// Gets or Sets WorkTimeInMillis
        /// </summary>
        [DataMember(Name="workTimeInMillis", EmitDefaultValue=false)]
        public long? WorkTimeInMillis { get; set; }

        /// <summary>
        /// Gets or Sets ClaimTime
        /// </summary>
        [DataMember(Name="claimTime", EmitDefaultValue=false)]
        public DateTime? ClaimTime { get; set; }

        /// <summary>
        /// Gets or Sets TaskDefinitionKey
        /// </summary>
        [DataMember(Name="taskDefinitionKey", EmitDefaultValue=false)]
        public string TaskDefinitionKey { get; set; }

        /// <summary>
        /// Gets or Sets FormKey
        /// </summary>
        [DataMember(Name="formKey", EmitDefaultValue=false)]
        public string FormKey { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name="dueDate", EmitDefaultValue=false)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or Sets ParentTaskId
        /// </summary>
        [DataMember(Name="parentTaskId", EmitDefaultValue=false)]
        public string ParentTaskId { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public List<RestVariable> Variables { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricTaskInstanceResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionUrl: ").Append(ProcessDefinitionUrl).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ProcessInstanceUrl: ").Append(ProcessInstanceUrl).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DeleteReason: ").Append(DeleteReason).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  DurationInMillis: ").Append(DurationInMillis).Append("\n");
            sb.Append("  WorkTimeInMillis: ").Append(WorkTimeInMillis).Append("\n");
            sb.Append("  ClaimTime: ").Append(ClaimTime).Append("\n");
            sb.Append("  TaskDefinitionKey: ").Append(TaskDefinitionKey).Append("\n");
            sb.Append("  FormKey: ").Append(FormKey).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  ParentTaskId: ").Append(ParentTaskId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(input as HistoricTaskInstanceResponse);
        }

        /// <summary>
        /// Returns true if HistoricTaskInstanceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricTaskInstanceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricTaskInstanceResponse input)
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
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DeleteReason == input.DeleteReason ||
                    (this.DeleteReason != null &&
                    this.DeleteReason.Equals(input.DeleteReason))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Assignee == input.Assignee ||
                    (this.Assignee != null &&
                    this.Assignee.Equals(input.Assignee))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.DurationInMillis == input.DurationInMillis ||
                    (this.DurationInMillis != null &&
                    this.DurationInMillis.Equals(input.DurationInMillis))
                ) && 
                (
                    this.WorkTimeInMillis == input.WorkTimeInMillis ||
                    (this.WorkTimeInMillis != null &&
                    this.WorkTimeInMillis.Equals(input.WorkTimeInMillis))
                ) && 
                (
                    this.ClaimTime == input.ClaimTime ||
                    (this.ClaimTime != null &&
                    this.ClaimTime.Equals(input.ClaimTime))
                ) && 
                (
                    this.TaskDefinitionKey == input.TaskDefinitionKey ||
                    (this.TaskDefinitionKey != null &&
                    this.TaskDefinitionKey.Equals(input.TaskDefinitionKey))
                ) && 
                (
                    this.FormKey == input.FormKey ||
                    (this.FormKey != null &&
                    this.FormKey.Equals(input.FormKey))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.ParentTaskId == input.ParentTaskId ||
                    (this.ParentTaskId != null &&
                    this.ParentTaskId.Equals(input.ParentTaskId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
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
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessDefinitionUrl != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionUrl.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ProcessInstanceUrl != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceUrl.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DeleteReason != null)
                    hashCode = hashCode * 59 + this.DeleteReason.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Assignee != null)
                    hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.DurationInMillis != null)
                    hashCode = hashCode * 59 + this.DurationInMillis.GetHashCode();
                if (this.WorkTimeInMillis != null)
                    hashCode = hashCode * 59 + this.WorkTimeInMillis.GetHashCode();
                if (this.ClaimTime != null)
                    hashCode = hashCode * 59 + this.ClaimTime.GetHashCode();
                if (this.TaskDefinitionKey != null)
                    hashCode = hashCode * 59 + this.TaskDefinitionKey.GetHashCode();
                if (this.FormKey != null)
                    hashCode = hashCode * 59 + this.FormKey.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.ParentTaskId != null)
                    hashCode = hashCode * 59 + this.ParentTaskId.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
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
