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
    /// Message
    /// </summary>
    [DataContract]
    public partial class Message :  IEquatable<Message>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="XmlRowNumber">XmlRowNumber.</param>
        /// <param name="XmlColumnNumber">XmlColumnNumber.</param>
        /// <param name="ExtensionElements">ExtensionElements.</param>
        /// <param name="Attributes">Attributes.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ItemRef">ItemRef.</param>
        public Message(string Id = default(string), int? XmlRowNumber = default(int?), int? XmlColumnNumber = default(int?), Dictionary<string, List<ExtensionElement>> ExtensionElements = default(Dictionary<string, List<ExtensionElement>>), Dictionary<string, List<ExtensionAttribute>> Attributes = default(Dictionary<string, List<ExtensionAttribute>>), string Name = default(string), string ItemRef = default(string))
        {
            this.Id = Id;
            this.XmlRowNumber = XmlRowNumber;
            this.XmlColumnNumber = XmlColumnNumber;
            this.ExtensionElements = ExtensionElements;
            this.Attributes = Attributes;
            this.Name = Name;
            this.ItemRef = ItemRef;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets XmlRowNumber
        /// </summary>
        [DataMember(Name="xmlRowNumber", EmitDefaultValue=false)]
        public int? XmlRowNumber { get; set; }

        /// <summary>
        /// Gets or Sets XmlColumnNumber
        /// </summary>
        [DataMember(Name="xmlColumnNumber", EmitDefaultValue=false)]
        public int? XmlColumnNumber { get; set; }

        /// <summary>
        /// Gets or Sets ExtensionElements
        /// </summary>
        [DataMember(Name="extensionElements", EmitDefaultValue=false)]
        public Dictionary<string, List<ExtensionElement>> ExtensionElements { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, List<ExtensionAttribute>> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ItemRef
        /// </summary>
        [DataMember(Name="itemRef", EmitDefaultValue=false)]
        public string ItemRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  XmlRowNumber: ").Append(XmlRowNumber).Append("\n");
            sb.Append("  XmlColumnNumber: ").Append(XmlColumnNumber).Append("\n");
            sb.Append("  ExtensionElements: ").Append(ExtensionElements).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ItemRef: ").Append(ItemRef).Append("\n");
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
            return this.Equals(input as Message);
        }

        /// <summary>
        /// Returns true if Message instances are equal
        /// </summary>
        /// <param name="input">Instance of Message to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Message input)
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
                    this.XmlRowNumber == input.XmlRowNumber ||
                    (this.XmlRowNumber != null &&
                    this.XmlRowNumber.Equals(input.XmlRowNumber))
                ) && 
                (
                    this.XmlColumnNumber == input.XmlColumnNumber ||
                    (this.XmlColumnNumber != null &&
                    this.XmlColumnNumber.Equals(input.XmlColumnNumber))
                ) && 
                (
                    this.ExtensionElements == input.ExtensionElements ||
                    this.ExtensionElements != null &&
                    this.ExtensionElements.SequenceEqual(input.ExtensionElements)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ItemRef == input.ItemRef ||
                    (this.ItemRef != null &&
                    this.ItemRef.Equals(input.ItemRef))
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
                if (this.XmlRowNumber != null)
                    hashCode = hashCode * 59 + this.XmlRowNumber.GetHashCode();
                if (this.XmlColumnNumber != null)
                    hashCode = hashCode * 59 + this.XmlColumnNumber.GetHashCode();
                if (this.ExtensionElements != null)
                    hashCode = hashCode * 59 + this.ExtensionElements.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ItemRef != null)
                    hashCode = hashCode * 59 + this.ItemRef.GetHashCode();
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
