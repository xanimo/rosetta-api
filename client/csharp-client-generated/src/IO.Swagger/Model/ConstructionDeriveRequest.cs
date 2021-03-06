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
    /// ConstructionDeriveRequest is passed to the &#x60;/construction/derive&#x60; endpoint. Network is provided in the request because some blockchains have different address formats for different networks. Metadata is provided in the request because some blockchains allow for multiple address types (i.e. different address for validators vs normal accounts).
    /// </summary>
    [DataContract]
        public partial class ConstructionDeriveRequest :  IEquatable<ConstructionDeriveRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionDeriveRequest" /> class.
        /// </summary>
        /// <param name="networkIdentifier">networkIdentifier (required).</param>
        /// <param name="publicKey">publicKey (required).</param>
        /// <param name="metadata">metadata.</param>
        public ConstructionDeriveRequest(NetworkIdentifier networkIdentifier = default(NetworkIdentifier), PublicKey publicKey = default(PublicKey), Object metadata = default(Object))
        {
            // to ensure "networkIdentifier" is required (not null)
            if (networkIdentifier == null)
            {
                throw new InvalidDataException("networkIdentifier is a required property for ConstructionDeriveRequest and cannot be null");
            }
            else
            {
                this.NetworkIdentifier = networkIdentifier;
            }
            // to ensure "publicKey" is required (not null)
            if (publicKey == null)
            {
                throw new InvalidDataException("publicKey is a required property for ConstructionDeriveRequest and cannot be null");
            }
            else
            {
                this.PublicKey = publicKey;
            }
            this.Metadata = metadata;
        }
        
        /// <summary>
        /// Gets or Sets NetworkIdentifier
        /// </summary>
        [DataMember(Name="network_identifier", EmitDefaultValue=false)]
        public NetworkIdentifier NetworkIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets PublicKey
        /// </summary>
        [DataMember(Name="public_key", EmitDefaultValue=false)]
        public PublicKey PublicKey { get; set; }

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
            sb.Append("class ConstructionDeriveRequest {\n");
            sb.Append("  NetworkIdentifier: ").Append(NetworkIdentifier).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
            return this.Equals(input as ConstructionDeriveRequest);
        }

        /// <summary>
        /// Returns true if ConstructionDeriveRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ConstructionDeriveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstructionDeriveRequest input)
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
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
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
                if (this.PublicKey != null)
                    hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
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
