/*
 * Rosetta
 *
 * Build Once. Integrate Your Blockchain Everywhere.
 *
 * API version: 1.4.10
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger
// ExemptionType : ExemptionType is used to indicate if the live balance for an account subject to a BalanceExemption could increase above, decrease below, or equal the computed balance. * greater_or_equal: The live balance may increase above or equal the computed balance. This typically   occurs with staking rewards that accrue on each block. * less_or_equal: The live balance may decrease below or equal the computed balance. This typically   occurs as balance moves from locked to spendable on a vesting account. * dynamic: The live balance may increase above, decrease below, or equal the computed balance. This   typically occurs with tokens that have a dynamic supply.
type ExemptionType string

// List of ExemptionType
const (
	GREATER_OR_EQUAL_ExemptionType ExemptionType = "greater_or_equal"
	LESS_OR_EQUAL_ExemptionType ExemptionType = "less_or_equal"
	DYNAMIC_ExemptionType ExemptionType = "dynamic"
)
