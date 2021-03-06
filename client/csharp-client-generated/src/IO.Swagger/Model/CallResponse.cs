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
    /// CallResponse contains the result of a &#x60;/call&#x60; invocation.
    /// </summary>
    [DataContract]
        public partial class CallResponse :  IEquatable<CallResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallResponse" /> class.
        /// </summary>
        /// <param name="result">Result contains the result of the &#x60;/call&#x60; invocation. This result will not be inspected or interpreted by Rosetta tooling and is left to the caller to decode. (required).</param>
        /// <param name="idempotent">Idempotent indicates that if &#x60;/call&#x60; is invoked with the same CallRequest again, at any point in time, it will return the same CallResponse. Integrators may cache the CallResponse if this is set to true to avoid making unnecessary calls to the Rosetta implementation. For this reason, implementers should be very conservative about returning true here or they could cause issues for the caller. (required).</param>
        public CallResponse(Object result = default(Object), bool? idempotent = default(bool?))
        {
            // to ensure "result" is required (not null)
            if (result == null)
            {
                throw new InvalidDataException("result is a required property for CallResponse and cannot be null");
            }
            else
            {
                this.Result = result;
            }
            // to ensure "idempotent" is required (not null)
            if (idempotent == null)
            {
                throw new InvalidDataException("idempotent is a required property for CallResponse and cannot be null");
            }
            else
            {
                this.Idempotent = idempotent;
            }
        }
        
        /// <summary>
        /// Result contains the result of the &#x60;/call&#x60; invocation. This result will not be inspected or interpreted by Rosetta tooling and is left to the caller to decode.
        /// </summary>
        /// <value>Result contains the result of the &#x60;/call&#x60; invocation. This result will not be inspected or interpreted by Rosetta tooling and is left to the caller to decode.</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public Object Result { get; set; }

        /// <summary>
        /// Idempotent indicates that if &#x60;/call&#x60; is invoked with the same CallRequest again, at any point in time, it will return the same CallResponse. Integrators may cache the CallResponse if this is set to true to avoid making unnecessary calls to the Rosetta implementation. For this reason, implementers should be very conservative about returning true here or they could cause issues for the caller.
        /// </summary>
        /// <value>Idempotent indicates that if &#x60;/call&#x60; is invoked with the same CallRequest again, at any point in time, it will return the same CallResponse. Integrators may cache the CallResponse if this is set to true to avoid making unnecessary calls to the Rosetta implementation. For this reason, implementers should be very conservative about returning true here or they could cause issues for the caller.</value>
        [DataMember(Name="idempotent", EmitDefaultValue=false)]
        public bool? Idempotent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallResponse {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Idempotent: ").Append(Idempotent).Append("\n");
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
            return this.Equals(input as CallResponse);
        }

        /// <summary>
        /// Returns true if CallResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CallResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.Idempotent == input.Idempotent ||
                    (this.Idempotent != null &&
                    this.Idempotent.Equals(input.Idempotent))
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
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Idempotent != null)
                    hashCode = hashCode * 59 + this.Idempotent.GetHashCode();
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
