/*
 * Rosetta
 *
 * Build Once. Integrate Your Blockchain Everywhere.
 *
 * API version: 1.4.10
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

// In blockchains with sharded state, the SubNetworkIdentifier is required to query some object on a specific shard. This identifier is optional for all non-sharded blockchains.
type SubNetworkIdentifier struct {
	Network string `json:"network"`
	Metadata *interface{} `json:"metadata,omitempty"`
}