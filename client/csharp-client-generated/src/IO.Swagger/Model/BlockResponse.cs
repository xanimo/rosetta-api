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
    /// A BlockResponse includes a fully-populated block or a partially-populated block with a list of other transactions to fetch (other_transactions). As a result of the consensus algorithm of some blockchains, blocks can be omitted (i.e. certain block indices can be skipped). If a query for one of these omitted indices is made, the response should not include a &#x60;Block&#x60; object. It is VERY important to note that blocks MUST still form a canonical, connected chain of blocks where each block has a unique index. In other words, the &#x60;PartialBlockIdentifier&#x60; of a block after an omitted block should reference the last non-omitted block.
    /// </summary>
    [DataContract]
        public partial class BlockResponse :  IEquatable<BlockResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockResponse" /> class.
        /// </summary>
        /// <param name="block">block.</param>
        /// <param name="otherTransactions">Some blockchains may require additional transactions to be fetched that weren&#x27;t returned in the block response (ex: block only returns transaction hashes). For blockchains with a lot of transactions in each block, this can be very useful as consumers can concurrently fetch all transactions returned..</param>
        public BlockResponse(Block block = default(Block), List<TransactionIdentifier> otherTransactions = default(List<TransactionIdentifier>))
        {
            this.Block = block;
            this.OtherTransactions = otherTransactions;
        }
        
        /// <summary>
        /// Gets or Sets Block
        /// </summary>
        [DataMember(Name="block", EmitDefaultValue=false)]
        public Block Block { get; set; }

        /// <summary>
        /// Some blockchains may require additional transactions to be fetched that weren&#x27;t returned in the block response (ex: block only returns transaction hashes). For blockchains with a lot of transactions in each block, this can be very useful as consumers can concurrently fetch all transactions returned.
        /// </summary>
        /// <value>Some blockchains may require additional transactions to be fetched that weren&#x27;t returned in the block response (ex: block only returns transaction hashes). For blockchains with a lot of transactions in each block, this can be very useful as consumers can concurrently fetch all transactions returned.</value>
        [DataMember(Name="other_transactions", EmitDefaultValue=false)]
        public List<TransactionIdentifier> OtherTransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlockResponse {\n");
            sb.Append("  Block: ").Append(Block).Append("\n");
            sb.Append("  OtherTransactions: ").Append(OtherTransactions).Append("\n");
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
            return this.Equals(input as BlockResponse);
        }

        /// <summary>
        /// Returns true if BlockResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BlockResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Block == input.Block ||
                    (this.Block != null &&
                    this.Block.Equals(input.Block))
                ) && 
                (
                    this.OtherTransactions == input.OtherTransactions ||
                    this.OtherTransactions != null &&
                    input.OtherTransactions != null &&
                    this.OtherTransactions.SequenceEqual(input.OtherTransactions)
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
                if (this.Block != null)
                    hashCode = hashCode * 59 + this.Block.GetHashCode();
                if (this.OtherTransactions != null)
                    hashCode = hashCode * 59 + this.OtherTransactions.GetHashCode();
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
