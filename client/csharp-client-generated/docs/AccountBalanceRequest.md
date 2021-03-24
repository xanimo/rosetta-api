# IO.Swagger.Model.AccountBalanceRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkIdentifier** | [**NetworkIdentifier**](NetworkIdentifier.md) |  | 
**AccountIdentifier** | [**AccountIdentifier**](AccountIdentifier.md) |  | 
**BlockIdentifier** | [**PartialBlockIdentifier**](PartialBlockIdentifier.md) |  | [optional] 
**Currencies** | [**List&lt;Currency&gt;**](Currency.md) | In some cases, the caller may not want to retrieve all available balances for an AccountIdentifier. If the currencies field is populated, only balances for the specified currencies will be returned. If not populated, all available balances will be returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

