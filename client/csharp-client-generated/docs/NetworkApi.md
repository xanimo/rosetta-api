# IO.Swagger.Api.NetworkApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NetworkList**](NetworkApi.md#networklist) | **POST** /network/list | Get List of Available Networks
[**NetworkOptions**](NetworkApi.md#networkoptions) | **POST** /network/options | Get Network Options
[**NetworkStatus**](NetworkApi.md#networkstatus) | **POST** /network/status | Get Network Status

<a name="networklist"></a>
# **NetworkList**
> NetworkListResponse NetworkList (MetadataRequest body)

Get List of Available Networks

This endpoint returns a list of NetworkIdentifiers that the Rosetta server supports.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NetworkListExample
    {
        public void main()
        {
            var apiInstance = new NetworkApi();
            var body = new MetadataRequest(); // MetadataRequest | 

            try
            {
                // Get List of Available Networks
                NetworkListResponse result = apiInstance.NetworkList(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkApi.NetworkList: " + e.Message );
            }
        }
    }
}
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
<a name="networkoptions"></a>
# **NetworkOptions**
> NetworkOptionsResponse NetworkOptions (NetworkRequest body)

Get Network Options

This endpoint returns the version information and allowed network-specific types for a NetworkIdentifier. Any NetworkIdentifier returned by /network/list should be accessible here. Because options are retrievable in the context of a NetworkIdentifier, it is possible to define unique options for each network.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NetworkOptionsExample
    {
        public void main()
        {
            var apiInstance = new NetworkApi();
            var body = new NetworkRequest(); // NetworkRequest | 

            try
            {
                // Get Network Options
                NetworkOptionsResponse result = apiInstance.NetworkOptions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkApi.NetworkOptions: " + e.Message );
            }
        }
    }
}
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
<a name="networkstatus"></a>
# **NetworkStatus**
> NetworkStatusResponse NetworkStatus (NetworkRequest body)

Get Network Status

This endpoint returns the current status of the network requested. Any NetworkIdentifier returned by /network/list should be accessible here.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NetworkStatusExample
    {
        public void main()
        {
            var apiInstance = new NetworkApi();
            var body = new NetworkRequest(); // NetworkRequest | 

            try
            {
                // Get Network Status
                NetworkStatusResponse result = apiInstance.NetworkStatus(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NetworkApi.NetworkStatus: " + e.Message );
            }
        }
    }
}
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
