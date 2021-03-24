# Transaction

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionIdentifier** | [***TransactionIdentifier**](TransactionIdentifier.md) |  | [default to null]
**Operations** | [**[]Operation**](Operation.md) |  | [default to null]
**RelatedTransactions** | [**[]RelatedTransaction**](RelatedTransaction.md) |  | [optional] [default to null]
**Metadata** | [***interface{}**](interface{}.md) | Transactions that are related to other transactions (like a cross-shard transaction) should include the tranaction_identifier of these transactions in the metadata. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

