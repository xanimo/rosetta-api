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
    /// AccountCoinsResponse is returned on the /account/coins endpoint and includes all unspent Coins owned by an AccountIdentifier.
    /// </summary>
    [DataContract]
        public partial class AccountCoinsResponse :  IEquatable<AccountCoinsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCoinsResponse" /> class.
        /// </summary>
        /// <param name="blockIdentifier">blockIdentifier (required).</param>
        /// <param name="coins">If a blockchain is UTXO-based, all unspent Coins owned by an account_identifier should be returned alongside the balance. It is highly recommended to populate this field so that users of the Rosetta API implementation don&#x27;t need to maintain their own indexer to track their UTXOs. (required).</param>
        /// <param name="metadata">Account-based blockchains that utilize a nonce or sequence number should include that number in the metadata. This number could be unique to the identifier or global across the account address..</param>
        public AccountCoinsResponse(BlockIdentifier blockIdentifier = default(BlockIdentifier), List<Coin> coins = default(List<Coin>), Object metadata = default(Object))
        {
            // to ensure "blockIdentifier" is required (not null)
            if (blockIdentifier == null)
            {
                throw new InvalidDataException("blockIdentifier is a required property for AccountCoinsResponse and cannot be null");
            }
            else
            {
                this.BlockIdentifier = blockIdentifier;
            }
            // to ensure "coins" is required (not null)
            if (coins == null)
            {
                throw new InvalidDataException("coins is a required property for AccountCoinsResponse and cannot be null");
            }
            else
            {
                this.Coins = coins;
            }
            this.Metadata = metadata;
        }
        
        /// <summary>
        /// Gets or Sets BlockIdentifier
        /// </summary>
        [DataMember(Name="block_identifier", EmitDefaultValue=false)]
        public BlockIdentifier BlockIdentifier { get; set; }

        /// <summary>
        /// If a blockchain is UTXO-based, all unspent Coins owned by an account_identifier should be returned alongside the balance. It is highly recommended to populate this field so that users of the Rosetta API implementation don&#x27;t need to maintain their own indexer to track their UTXOs.
        /// </summary>
        /// <value>If a blockchain is UTXO-based, all unspent Coins owned by an account_identifier should be returned alongside the balance. It is highly recommended to populate this field so that users of the Rosetta API implementation don&#x27;t need to maintain their own indexer to track their UTXOs.</value>
        [DataMember(Name="coins", EmitDefaultValue=false)]
        public List<Coin> Coins { get; set; }

        /// <summary>
        /// Account-based blockchains that utilize a nonce or sequence number should include that number in the metadata. This number could be unique to the identifier or global across the account address.
        /// </summary>
        /// <value>Account-based blockchains that utilize a nonce or sequence number should include that number in the metadata. This number could be unique to the identifier or global across the account address.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountCoinsResponse {\n");
            sb.Append("  BlockIdentifier: ").Append(BlockIdentifier).Append("\n");
            sb.Append("  Coins: ").Append(Coins).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as AccountCoinsResponse);
        }

        /// <summary>
        /// Returns true if AccountCoinsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountCoinsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountCoinsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlockIdentifier == input.BlockIdentifier ||
                    (this.BlockIdentifier != null &&
                    this.BlockIdentifier.Equals(input.BlockIdentifier))
                ) && 
                (
                    this.Coins == input.Coins ||
                    this.Coins != null &&
                    input.Coins != null &&
                    this.Coins.SequenceEqual(input.Coins)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.BlockIdentifier != null)
                    hashCode = hashCode * 59 + this.BlockIdentifier.GetHashCode();
                if (this.Coins != null)
                    hashCode = hashCode * 59 + this.Coins.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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
