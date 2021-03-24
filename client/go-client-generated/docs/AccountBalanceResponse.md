# AccountBalanceResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockIdentifier** | [***BlockIdentifier**](BlockIdentifier.md) |  | [default to null]
**Balances** | [**[]Amount**](Amount.md) | A single account may have a balance in multiple currencies. | [default to null]
**Metadata** | [***interface{}**](interface{}.md) | Account-based blockchains that utilize a nonce or sequence number should include that number in the metadata. This number could be unique to the identifier or global across the account address. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

