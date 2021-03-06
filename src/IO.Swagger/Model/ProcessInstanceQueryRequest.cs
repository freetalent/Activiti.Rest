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
    /// ProcessInstanceQueryRequest
    /// </summary>
    [DataContract]
    public partial class ProcessInstanceQueryRequest :  IEquatable<ProcessInstanceQueryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessInstanceQueryRequest" /> class.
        /// </summary>
        /// <param name="Start">Start.</param>
        /// <param name="Size">Size.</param>
        /// <param name="Sort">Sort.</param>
        /// <param name="Order">Order.</param>
        /// <param name="ProcessInstanceId">ProcessInstanceId.</param>
        /// <param name="ProcessBusinessKey">ProcessBusinessKey.</param>
        /// <param name="ProcessDefinitionId">ProcessDefinitionId.</param>
        /// <param name="ProcessDefinitionKey">ProcessDefinitionKey.</param>
        /// <param name="SuperProcessInstanceId">SuperProcessInstanceId.</param>
        /// <param name="SubProcessInstanceId">SubProcessInstanceId.</param>
        /// <param name="ExcludeSubprocesses">ExcludeSubprocesses (default to false).</param>
        /// <param name="InvolvedUser">InvolvedUser.</param>
        /// <param name="Suspended">Suspended (default to false).</param>
        /// <param name="IncludeProcessVariables">IncludeProcessVariables (default to false).</param>
        /// <param name="Variables">Variables.</param>
        /// <param name="TenantId">TenantId.</param>
        /// <param name="TenantIdLike">TenantIdLike.</param>
        /// <param name="WithoutTenantId">WithoutTenantId (default to false).</param>
        public ProcessInstanceQueryRequest(int? Start = default(int?), int? Size = default(int?), string Sort = default(string), string Order = default(string), string ProcessInstanceId = default(string), string ProcessBusinessKey = default(string), string ProcessDefinitionId = default(string), string ProcessDefinitionKey = default(string), string SuperProcessInstanceId = default(string), string SubProcessInstanceId = default(string), bool? ExcludeSubprocesses = false, string InvolvedUser = default(string), bool? Suspended = false, bool? IncludeProcessVariables = false, List<QueryVariable> Variables = default(List<QueryVariable>), string TenantId = default(string), string TenantIdLike = default(string), bool? WithoutTenantId = false)
        {
            this.Start = Start;
            this.Size = Size;
            this.Sort = Sort;
            this.Order = Order;
            this.ProcessInstanceId = ProcessInstanceId;
            this.ProcessBusinessKey = ProcessBusinessKey;
            this.ProcessDefinitionId = ProcessDefinitionId;
            this.ProcessDefinitionKey = ProcessDefinitionKey;
            this.SuperProcessInstanceId = SuperProcessInstanceId;
            this.SubProcessInstanceId = SubProcessInstanceId;
            // use default value if no "ExcludeSubprocesses" provided
            if (ExcludeSubprocesses == null)
            {
                this.ExcludeSubprocesses = false;
            }
            else
            {
                this.ExcludeSubprocesses = ExcludeSubprocesses;
            }
            this.InvolvedUser = InvolvedUser;
            // use default value if no "Suspended" provided
            if (Suspended == null)
            {
                this.Suspended = false;
            }
            else
            {
                this.Suspended = Suspended;
            }
            // use default value if no "IncludeProcessVariables" provided
            if (IncludeProcessVariables == null)
            {
                this.IncludeProcessVariables = false;
            }
            else
            {
                this.IncludeProcessVariables = IncludeProcessVariables;
            }
            this.Variables = Variables;
            this.TenantId = TenantId;
            this.TenantIdLike = TenantIdLike;
            // use default value if no "WithoutTenantId" provided
            if (WithoutTenantId == null)
            {
                this.WithoutTenantId = false;
            }
            else
            {
                this.WithoutTenantId = WithoutTenantId;
            }
        }
        
        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public int? Start { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public string Sort { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }

        /// <summary>
        /// Gets or Sets ProcessInstanceId
        /// </summary>
        [DataMember(Name="processInstanceId", EmitDefaultValue=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets ProcessBusinessKey
        /// </summary>
        [DataMember(Name="processBusinessKey", EmitDefaultValue=false)]
        public string ProcessBusinessKey { get; set; }

        /// <summary>
        /// Gets or Sets ProcessDefinitionId
        /// </summary>
        [DataMember(Name="processDefinitionId", EmitDefaultValue=false)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// Gets or Sets ProcessDefinitionKey
        /// </summary>
        [DataMember(Name="processDefinitionKey", EmitDefaultValue=false)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// Gets or Sets SuperProcessInstanceId
        /// </summary>
        [DataMember(Name="superProcessInstanceId", EmitDefaultValue=false)]
        public string SuperProcessInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets SubProcessInstanceId
        /// </summary>
        [DataMember(Name="subProcessInstanceId", EmitDefaultValue=false)]
        public string SubProcessInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets ExcludeSubprocesses
        /// </summary>
        [DataMember(Name="excludeSubprocesses", EmitDefaultValue=false)]
        public bool? ExcludeSubprocesses { get; set; }

        /// <summary>
        /// Gets or Sets InvolvedUser
        /// </summary>
        [DataMember(Name="involvedUser", EmitDefaultValue=false)]
        public string InvolvedUser { get; set; }

        /// <summary>
        /// Gets or Sets Suspended
        /// </summary>
        [DataMember(Name="suspended", EmitDefaultValue=false)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// Gets or Sets IncludeProcessVariables
        /// </summary>
        [DataMember(Name="includeProcessVariables", EmitDefaultValue=false)]
        public bool? IncludeProcessVariables { get; set; }

        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public List<QueryVariable> Variables { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets TenantIdLike
        /// </summary>
        [DataMember(Name="tenantIdLike", EmitDefaultValue=false)]
        public string TenantIdLike { get; set; }

        /// <summary>
        /// Gets or Sets WithoutTenantId
        /// </summary>
        [DataMember(Name="withoutTenantId", EmitDefaultValue=false)]
        public bool? WithoutTenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessInstanceQueryRequest {\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ProcessBusinessKey: ").Append(ProcessBusinessKey).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  SuperProcessInstanceId: ").Append(SuperProcessInstanceId).Append("\n");
            sb.Append("  SubProcessInstanceId: ").Append(SubProcessInstanceId).Append("\n");
            sb.Append("  ExcludeSubprocesses: ").Append(ExcludeSubprocesses).Append("\n");
            sb.Append("  InvolvedUser: ").Append(InvolvedUser).Append("\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
            sb.Append("  IncludeProcessVariables: ").Append(IncludeProcessVariables).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  TenantIdLike: ").Append(TenantIdLike).Append("\n");
            sb.Append("  WithoutTenantId: ").Append(WithoutTenantId).Append("\n");
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
            return this.Equals(input as ProcessInstanceQueryRequest);
        }

        /// <summary>
        /// Returns true if ProcessInstanceQueryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessInstanceQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessInstanceQueryRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.ProcessInstanceId == input.ProcessInstanceId ||
                    (this.ProcessInstanceId != null &&
                    this.ProcessInstanceId.Equals(input.ProcessInstanceId))
                ) && 
                (
                    this.ProcessBusinessKey == input.ProcessBusinessKey ||
                    (this.ProcessBusinessKey != null &&
                    this.ProcessBusinessKey.Equals(input.ProcessBusinessKey))
                ) && 
                (
                    this.ProcessDefinitionId == input.ProcessDefinitionId ||
                    (this.ProcessDefinitionId != null &&
                    this.ProcessDefinitionId.Equals(input.ProcessDefinitionId))
                ) && 
                (
                    this.ProcessDefinitionKey == input.ProcessDefinitionKey ||
                    (this.ProcessDefinitionKey != null &&
                    this.ProcessDefinitionKey.Equals(input.ProcessDefinitionKey))
                ) && 
                (
                    this.SuperProcessInstanceId == input.SuperProcessInstanceId ||
                    (this.SuperProcessInstanceId != null &&
                    this.SuperProcessInstanceId.Equals(input.SuperProcessInstanceId))
                ) && 
                (
                    this.SubProcessInstanceId == input.SubProcessInstanceId ||
                    (this.SubProcessInstanceId != null &&
                    this.SubProcessInstanceId.Equals(input.SubProcessInstanceId))
                ) && 
                (
                    this.ExcludeSubprocesses == input.ExcludeSubprocesses ||
                    (this.ExcludeSubprocesses != null &&
                    this.ExcludeSubprocesses.Equals(input.ExcludeSubprocesses))
                ) && 
                (
                    this.InvolvedUser == input.InvolvedUser ||
                    (this.InvolvedUser != null &&
                    this.InvolvedUser.Equals(input.InvolvedUser))
                ) && 
                (
                    this.Suspended == input.Suspended ||
                    (this.Suspended != null &&
                    this.Suspended.Equals(input.Suspended))
                ) && 
                (
                    this.IncludeProcessVariables == input.IncludeProcessVariables ||
                    (this.IncludeProcessVariables != null &&
                    this.IncludeProcessVariables.Equals(input.IncludeProcessVariables))
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
                    this.TenantIdLike == input.TenantIdLike ||
                    (this.TenantIdLike != null &&
                    this.TenantIdLike.Equals(input.TenantIdLike))
                ) && 
                (
                    this.WithoutTenantId == input.WithoutTenantId ||
                    (this.WithoutTenantId != null &&
                    this.WithoutTenantId.Equals(input.WithoutTenantId))
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
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ProcessBusinessKey != null)
                    hashCode = hashCode * 59 + this.ProcessBusinessKey.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.SuperProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.SuperProcessInstanceId.GetHashCode();
                if (this.SubProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.SubProcessInstanceId.GetHashCode();
                if (this.ExcludeSubprocesses != null)
                    hashCode = hashCode * 59 + this.ExcludeSubprocesses.GetHashCode();
                if (this.InvolvedUser != null)
                    hashCode = hashCode * 59 + this.InvolvedUser.GetHashCode();
                if (this.Suspended != null)
                    hashCode = hashCode * 59 + this.Suspended.GetHashCode();
                if (this.IncludeProcessVariables != null)
                    hashCode = hashCode * 59 + this.IncludeProcessVariables.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.TenantIdLike != null)
                    hashCode = hashCode * 59 + this.TenantIdLike.GetHashCode();
                if (this.WithoutTenantId != null)
                    hashCode = hashCode * 59 + this.WithoutTenantId.GetHashCode();
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
