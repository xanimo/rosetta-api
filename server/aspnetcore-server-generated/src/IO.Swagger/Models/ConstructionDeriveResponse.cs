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
    /// ConstructionDeriveResponse is returned by the &#x60;/construction/derive&#x60; endpoint.
    /// </summary>
    [DataContract]
    public partial class ConstructionDeriveResponse : IEquatable<ConstructionDeriveResponse>
    { 
        /// <summary>
        /// [DEPRECATED by &#x60;account_identifier&#x60; in &#x60;v1.4.4&#x60;] Address in network-specific format.
        /// </summary>
        /// <value>[DEPRECATED by &#x60;account_identifier&#x60; in &#x60;v1.4.4&#x60;] Address in network-specific format.</value>
        [DataMember(Name="address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets AccountIdentifier
        /// </summary>
        [DataMember(Name="account_identifier")]
        public AccountIdentifier AccountIdentifier { get; set; }

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
            sb.Append("class ConstructionDeriveResponse {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AccountIdentifier: ").Append(AccountIdentifier).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ConstructionDeriveResponse)obj);
        }

        /// <summary>
        /// Returns true if ConstructionDeriveResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConstructionDeriveResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstructionDeriveResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Address == other.Address ||
                    Address != null &&
                    Address.Equals(other.Address)
                ) && 
                (
                    AccountIdentifier == other.AccountIdentifier ||
                    AccountIdentifier != null &&
                    AccountIdentifier.Equals(other.AccountIdentifier)
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
                    if (Address != null)
                    hashCode = hashCode * 59 + Address.GetHashCode();
                    if (AccountIdentifier != null)
                    hashCode = hashCode * 59 + AccountIdentifier.GetHashCode();
                    if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ConstructionDeriveResponse left, ConstructionDeriveResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ConstructionDeriveResponse left, ConstructionDeriveResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}