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
    /// EndpointSubset is a group of addresses with a common set of ports. The expanded set of endpoints is the Cartesian product of Addresses x Ports. For example, given:   {     Addresses: [{\&quot;ip\&quot;: \&quot;10.10.1.1\&quot;}, {\&quot;ip\&quot;: \&quot;10.10.2.2\&quot;}],     Ports:     [{\&quot;name\&quot;: \&quot;a\&quot;, \&quot;port\&quot;: 8675}, {\&quot;name\&quot;: \&quot;b\&quot;, \&quot;port\&quot;: 309}]   } The resulting set of endpoints can be viewed as:     a: [ 10.10.1.1:8675, 10.10.2.2:8675 ],     b: [ 10.10.1.1:309, 10.10.2.2:309 ]
    /// </summary>
    [DataContract]
    public partial class V1EndpointSubset :  IEquatable<V1EndpointSubset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1EndpointSubset" /> class.
        /// </summary>
        /// <param name="Addresses">IP addresses which offer the related ports that are marked as ready. These endpoints should be considered safe for load balancers and clients to utilize..</param>
        /// <param name="NotReadyAddresses">IP addresses which offer the related ports but are not currently marked as ready because they have not yet finished starting, have recently failed a readiness check, or have recently failed a liveness check..</param>
        /// <param name="Ports">Port numbers available on the related IP addresses..</param>
        public V1EndpointSubset(List<V1EndpointAddress> Addresses = default(List<V1EndpointAddress>), List<V1EndpointAddress> NotReadyAddresses = default(List<V1EndpointAddress>), List<V1EndpointPort> Ports = default(List<V1EndpointPort>))
        {
            this.Addresses = Addresses;
            this.NotReadyAddresses = NotReadyAddresses;
            this.Ports = Ports;
        }
        
        /// <summary>
        /// IP addresses which offer the related ports that are marked as ready. These endpoints should be considered safe for load balancers and clients to utilize.
        /// </summary>
        /// <value>IP addresses which offer the related ports that are marked as ready. These endpoints should be considered safe for load balancers and clients to utilize.</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<V1EndpointAddress> Addresses { get; set; }

        /// <summary>
        /// IP addresses which offer the related ports but are not currently marked as ready because they have not yet finished starting, have recently failed a readiness check, or have recently failed a liveness check.
        /// </summary>
        /// <value>IP addresses which offer the related ports but are not currently marked as ready because they have not yet finished starting, have recently failed a readiness check, or have recently failed a liveness check.</value>
        [DataMember(Name="notReadyAddresses", EmitDefaultValue=false)]
        public List<V1EndpointAddress> NotReadyAddresses { get; set; }

        /// <summary>
        /// Port numbers available on the related IP addresses.
        /// </summary>
        /// <value>Port numbers available on the related IP addresses.</value>
        [DataMember(Name="ports", EmitDefaultValue=false)]
        public List<V1EndpointPort> Ports { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1EndpointSubset {\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  NotReadyAddresses: ").Append(NotReadyAddresses).Append("\n");
            sb.Append("  Ports: ").Append(Ports).Append("\n");
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
            return this.Equals(obj as V1EndpointSubset);
        }

        /// <summary>
        /// Returns true if V1EndpointSubset instances are equal
        /// </summary>
        /// <param name="other">Instance of V1EndpointSubset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1EndpointSubset other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Addresses == other.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(other.Addresses)
                ) && 
                (
                    this.NotReadyAddresses == other.NotReadyAddresses ||
                    this.NotReadyAddresses != null &&
                    this.NotReadyAddresses.SequenceEqual(other.NotReadyAddresses)
                ) && 
                (
                    this.Ports == other.Ports ||
                    this.Ports != null &&
                    this.Ports.SequenceEqual(other.Ports)
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
                if (this.Addresses != null)
                    hash = hash * 59 + this.Addresses.GetHashCode();
                if (this.NotReadyAddresses != null)
                    hash = hash * 59 + this.NotReadyAddresses.GetHashCode();
                if (this.Ports != null)
                    hash = hash * 59 + this.Ports.GetHashCode();
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
