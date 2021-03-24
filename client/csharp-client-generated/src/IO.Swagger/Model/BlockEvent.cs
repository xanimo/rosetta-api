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
    /// BlockEvent represents the addition or removal of a BlockIdentifier from storage. Streaming BlockEvents allows lightweight clients to update their own state without needing to implement their own syncing logic.
    /// </summary>
    [DataContract]
        public partial class BlockEvent :  IEquatable<BlockEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockEvent" /> class.
        /// </summary>
        /// <param name="sequence">sequence is the unique identifier of a BlockEvent within the context of a NetworkIdentifier. (required).</param>
        /// <param name="blockIdentifier">blockIdentifier (required).</param>
        /// <param name="type">type (required).</param>
        public BlockEvent(long? sequence = default(long?), BlockIdentifier blockIdentifier = default(BlockIdentifier), BlockEventType type = default(BlockEventType))
        {
            // to ensure "sequence" is required (not null)
            if (sequence == null)
            {
                throw new InvalidDataException("sequence is a required property for BlockEvent and cannot be null");
            }
            else
            {
                this.Sequence = sequence;
            }
            // to ensure "blockIdentifier" is required (not null)
            if (blockIdentifier == null)
            {
                throw new InvalidDataException("blockIdentifier is a required property for BlockEvent and cannot be null");
            }
            else
            {
                this.BlockIdentifier = blockIdentifier;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for BlockEvent and cannot be null");
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// sequence is the unique identifier of a BlockEvent within the context of a NetworkIdentifier.
        /// </summary>
        /// <value>sequence is the unique identifier of a BlockEvent within the context of a NetworkIdentifier.</value>
        [DataMember(Name="sequence", EmitDefaultValue=false)]
        public long? Sequence { get; set; }

        /// <summary>
        /// Gets or Sets BlockIdentifier
        /// </summary>
        [DataMember(Name="block_identifier", EmitDefaultValue=false)]
        public BlockIdentifier BlockIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public BlockEventType Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlockEvent {\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  BlockIdentifier: ").Append(BlockIdentifier).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as BlockEvent);
        }

        /// <summary>
        /// Returns true if BlockEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of BlockEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                ) && 
                (
                    this.BlockIdentifier == input.BlockIdentifier ||
                    (this.BlockIdentifier != null &&
                    this.BlockIdentifier.Equals(input.BlockIdentifier))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.BlockIdentifier != null)
                    hashCode = hashCode * 59 + this.BlockIdentifier.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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