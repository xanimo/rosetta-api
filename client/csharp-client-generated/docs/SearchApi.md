# IO.Swagger.Api.SearchApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchTransactions**](SearchApi.md#searchtransactions) | **POST** /search/transactions | [INDEXER] Search for Transactions

<a name="searchtransactions"></a>
# **SearchTransactions**
> SearchTransactionsResponse SearchTransactions (SearchTransactionsRequest body)

[INDEXER] Search for Transactions

`/search/transactions` allows the caller to search for transactions that meet certain conditions. Some conditions include matching a transaction hash, containing an operation with a certain status, or containing an operation that affects a certain account. `/search/transactions` is considered an \"indexer\" endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \"indexer\" MUST support this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchTransactionsExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var body = new SearchTransactionsRequest(); // SearchTransactionsRequest | 

            try
            {
                // [INDEXER] Search for Transactions
                SearchTransactionsResponse result = apiInstance.SearchTransactions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SearchTransactionsRequest**](SearchTransactionsRequest.md)|  | 

### Return type

[**SearchTransactionsResponse**](SearchTransactionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
