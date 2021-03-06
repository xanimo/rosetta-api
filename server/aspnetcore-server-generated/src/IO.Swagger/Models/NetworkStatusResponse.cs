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
    /// NetworkStatusResponse contains basic information about the node&#x27;s view of a blockchain network. It is assumed that any BlockIdentifier.Index less than or equal to CurrentBlockIdentifier.Index can be queried. If a Rosetta implementation prunes historical state, it should populate the optional &#x60;oldest_block_identifier&#x60; field with the oldest block available to query. If this is not populated, it is assumed that the &#x60;genesis_block_identifier&#x60; is the oldest queryable block. If a Rosetta implementation performs some pre-sync before it is possible to query blocks, sync_status should be populated so that clients can still monitor healthiness. Without this field, it may appear that the implementation is stuck syncing and needs to be terminated.
    /// </summary>
    [DataContract]
    public partial class NetworkStatusResponse : IEquatable<NetworkStatusResponse>
    { 
        /// <summary>
        /// Gets or Sets CurrentBlockIdentifier
        /// </summary>
        [Required]
        [DataMember(Name="current_block_identifier")]
        public BlockIdentifier CurrentBlockIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets CurrentBlockTimestamp
        /// </summary>
        [Required]
        [DataMember(Name="current_block_timestamp")]
        public long? CurrentBlockTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets GenesisBlockIdentifier
        /// </summary>
        [Required]
        [DataMember(Name="genesis_block_identifier")]
        public BlockIdentifier GenesisBlockIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets OldestBlockIdentifier
        /// </summary>
        [DataMember(Name="oldest_block_identifier")]
        public BlockIdentifier OldestBlockIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets SyncStatus
        /// </summary>
        [DataMember(Name="sync_status")]
        public SyncStatus SyncStatus { get; set; }

        /// <summary>
        /// Gets or Sets Peers
        /// </summary>
        [Required]
        [DataMember(Name="peers")]
        public List<Peer> Peers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkStatusResponse {\n");
            sb.Append("  CurrentBlockIdentifier: ").Append(CurrentBlockIdentifier).Append("\n");
            sb.Append("  CurrentBlockTimestamp: ").Append(CurrentBlockTimestamp).Append("\n");
            sb.Append("  GenesisBlockIdentifier: ").Append(GenesisBlockIdentifier).Append("\n");
            sb.Append("  OldestBlockIdentifier: ").Append(OldestBlockIdentifier).Append("\n");
            sb.Append("  SyncStatus: ").Append(SyncStatus).Append("\n");
            sb.Append("  Peers: ").Append(Peers).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NetworkStatusResponse)obj);
        }

        /// <summary>
        /// Returns true if NetworkStatusResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of NetworkStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkStatusResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CurrentBlockIdentifier == other.CurrentBlockIdentifier ||
                    CurrentBlockIdentifier != null &&
                    CurrentBlockIdentifier.Equals(other.CurrentBlockIdentifier)
                ) && 
                (
                    CurrentBlockTimestamp == other.CurrentBlockTimestamp ||
                    CurrentBlockTimestamp != null &&
                    CurrentBlockTimestamp.Equals(other.CurrentBlockTimestamp)
                ) && 
                (
                    GenesisBlockIdentifier == other.GenesisBlockIdentifier ||
                    GenesisBlockIdentifier != null &&
                    GenesisBlockIdentifier.Equals(other.GenesisBlockIdentifier)
                ) && 
                (
                    OldestBlockIdentifier == other.OldestBlockIdentifier ||
                    OldestBlockIdentifier != null &&
                    OldestBlockIdentifier.Equals(other.OldestBlockIdentifier)
                ) && 
                (
                    SyncStatus == other.SyncStatus ||
                    SyncStatus != null &&
                    SyncStatus.Equals(other.SyncStatus)
                ) && 
                (
                    Peers == other.Peers ||
                    Peers != null &&
                    Peers.SequenceEqual(other.Peers)
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
                    if (CurrentBlockIdentifier != null)
                    hashCode = hashCode * 59 + CurrentBlockIdentifier.GetHashCode();
                    if (CurrentBlockTimestamp != null)
                    hashCode = hashCode * 59 + CurrentBlockTimestamp.GetHashCode();
                    if (GenesisBlockIdentifier != null)
                    hashCode = hashCode * 59 + GenesisBlockIdentifier.GetHashCode();
                    if (OldestBlockIdentifier != null)
                    hashCode = hashCode * 59 + OldestBlockIdentifier.GetHashCode();
                    if (SyncStatus != null)
                    hashCode = hashCode * 59 + SyncStatus.GetHashCode();
                    if (Peers != null)
                    hashCode = hashCode * 59 + Peers.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NetworkStatusResponse left, NetworkStatusResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NetworkStatusResponse left, NetworkStatusResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
