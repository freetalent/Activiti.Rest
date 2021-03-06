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
    /// ProcessDefinitionActionRequest
    /// </summary>
    [DataContract]
    public partial class ProcessDefinitionActionRequest :  IEquatable<ProcessDefinitionActionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessDefinitionActionRequest" /> class.
        /// </summary>
        /// <param name="Action">Action.</param>
        /// <param name="IncludeProcessInstances">Whether or not to suspend/activate running process-instances for this process-definition. If omitted, the process-instances are left in the state they are (default to false).</param>
        /// <param name="Date">Date (ISO-8601) when the suspension/activation should be executed. If omitted, the suspend/activation is effective immediately..</param>
        /// <param name="Category">Category.</param>
        public ProcessDefinitionActionRequest(string Action = default(string), bool? IncludeProcessInstances = false, DateTime? Date = default(DateTime?), string Category = default(string))
        {
            this.Action = Action;
            // use default value if no "IncludeProcessInstances" provided
            if (IncludeProcessInstances == null)
            {
                this.IncludeProcessInstances = false;
            }
            else
            {
                this.IncludeProcessInstances = IncludeProcessInstances;
            }
            this.Date = Date;
            this.Category = Category;
        }
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Whether or not to suspend/activate running process-instances for this process-definition. If omitted, the process-instances are left in the state they are
        /// </summary>
        /// <value>Whether or not to suspend/activate running process-instances for this process-definition. If omitted, the process-instances are left in the state they are</value>
        [DataMember(Name="includeProcessInstances", EmitDefaultValue=false)]
        public bool? IncludeProcessInstances { get; set; }

        /// <summary>
        /// Date (ISO-8601) when the suspension/activation should be executed. If omitted, the suspend/activation is effective immediately.
        /// </summary>
        /// <value>Date (ISO-8601) when the suspension/activation should be executed. If omitted, the suspend/activation is effective immediately.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

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
            sb.Append("class ProcessDefinitionActionRequest {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  IncludeProcessInstances: ").Append(IncludeProcessInstances).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as ProcessDefinitionActionRequest);
        }

        /// <summary>
        /// Returns true if ProcessDefinitionActionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessDefinitionActionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessDefinitionActionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.IncludeProcessInstances == input.IncludeProcessInstances ||
                    (this.IncludeProcessInstances != null &&
                    this.IncludeProcessInstances.Equals(input.IncludeProcessInstances))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.IncludeProcessInstances != null)
                    hashCode = hashCode * 59 + this.IncludeProcessInstances.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
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
