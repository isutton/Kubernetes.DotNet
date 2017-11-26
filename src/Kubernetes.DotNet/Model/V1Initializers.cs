/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.7.10
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
using SwaggerDateConverter = Kubernetes.DotNet.Client.SwaggerDateConverter;

namespace Kubernetes.DotNet.Model
{
    /// <summary>
    /// Initializers tracks the progress of initialization.
    /// </summary>
    [DataContract]
    public partial class V1Initializers :  IEquatable<V1Initializers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Initializers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1Initializers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Initializers" /> class.
        /// </summary>
        /// <param name="Pending">Pending is a list of initializers that must execute in order before this object is visible. When the last pending initializer is removed, and no failing result is set, the initializers struct will be set to nil and the object is considered as initialized and visible to all clients. (required).</param>
        /// <param name="Result">If result is set with the Failure field, the object will be persisted to storage and then deleted, ensuring that other clients can observe the deletion..</param>
        public V1Initializers(List<V1Initializer> Pending = default(List<V1Initializer>), V1Status Result = default(V1Status))
        {
            // to ensure "Pending" is required (not null)
            if (Pending == null)
            {
                throw new InvalidDataException("Pending is a required property for V1Initializers and cannot be null");
            }
            else
            {
                this.Pending = Pending;
            }
            this.Result = Result;
        }
        
        /// <summary>
        /// Pending is a list of initializers that must execute in order before this object is visible. When the last pending initializer is removed, and no failing result is set, the initializers struct will be set to nil and the object is considered as initialized and visible to all clients.
        /// </summary>
        /// <value>Pending is a list of initializers that must execute in order before this object is visible. When the last pending initializer is removed, and no failing result is set, the initializers struct will be set to nil and the object is considered as initialized and visible to all clients.</value>
        [DataMember(Name="pending", EmitDefaultValue=false)]
        public List<V1Initializer> Pending { get; set; }

        /// <summary>
        /// If result is set with the Failure field, the object will be persisted to storage and then deleted, ensuring that other clients can observe the deletion.
        /// </summary>
        /// <value>If result is set with the Failure field, the object will be persisted to storage and then deleted, ensuring that other clients can observe the deletion.</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public V1Status Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1Initializers {\n");
            sb.Append("  Pending: ").Append(Pending).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V1Initializers);
        }

        /// <summary>
        /// Returns true if V1Initializers instances are equal
        /// </summary>
        /// <param name="other">Instance of V1Initializers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1Initializers other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Pending == other.Pending ||
                    this.Pending != null &&
                    this.Pending.SequenceEqual(other.Pending)
                ) && 
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Pending != null)
                    hash = hash * 59 + this.Pending.GetHashCode();
                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();
                return hash;
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