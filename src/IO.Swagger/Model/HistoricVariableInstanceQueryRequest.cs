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
    /// HistoricVariableInstanceQueryRequest
    /// </summary>
    [DataContract]
    public partial class HistoricVariableInstanceQueryRequest :  IEquatable<HistoricVariableInstanceQueryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricVariableInstanceQueryRequest" /> class.
        /// </summary>
        /// <param name="ExcludeTaskVariables">ExcludeTaskVariables (default to false).</param>
        /// <param name="TaskId">TaskId.</param>
        /// <param name="ExecutionId">ExecutionId.</param>
        /// <param name="ProcessInstanceId">ProcessInstanceId.</param>
        /// <param name="VariableName">VariableName.</param>
        /// <param name="VariableNameLike">VariableNameLike.</param>
        /// <param name="Variables">Variables.</param>
        public HistoricVariableInstanceQueryRequest(bool? ExcludeTaskVariables = false, string TaskId = default(string), string ExecutionId = default(string), string ProcessInstanceId = default(string), string VariableName = default(string), string VariableNameLike = default(string), List<QueryVariable> Variables = default(List<QueryVariable>))
        {
            // use default value if no "ExcludeTaskVariables" provided
            if (ExcludeTaskVariables == null)
            {
                this.ExcludeTaskVariables = false;
            }
            else
            {
                this.ExcludeTaskVariables = ExcludeTaskVariables;
            }
            this.TaskId = TaskId;
            this.ExecutionId = ExecutionId;
            this.ProcessInstanceId = ProcessInstanceId;
            this.VariableName = VariableName;
            this.VariableNameLike = VariableNameLike;
            this.Variables = Variables;
        }
        
        /// <summary>
        /// Gets or Sets ExcludeTaskVariables
        /// </summary>
        [DataMember(Name="excludeTaskVariables", EmitDefaultValue=false)]
        public bool? ExcludeTaskVariables { get; set; }

        /// <summary>
        /// Gets or Sets TaskId
        /// </summary>
        [DataMember(Name="taskId", EmitDefaultValue=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionId
        /// </summary>
        [DataMember(Name="executionId", EmitDefaultValue=false)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Gets or Sets ProcessInstanceId
        /// </summary>
        [DataMember(Name="processInstanceId", EmitDefaultValue=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets VariableName
        /// </summary>
        [DataMember(Name="variableName", EmitDefaultValue=false)]
        public string VariableName { get; set; }

        /// <summary>
        /// Gets or Sets VariableNameLike
        /// </summary>
        [DataMember(Name="variableNameLike", EmitDefaultValue=false)]
        public string VariableNameLike { get; set; }

        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public List<QueryVariable> Variables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricVariableInstanceQueryRequest {\n");
            sb.Append("  ExcludeTaskVariables: ").Append(ExcludeTaskVariables).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
            sb.Append("  VariableNameLike: ").Append(VariableNameLike).Append("\n");
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
            return this.Equals(input as HistoricVariableInstanceQueryRequest);
        }

        /// <summary>
        /// Returns true if HistoricVariableInstanceQueryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricVariableInstanceQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricVariableInstanceQueryRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExcludeTaskVariables == input.ExcludeTaskVariables ||
                    (this.ExcludeTaskVariables != null &&
                    this.ExcludeTaskVariables.Equals(input.ExcludeTaskVariables))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.ProcessInstanceId == input.ProcessInstanceId ||
                    (this.ProcessInstanceId != null &&
                    this.ProcessInstanceId.Equals(input.ProcessInstanceId))
                ) && 
                (
                    this.VariableName == input.VariableName ||
                    (this.VariableName != null &&
                    this.VariableName.Equals(input.VariableName))
                ) && 
                (
                    this.VariableNameLike == input.VariableNameLike ||
                    (this.VariableNameLike != null &&
                    this.VariableNameLike.Equals(input.VariableNameLike))
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
                if (this.ExcludeTaskVariables != null)
                    hashCode = hashCode * 59 + this.ExcludeTaskVariables.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.VariableName != null)
                    hashCode = hashCode * 59 + this.VariableName.GetHashCode();
                if (this.VariableNameLike != null)
                    hashCode = hashCode * 59 + this.VariableNameLike.GetHashCode();
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
