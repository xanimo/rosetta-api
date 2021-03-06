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
    /// ConstructionHashRequest is the input to the &#x60;/construction/hash&#x60; endpoint.
    /// </summary>
    [DataContract]
    public partial class ConstructionHashRequest : IEquatable<ConstructionHashRequest>
    { 
        /// <summary>
        /// Gets or Sets NetworkIdentifier
        /// </summary>
        [Required]
        [DataMember(Name="network_identifier")]
        public NetworkIdentifier NetworkIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets SignedTransaction
        /// </summary>
        [Required]
        [DataMember(Name="signed_transaction")]
        public string SignedTransaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConstructionHashRequest {\n");
            sb.Append("  NetworkIdentifier: ").Append(NetworkIdentifier).Append("\n");
            sb.Append("  SignedTransaction: ").Append(SignedTransaction).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ConstructionHashRequest)obj);
        }

        /// <summary>
        /// Returns true if ConstructionHashRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ConstructionHashRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstructionHashRequest other)
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
                    SignedTransaction == other.SignedTransaction ||
                    SignedTransaction != null &&
                    SignedTransaction.Equals(other.SignedTransaction)
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
                    if (SignedTransaction != null)
                    hashCode = hashCode * 59 + SignedTransaction.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ConstructionHashRequest left, ConstructionHashRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ConstructionHashRequest left, ConstructionHashRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
