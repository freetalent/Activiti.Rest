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
    /// TaskResponse
    /// </summary>
    [DataContract]
    public partial class TaskResponse :  IEquatable<TaskResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResponse" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Url">Url.</param>
        /// <param name="Owner">Owner.</param>
        /// <param name="Assignee">Assignee.</param>
        /// <param name="DelegationState">Delegation-state of the task, can be null, \&quot;pending\&quot; or \&quot;resolved\&quot;..</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="CreateTime">CreateTime.</param>
        /// <param name="DueDate">DueDate.</param>
        /// <param name="Priority">Priority.</param>
        /// <param name="Suspended">Suspended (default to false).</param>
        /// <param name="TaskDefinitionKey">TaskDefinitionKey.</param>
        /// <param name="TenantId">TenantId.</param>
        /// <param name="Category">Category.</param>
        /// <param name="FormKey">FormKey.</param>
        /// <param name="ParentTaskId">ParentTaskId.</param>
        /// <param name="ParentTaskUrl">ParentTaskUrl.</param>
        /// <param name="ExecutionId">ExecutionId.</param>
        /// <param name="ExecutionUrl">ExecutionUrl.</param>
        /// <param name="ProcessInstanceId">ProcessInstanceId.</param>
        /// <param name="ProcessInstanceUrl">ProcessInstanceUrl.</param>
        /// <param name="ProcessDefinitionId">ProcessDefinitionId.</param>
        /// <param name="ProcessDefinitionUrl">ProcessDefinitionUrl.</param>
        /// <param name="Variables">Variables.</param>
        public TaskResponse(string Id = default(string), string Url = default(string), string Owner = default(string), string Assignee = default(string), string DelegationState = default(string), string Name = default(string), string Description = default(string), DateTime? CreateTime = default(DateTime?), DateTime? DueDate = default(DateTime?), int? Priority = default(int?), bool? Suspended = false, string TaskDefinitionKey = default(string), string TenantId = default(string), string Category = default(string), string FormKey = default(string), string ParentTaskId = default(string), string ParentTaskUrl = default(string), string ExecutionId = default(string), string ExecutionUrl = default(string), string ProcessInstanceId = default(string), string ProcessInstanceUrl = default(string), string ProcessDefinitionId = default(string), string ProcessDefinitionUrl = default(string), List<RestVariable> Variables = default(List<RestVariable>))
        {
            this.Id = Id;
            this.Url = Url;
            this.Owner = Owner;
            this.Assignee = Assignee;
            this.DelegationState = DelegationState;
            this.Name = Name;
            this.Description = Description;
            this.CreateTime = CreateTime;
            this.DueDate = DueDate;
            this.Priority = Priority;
            // use default value if no "Suspended" provided
            if (Suspended == null)
            {
                this.Suspended = false;
            }
            else
            {
                this.Suspended = Suspended;
            }
            this.TaskDefinitionKey = TaskDefinitionKey;
            this.TenantId = TenantId;
            this.Category = Category;
            this.FormKey = FormKey;
            this.ParentTaskId = ParentTaskId;
            this.ParentTaskUrl = ParentTaskUrl;
            this.ExecutionId = ExecutionId;
            this.ExecutionUrl = ExecutionUrl;
            this.ProcessInstanceId = ProcessInstanceId;
            this.ProcessInstanceUrl = ProcessInstanceUrl;
            this.ProcessDefinitionId = ProcessDefinitionId;
            this.ProcessDefinitionUrl = ProcessDefinitionUrl;
            this.Variables = Variables;
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
        /// Delegation-state of the task, can be null, \&quot;pending\&quot; or \&quot;resolved\&quot;.
        /// </summary>
        /// <value>Delegation-state of the task, can be null, \&quot;pending\&quot; or \&quot;resolved\&quot;.</value>
        [DataMember(Name="delegationState", EmitDefaultValue=false)]
        public string DelegationState { get; set; }

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
        /// Gets or Sets CreateTime
        /// </summary>
        [DataMember(Name="createTime", EmitDefaultValue=false)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name="dueDate", EmitDefaultValue=false)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or Sets Suspended
        /// </summary>
        [DataMember(Name="suspended", EmitDefaultValue=false)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// Gets or Sets TaskDefinitionKey
        /// </summary>
        [DataMember(Name="taskDefinitionKey", EmitDefaultValue=false)]
        public string TaskDefinitionKey { get; set; }

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
        /// Gets or Sets FormKey
        /// </summary>
        [DataMember(Name="formKey", EmitDefaultValue=false)]
        public string FormKey { get; set; }

        /// <summary>
        /// Gets or Sets ParentTaskId
        /// </summary>
        [DataMember(Name="parentTaskId", EmitDefaultValue=false)]
        public string ParentTaskId { get; set; }

        /// <summary>
        /// Gets or Sets ParentTaskUrl
        /// </summary>
        [DataMember(Name="parentTaskUrl", EmitDefaultValue=false)]
        public string ParentTaskUrl { get; set; }

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
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public List<RestVariable> Variables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
            sb.Append("  DelegationState: ").Append(DelegationState).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
            sb.Append("  TaskDefinitionKey: ").Append(TaskDefinitionKey).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  FormKey: ").Append(FormKey).Append("\n");
            sb.Append("  ParentTaskId: ").Append(ParentTaskId).Append("\n");
            sb.Append("  ParentTaskUrl: ").Append(ParentTaskUrl).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  ExecutionUrl: ").Append(ExecutionUrl).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ProcessInstanceUrl: ").Append(ProcessInstanceUrl).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionUrl: ").Append(ProcessDefinitionUrl).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
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
            return this.Equals(input as TaskResponse);
        }

        /// <summary>
        /// Returns true if TaskResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskResponse input)
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
                    this.DelegationState == input.DelegationState ||
                    (this.DelegationState != null &&
                    this.DelegationState.Equals(input.DelegationState))
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
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Suspended == input.Suspended ||
                    (this.Suspended != null &&
                    this.Suspended.Equals(input.Suspended))
                ) && 
                (
                    this.TaskDefinitionKey == input.TaskDefinitionKey ||
                    (this.TaskDefinitionKey != null &&
                    this.TaskDefinitionKey.Equals(input.TaskDefinitionKey))
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
                ) && 
                (
                    this.FormKey == input.FormKey ||
                    (this.FormKey != null &&
                    this.FormKey.Equals(input.FormKey))
                ) && 
                (
                    this.ParentTaskId == input.ParentTaskId ||
                    (this.ParentTaskId != null &&
                    this.ParentTaskId.Equals(input.ParentTaskId))
                ) && 
                (
                    this.ParentTaskUrl == input.ParentTaskUrl ||
                    (this.ParentTaskUrl != null &&
                    this.ParentTaskUrl.Equals(input.ParentTaskUrl))
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
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
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
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Assignee != null)
                    hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.DelegationState != null)
                    hashCode = hashCode * 59 + this.DelegationState.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Suspended != null)
                    hashCode = hashCode * 59 + this.Suspended.GetHashCode();
                if (this.TaskDefinitionKey != null)
                    hashCode = hashCode * 59 + this.TaskDefinitionKey.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.FormKey != null)
                    hashCode = hashCode * 59 + this.FormKey.GetHashCode();
                if (this.ParentTaskId != null)
                    hashCode = hashCode * 59 + this.ParentTaskId.GetHashCode();
                if (this.ParentTaskUrl != null)
                    hashCode = hashCode * 59 + this.ParentTaskUrl.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.ExecutionUrl != null)
                    hashCode = hashCode * 59 + this.ExecutionUrl.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ProcessInstanceUrl != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceUrl.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessDefinitionUrl != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionUrl.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
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
