# IO.Swagger.Api.EventsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EventsBlocks**](EventsApi.md#eventsblocks) | **POST** /events/blocks | [INDEXER] Get a range of BlockEvents

<a name="eventsblocks"></a>
# **EventsBlocks**
> EventsBlocksResponse EventsBlocks (EventsBlocksRequest body)

[INDEXER] Get a range of BlockEvents

`/events/blocks` allows the caller to query a sequence of BlockEvents indicating which blocks were added and removed from storage to reach the current state. Following BlockEvents allows lightweight clients to update their state without needing to implement their own syncing logic (like finding the common parent in a reorg). `/events/blocks` is considered an \"indexer\" endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \"indexer\" MUST support this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EventsBlocksExample
    {
        public void main()
        {
            var apiInstance = new EventsApi();
            var body = new EventsBlocksRequest(); // EventsBlocksRequest | 

            try
            {
                // [INDEXER] Get a range of BlockEvents
                EventsBlocksResponse result = apiInstance.EventsBlocks(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.EventsBlocks: " + e.Message );
            }
        }
    }
}
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
