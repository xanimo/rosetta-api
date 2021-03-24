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
    /// A MempoolResponse contains all transaction identifiers in the mempool for a particular network_identifier.
    /// </summary>
    [DataContract]
    public partial class MempoolResponse : IEquatable<MempoolResponse>
    { 
        /// <summary>
        /// Gets or Sets TransactionIdentifiers
        /// </summary>
        [Required]
        [DataMember(Name="transaction_identifiers")]
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
            return obj.GetType() == GetType() && Equals((MempoolResponse)obj);
        }

        /// <summary>
        /// Returns true if MempoolResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of MempoolResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MempoolResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TransactionIdentifiers == other.TransactionIdentifiers ||
                    TransactionIdentifiers != null &&
                    TransactionIdentifiers.SequenceEqual(other.TransactionIdentifiers)
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
                    if (TransactionIdentifiers != null)
                    hashCode = hashCode * 59 + TransactionIdentifiers.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MempoolResponse left, MempoolResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MempoolResponse left, MempoolResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}