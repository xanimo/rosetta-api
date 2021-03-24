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
    /// A NetworkListResponse contains all NetworkIdentifiers that the node can serve information for.
    /// </summary>
    [DataContract]
    public partial class NetworkListResponse : IEquatable<NetworkListResponse>
    { 
        /// <summary>
        /// Gets or Sets NetworkIdentifiers
        /// </summary>
        [Required]
        [DataMember(Name="network_identifiers")]
        public List<NetworkIdentifier> NetworkIdentifiers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkListResponse {\n");
            sb.Append("  NetworkIdentifiers: ").Append(NetworkIdentifiers).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NetworkListResponse)obj);
        }

        /// <summary>
        /// Returns true if NetworkListResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of NetworkListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkListResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NetworkIdentifiers == other.NetworkIdentifiers ||
                    NetworkIdentifiers != null &&
                    NetworkIdentifiers.SequenceEqual(other.NetworkIdentifiers)
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
                    if (NetworkIdentifiers != null)
                    hashCode = hashCode * 59 + NetworkIdentifiers.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NetworkListResponse left, NetworkListResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NetworkListResponse left, NetworkListResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}