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
    /// The Version object is utilized to inform the client of the versions of different components of the Rosetta implementation.
    /// </summary>
    [DataContract]
    public partial class Version : IEquatable<Version>
    { 
        /// <summary>
        /// The rosetta_version is the version of the Rosetta interface the implementation adheres to. This can be useful for clients looking to reliably parse responses.
        /// </summary>
        /// <value>The rosetta_version is the version of the Rosetta interface the implementation adheres to. This can be useful for clients looking to reliably parse responses.</value>
        [Required]
        [DataMember(Name="rosetta_version")]
        public string RosettaVersion { get; set; }

        /// <summary>
        /// The node_version is the canonical version of the node runtime. This can help clients manage deployments.
        /// </summary>
        /// <value>The node_version is the canonical version of the node runtime. This can help clients manage deployments.</value>
        [Required]
        [DataMember(Name="node_version")]
        public string NodeVersion { get; set; }

        /// <summary>
        /// When a middleware server is used to adhere to the Rosetta interface, it should return its version here. This can help clients manage deployments.
        /// </summary>
        /// <value>When a middleware server is used to adhere to the Rosetta interface, it should return its version here. This can help clients manage deployments.</value>
        [DataMember(Name="middleware_version")]
        public string MiddlewareVersion { get; set; }

        /// <summary>
        /// Any other information that may be useful about versioning of dependent services should be returned here.
        /// </summary>
        /// <value>Any other information that may be useful about versioning of dependent services should be returned here.</value>
        [DataMember(Name="metadata")]
        public Object Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Version {\n");
            sb.Append("  RosettaVersion: ").Append(RosettaVersion).Append("\n");
            sb.Append("  NodeVersion: ").Append(NodeVersion).Append("\n");
            sb.Append("  MiddlewareVersion: ").Append(MiddlewareVersion).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Version)obj);
        }

        /// <summary>
        /// Returns true if Version instances are equal
        /// </summary>
        /// <param name="other">Instance of Version to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Version other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RosettaVersion == other.RosettaVersion ||
                    RosettaVersion != null &&
                    RosettaVersion.Equals(other.RosettaVersion)
                ) && 
                (
                    NodeVersion == other.NodeVersion ||
                    NodeVersion != null &&
                    NodeVersion.Equals(other.NodeVersion)
                ) && 
                (
                    MiddlewareVersion == other.MiddlewareVersion ||
                    MiddlewareVersion != null &&
                    MiddlewareVersion.Equals(other.MiddlewareVersion)
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
                    if (RosettaVersion != null)
                    hashCode = hashCode * 59 + RosettaVersion.GetHashCode();
                    if (NodeVersion != null)
                    hashCode = hashCode * 59 + NodeVersion.GetHashCode();
                    if (MiddlewareVersion != null)
                    hashCode = hashCode * 59 + MiddlewareVersion.GetHashCode();
                    if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Version left, Version right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Version left, Version right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
