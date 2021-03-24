# Transaction

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_identifier** | [**TransactionIdentifier**](TransactionIdentifier.md) |  | 
**operations** | [**list[Operation]**](Operation.md) |  | 
**related_transactions** | [**list[RelatedTransaction]**](RelatedTransaction.md) |  | [optional] 
**metadata** | **object** | Transactions that are related to other transactions (like a cross-shard transaction) should include the tranaction_identifier of these transactions in the metadata. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

