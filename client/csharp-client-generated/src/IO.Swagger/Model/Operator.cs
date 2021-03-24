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
    /// Operator is used by query-related endpoints to determine how to apply conditions. If this field is not populated, the default &#x60;and&#x60; value will be used.
    /// </summary>
    /// <value>Operator is used by query-related endpoints to determine how to apply conditions. If this field is not populated, the default &#x60;and&#x60; value will be used.</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum Operator
    {
        /// <summary>
        /// Enum Or for value: or
        /// </summary>
        [EnumMember(Value = "or")]
        Or = 1,
        /// <summary>
        /// Enum And for value: and
        /// </summary>
        [EnumMember(Value = "and")]
        And = 2    }
}