# IO.Swagger.Model.Transaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionIdentifier** | [**TransactionIdentifier**](TransactionIdentifier.md) |  | 
**Operations** | [**List&lt;Operation&gt;**](Operation.md) |  | 
**RelatedTransactions** | [**List&lt;RelatedTransaction&gt;**](RelatedTransaction.md) |  | [optional] 
**Metadata** | **Object** | Transactions that are related to other transactions (like a cross-shard transaction) should include the tranaction_identifier of these transactions in the metadata. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

