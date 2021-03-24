# AccountCoinsRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkIdentifier** | [***NetworkIdentifier**](NetworkIdentifier.md) |  | [default to null]
**AccountIdentifier** | [***AccountIdentifier**](AccountIdentifier.md) |  | [default to null]
**IncludeMempool** | **bool** | Include state from the mempool when looking up an account&#x27;s unspent coins. Note, using this functionality breaks any guarantee of idempotency. | [default to null]
**Currencies** | [**[]Currency**](Currency.md) | In some cases, the caller may not want to retrieve coins for all currencies for an AccountIdentifier. If the currencies field is populated, only coins for the specified currencies will be returned. If not populated, all unspent coins will be returned. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

