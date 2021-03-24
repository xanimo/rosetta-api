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
    /// SyncStatus is used to provide additional context about an implementation&#x27;s sync status. This object is often used by implementations to indicate healthiness when block data cannot be queried until some sync phase completes or cannot be determined by comparing the timestamp of the most recent block with the current time.
    /// </summary>
    [DataContract]
        public partial class SyncStatus :  IEquatable<SyncStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncStatus" /> class.
        /// </summary>
        /// <param name="currentIndex">CurrentIndex is the index of the last synced block in the current stage. This is a separate field from current_block_identifier in NetworkStatusResponse because blocks with indices up to and including the current_index may not yet be queryable by the caller. To reiterate, all indices up to and including current_block_identifier in NetworkStatusResponse must be queryable via the /block endpoint (excluding indices less than oldest_block_identifier)..</param>
        /// <param name="targetIndex">TargetIndex is the index of the block that the implementation is attempting to sync to in the current stage..</param>
        /// <param name="stage">Stage is the phase of the sync process..</param>
        /// <param name="synced">sycned is a boolean that indicates if an implementation has synced up to the most recent block. If this field is not populated, the caller should rely on a traditional tip timestamp comparison to determine if an implementation is synced. This field is particularly useful for quiescent blockchains (blocks only produced when there are pending transactions). In these blockchains, the most recent block could have a timestamp far behind the current time but the node could be healthy and at tip..</param>
        public SyncStatus(long? currentIndex = default(long?), long? targetIndex = default(long?), string stage = default(string), bool? synced = default(bool?))
        {
            this.CurrentIndex = currentIndex;
            this.TargetIndex = targetIndex;
            this.Stage = stage;
            this.Synced = synced;
        }
        
        /// <summary>
        /// CurrentIndex is the index of the last synced block in the current stage. This is a separate field from current_block_identifier in NetworkStatusResponse because blocks with indices up to and including the current_index may not yet be queryable by the caller. To reiterate, all indices up to and including current_block_identifier in NetworkStatusResponse must be queryable via the /block endpoint (excluding indices less than oldest_block_identifier).
        /// </summary>
        /// <value>CurrentIndex is the index of the last synced block in the current stage. This is a separate field from current_block_identifier in NetworkStatusResponse because blocks with indices up to and including the current_index may not yet be queryable by the caller. To reiterate, all indices up to and including current_block_identifier in NetworkStatusResponse must be queryable via the /block endpoint (excluding indices less than oldest_block_identifier).</value>
        [DataMember(Name="current_index", EmitDefaultValue=false)]
        public long? CurrentIndex { get; set; }

        /// <summary>
        /// TargetIndex is the index of the block that the implementation is attempting to sync to in the current stage.
        /// </summary>
        /// <value>TargetIndex is the index of the block that the implementation is attempting to sync to in the current stage.</value>
        [DataMember(Name="target_index", EmitDefaultValue=false)]
        public long? TargetIndex { get; set; }

        /// <summary>
        /// Stage is the phase of the sync process.
        /// </summary>
        /// <value>Stage is the phase of the sync process.</value>
        [DataMember(Name="stage", EmitDefaultValue=false)]
        public string Stage { get; set; }

        /// <summary>
        /// sycned is a boolean that indicates if an implementation has synced up to the most recent block. If this field is not populated, the caller should rely on a traditional tip timestamp comparison to determine if an implementation is synced. This field is particularly useful for quiescent blockchains (blocks only produced when there are pending transactions). In these blockchains, the most recent block could have a timestamp far behind the current time but the node could be healthy and at tip.
        /// </summary>
        /// <value>sycned is a boolean that indicates if an implementation has synced up to the most recent block. If this field is not populated, the caller should rely on a traditional tip timestamp comparison to determine if an implementation is synced. This field is particularly useful for quiescent blockchains (blocks only produced when there are pending transactions). In these blockchains, the most recent block could have a timestamp far behind the current time but the node could be healthy and at tip.</value>
        [DataMember(Name="synced", EmitDefaultValue=false)]
        public bool? Synced { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SyncStatus {\n");
            sb.Append("  CurrentIndex: ").Append(CurrentIndex).Append("\n");
            sb.Append("  TargetIndex: ").Append(TargetIndex).Append("\n");
            sb.Append("  Stage: ").Append(Stage).Append("\n");
            sb.Append("  Synced: ").Append(Synced).Append("\n");
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
            return this.Equals(input as SyncStatus);
        }

        /// <summary>
        /// Returns true if SyncStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of SyncStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyncStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentIndex == input.CurrentIndex ||
                    (this.CurrentIndex != null &&
                    this.CurrentIndex.Equals(input.CurrentIndex))
                ) && 
                (
                    this.TargetIndex == input.TargetIndex ||
                    (this.TargetIndex != null &&
                    this.TargetIndex.Equals(input.TargetIndex))
                ) && 
                (
                    this.Stage == input.Stage ||
                    (this.Stage != null &&
                    this.Stage.Equals(input.Stage))
                ) && 
                (
                    this.Synced == input.Synced ||
                    (this.Synced != null &&
                    this.Synced.Equals(input.Synced))
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
                if (this.CurrentIndex != null)
                    hashCode = hashCode * 59 + this.CurrentIndex.GetHashCode();
                if (this.TargetIndex != null)
                    hashCode = hashCode * 59 + this.TargetIndex.GetHashCode();
                if (this.Stage != null)
                    hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.Synced != null)
                    hashCode = hashCode * 59 + this.Synced.GetHashCode();
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
