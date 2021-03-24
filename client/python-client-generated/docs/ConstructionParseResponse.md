# ConstructionParseResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**operations** | [**list[Operation]**](Operation.md) |  | 
**signers** | **list[str]** | [DEPRECATED by &#x60;account_identifier_signers&#x60; in &#x60;v1.4.4&#x60;] All signers (addresses) of a particular transaction. If the transaction is unsigned, it should be empty. | [optional] 
**account_identifier_signers** | [**list[AccountIdentifier]**](AccountIdentifier.md) |  | [optional] 
**metadata** | **object** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

