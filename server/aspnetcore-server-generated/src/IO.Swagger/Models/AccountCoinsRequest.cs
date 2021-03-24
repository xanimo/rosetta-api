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
    /// AccountCoinsRequest is utilized to make a request on the /account/coins endpoint.
    /// </summary>
    [DataContract]
    public partial class AccountCoinsRequest : IEquatable<AccountCoinsRequest>
    { 
        /// <summary>
        /// Gets or Sets NetworkIdentifier
        /// </summary>
        [Required]
        [DataMember(Name="network_identifier")]
        public NetworkIdentifier NetworkIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets AccountIdentifier
        /// </summary>
        [Required]
        [DataMember(Name="account_identifier")]
        public AccountIdentifier AccountIdentifier { get; set; }

        /// <summary>
        /// Include state from the mempool when looking up an account&#x27;s unspent coins. Note, using this functionality breaks any guarantee of idempotency.
        /// </summary>
        /// <value>Include state from the mempool when looking up an account&#x27;s unspent coins. Note, using this functionality breaks any guarantee of idempotency.</value>
        [Required]
        [DataMember(Name="include_mempool")]
        public bool? IncludeMempool { get; set; }

        /// <summary>
        /// In some cases, the caller may not want to retrieve coins for all currencies for an AccountIdentifier. If the currencies field is populated, only coins for the specified currencies will be returned. If not populated, all unspent coins will be returned.
        /// </summary>
        /// <value>In some cases, the caller may not want to retrieve coins for all currencies for an AccountIdentifier. If the currencies field is populated, only coins for the specified currencies will be returned. If not populated, all unspent coins will be returned.</value>
        [DataMember(Name="currencies")]
        public List<Currency> Currencies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountCoinsRequest {\n");
            sb.Append("  NetworkIdentifier: ").Append(NetworkIdentifier).Append("\n");
            sb.Append("  AccountIdentifier: ").Append(AccountIdentifier).Append("\n");
            sb.Append("  IncludeMempool: ").Append(IncludeMempool).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AccountCoinsRequest)obj);
        }

        /// <summary>
        /// Returns true if AccountCoinsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountCoinsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountCoinsRequest other)
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
                    AccountIdentifier == other.AccountIdentifier ||
                    AccountIdentifier != null &&
                    AccountIdentifier.Equals(other.AccountIdentifier)
                ) && 
                (
                    IncludeMempool == other.IncludeMempool ||
                    IncludeMempool != null &&
                    IncludeMempool.Equals(other.IncludeMempool)
                ) && 
                (
                    Currencies == other.Currencies ||
                    Currencies != null &&
                    Currencies.SequenceEqual(other.Currencies)
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
                    if (AccountIdentifier != null)
                    hashCode = hashCode * 59 + AccountIdentifier.GetHashCode();
                    if (IncludeMempool != null)
                    hashCode = hashCode * 59 + IncludeMempool.GetHashCode();
                    if (Currencies != null)
                    hashCode = hashCode * 59 + Currencies.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AccountCoinsRequest left, AccountCoinsRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AccountCoinsRequest left, AccountCoinsRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}