# IO.Swagger.Model.CallResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Result** | **Object** | Result contains the result of the &#x60;/call&#x60; invocation. This result will not be inspected or interpreted by Rosetta tooling and is left to the caller to decode. | 
**Idempotent** | **bool?** | Idempotent indicates that if &#x60;/call&#x60; is invoked with the same CallRequest again, at any point in time, it will return the same CallResponse. Integrators may cache the CallResponse if this is set to true to avoid making unnecessary calls to the Rosetta implementation. For this reason, implementers should be very conservative about returning true here or they could cause issues for the caller. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

