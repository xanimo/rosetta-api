# swagger_client.NetworkApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**network_list**](NetworkApi.md#network_list) | **POST** /network/list | Get List of Available Networks
[**network_options**](NetworkApi.md#network_options) | **POST** /network/options | Get Network Options
[**network_status**](NetworkApi.md#network_status) | **POST** /network/status | Get Network Status

# **network_list**
> NetworkListResponse network_list(body)

Get List of Available Networks

This endpoint returns a list of NetworkIdentifiers that the Rosetta server supports.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NetworkApi()
body = swagger_client.MetadataRequest() # MetadataRequest | 

try:
    # Get List of Available Networks
    api_response = api_instance.network_list(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NetworkApi->network_list: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MetadataRequest**](MetadataRequest.md)|  | 

### Return type

[**NetworkListResponse**](NetworkListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **network_options**
> NetworkOptionsResponse network_options(body)

Get Network Options

This endpoint returns the version information and allowed network-specific types for a NetworkIdentifier. Any NetworkIdentifier returned by /network/list should be accessible here. Because options are retrievable in the context of a NetworkIdentifier, it is possible to define unique options for each network.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NetworkApi()
body = swagger_client.NetworkRequest() # NetworkRequest | 

try:
    # Get Network Options
    api_response = api_instance.network_options(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NetworkApi->network_options: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NetworkRequest**](NetworkRequest.md)|  | 

### Return type

[**NetworkOptionsResponse**](NetworkOptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **network_status**
> NetworkStatusResponse network_status(body)

Get Network Status

This endpoint returns the current status of the network requested. Any NetworkIdentifier returned by /network/list should be accessible here.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NetworkApi()
body = swagger_client.NetworkRequest() # NetworkRequest | 

try:
    # Get Network Status
    api_response = api_instance.network_status(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NetworkApi->network_status: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NetworkRequest**](NetworkRequest.md)|  | 

### Return type

[**NetworkStatusResponse**](NetworkStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

