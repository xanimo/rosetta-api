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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// The network_identifier specifies which network a particular object is associated with.
    /// </summary>
    [DataContract]
        public partial class NetworkIdentifier :  IEquatable<NetworkIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkIdentifier" /> class.
        /// </summary>
        /// <param name="blockchain">blockchain (required).</param>
        /// <param name="network">If a blockchain has a specific chain-id or network identifier, it should go in this field. It is up to the client to determine which network-specific identifier is mainnet or testnet. (required).</param>
        /// <param name="subNetworkIdentifier">subNetworkIdentifier.</param>
        public NetworkIdentifier(string blockchain = default(string), string network = default(string), SubNetworkIdentifier subNetworkIdentifier = default(SubNetworkIdentifier))
        {
            // to ensure "blockchain" is required (not null)
            if (blockchain == null)
            {
                throw new InvalidDataException("blockchain is a required property for NetworkIdentifier and cannot be null");
            }
            else
            {
                this.Blockchain = blockchain;
            }
            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new InvalidDataException("network is a required property for NetworkIdentifier and cannot be null");
            }
            else
            {
                this.Network = network;
            }
            this.SubNetworkIdentifier = subNetworkIdentifier;
        }
        
        /// <summary>
        /// Gets or Sets Blockchain
        /// </summary>
        [DataMember(Name="blockchain", EmitDefaultValue=false)]
        public string Blockchain { get; set; }

        /// <summary>
        /// If a blockchain has a specific chain-id or network identifier, it should go in this field. It is up to the client to determine which network-specific identifier is mainnet or testnet.
        /// </summary>
        /// <value>If a blockchain has a specific chain-id or network identifier, it should go in this field. It is up to the client to determine which network-specific identifier is mainnet or testnet.</value>
        [DataMember(Name="network", EmitDefaultValue=false)]
        public string Network { get; set; }

        /// <summary>
        /// Gets or Sets SubNetworkIdentifier
        /// </summary>
        [DataMember(Name="sub_network_identifier", EmitDefaultValue=false)]
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
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkIdentifier);
        }

        /// <summary>
        /// Returns true if NetworkIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkIdentifier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Blockchain == input.Blockchain ||
                    (this.Blockchain != null &&
                    this.Blockchain.Equals(input.Blockchain))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.SubNetworkIdentifier == input.SubNetworkIdentifier ||
                    (this.SubNetworkIdentifier != null &&
                    this.SubNetworkIdentifier.Equals(input.SubNetworkIdentifier))
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
                int hashCode = 41;
                if (this.Blockchain != null)
                    hashCode = hashCode * 59 + this.Blockchain.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.SubNetworkIdentifier != null)
                    hashCode = hashCode * 59 + this.SubNetworkIdentifier.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
