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
    /// EventsBlocksResponse contains an ordered collection of BlockEvents and the max retrievable sequence.
    /// </summary>
    [DataContract]
        public partial class EventsBlocksResponse :  IEquatable<EventsBlocksResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventsBlocksResponse" /> class.
        /// </summary>
        /// <param name="maxSequence">max_sequence is the maximum available sequence number to fetch. (required).</param>
        /// <param name="events">events is an array of BlockEvents indicating the order to add and remove blocks to maintain a canonical view of blockchain state. Lightweight clients can use this event stream to update state without implementing their own block syncing logic. (required).</param>
        public EventsBlocksResponse(long? maxSequence = default(long?), List<BlockEvent> events = default(List<BlockEvent>))
        {
            // to ensure "maxSequence" is required (not null)
            if (maxSequence == null)
            {
                throw new InvalidDataException("maxSequence is a required property for EventsBlocksResponse and cannot be null");
            }
            else
            {
                this.MaxSequence = maxSequence;
            }
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new InvalidDataException("events is a required property for EventsBlocksResponse and cannot be null");
            }
            else
            {
                this.Events = events;
            }
        }
        
        /// <summary>
        /// max_sequence is the maximum available sequence number to fetch.
        /// </summary>
        /// <value>max_sequence is the maximum available sequence number to fetch.</value>
        [DataMember(Name="max_sequence", EmitDefaultValue=false)]
        public long? MaxSequence { get; set; }

        /// <summary>
        /// events is an array of BlockEvents indicating the order to add and remove blocks to maintain a canonical view of blockchain state. Lightweight clients can use this event stream to update state without implementing their own block syncing logic.
        /// </summary>
        /// <value>events is an array of BlockEvents indicating the order to add and remove blocks to maintain a canonical view of blockchain state. Lightweight clients can use this event stream to update state without implementing their own block syncing logic.</value>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<BlockEvent> Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventsBlocksResponse {\n");
            sb.Append("  MaxSequence: ").Append(MaxSequence).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
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
            return this.Equals(input as EventsBlocksResponse);
        }

        /// <summary>
        /// Returns true if EventsBlocksResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EventsBlocksResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventsBlocksResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxSequence == input.MaxSequence ||
                    (this.MaxSequence != null &&
                    this.MaxSequence.Equals(input.MaxSequence))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
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
                if (this.MaxSequence != null)
                    hashCode = hashCode * 59 + this.MaxSequence.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
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
