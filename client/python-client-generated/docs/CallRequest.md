# CallRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**network_identifier** | [**NetworkIdentifier**](NetworkIdentifier.md) |  | 
**method** | **str** | Method is some network-specific procedure call. This method could map to a network-specific RPC endpoint, a method in an SDK generated from a smart contract, or some hybrid of the two. The implementation must define all available methods in the Allow object. However, it is up to the caller to determine which parameters to provide when invoking &#x60;/call&#x60;. | 
**parameters** | **object** | Parameters is some network-specific argument for a method. It is up to the caller to determine which parameters to provide when invoking &#x60;/call&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

