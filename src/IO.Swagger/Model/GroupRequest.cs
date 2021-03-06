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
    /// GroupRequest
    /// </summary>
    [DataContract]
    public partial class GroupRequest :  IEquatable<GroupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupRequest" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Url">Url.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type.</param>
        /// <param name="NameChanged">NameChanged (default to false).</param>
        /// <param name="TypeChanged">TypeChanged (default to false).</param>
        public GroupRequest(string Id = default(string), string Url = default(string), string Name = default(string), string Type = default(string), bool? NameChanged = false, bool? TypeChanged = false)
        {
            this.Id = Id;
            this.Url = Url;
            this.Name = Name;
            this.Type = Type;
            // use default value if no "NameChanged" provided
            if (NameChanged == null)
            {
                this.NameChanged = false;
            }
            else
            {
                this.NameChanged = NameChanged;
            }
            // use default value if no "TypeChanged" provided
            if (TypeChanged == null)
            {
                this.TypeChanged = false;
            }
            else
            {
                this.TypeChanged = TypeChanged;
            }
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets NameChanged
        /// </summary>
        [DataMember(Name="nameChanged", EmitDefaultValue=false)]
        public bool? NameChanged { get; set; }

        /// <summary>
        /// Gets or Sets TypeChanged
        /// </summary>
        [DataMember(Name="typeChanged", EmitDefaultValue=false)]
        public bool? TypeChanged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NameChanged: ").Append(NameChanged).Append("\n");
            sb.Append("  TypeChanged: ").Append(TypeChanged).Append("\n");
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
            return this.Equals(input as GroupRequest);
        }

        /// <summary>
        /// Returns true if GroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupRequest input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.NameChanged == input.NameChanged ||
                    (this.NameChanged != null &&
                    this.NameChanged.Equals(input.NameChanged))
                ) && 
                (
                    this.TypeChanged == input.TypeChanged ||
                    (this.TypeChanged != null &&
                    this.TypeChanged.Equals(input.TypeChanged))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.NameChanged != null)
                    hashCode = hashCode * 59 + this.NameChanged.GetHashCode();
                if (this.TypeChanged != null)
                    hashCode = hashCode * 59 + this.TypeChanged.GetHashCode();
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
