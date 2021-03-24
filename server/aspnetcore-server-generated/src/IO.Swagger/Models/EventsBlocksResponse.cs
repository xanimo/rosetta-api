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
    /// EventsBlocksResponse contains an ordered collection of BlockEvents and the max retrievable sequence.
    /// </summary>
    [DataContract]
    public partial class EventsBlocksResponse : IEquatable<EventsBlocksResponse>
    { 
        /// <summary>
        /// max_sequence is the maximum available sequence number to fetch.
        /// </summary>
        /// <value>max_sequence is the maximum available sequence number to fetch.</value>
        [Required]
        [DataMember(Name="max_sequence")]
        public long? MaxSequence { get; set; }

        /// <summary>
        /// events is an array of BlockEvents indicating the order to add and remove blocks to maintain a canonical view of blockchain state. Lightweight clients can use this event stream to update state without implementing their own block syncing logic.
        /// </summary>
        /// <value>events is an array of BlockEvents indicating the order to add and remove blocks to maintain a canonical view of blockchain state. Lightweight clients can use this event stream to update state without implementing their own block syncing logic.</value>
        [Required]
        [DataMember(Name="events")]
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
            return obj.GetType() == GetType() && Equals((EventsBlocksResponse)obj);
        }

        /// <summary>
        /// Returns true if EventsBlocksResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EventsBlocksResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventsBlocksResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    MaxSequence == other.MaxSequence ||
                    MaxSequence != null &&
                    MaxSequence.Equals(other.MaxSequence)
                ) && 
                (
                    Events == other.Events ||
                    Events != null &&
                    Events.SequenceEqual(other.Events)
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
                    if (MaxSequence != null)
                    hashCode = hashCode * 59 + MaxSequence.GetHashCode();
                    if (Events != null)
                    hashCode = hashCode * 59 + Events.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EventsBlocksResponse left, EventsBlocksResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EventsBlocksResponse left, EventsBlocksResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
