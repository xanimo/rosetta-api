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
    /// A Peer is a representation of a node&#x27;s peer.
    /// </summary>
    [DataContract]
        public partial class Peer :  IEquatable<Peer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Peer" /> class.
        /// </summary>
        /// <param name="peerId">peerId (required).</param>
        /// <param name="metadata">metadata.</param>
        public Peer(string peerId = default(string), Object metadata = default(Object))
        {
            // to ensure "peerId" is required (not null)
            if (peerId == null)
            {
                throw new InvalidDataException("peerId is a required property for Peer and cannot be null");
            }
            else
            {
                this.PeerId = peerId;
            }
            this.Metadata = metadata;
        }
        
        /// <summary>
        /// Gets or Sets PeerId
        /// </summary>
        [DataMember(Name="peer_id", EmitDefaultValue=false)]
        public string PeerId { get; set; }

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
            sb.Append("class Peer {\n");
            sb.Append("  PeerId: ").Append(PeerId).Append("\n");
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
            return this.Equals(input as Peer);
        }

        /// <summary>
        /// Returns true if Peer instances are equal
        /// </summary>
        /// <param name="input">Instance of Peer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Peer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PeerId == input.PeerId ||
                    (this.PeerId != null &&
                    this.PeerId.Equals(input.PeerId))
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
                if (this.PeerId != null)
                    hashCode = hashCode * 59 + this.PeerId.GetHashCode();
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
