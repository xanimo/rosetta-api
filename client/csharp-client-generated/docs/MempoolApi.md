# IO.Swagger.Api.MempoolApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Mempool**](MempoolApi.md#mempool) | **POST** /mempool | Get All Mempool Transactions
[**MempoolTransaction**](MempoolApi.md#mempooltransaction) | **POST** /mempool/transaction | Get a Mempool Transaction

<a name="mempool"></a>
# **Mempool**
> MempoolResponse Mempool (NetworkRequest body)

Get All Mempool Transactions

Get all Transaction Identifiers in the mempool

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MempoolExample
    {
        public void main()
        {
            var apiInstance = new MempoolApi();
            var body = new NetworkRequest(); // NetworkRequest | 

            try
            {
                // Get All Mempool Transactions
                MempoolResponse result = apiInstance.Mempool(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MempoolApi.Mempool: " + e.Message );
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

[**MempoolResponse**](MempoolResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mempooltransaction"></a>
# **MempoolTransaction**
> MempoolTransactionResponse MempoolTransaction (MempoolTransactionRequest body)

Get a Mempool Transaction

Get a transaction in the mempool by its Transaction Identifier. This is a separate request than fetching a block transaction (/block/transaction) because some blockchain nodes need to know that a transaction query is for something in the mempool instead of a transaction in a block. Transactions may not be fully parsable until they are in a block (ex: may not be possible to determine the fee to pay before a transaction is executed). On this endpoint, it is ok that returned transactions are only estimates of what may actually be included in a block.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MempoolTransactionExample
    {
        public void main()
        {
            var apiInstance = new MempoolApi();
            var body = new MempoolTransactionRequest(); // MempoolTransactionRequest | 

            try
            {
                // Get a Mempool Transaction
                MempoolTransactionResponse result = apiInstance.MempoolTransaction(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MempoolApi.MempoolTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MempoolTransactionRequest**](MempoolTransactionRequest.md)|  | 

### Return type

[**MempoolTransactionResponse**](MempoolTransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
