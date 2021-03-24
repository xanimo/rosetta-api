# swagger_client.EventsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**events_blocks**](EventsApi.md#events_blocks) | **POST** /events/blocks | [INDEXER] Get a range of BlockEvents

# **events_blocks**
> EventsBlocksResponse events_blocks(body)

[INDEXER] Get a range of BlockEvents

`/events/blocks` allows the caller to query a sequence of BlockEvents indicating which blocks were added and removed from storage to reach the current state. Following BlockEvents allows lightweight clients to update their state without needing to implement their own syncing logic (like finding the common parent in a reorg). `/events/blocks` is considered an \"indexer\" endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \"indexer\" MUST support this endpoint.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EventsApi()
body = swagger_client.EventsBlocksRequest() # EventsBlocksRequest | 

try:
    # [INDEXER] Get a range of BlockEvents
    api_response = api_instance.events_blocks(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EventsApi->events_blocks: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventsBlocksRequest**](EventsBlocksRequest.md)|  | 

### Return type

[**EventsBlocksResponse**](EventsBlocksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

