# IO.Swagger.Api.BlockApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Block**](BlockApi.md#block) | **POST** /block | Get a Block
[**BlockTransaction**](BlockApi.md#blocktransaction) | **POST** /block/transaction | Get a Block Transaction

<a name="block"></a>
# **Block**
> BlockResponse Block (BlockRequest body)

Get a Block

Get a block by its Block Identifier. If transactions are returned in the same call to the node as fetching the block, the response should include these transactions in the Block object. If not, an array of Transaction Identifiers should be returned so /block/transaction fetches can be done to get all transaction information. When requesting a block by the hash component of the BlockIdentifier, this request MUST be idempotent: repeated invocations for the same hash-identified block must return the exact same block contents. No such restriction is imposed when requesting a block by height, given that a chain reorg event might cause the specific block at height `n` to be set to a different one.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BlockExample
    {
        public void main()
        {
            var apiInstance = new BlockApi();
            var body = new BlockRequest(); // BlockRequest | 

            try
            {
                // Get a Block
                BlockResponse result = apiInstance.Block(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.Block: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BlockRequest**](BlockRequest.md)|  | 

### Return type

[**BlockResponse**](BlockResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="blocktransaction"></a>
# **BlockTransaction**
> BlockTransactionResponse BlockTransaction (BlockTransactionRequest body)

Get a Block Transaction

Get a transaction in a block by its Transaction Identifier. This endpoint should only be used when querying a node for a block does not return all transactions contained within it. All transactions returned by this endpoint must be appended to any transactions returned by the /block method by consumers of this data. Fetching a transaction by hash is considered an Explorer Method (which is classified under the Future Work section). This method can be used to let consumers to paginate results when the  block trasactions count is too big to be returned in a single BlockResponse. Calling this endpoint requires reference to a BlockIdentifier because transaction parsing can change depending on which block contains the transaction. For example, in Bitcoin it is necessary to know which block contains a transaction to determine the destination of fee payments. Without specifying a block identifier, the node would have to infer which block to use (which could change during a re-org). Implementations that require fetching previous transactions to populate the response (ex: Previous UTXOs in Bitcoin) may find it useful to run a cache within the Rosetta server in the /data directory (on a path that does not conflict with the node).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BlockTransactionExample
    {
        public void main()
        {
            var apiInstance = new BlockApi();
            var body = new BlockTransactionRequest(); // BlockTransactionRequest | 

            try
            {
                // Get a Block Transaction
                BlockTransactionResponse result = apiInstance.BlockTransaction(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.BlockTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BlockTransactionRequest**](BlockTransactionRequest.md)|  | 

### Return type

[**BlockTransactionResponse**](BlockTransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
