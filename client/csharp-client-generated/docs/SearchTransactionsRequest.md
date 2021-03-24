# IO.Swagger.Model.SearchTransactionsRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkIdentifier** | [**NetworkIdentifier**](NetworkIdentifier.md) |  | 
**Operator** | **Operator** |  | [optional] 
**MaxBlock** | **long?** | max_block is the largest block index to consider when searching for transactions. If this field is not populated, the current block is considered the max_block. If you do not specify a max_block, it is possible a newly synced block will interfere with paginated transaction queries (as the offset could become invalid with newly added rows). | [optional] 
**Offset** | **long?** | offset is the offset into the query result to start returning transactions. If any search conditions are changed, the query offset will change and you must restart your search iteration. | [optional] 
**Limit** | **long?** | limit is the maximum number of transactions to return in one call. The implementation may return &lt;&#x3D; limit transactions. | [optional] 
**TransactionIdentifier** | [**TransactionIdentifier**](TransactionIdentifier.md) |  | [optional] 
**AccountIdentifier** | [**AccountIdentifier**](AccountIdentifier.md) |  | [optional] 
**CoinIdentifier** | [**CoinIdentifier**](CoinIdentifier.md) |  | [optional] 
**Currency** | [**Currency**](Currency.md) |  | [optional] 
**Status** | **string** | status is the network-specific operation type. | [optional] 
**Type** | **string** | type is the network-specific operation type. | [optional] 
**Address** | **string** | address is AccountIdentifier.Address. This is used to get all transactions related to an AccountIdentifier.Address, regardless of SubAccountIdentifier. | [optional] 
**Success** | **bool?** | success is a synthetic condition populated by parsing network-specific operation statuses (using the mapping provided in &#x60;/network/options&#x60;). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

