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
    /// ConstructionCombineRequest is the input to the &#x60;/construction/combine&#x60; endpoint. It contains the unsigned transaction blob returned by &#x60;/construction/payloads&#x60; and all required signatures to create a network transaction.
    /// </summary>
    [DataContract]
    public partial class ConstructionCombineRequest : IEquatable<ConstructionCombineRequest>
    { 
        /// <summary>
        /// Gets or Sets NetworkIdentifier
        /// </summary>
        [Required]
        [DataMember(Name="network_identifier")]
        public NetworkIdentifier NetworkIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets UnsignedTransaction
        /// </summary>
        [Required]
        [DataMember(Name="unsigned_transaction")]
        public string UnsignedTransaction { get; set; }

        /// <summary>
        /// Gets or Sets Signatures
        /// </summary>
        [Required]
        [DataMember(Name="signatures")]
        public List<Signature> Signatures { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConstructionCombineRequest {\n");
            sb.Append("  NetworkIdentifier: ").Append(NetworkIdentifier).Append("\n");
            sb.Append("  UnsignedTransaction: ").Append(UnsignedTransaction).Append("\n");
            sb.Append("  Signatures: ").Append(Signatures).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ConstructionCombineRequest)obj);
        }

        /// <summary>
        /// Returns true if ConstructionCombineRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ConstructionCombineRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstructionCombineRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NetworkIdentifier == other.NetworkIdentifier ||
                    NetworkIdentifier != null &&
                    NetworkIdentifier.Equals(other.NetworkIdentifier)
                ) && 
                (
                    UnsignedTransaction == other.UnsignedTransaction ||
                    UnsignedTransaction != null &&
                    UnsignedTransaction.Equals(other.UnsignedTransaction)
                ) && 
                (
                    Signatures == other.Signatures ||
                    Signatures != null &&
                    Signatures.SequenceEqual(other.Signatures)
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
                    if (NetworkIdentifier != null)
                    hashCode = hashCode * 59 + NetworkIdentifier.GetHashCode();
                    if (UnsignedTransaction != null)
                    hashCode = hashCode * 59 + UnsignedTransaction.GetHashCode();
                    if (Signatures != null)
                    hashCode = hashCode * 59 + Signatures.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ConstructionCombineRequest left, ConstructionCombineRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ConstructionCombineRequest left, ConstructionCombineRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
