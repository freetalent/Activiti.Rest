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
    /// TaskRequest
    /// </summary>
    [DataContract]
    public partial class TaskRequest :  IEquatable<TaskRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskRequest" /> class.
        /// </summary>
        /// <param name="Owner">Owner.</param>
        /// <param name="Assignee">Assignee.</param>
        /// <param name="DelegationState">DelegationState.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="DueDate">DueDate.</param>
        /// <param name="Priority">Priority.</param>
        /// <param name="ParentTaskId">ParentTaskId.</param>
        /// <param name="Category">Category.</param>
        /// <param name="TenantId">TenantId.</param>
        /// <param name="FormKey">FormKey.</param>
        /// <param name="OwnerSet">OwnerSet (default to false).</param>
        /// <param name="AssigneeSet">AssigneeSet (default to false).</param>
        /// <param name="DelegationStateSet">DelegationStateSet (default to false).</param>
        /// <param name="NameSet">NameSet (default to false).</param>
        /// <param name="DescriptionSet">DescriptionSet (default to false).</param>
        /// <param name="DuedateSet">DuedateSet (default to false).</param>
        /// <param name="PrioritySet">PrioritySet (default to false).</param>
        /// <param name="ParentTaskIdSet">ParentTaskIdSet (default to false).</param>
        /// <param name="CategorySet">CategorySet (default to false).</param>
        /// <param name="TenantIdSet">TenantIdSet (default to false).</param>
        /// <param name="FormKeySet">FormKeySet (default to false).</param>
        public TaskRequest(string Owner = default(string), string Assignee = default(string), string DelegationState = default(string), string Name = default(string), string Description = default(string), DateTime? DueDate = default(DateTime?), int? Priority = default(int?), string ParentTaskId = default(string), string Category = default(string), string TenantId = default(string), string FormKey = default(string), bool? OwnerSet = false, bool? AssigneeSet = false, bool? DelegationStateSet = false, bool? NameSet = false, bool? DescriptionSet = false, bool? DuedateSet = false, bool? PrioritySet = false, bool? ParentTaskIdSet = false, bool? CategorySet = false, bool? TenantIdSet = false, bool? FormKeySet = false)
        {
            this.Owner = Owner;
            this.Assignee = Assignee;
            this.DelegationState = DelegationState;
            this.Name = Name;
            this.Description = Description;
            this.DueDate = DueDate;
            this.Priority = Priority;
            this.ParentTaskId = ParentTaskId;
            this.Category = Category;
            this.TenantId = TenantId;
            this.FormKey = FormKey;
            // use default value if no "OwnerSet" provided
            if (OwnerSet == null)
            {
                this.OwnerSet = false;
            }
            else
            {
                this.OwnerSet = OwnerSet;
            }
            // use default value if no "AssigneeSet" provided
            if (AssigneeSet == null)
            {
                this.AssigneeSet = false;
            }
            else
            {
                this.AssigneeSet = AssigneeSet;
            }
            // use default value if no "DelegationStateSet" provided
            if (DelegationStateSet == null)
            {
                this.DelegationStateSet = false;
            }
            else
            {
                this.DelegationStateSet = DelegationStateSet;
            }
            // use default value if no "NameSet" provided
            if (NameSet == null)
            {
                this.NameSet = false;
            }
            else
            {
                this.NameSet = NameSet;
            }
            // use default value if no "DescriptionSet" provided
            if (DescriptionSet == null)
            {
                this.DescriptionSet = false;
            }
            else
            {
                this.DescriptionSet = DescriptionSet;
            }
            // use default value if no "DuedateSet" provided
            if (DuedateSet == null)
            {
                this.DuedateSet = false;
            }
            else
            {
                this.DuedateSet = DuedateSet;
            }
            // use default value if no "PrioritySet" provided
            if (PrioritySet == null)
            {
                this.PrioritySet = false;
            }
            else
            {
                this.PrioritySet = PrioritySet;
            }
            // use default value if no "ParentTaskIdSet" provided
            if (ParentTaskIdSet == null)
            {
                this.ParentTaskIdSet = false;
            }
            else
            {
                this.ParentTaskIdSet = ParentTaskIdSet;
            }
            // use default value if no "CategorySet" provided
            if (CategorySet == null)
            {
                this.CategorySet = false;
            }
            else
            {
                this.CategorySet = CategorySet;
            }
            // use default value if no "TenantIdSet" provided
            if (TenantIdSet == null)
            {
                this.TenantIdSet = false;
            }
            else
            {
                this.TenantIdSet = TenantIdSet;
            }
            // use default value if no "FormKeySet" provided
            if (FormKeySet == null)
            {
                this.FormKeySet = false;
            }
            else
            {
                this.FormKeySet = FormKeySet;
            }
        }
        
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
        /// Gets or Sets DelegationState
        /// </summary>
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
        /// Gets or Sets ParentTaskId
        /// </summary>
        [DataMember(Name="parentTaskId", EmitDefaultValue=false)]
        public string ParentTaskId { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets FormKey
        /// </summary>
        [DataMember(Name="formKey", EmitDefaultValue=false)]
        public string FormKey { get; set; }

        /// <summary>
        /// Gets or Sets OwnerSet
        /// </summary>
        [DataMember(Name="ownerSet", EmitDefaultValue=false)]
        public bool? OwnerSet { get; set; }

        /// <summary>
        /// Gets or Sets AssigneeSet
        /// </summary>
        [DataMember(Name="assigneeSet", EmitDefaultValue=false)]
        public bool? AssigneeSet { get; set; }

        /// <summary>
        /// Gets or Sets DelegationStateSet
        /// </summary>
        [DataMember(Name="delegationStateSet", EmitDefaultValue=false)]
        public bool? DelegationStateSet { get; set; }

        /// <summary>
        /// Gets or Sets NameSet
        /// </summary>
        [DataMember(Name="nameSet", EmitDefaultValue=false)]
        public bool? NameSet { get; set; }

        /// <summary>
        /// Gets or Sets DescriptionSet
        /// </summary>
        [DataMember(Name="descriptionSet", EmitDefaultValue=false)]
        public bool? DescriptionSet { get; set; }

        /// <summary>
        /// Gets or Sets DuedateSet
        /// </summary>
        [DataMember(Name="duedateSet", EmitDefaultValue=false)]
        public bool? DuedateSet { get; set; }

        /// <summary>
        /// Gets or Sets PrioritySet
        /// </summary>
        [DataMember(Name="prioritySet", EmitDefaultValue=false)]
        public bool? PrioritySet { get; set; }

        /// <summary>
        /// Gets or Sets ParentTaskIdSet
        /// </summary>
        [DataMember(Name="parentTaskIdSet", EmitDefaultValue=false)]
        public bool? ParentTaskIdSet { get; set; }

        /// <summary>
        /// Gets or Sets CategorySet
        /// </summary>
        [DataMember(Name="categorySet", EmitDefaultValue=false)]
        public bool? CategorySet { get; set; }

        /// <summary>
        /// Gets or Sets TenantIdSet
        /// </summary>
        [DataMember(Name="tenantIdSet", EmitDefaultValue=false)]
        public bool? TenantIdSet { get; set; }

        /// <summary>
        /// Gets or Sets FormKeySet
        /// </summary>
        [DataMember(Name="formKeySet", EmitDefaultValue=false)]
        public bool? FormKeySet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskRequest {\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
            sb.Append("  DelegationState: ").Append(DelegationState).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  ParentTaskId: ").Append(ParentTaskId).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  FormKey: ").Append(FormKey).Append("\n");
            sb.Append("  OwnerSet: ").Append(OwnerSet).Append("\n");
            sb.Append("  AssigneeSet: ").Append(AssigneeSet).Append("\n");
            sb.Append("  DelegationStateSet: ").Append(DelegationStateSet).Append("\n");
            sb.Append("  NameSet: ").Append(NameSet).Append("\n");
            sb.Append("  DescriptionSet: ").Append(DescriptionSet).Append("\n");
            sb.Append("  DuedateSet: ").Append(DuedateSet).Append("\n");
            sb.Append("  PrioritySet: ").Append(PrioritySet).Append("\n");
            sb.Append("  ParentTaskIdSet: ").Append(ParentTaskIdSet).Append("\n");
            sb.Append("  CategorySet: ").Append(CategorySet).Append("\n");
            sb.Append("  TenantIdSet: ").Append(TenantIdSet).Append("\n");
            sb.Append("  FormKeySet: ").Append(FormKeySet).Append("\n");
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
            return this.Equals(input as TaskRequest);
        }

        /// <summary>
        /// Returns true if TaskRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskRequest input)
        {
            if (input == null)
                return false;

            return 
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
                    this.ParentTaskId == input.ParentTaskId ||
                    (this.ParentTaskId != null &&
                    this.ParentTaskId.Equals(input.ParentTaskId))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.FormKey == input.FormKey ||
                    (this.FormKey != null &&
                    this.FormKey.Equals(input.FormKey))
                ) && 
                (
                    this.OwnerSet == input.OwnerSet ||
                    (this.OwnerSet != null &&
                    this.OwnerSet.Equals(input.OwnerSet))
                ) && 
                (
                    this.AssigneeSet == input.AssigneeSet ||
                    (this.AssigneeSet != null &&
                    this.AssigneeSet.Equals(input.AssigneeSet))
                ) && 
                (
                    this.DelegationStateSet == input.DelegationStateSet ||
                    (this.DelegationStateSet != null &&
                    this.DelegationStateSet.Equals(input.DelegationStateSet))
                ) && 
                (
                    this.NameSet == input.NameSet ||
                    (this.NameSet != null &&
                    this.NameSet.Equals(input.NameSet))
                ) && 
                (
                    this.DescriptionSet == input.DescriptionSet ||
                    (this.DescriptionSet != null &&
                    this.DescriptionSet.Equals(input.DescriptionSet))
                ) && 
                (
                    this.DuedateSet == input.DuedateSet ||
                    (this.DuedateSet != null &&
                    this.DuedateSet.Equals(input.DuedateSet))
                ) && 
                (
                    this.PrioritySet == input.PrioritySet ||
                    (this.PrioritySet != null &&
                    this.PrioritySet.Equals(input.PrioritySet))
                ) && 
                (
                    this.ParentTaskIdSet == input.ParentTaskIdSet ||
                    (this.ParentTaskIdSet != null &&
                    this.ParentTaskIdSet.Equals(input.ParentTaskIdSet))
                ) && 
                (
                    this.CategorySet == input.CategorySet ||
                    (this.CategorySet != null &&
                    this.CategorySet.Equals(input.CategorySet))
                ) && 
                (
                    this.TenantIdSet == input.TenantIdSet ||
                    (this.TenantIdSet != null &&
                    this.TenantIdSet.Equals(input.TenantIdSet))
                ) && 
                (
                    this.FormKeySet == input.FormKeySet ||
                    (this.FormKeySet != null &&
                    this.FormKeySet.Equals(input.FormKeySet))
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
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.ParentTaskId != null)
                    hashCode = hashCode * 59 + this.ParentTaskId.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.FormKey != null)
                    hashCode = hashCode * 59 + this.FormKey.GetHashCode();
                if (this.OwnerSet != null)
                    hashCode = hashCode * 59 + this.OwnerSet.GetHashCode();
                if (this.AssigneeSet != null)
                    hashCode = hashCode * 59 + this.AssigneeSet.GetHashCode();
                if (this.DelegationStateSet != null)
                    hashCode = hashCode * 59 + this.DelegationStateSet.GetHashCode();
                if (this.NameSet != null)
                    hashCode = hashCode * 59 + this.NameSet.GetHashCode();
                if (this.DescriptionSet != null)
                    hashCode = hashCode * 59 + this.DescriptionSet.GetHashCode();
                if (this.DuedateSet != null)
                    hashCode = hashCode * 59 + this.DuedateSet.GetHashCode();
                if (this.PrioritySet != null)
                    hashCode = hashCode * 59 + this.PrioritySet.GetHashCode();
                if (this.ParentTaskIdSet != null)
                    hashCode = hashCode * 59 + this.ParentTaskIdSet.GetHashCode();
                if (this.CategorySet != null)
                    hashCode = hashCode * 59 + this.CategorySet.GetHashCode();
                if (this.TenantIdSet != null)
                    hashCode = hashCode * 59 + this.TenantIdSet.GetHashCode();
                if (this.FormKeySet != null)
                    hashCode = hashCode * 59 + this.FormKeySet.GetHashCode();
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
