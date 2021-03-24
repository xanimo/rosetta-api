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
    /// Transactions contain an array of Operations that are attributable to the same TransactionIdentifier.
    /// </summary>
    [DataContract]
    public partial class Transaction : IEquatable<Transaction>
    { 
        /// <summary>
        /// Gets or Sets TransactionIdentifier
        /// </summary>
        [Required]
        [DataMember(Name="transaction_identifier")]
        public TransactionIdentifier TransactionIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets Operations
        /// </summary>
        [Required]
        [DataMember(Name="operations")]
        public List<Operation> Operations { get; set; }

        /// <summary>
        /// Gets or Sets RelatedTransactions
        /// </summary>
        [DataMember(Name="related_transactions")]
        public List<RelatedTransaction> RelatedTransactions { get; set; }

        /// <summary>
        /// Transactions that are related to other transactions (like a cross-shard transaction) should include the tranaction_identifier of these transactions in the metadata.
        /// </summary>
        /// <value>Transactions that are related to other transactions (like a cross-shard transaction) should include the tranaction_identifier of these transactions in the metadata.</value>
        [DataMember(Name="metadata")]
        public Object Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transaction {\n");
            sb.Append("  TransactionIdentifier: ").Append(TransactionIdentifier).Append("\n");
            sb.Append("  Operations: ").Append(Operations).Append("\n");
            sb.Append("  RelatedTransactions: ").Append(RelatedTransactions).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Transaction)obj);
        }

        /// <summary>
        /// Returns true if Transaction instances are equal
        /// </summary>
        /// <param name="other">Instance of Transaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transaction other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TransactionIdentifier == other.TransactionIdentifier ||
                    TransactionIdentifier != null &&
                    TransactionIdentifier.Equals(other.TransactionIdentifier)
                ) && 
                (
                    Operations == other.Operations ||
                    Operations != null &&
                    Operations.SequenceEqual(other.Operations)
                ) && 
                (
                    RelatedTransactions == other.RelatedTransactions ||
                    RelatedTransactions != null &&
                    RelatedTransactions.SequenceEqual(other.RelatedTransactions)
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
                    if (TransactionIdentifier != null)
                    hashCode = hashCode * 59 + TransactionIdentifier.GetHashCode();
                    if (Operations != null)
                    hashCode = hashCode * 59 + Operations.GetHashCode();
                    if (RelatedTransactions != null)
                    hashCode = hashCode * 59 + RelatedTransactions.GetHashCode();
                    if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Transaction left, Transaction right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Transaction left, Transaction right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}