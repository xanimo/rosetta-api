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
    /// A MempoolResponse contains all transaction identifiers in the mempool for a particular network_identifier.
    /// </summary>
    [DataContract]
        public partial class MempoolResponse :  IEquatable<MempoolResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MempoolResponse" /> class.
        /// </summary>
        /// <param name="transactionIdentifiers">transactionIdentifiers (required).</param>
        public MempoolResponse(List<TransactionIdentifier> transactionIdentifiers = default(List<TransactionIdentifier>))
        {
            // to ensure "transactionIdentifiers" is required (not null)
            if (transactionIdentifiers == null)
            {
                throw new InvalidDataException("transactionIdentifiers is a required property for MempoolResponse and cannot be null");
            }
            else
            {
                this.TransactionIdentifiers = transactionIdentifiers;
            }
        }
        
        /// <summary>
        /// Gets or Sets TransactionIdentifiers
        /// </summary>
        [DataMember(Name="transaction_identifiers", EmitDefaultValue=false)]
        public List<TransactionIdentifier> TransactionIdentifiers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MempoolResponse {\n");
            sb.Append("  TransactionIdentifiers: ").Append(TransactionIdentifiers).Append("\n");
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
            return this.Equals(input as MempoolResponse);
        }

        /// <summary>
        /// Returns true if MempoolResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MempoolResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MempoolResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionIdentifiers == input.TransactionIdentifiers ||
                    this.TransactionIdentifiers != null &&
                    input.TransactionIdentifiers != null &&
                    this.TransactionIdentifiers.SequenceEqual(input.TransactionIdentifiers)
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
                if (this.TransactionIdentifiers != null)
                    hashCode = hashCode * 59 + this.TransactionIdentifiers.GetHashCode();
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
