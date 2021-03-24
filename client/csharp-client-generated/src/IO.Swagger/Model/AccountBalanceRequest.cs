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
    /// An AccountBalanceRequest is utilized to make a balance request on the /account/balance endpoint. If the block_identifier is populated, a historical balance query should be performed.
    /// </summary>
    [DataContract]
        public partial class AccountBalanceRequest :  IEquatable<AccountBalanceRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBalanceRequest" /> class.
        /// </summary>
        /// <param name="networkIdentifier">networkIdentifier (required).</param>
        /// <param name="accountIdentifier">accountIdentifier (required).</param>
        /// <param name="blockIdentifier">blockIdentifier.</param>
        /// <param name="currencies">In some cases, the caller may not want to retrieve all available balances for an AccountIdentifier. If the currencies field is populated, only balances for the specified currencies will be returned. If not populated, all available balances will be returned..</param>
        public AccountBalanceRequest(NetworkIdentifier networkIdentifier = default(NetworkIdentifier), AccountIdentifier accountIdentifier = default(AccountIdentifier), PartialBlockIdentifier blockIdentifier = default(PartialBlockIdentifier), List<Currency> currencies = default(List<Currency>))
        {
            // to ensure "networkIdentifier" is required (not null)
            if (networkIdentifier == null)
            {
                throw new InvalidDataException("networkIdentifier is a required property for AccountBalanceRequest and cannot be null");
            }
            else
            {
                this.NetworkIdentifier = networkIdentifier;
            }
            // to ensure "accountIdentifier" is required (not null)
            if (accountIdentifier == null)
            {
                throw new InvalidDataException("accountIdentifier is a required property for AccountBalanceRequest and cannot be null");
            }
            else
            {
                this.AccountIdentifier = accountIdentifier;
            }
            this.BlockIdentifier = blockIdentifier;
            this.Currencies = currencies;
        }
        
        /// <summary>
        /// Gets or Sets NetworkIdentifier
        /// </summary>
        [DataMember(Name="network_identifier", EmitDefaultValue=false)]
        public NetworkIdentifier NetworkIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets AccountIdentifier
        /// </summary>
        [DataMember(Name="account_identifier", EmitDefaultValue=false)]
        public AccountIdentifier AccountIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets BlockIdentifier
        /// </summary>
        [DataMember(Name="block_identifier", EmitDefaultValue=false)]
        public PartialBlockIdentifier BlockIdentifier { get; set; }

        /// <summary>
        /// In some cases, the caller may not want to retrieve all available balances for an AccountIdentifier. If the currencies field is populated, only balances for the specified currencies will be returned. If not populated, all available balances will be returned.
        /// </summary>
        /// <value>In some cases, the caller may not want to retrieve all available balances for an AccountIdentifier. If the currencies field is populated, only balances for the specified currencies will be returned. If not populated, all available balances will be returned.</value>
        [DataMember(Name="currencies", EmitDefaultValue=false)]
        public List<Currency> Currencies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountBalanceRequest {\n");
            sb.Append("  NetworkIdentifier: ").Append(NetworkIdentifier).Append("\n");
            sb.Append("  AccountIdentifier: ").Append(AccountIdentifier).Append("\n");
            sb.Append("  BlockIdentifier: ").Append(BlockIdentifier).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
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
            return this.Equals(input as AccountBalanceRequest);
        }

        /// <summary>
        /// Returns true if AccountBalanceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountBalanceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountBalanceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NetworkIdentifier == input.NetworkIdentifier ||
                    (this.NetworkIdentifier != null &&
                    this.NetworkIdentifier.Equals(input.NetworkIdentifier))
                ) && 
                (
                    this.AccountIdentifier == input.AccountIdentifier ||
                    (this.AccountIdentifier != null &&
                    this.AccountIdentifier.Equals(input.AccountIdentifier))
                ) && 
                (
                    this.BlockIdentifier == input.BlockIdentifier ||
                    (this.BlockIdentifier != null &&
                    this.BlockIdentifier.Equals(input.BlockIdentifier))
                ) && 
                (
                    this.Currencies == input.Currencies ||
                    this.Currencies != null &&
                    input.Currencies != null &&
                    this.Currencies.SequenceEqual(input.Currencies)
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
                if (this.NetworkIdentifier != null)
                    hashCode = hashCode * 59 + this.NetworkIdentifier.GetHashCode();
                if (this.AccountIdentifier != null)
                    hashCode = hashCode * 59 + this.AccountIdentifier.GetHashCode();
                if (this.BlockIdentifier != null)
                    hashCode = hashCode * 59 + this.BlockIdentifier.GetHashCode();
                if (this.Currencies != null)
                    hashCode = hashCode * 59 + this.Currencies.GetHashCode();
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