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
    /// TransactionIdentifierResponse contains the transaction_identifier of a transaction that was submitted to either &#x60;/construction/hash&#x60; or &#x60;/construction/submit&#x60;.
    /// </summary>
    [DataContract]
        public partial class TransactionIdentifierResponse :  IEquatable<TransactionIdentifierResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionIdentifierResponse" /> class.
        /// </summary>
        /// <param name="transactionIdentifier">transactionIdentifier (required).</param>
        /// <param name="metadata">metadata.</param>
        public TransactionIdentifierResponse(TransactionIdentifier transactionIdentifier = default(TransactionIdentifier), Object metadata = default(Object))
        {
            // to ensure "transactionIdentifier" is required (not null)
            if (transactionIdentifier == null)
            {
                throw new InvalidDataException("transactionIdentifier is a required property for TransactionIdentifierResponse and cannot be null");
            }
            else
            {
                this.TransactionIdentifier = transactionIdentifier;
            }
            this.Metadata = metadata;
        }
        
        /// <summary>
        /// Gets or Sets TransactionIdentifier
        /// </summary>
        [DataMember(Name="transaction_identifier", EmitDefaultValue=false)]
        public TransactionIdentifier TransactionIdentifier { get; set; }

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
            sb.Append("class TransactionIdentifierResponse {\n");
            sb.Append("  TransactionIdentifier: ").Append(TransactionIdentifier).Append("\n");
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
            return this.Equals(input as TransactionIdentifierResponse);
        }

        /// <summary>
        /// Returns true if TransactionIdentifierResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionIdentifierResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionIdentifierResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionIdentifier == input.TransactionIdentifier ||
                    (this.TransactionIdentifier != null &&
                    this.TransactionIdentifier.Equals(input.TransactionIdentifier))
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
                if (this.TransactionIdentifier != null)
                    hashCode = hashCode * 59 + this.TransactionIdentifier.GetHashCode();
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
