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
    /// An AccountBalanceResponse is returned on the /account/balance endpoint. If an account has a balance for each AccountIdentifier describing it (ex: an ERC-20 token balance on a few smart contracts), an account balance request must be made with each AccountIdentifier. The &#x60;coins&#x60; field was removed and replaced by by &#x60;/account/coins&#x60; in &#x60;v1.4.7&#x60;.
    /// </summary>
    [DataContract]
        public partial class AccountBalanceResponse :  IEquatable<AccountBalanceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBalanceResponse" /> class.
        /// </summary>
        /// <param name="blockIdentifier">blockIdentifier (required).</param>
        /// <param name="balances">A single account may have a balance in multiple currencies. (required).</param>
        /// <param name="metadata">Account-based blockchains that utilize a nonce or sequence number should include that number in the metadata. This number could be unique to the identifier or global across the account address..</param>
        public AccountBalanceResponse(BlockIdentifier blockIdentifier = default(BlockIdentifier), List<Amount> balances = default(List<Amount>), Object metadata = default(Object))
        {
            // to ensure "blockIdentifier" is required (not null)
            if (blockIdentifier == null)
            {
                throw new InvalidDataException("blockIdentifier is a required property for AccountBalanceResponse and cannot be null");
            }
            else
            {
                this.BlockIdentifier = blockIdentifier;
            }
            // to ensure "balances" is required (not null)
            if (balances == null)
            {
                throw new InvalidDataException("balances is a required property for AccountBalanceResponse and cannot be null");
            }
            else
            {
                this.Balances = balances;
            }
            this.Metadata = metadata;
        }
        
        /// <summary>
        /// Gets or Sets BlockIdentifier
        /// </summary>
        [DataMember(Name="block_identifier", EmitDefaultValue=false)]
        public BlockIdentifier BlockIdentifier { get; set; }

        /// <summary>
        /// A single account may have a balance in multiple currencies.
        /// </summary>
        /// <value>A single account may have a balance in multiple currencies.</value>
        [DataMember(Name="balances", EmitDefaultValue=false)]
        public List<Amount> Balances { get; set; }

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
            sb.Append("class AccountBalanceResponse {\n");
            sb.Append("  BlockIdentifier: ").Append(BlockIdentifier).Append("\n");
            sb.Append("  Balances: ").Append(Balances).Append("\n");
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
            return this.Equals(input as AccountBalanceResponse);
        }

        /// <summary>
        /// Returns true if AccountBalanceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountBalanceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountBalanceResponse input)
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
                    this.Balances == input.Balances ||
                    this.Balances != null &&
                    input.Balances != null &&
                    this.Balances.SequenceEqual(input.Balances)
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
                if (this.Balances != null)
                    hashCode = hashCode * 59 + this.Balances.GetHashCode();
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