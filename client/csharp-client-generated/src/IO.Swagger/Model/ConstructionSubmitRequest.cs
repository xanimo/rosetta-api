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
    /// The transaction submission request includes a signed transaction.
    /// </summary>
    [DataContract]
        public partial class ConstructionSubmitRequest :  IEquatable<ConstructionSubmitRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionSubmitRequest" /> class.
        /// </summary>
        /// <param name="networkIdentifier">networkIdentifier (required).</param>
        /// <param name="signedTransaction">signedTransaction (required).</param>
        public ConstructionSubmitRequest(NetworkIdentifier networkIdentifier = default(NetworkIdentifier), string signedTransaction = default(string))
        {
            // to ensure "networkIdentifier" is required (not null)
            if (networkIdentifier == null)
            {
                throw new InvalidDataException("networkIdentifier is a required property for ConstructionSubmitRequest and cannot be null");
            }
            else
            {
                this.NetworkIdentifier = networkIdentifier;
            }
            // to ensure "signedTransaction" is required (not null)
            if (signedTransaction == null)
            {
                throw new InvalidDataException("signedTransaction is a required property for ConstructionSubmitRequest and cannot be null");
            }
            else
            {
                this.SignedTransaction = signedTransaction;
            }
        }
        
        /// <summary>
        /// Gets or Sets NetworkIdentifier
        /// </summary>
        [DataMember(Name="network_identifier", EmitDefaultValue=false)]
        public NetworkIdentifier NetworkIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets SignedTransaction
        /// </summary>
        [DataMember(Name="signed_transaction", EmitDefaultValue=false)]
        public string SignedTransaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConstructionSubmitRequest {\n");
            sb.Append("  NetworkIdentifier: ").Append(NetworkIdentifier).Append("\n");
            sb.Append("  SignedTransaction: ").Append(SignedTransaction).Append("\n");
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
            return this.Equals(input as ConstructionSubmitRequest);
        }

        /// <summary>
        /// Returns true if ConstructionSubmitRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ConstructionSubmitRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstructionSubmitRequest input)
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
                    this.SignedTransaction == input.SignedTransaction ||
                    (this.SignedTransaction != null &&
                    this.SignedTransaction.Equals(input.SignedTransaction))
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
                if (this.SignedTransaction != null)
                    hashCode = hashCode * 59 + this.SignedTransaction.GetHashCode();
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
