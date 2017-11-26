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
    /// Affinity is a group of affinity scheduling rules.
    /// </summary>
    [DataContract]
    public partial class V1Affinity :  IEquatable<V1Affinity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Affinity" /> class.
        /// </summary>
        /// <param name="NodeAffinity">Describes node affinity scheduling rules for the pod..</param>
        /// <param name="PodAffinity">Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s))..</param>
        /// <param name="PodAntiAffinity">Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s))..</param>
        public V1Affinity(V1NodeAffinity NodeAffinity = default(V1NodeAffinity), V1PodAffinity PodAffinity = default(V1PodAffinity), V1PodAntiAffinity PodAntiAffinity = default(V1PodAntiAffinity))
        {
            this.NodeAffinity = NodeAffinity;
            this.PodAffinity = PodAffinity;
            this.PodAntiAffinity = PodAntiAffinity;
        }
        
        /// <summary>
        /// Describes node affinity scheduling rules for the pod.
        /// </summary>
        /// <value>Describes node affinity scheduling rules for the pod.</value>
        [DataMember(Name="nodeAffinity", EmitDefaultValue=false)]
        public V1NodeAffinity NodeAffinity { get; set; }

        /// <summary>
        /// Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        /// <value>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</value>
        [DataMember(Name="podAffinity", EmitDefaultValue=false)]
        public V1PodAffinity PodAffinity { get; set; }

        /// <summary>
        /// Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        /// <value>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</value>
        [DataMember(Name="podAntiAffinity", EmitDefaultValue=false)]
        public V1PodAntiAffinity PodAntiAffinity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1Affinity {\n");
            sb.Append("  NodeAffinity: ").Append(NodeAffinity).Append("\n");
            sb.Append("  PodAffinity: ").Append(PodAffinity).Append("\n");
            sb.Append("  PodAntiAffinity: ").Append(PodAntiAffinity).Append("\n");
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
            return this.Equals(obj as V1Affinity);
        }

        /// <summary>
        /// Returns true if V1Affinity instances are equal
        /// </summary>
        /// <param name="other">Instance of V1Affinity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1Affinity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NodeAffinity == other.NodeAffinity ||
                    this.NodeAffinity != null &&
                    this.NodeAffinity.Equals(other.NodeAffinity)
                ) && 
                (
                    this.PodAffinity == other.PodAffinity ||
                    this.PodAffinity != null &&
                    this.PodAffinity.Equals(other.PodAffinity)
                ) && 
                (
                    this.PodAntiAffinity == other.PodAntiAffinity ||
                    this.PodAntiAffinity != null &&
                    this.PodAntiAffinity.Equals(other.PodAntiAffinity)
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
                if (this.NodeAffinity != null)
                    hash = hash * 59 + this.NodeAffinity.GetHashCode();
                if (this.PodAffinity != null)
                    hash = hash * 59 + this.PodAffinity.GetHashCode();
                if (this.PodAntiAffinity != null)
                    hash = hash * 59 + this.PodAntiAffinity.GetHashCode();
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