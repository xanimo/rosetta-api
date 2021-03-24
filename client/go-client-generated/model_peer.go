/*
 * Rosetta
 *
 * Build Once. Integrate Your Blockchain Everywhere.
 *
 * API version: 1.4.10
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

// A Peer is a representation of a node's peer.
type Peer struct {
	PeerId string `json:"peer_id"`
	Metadata *interface{} `json:"metadata,omitempty"`
}