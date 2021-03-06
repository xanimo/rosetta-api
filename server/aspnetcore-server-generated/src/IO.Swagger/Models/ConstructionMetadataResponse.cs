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
    /// The ConstructionMetadataResponse returns network-specific metadata used for transaction construction. Optionally, the implementer can return the suggested fee associated with the transaction being constructed. The caller may use this info to adjust the intent of the transaction or to create a transaction with a different account that can pay the suggested fee. Suggested fee is an array in case fee payment must occur in multiple currencies.
    /// </summary>
    [DataContract]
    public partial class ConstructionMetadataResponse : IEquatable<ConstructionMetadataResponse>
    { 
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [Required]
        [DataMember(Name="metadata")]
        public Object Metadata { get; set; }

        /// <summary>
        /// Gets or Sets SuggestedFee
        /// </summary>
        [DataMember(Name="suggested_fee")]
        public List<Amount> SuggestedFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConstructionMetadataResponse {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  SuggestedFee: ").Append(SuggestedFee).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ConstructionMetadataResponse)obj);
        }

        /// <summary>
        /// Returns true if ConstructionMetadataResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConstructionMetadataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstructionMetadataResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Metadata == other.Metadata ||
                    Metadata != null &&
                    Metadata.Equals(other.Metadata)
                ) && 
                (
                    SuggestedFee == other.SuggestedFee ||
                    SuggestedFee != null &&
                    SuggestedFee.SequenceEqual(other.SuggestedFee)
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
                    if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                    if (SuggestedFee != null)
                    hashCode = hashCode * 59 + SuggestedFee.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ConstructionMetadataResponse left, ConstructionMetadataResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ConstructionMetadataResponse left, ConstructionMetadataResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
