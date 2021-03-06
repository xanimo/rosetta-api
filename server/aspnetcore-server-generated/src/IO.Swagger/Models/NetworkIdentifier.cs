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
    /// The network_identifier specifies which network a particular object is associated with.
    /// </summary>
    [DataContract]
    public partial class NetworkIdentifier : IEquatable<NetworkIdentifier>
    { 
        /// <summary>
        /// Gets or Sets Blockchain
        /// </summary>
        [Required]
        [DataMember(Name="blockchain")]
        public string Blockchain { get; set; }

        /// <summary>
        /// If a blockchain has a specific chain-id or network identifier, it should go in this field. It is up to the client to determine which network-specific identifier is mainnet or testnet.
        /// </summary>
        /// <value>If a blockchain has a specific chain-id or network identifier, it should go in this field. It is up to the client to determine which network-specific identifier is mainnet or testnet.</value>
        [Required]
        [DataMember(Name="network")]
        public string Network { get; set; }

        /// <summary>
        /// Gets or Sets SubNetworkIdentifier
        /// </summary>
        [DataMember(Name="sub_network_identifier")]
        public SubNetworkIdentifier SubNetworkIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkIdentifier {\n");
            sb.Append("  Blockchain: ").Append(Blockchain).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  SubNetworkIdentifier: ").Append(SubNetworkIdentifier).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NetworkIdentifier)obj);
        }

        /// <summary>
        /// Returns true if NetworkIdentifier instances are equal
        /// </summary>
        /// <param name="other">Instance of NetworkIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkIdentifier other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Blockchain == other.Blockchain ||
                    Blockchain != null &&
                    Blockchain.Equals(other.Blockchain)
                ) && 
                (
                    Network == other.Network ||
                    Network != null &&
                    Network.Equals(other.Network)
                ) && 
                (
                    SubNetworkIdentifier == other.SubNetworkIdentifier ||
                    SubNetworkIdentifier != null &&
                    SubNetworkIdentifier.Equals(other.SubNetworkIdentifier)
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
                    if (Blockchain != null)
                    hashCode = hashCode * 59 + Blockchain.GetHashCode();
                    if (Network != null)
                    hashCode = hashCode * 59 + Network.GetHashCode();
                    if (SubNetworkIdentifier != null)
                    hashCode = hashCode * 59 + SubNetworkIdentifier.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NetworkIdentifier left, NetworkIdentifier right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NetworkIdentifier left, NetworkIdentifier right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
