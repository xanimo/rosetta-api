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
    /// The transaction_identifier uniquely identifies a transaction in a particular network and block or in the mempool.
    /// </summary>
    [DataContract]
        public partial class TransactionIdentifier :  IEquatable<TransactionIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionIdentifier" /> class.
        /// </summary>
        /// <param name="hash">Any transactions that are attributable only to a block (ex: a block event) should use the hash of the block as the identifier. (required).</param>
        public TransactionIdentifier(string hash = default(string))
        {
            // to ensure "hash" is required (not null)
            if (hash == null)
            {
                throw new InvalidDataException("hash is a required property for TransactionIdentifier and cannot be null");
            }
            else
            {
                this.Hash = hash;
            }
        }
        
        /// <summary>
        /// Any transactions that are attributable only to a block (ex: a block event) should use the hash of the block as the identifier.
        /// </summary>
        /// <value>Any transactions that are attributable only to a block (ex: a block event) should use the hash of the block as the identifier.</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionIdentifier {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
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
            return this.Equals(input as TransactionIdentifier);
        }

        /// <summary>
        /// Returns true if TransactionIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionIdentifier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
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
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
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
