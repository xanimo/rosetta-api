# ConstructionParseResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operations** | [**[]Operation**](Operation.md) |  | [default to null]
**Signers** | **[]string** | [DEPRECATED by &#x60;account_identifier_signers&#x60; in &#x60;v1.4.4&#x60;] All signers (addresses) of a particular transaction. If the transaction is unsigned, it should be empty. | [optional] [default to null]
**AccountIdentifierSigners** | [**[]AccountIdentifier**](AccountIdentifier.md) |  | [optional] [default to null]
**Metadata** | [***interface{}**](interface{}.md) |  | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

