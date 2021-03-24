# AccountBalanceRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkIdentifier** | [***NetworkIdentifier**](NetworkIdentifier.md) |  | [default to null]
**AccountIdentifier** | [***AccountIdentifier**](AccountIdentifier.md) |  | [default to null]
**BlockIdentifier** | [***PartialBlockIdentifier**](PartialBlockIdentifier.md) |  | [optional] [default to null]
**Currencies** | [**[]Currency**](Currency.md) | In some cases, the caller may not want to retrieve all available balances for an AccountIdentifier. If the currencies field is populated, only balances for the specified currencies will be returned. If not populated, all available balances will be returned. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

