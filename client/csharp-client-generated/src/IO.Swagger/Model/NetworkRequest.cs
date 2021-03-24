/* 
 * Rosetta
 *
 * Build Once. Integrate Your Blockchain Everywhere.
 *
 * OpenAPI spec version: 1.4.10
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// A NetworkRequest is utilized to retrieve some data specific exclusively to a NetworkIdentifier.
    /// </summary>
    [DataContract]
        public partial class NetworkRequest :  IEquatable<NetworkRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRequest" /> class.
        /// </summary>
        /// <param name="networkIdentifier">networkIdentifier (required).</param>
        /// <param name="metadata">metadata.</param>
        public NetworkRequest(NetworkIdentifier networkIdentifier = default(NetworkIdentifier), Object metadata = default(Object))
        {
            // to ensure "networkIdentifier" is required (not null)
            if (networkIdentifier == null)
            {
                throw new InvalidDataException("networkIdentifier is a required property for NetworkRequest and cannot be null");
            }
            else
            {
                this.NetworkIdentifier = networkIdentifier;
            }
            this.Metadata = metadata;
        }
        
        /// <summary>
        /// Gets or Sets NetworkIdentifier
        /// </summary>
        [DataMember(Name="network_identifier", EmitDefaultValue=false)]
        public NetworkIdentifier NetworkIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkRequest {\n");
            sb.Append("  NetworkIdentifier: ").Append(NetworkIdentifier).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as NetworkRequest);
        }

        /// <summary>
        /// Returns true if NetworkRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NetworkIdentifier == input.NetworkIdentifier ||
                    (this.NetworkIdentifier != null &&
                    this.NetworkIdentifier.Equals(input.NetworkIdentifier))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.NetworkIdentifier != null)
                    hashCode = hashCode * 59 + this.NetworkIdentifier.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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
