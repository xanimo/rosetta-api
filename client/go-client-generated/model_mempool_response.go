/*
 * Rosetta
 *
 * Build Once. Integrate Your Blockchain Everywhere.
 *
 * API version: 1.4.10
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

// A MempoolResponse contains all transaction identifiers in the mempool for a particular network_identifier.
type MempoolResponse struct {
	TransactionIdentifiers []TransactionIdentifier `json:"transaction_identifiers"`
}
