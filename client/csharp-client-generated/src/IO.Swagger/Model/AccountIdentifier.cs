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
    /// The account_identifier uniquely identifies an account within a network. All fields in the account_identifier are utilized to determine this uniqueness (including the metadata field, if populated).
    /// </summary>
    [DataContract]
        public partial class AccountIdentifier :  IEquatable<AccountIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountIdentifier" /> class.
        /// </summary>
        /// <param name="address">The address may be a cryptographic public key (or some encoding of it) or a provided username. (required).</param>
        /// <param name="subAccount">subAccount.</param>
        /// <param name="metadata">Blockchains that utilize a username model (where the address is not a derivative of a cryptographic public key) should specify the public key(s) owned by the address in metadata..</param>
        public AccountIdentifier(string address = default(string), SubAccountIdentifier subAccount = default(SubAccountIdentifier), Object metadata = default(Object))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for AccountIdentifier and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            this.SubAccount = subAccount;
            this.Metadata = metadata;
        }
        
        /// <summary>
        /// The address may be a cryptographic public key (or some encoding of it) or a provided username.
        /// </summary>
        /// <value>The address may be a cryptographic public key (or some encoding of it) or a provided username.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets SubAccount
        /// </summary>
        [DataMember(Name="sub_account", EmitDefaultValue=false)]
        public SubAccountIdentifier SubAccount { get; set; }

        /// <summary>
        /// Blockchains that utilize a username model (where the address is not a derivative of a cryptographic public key) should specify the public key(s) owned by the address in metadata.
        /// </summary>
        /// <value>Blockchains that utilize a username model (where the address is not a derivative of a cryptographic public key) should specify the public key(s) owned by the address in metadata.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountIdentifier {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  SubAccount: ").Append(SubAccount).Append("\n");
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
            return this.Equals(input as AccountIdentifier);
        }

        /// <summary>
        /// Returns true if AccountIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountIdentifier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.SubAccount == input.SubAccount ||
                    (this.SubAccount != null &&
                    this.SubAccount.Equals(input.SubAccount))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.SubAccount != null)
                    hashCode = hashCode * 59 + this.SubAccount.GetHashCode();
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
