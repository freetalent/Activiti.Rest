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
    /// ProcessInstanceCreateRequest
    /// </summary>
    [DataContract]
    public partial class ProcessInstanceCreateRequest :  IEquatable<ProcessInstanceCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessInstanceCreateRequest" /> class.
        /// </summary>
        /// <param name="ProcessDefinitionId">ProcessDefinitionId.</param>
        /// <param name="ProcessDefinitionKey">ProcessDefinitionKey.</param>
        /// <param name="Message">Message.</param>
        /// <param name="BusinessKey">BusinessKey.</param>
        /// <param name="Variables">Variables.</param>
        /// <param name="TransientVariables">TransientVariables.</param>
        /// <param name="TenantId">TenantId.</param>
        /// <param name="ReturnVariables">ReturnVariables (default to false).</param>
        public ProcessInstanceCreateRequest(string ProcessDefinitionId = default(string), string ProcessDefinitionKey = default(string), string Message = default(string), string BusinessKey = default(string), List<RestVariable> Variables = default(List<RestVariable>), List<RestVariable> TransientVariables = default(List<RestVariable>), string TenantId = default(string), bool? ReturnVariables = false)
        {
            this.ProcessDefinitionId = ProcessDefinitionId;
            this.ProcessDefinitionKey = ProcessDefinitionKey;
            this.Message = Message;
            this.BusinessKey = BusinessKey;
            this.Variables = Variables;
            this.TransientVariables = TransientVariables;
            this.TenantId = TenantId;
            // use default value if no "ReturnVariables" provided
            if (ReturnVariables == null)
            {
                this.ReturnVariables = false;
            }
            else
            {
                this.ReturnVariables = ReturnVariables;
            }
        }
        
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
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets BusinessKey
        /// </summary>
        [DataMember(Name="businessKey", EmitDefaultValue=false)]
        public string BusinessKey { get; set; }

        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public List<RestVariable> Variables { get; set; }

        /// <summary>
        /// Gets or Sets TransientVariables
        /// </summary>
        [DataMember(Name="transientVariables", EmitDefaultValue=false)]
        public List<RestVariable> TransientVariables { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets ReturnVariables
        /// </summary>
        [DataMember(Name="returnVariables", EmitDefaultValue=false)]
        public bool? ReturnVariables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessInstanceCreateRequest {\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  BusinessKey: ").Append(BusinessKey).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  TransientVariables: ").Append(TransientVariables).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ReturnVariables: ").Append(ReturnVariables).Append("\n");
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
            return this.Equals(input as ProcessInstanceCreateRequest);
        }

        /// <summary>
        /// Returns true if ProcessInstanceCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessInstanceCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessInstanceCreateRequest input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.BusinessKey == input.BusinessKey ||
                    (this.BusinessKey != null &&
                    this.BusinessKey.Equals(input.BusinessKey))
                ) && 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
                ) && 
                (
                    this.TransientVariables == input.TransientVariables ||
                    this.TransientVariables != null &&
                    this.TransientVariables.SequenceEqual(input.TransientVariables)
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.ReturnVariables == input.ReturnVariables ||
                    (this.ReturnVariables != null &&
                    this.ReturnVariables.Equals(input.ReturnVariables))
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
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.BusinessKey != null)
                    hashCode = hashCode * 59 + this.BusinessKey.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.TransientVariables != null)
                    hashCode = hashCode * 59 + this.TransientVariables.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ReturnVariables != null)
                    hashCode = hashCode * 59 + this.ReturnVariables.GetHashCode();
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
