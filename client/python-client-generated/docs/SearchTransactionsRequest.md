# SearchTransactionsRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**network_identifier** | [**NetworkIdentifier**](NetworkIdentifier.md) |  | 
**operator** | [**Operator**](Operator.md) |  | [optional] 
**max_block** | **int** | max_block is the largest block index to consider when searching for transactions. If this field is not populated, the current block is considered the max_block. If you do not specify a max_block, it is possible a newly synced block will interfere with paginated transaction queries (as the offset could become invalid with newly added rows). | [optional] 
**offset** | **int** | offset is the offset into the query result to start returning transactions. If any search conditions are changed, the query offset will change and you must restart your search iteration. | [optional] 
**limit** | **int** | limit is the maximum number of transactions to return in one call. The implementation may return &lt;&#x3D; limit transactions. | [optional] 
**transaction_identifier** | [**TransactionIdentifier**](TransactionIdentifier.md) |  | [optional] 
**account_identifier** | [**AccountIdentifier**](AccountIdentifier.md) |  | [optional] 
**coin_identifier** | [**CoinIdentifier**](CoinIdentifier.md) |  | [optional] 
**currency** | [**Currency**](Currency.md) |  | [optional] 
**status** | **str** | status is the network-specific operation type. | [optional] 
**type** | **str** | type is the network-specific operation type. | [optional] 
**address** | **str** | address is AccountIdentifier.Address. This is used to get all transactions related to an AccountIdentifier.Address, regardless of SubAccountIdentifier. | [optional] 
**success** | **bool** | success is a synthetic condition populated by parsing network-specific operation statuses (using the mapping provided in &#x60;/network/options&#x60;). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

