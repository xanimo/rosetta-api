/*
 * Rosetta
 *
 * Build Once. Integrate Your Blockchain Everywhere.
 *
 * API version: 1.4.10
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

// The account_identifier uniquely identifies an account within a network. All fields in the account_identifier are utilized to determine this uniqueness (including the metadata field, if populated).
type AccountIdentifier struct {
	// The address may be a cryptographic public key (or some encoding of it) or a provided username.
	Address string `json:"address"`
	SubAccount *SubAccountIdentifier `json:"sub_account,omitempty"`
	// Blockchains that utilize a username model (where the address is not a derivative of a cryptographic public key) should specify the public key(s) owned by the address in metadata.
	Metadata *interface{} `json:"metadata,omitempty"`
}
