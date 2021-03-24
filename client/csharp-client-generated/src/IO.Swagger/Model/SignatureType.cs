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
    /// SignatureType is the type of a cryptographic signature. * ecdsa: &#x60;r (32-bytes) || s (32-bytes)&#x60; - &#x60;64 bytes&#x60; * ecdsa_recovery: &#x60;r (32-bytes) || s (32-bytes) || v (1-byte)&#x60; - &#x60;65 bytes&#x60; * ed25519: &#x60;R (32-byte) || s (32-bytes)&#x60; - &#x60;64 bytes&#x60; * schnorr_1: &#x60;r (32-bytes) || s (32-bytes)&#x60; - &#x60;64 bytes&#x60;  (schnorr signature implemented by Zilliqa where both &#x60;r&#x60; and &#x60;s&#x60; are scalars encoded as &#x60;32-bytes&#x60; values, most significant byte first.) * schnorr_poseidon: &#x60;r (32-bytes) || s (32-bytes)&#x60; where s &#x3D; Hash(1st pk || 2nd pk || r) - &#x60;64 bytes&#x60;  (schnorr signature w/ Poseidon hash function implemented by O(1) Labs where both &#x60;r&#x60; and &#x60;s&#x60; are scalars encoded as &#x60;32-bytes&#x60; values, least significant byte first. https://github.com/CodaProtocol/signer-reference/blob/master/schnorr.ml )
    /// </summary>
    /// <value>SignatureType is the type of a cryptographic signature. * ecdsa: &#x60;r (32-bytes) || s (32-bytes)&#x60; - &#x60;64 bytes&#x60; * ecdsa_recovery: &#x60;r (32-bytes) || s (32-bytes) || v (1-byte)&#x60; - &#x60;65 bytes&#x60; * ed25519: &#x60;R (32-byte) || s (32-bytes)&#x60; - &#x60;64 bytes&#x60; * schnorr_1: &#x60;r (32-bytes) || s (32-bytes)&#x60; - &#x60;64 bytes&#x60;  (schnorr signature implemented by Zilliqa where both &#x60;r&#x60; and &#x60;s&#x60; are scalars encoded as &#x60;32-bytes&#x60; values, most significant byte first.) * schnorr_poseidon: &#x60;r (32-bytes) || s (32-bytes)&#x60; where s &#x3D; Hash(1st pk || 2nd pk || r) - &#x60;64 bytes&#x60;  (schnorr signature w/ Poseidon hash function implemented by O(1) Labs where both &#x60;r&#x60; and &#x60;s&#x60; are scalars encoded as &#x60;32-bytes&#x60; values, least significant byte first. https://github.com/CodaProtocol/signer-reference/blob/master/schnorr.ml )</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum SignatureType
    {
        /// <summary>
        /// Enum Ecdsa for value: ecdsa
        /// </summary>
        [EnumMember(Value = "ecdsa")]
        Ecdsa = 1,
        /// <summary>
        /// Enum Ecdsarecovery for value: ecdsa_recovery
        /// </summary>
        [EnumMember(Value = "ecdsa_recovery")]
        Ecdsarecovery = 2,
        /// <summary>
        /// Enum Ed25519 for value: ed25519
        /// </summary>
        [EnumMember(Value = "ed25519")]
        Ed25519 = 3,
        /// <summary>
        /// Enum Schnorr1 for value: schnorr_1
        /// </summary>
        [EnumMember(Value = "schnorr_1")]
        Schnorr1 = 4,
        /// <summary>
        /// Enum Schnorrposeidon for value: schnorr_poseidon
        /// </summary>
        [EnumMember(Value = "schnorr_poseidon")]
        Schnorrposeidon = 5    }
}
