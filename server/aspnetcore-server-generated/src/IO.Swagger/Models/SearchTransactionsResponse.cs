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
    /// SearchTransactionsResponse contains an ordered collection of BlockTransactions that match the query in SearchTransactionsRequest. These BlockTransactions are sorted from most recent block to oldest block.
    /// </summary>
    [DataContract]
    public partial class SearchTransactionsResponse : IEquatable<SearchTransactionsResponse>
    { 
        /// <summary>
        /// transactions is an array of BlockTransactions sorted by most recent BlockIdentifier (meaning that transactions in recent blocks appear first). If there are many transactions for a particular search, transactions may not contain all matching transactions. It is up to the caller to paginate these transactions using the max_block field.
        /// </summary>
        /// <value>transactions is an array of BlockTransactions sorted by most recent BlockIdentifier (meaning that transactions in recent blocks appear first). If there are many transactions for a particular search, transactions may not contain all matching transactions. It is up to the caller to paginate these transactions using the max_block field.</value>
        [Required]
        [DataMember(Name="transactions")]
        public List<BlockTransaction> Transactions { get; set; }

        /// <summary>
        /// total_count is the number of results for a given search. Callers typically use this value to concurrently fetch results by offset or to display a virtual page number associated with results.
        /// </summary>
        /// <value>total_count is the number of results for a given search. Callers typically use this value to concurrently fetch results by offset or to display a virtual page number associated with results.</value>
        [Required]
        [DataMember(Name="total_count")]
        public long? TotalCount { get; set; }

        /// <summary>
        /// next_offset is the next offset to use when paginating through transaction results. If this field is not populated, there are no more transactions to query.
        /// </summary>
        /// <value>next_offset is the next offset to use when paginating through transaction results. If this field is not populated, there are no more transactions to query.</value>
        [DataMember(Name="next_offset")]
        public long? NextOffset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchTransactionsResponse {\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  NextOffset: ").Append(NextOffset).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SearchTransactionsResponse)obj);
        }

        /// <summary>
        /// Returns true if SearchTransactionsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchTransactionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchTransactionsResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Transactions == other.Transactions ||
                    Transactions != null &&
                    Transactions.SequenceEqual(other.Transactions)
                ) && 
                (
                    TotalCount == other.TotalCount ||
                    TotalCount != null &&
                    TotalCount.Equals(other.TotalCount)
                ) && 
                (
                    NextOffset == other.NextOffset ||
                    NextOffset != null &&
                    NextOffset.Equals(other.NextOffset)
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
                    if (Transactions != null)
                    hashCode = hashCode * 59 + Transactions.GetHashCode();
                    if (TotalCount != null)
                    hashCode = hashCode * 59 + TotalCount.GetHashCode();
                    if (NextOffset != null)
                    hashCode = hashCode * 59 + NextOffset.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SearchTransactionsResponse left, SearchTransactionsResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SearchTransactionsResponse left, SearchTransactionsResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
