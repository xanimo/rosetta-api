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
    /// The ConstructionMetadataResponse returns network-specific metadata used for transaction construction. Optionally, the implementer can return the suggested fee associated with the transaction being constructed. The caller may use this info to adjust the intent of the transaction or to create a transaction with a different account that can pay the suggested fee. Suggested fee is an array in case fee payment must occur in multiple currencies.
    /// </summary>
    [DataContract]
        public partial class ConstructionMetadataResponse :  IEquatable<ConstructionMetadataResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionMetadataResponse" /> class.
        /// </summary>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="suggestedFee">suggestedFee.</param>
        public ConstructionMetadataResponse(Object metadata = default(Object), List<Amount> suggestedFee = default(List<Amount>))
        {
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new InvalidDataException("metadata is a required property for ConstructionMetadataResponse and cannot be null");
            }
            else
            {
                this.Metadata = metadata;
            }
            this.SuggestedFee = suggestedFee;
        }
        
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Gets or Sets SuggestedFee
        /// </summary>
        [DataMember(Name="suggested_fee", EmitDefaultValue=false)]
        public List<Amount> SuggestedFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConstructionMetadataResponse {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  SuggestedFee: ").Append(SuggestedFee).Append("\n");
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
            return this.Equals(input as ConstructionMetadataResponse);
        }

        /// <summary>
        /// Returns true if ConstructionMetadataResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ConstructionMetadataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstructionMetadataResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.SuggestedFee == input.SuggestedFee ||
                    this.SuggestedFee != null &&
                    input.SuggestedFee != null &&
                    this.SuggestedFee.SequenceEqual(input.SuggestedFee)
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
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.SuggestedFee != null)
                    hashCode = hashCode * 59 + this.SuggestedFee.GetHashCode();
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