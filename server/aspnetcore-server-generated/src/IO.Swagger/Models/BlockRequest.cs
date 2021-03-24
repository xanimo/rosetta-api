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
    /// A BlockRequest is utilized to make a block request on the /block endpoint.
    /// </summary>
    [DataContract]
    public partial class BlockRequest : IEquatable<BlockRequest>
    { 
        /// <summary>
        /// Gets or Sets NetworkIdentifier
        /// </summary>
        [Required]
        [DataMember(Name="network_identifier")]
        public NetworkIdentifier NetworkIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets BlockIdentifier
        /// </summary>
        [Required]
        [DataMember(Name="block_identifier")]
        public PartialBlockIdentifier BlockIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlockRequest {\n");
            sb.Append("  NetworkIdentifier: ").Append(NetworkIdentifier).Append("\n");
            sb.Append("  BlockIdentifier: ").Append(BlockIdentifier).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BlockRequest)obj);
        }

        /// <summary>
        /// Returns true if BlockRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BlockRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockRequest other)
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
                    BlockIdentifier == other.BlockIdentifier ||
                    BlockIdentifier != null &&
                    BlockIdentifier.Equals(other.BlockIdentifier)
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
                    if (BlockIdentifier != null)
                    hashCode = hashCode * 59 + BlockIdentifier.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BlockRequest left, BlockRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BlockRequest left, BlockRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
