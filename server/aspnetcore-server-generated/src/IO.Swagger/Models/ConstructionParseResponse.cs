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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// ConstructionParseResponse contains an array of operations that occur in a transaction blob. This should match the array of operations provided to &#x60;/construction/preprocess&#x60; and &#x60;/construction/payloads&#x60;.
    /// </summary>
    [DataContract]
    public partial class ConstructionParseResponse : IEquatable<ConstructionParseResponse>
    { 
        /// <summary>
        /// Gets or Sets Operations
        /// </summary>
        [Required]
        [DataMember(Name="operations")]
        public List<Operation> Operations { get; set; }

        /// <summary>
        /// [DEPRECATED by &#x60;account_identifier_signers&#x60; in &#x60;v1.4.4&#x60;] All signers (addresses) of a particular transaction. If the transaction is unsigned, it should be empty.
        /// </summary>
        /// <value>[DEPRECATED by &#x60;account_identifier_signers&#x60; in &#x60;v1.4.4&#x60;] All signers (addresses) of a particular transaction. If the transaction is unsigned, it should be empty.</value>
        [DataMember(Name="signers")]
        public List<string> Signers { get; set; }

        /// <summary>
        /// Gets or Sets AccountIdentifierSigners
        /// </summary>
        [DataMember(Name="account_identifier_signers")]
        public List<AccountIdentifier> AccountIdentifierSigners { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata")]
        public Object Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConstructionParseResponse {\n");
            sb.Append("  Operations: ").Append(Operations).Append("\n");
            sb.Append("  Signers: ").Append(Signers).Append("\n");
            sb.Append("  AccountIdentifierSigners: ").Append(AccountIdentifierSigners).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ConstructionParseResponse)obj);
        }

        /// <summary>
        /// Returns true if ConstructionParseResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConstructionParseResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstructionParseResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Operations == other.Operations ||
                    Operations != null &&
                    Operations.SequenceEqual(other.Operations)
                ) && 
                (
                    Signers == other.Signers ||
                    Signers != null &&
                    Signers.SequenceEqual(other.Signers)
                ) && 
                (
                    AccountIdentifierSigners == other.AccountIdentifierSigners ||
                    AccountIdentifierSigners != null &&
                    AccountIdentifierSigners.SequenceEqual(other.AccountIdentifierSigners)
                ) && 
                (
                    Metadata == other.Metadata ||
                    Metadata != null &&
                    Metadata.Equals(other.Metadata)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Operations != null)
                    hashCode = hashCode * 59 + Operations.GetHashCode();
                    if (Signers != null)
                    hashCode = hashCode * 59 + Signers.GetHashCode();
                    if (AccountIdentifierSigners != null)
                    hashCode = hashCode * 59 + AccountIdentifierSigners.GetHashCode();
                    if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ConstructionParseResponse left, ConstructionParseResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ConstructionParseResponse left, ConstructionParseResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}