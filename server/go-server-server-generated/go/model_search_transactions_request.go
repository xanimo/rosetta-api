/*
 * Rosetta
 *
 * Build Once. Integrate Your Blockchain Everywhere.
 *
 * API version: 1.4.10
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

// SearchTransactionsRequest is used to search for transactions matching a set of provided conditions in canonical blocks.
type SearchTransactionsRequest struct {

	NetworkIdentifier *NetworkIdentifier `json:"network_identifier"`

	Operator *Operator `json:"operator,omitempty"`
	// max_block is the largest block index to consider when searching for transactions. If this field is not populated, the current block is considered the max_block. If you do not specify a max_block, it is possible a newly synced block will interfere with paginated transaction queries (as the offset could become invalid with newly added rows).
	MaxBlock int64 `json:"max_block,omitempty"`
	// offset is the offset into the query result to start returning transactions. If any search conditions are changed, the query offset will change and you must restart your search iteration.
	Offset int64 `json:"offset,omitempty"`
	// limit is the maximum number of transactions to return in one call. The implementation may return <= limit transactions.
	Limit int64 `json:"limit,omitempty"`

	TransactionIdentifier *TransactionIdentifier `json:"transaction_identifier,omitempty"`

	AccountIdentifier *AccountIdentifier `json:"account_identifier,omitempty"`

	CoinIdentifier *CoinIdentifier `json:"coin_identifier,omitempty"`

	Currency *Currency `json:"currency,omitempty"`
	// status is the network-specific operation type.
	Status string `json:"status,omitempty"`
	// type is the network-specific operation type.
	Type_ string `json:"type,omitempty"`
	// address is AccountIdentifier.Address. This is used to get all transactions related to an AccountIdentifier.Address, regardless of SubAccountIdentifier.
	Address string `json:"address,omitempty"`
	// success is a synthetic condition populated by parsing network-specific operation statuses (using the mapping provided in `/network/options`).
	Success bool `json:"success,omitempty"`
}