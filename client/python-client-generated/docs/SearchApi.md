# swagger_client.SearchApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**search_transactions**](SearchApi.md#search_transactions) | **POST** /search/transactions | [INDEXER] Search for Transactions

# **search_transactions**
> SearchTransactionsResponse search_transactions(body)

[INDEXER] Search for Transactions

`/search/transactions` allows the caller to search for transactions that meet certain conditions. Some conditions include matching a transaction hash, containing an operation with a certain status, or containing an operation that affects a certain account. `/search/transactions` is considered an \"indexer\" endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \"indexer\" MUST support this endpoint.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SearchApi()
body = swagger_client.SearchTransactionsRequest() # SearchTransactionsRequest | 

try:
    # [INDEXER] Search for Transactions
    api_response = api_instance.search_transactions(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SearchApi->search_transactions: %s\n" % e)
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

