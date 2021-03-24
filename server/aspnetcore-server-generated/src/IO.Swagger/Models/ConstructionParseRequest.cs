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
    /// ConstructionParseRequest is the input to the &#x60;/construction/parse&#x60; endpoint. It allows the caller to parse either an unsigned or signed transaction.
    /// </summary>
    [DataContract]
    public partial class ConstructionParseRequest : IEquatable<ConstructionParseRequest>
    { 
        /// <summary>
        /// Gets or Sets NetworkIdentifier
        /// </summary>
        [Required]
        [DataMember(Name="network_identifier")]
        public NetworkIdentifier NetworkIdentifier { get; set; }

        /// <summary>
        /// Signed is a boolean indicating whether the transaction is signed.
        /// </summary>
        /// <value>Signed is a boolean indicating whether the transaction is signed.</value>
        [Required]
        [DataMember(Name="signed")]
        public bool? Signed { get; set; }

        /// <summary>
        /// This must be either the unsigned transaction blob returned by &#x60;/construction/payloads&#x60; or the signed transaction blob returned by &#x60;/construction/combine&#x60;.
        /// </summary>
        /// <value>This must be either the unsigned transaction blob returned by &#x60;/construction/payloads&#x60; or the signed transaction blob returned by &#x60;/construction/combine&#x60;.</value>
        [Required]
        [DataMember(Name="transaction")]
        public string Transaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConstructionParseRequest {\n");
            sb.Append("  NetworkIdentifier: ").Append(NetworkIdentifier).Append("\n");
            sb.Append("  Signed: ").Append(Signed).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ConstructionParseRequest)obj);
        }

        /// <summary>
        /// Returns true if ConstructionParseRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ConstructionParseRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstructionParseRequest other)
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
                    Signed == other.Signed ||
                    Signed != null &&
                    Signed.Equals(other.Signed)
                ) && 
                (
                    Transaction == other.Transaction ||
                    Transaction != null &&
                    Transaction.Equals(other.Transaction)
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
                    if (Signed != null)
                    hashCode = hashCode * 59 + Signed.GetHashCode();
                    if (Transaction != null)
                    hashCode = hashCode * 59 + Transaction.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ConstructionParseRequest left, ConstructionParseRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ConstructionParseRequest left, ConstructionParseRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}