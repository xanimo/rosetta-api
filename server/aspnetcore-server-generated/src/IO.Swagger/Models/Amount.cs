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
    /// Amount is some Value of a Currency. It is considered invalid to specify a Value without a Currency.
    /// </summary>
    [DataContract]
    public partial class Amount : IEquatable<Amount>
    { 
        /// <summary>
        /// Value of the transaction in atomic units represented as an arbitrary-sized signed integer. For example, 1 BTC would be represented by a value of 100000000.
        /// </summary>
        /// <value>Value of the transaction in atomic units represented as an arbitrary-sized signed integer. For example, 1 BTC would be represented by a value of 100000000.</value>
        [Required]
        [DataMember(Name="value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [Required]
        [DataMember(Name="currency")]
        public Currency Currency { get; set; }

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
            sb.Append("class Amount {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Amount)obj);
        }

        /// <summary>
        /// Returns true if Amount instances are equal
        /// </summary>
        /// <param name="other">Instance of Amount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Amount other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
                ) && 
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
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
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                    if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                    if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Amount left, Amount right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Amount left, Amount right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
