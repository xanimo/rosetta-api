# swagger_client.ConstructionApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**construction_combine**](ConstructionApi.md#construction_combine) | **POST** /construction/combine | Create Network Transaction from Signatures
[**construction_derive**](ConstructionApi.md#construction_derive) | **POST** /construction/derive | Derive an AccountIdentifier from a PublicKey
[**construction_hash**](ConstructionApi.md#construction_hash) | **POST** /construction/hash | Get the Hash of a Signed Transaction
[**construction_metadata**](ConstructionApi.md#construction_metadata) | **POST** /construction/metadata | Get Metadata for Transaction Construction
[**construction_parse**](ConstructionApi.md#construction_parse) | **POST** /construction/parse | Parse a Transaction
[**construction_payloads**](ConstructionApi.md#construction_payloads) | **POST** /construction/payloads | Generate an Unsigned Transaction and Signing Payloads
[**construction_preprocess**](ConstructionApi.md#construction_preprocess) | **POST** /construction/preprocess | Create a Request to Fetch Metadata
[**construction_submit**](ConstructionApi.md#construction_submit) | **POST** /construction/submit | Submit a Signed Transaction

# **construction_combine**
> ConstructionCombineResponse construction_combine(body)

Create Network Transaction from Signatures

Combine creates a network-specific transaction from an unsigned transaction and an array of provided signatures. The signed transaction returned from this method will be sent to the `/construction/submit` endpoint by the caller.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ConstructionApi()
body = swagger_client.ConstructionCombineRequest() # ConstructionCombineRequest | 

try:
    # Create Network Transaction from Signatures
    api_response = api_instance.construction_combine(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ConstructionApi->construction_combine: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConstructionCombineRequest**](ConstructionCombineRequest.md)|  | 

### Return type

[**ConstructionCombineResponse**](ConstructionCombineResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **construction_derive**
> ConstructionDeriveResponse construction_derive(body)

Derive an AccountIdentifier from a PublicKey

Derive returns the AccountIdentifier associated with a public key. Blockchains that require an on-chain action to create an account should not implement this method.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ConstructionApi()
body = swagger_client.ConstructionDeriveRequest() # ConstructionDeriveRequest | 

try:
    # Derive an AccountIdentifier from a PublicKey
    api_response = api_instance.construction_derive(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ConstructionApi->construction_derive: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConstructionDeriveRequest**](ConstructionDeriveRequest.md)|  | 

### Return type

[**ConstructionDeriveResponse**](ConstructionDeriveResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **construction_hash**
> TransactionIdentifierResponse construction_hash(body)

Get the Hash of a Signed Transaction

TransactionHash returns the network-specific transaction hash for a signed transaction.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ConstructionApi()
body = swagger_client.ConstructionHashRequest() # ConstructionHashRequest | 

try:
    # Get the Hash of a Signed Transaction
    api_response = api_instance.construction_hash(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ConstructionApi->construction_hash: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConstructionHashRequest**](ConstructionHashRequest.md)|  | 

### Return type

[**TransactionIdentifierResponse**](TransactionIdentifierResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **construction_metadata**
> ConstructionMetadataResponse construction_metadata(body)

Get Metadata for Transaction Construction

Get any information required to construct a transaction for a specific network. Metadata returned here could be a recent hash to use, an account sequence number, or even arbitrary chain state. The request used when calling this endpoint is created by calling `/construction/preprocess` in an offline environment. You should NEVER assume that the request sent to this endpoint will be created by the caller or populated with any custom parameters. This must occur in `/construction/preprocess`. It is important to clarify that this endpoint should not pre-construct any transactions for the client (this should happen in `/construction/payloads`). This endpoint is left purposely unstructured because of the wide scope of metadata that could be required.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ConstructionApi()
body = swagger_client.ConstructionMetadataRequest() # ConstructionMetadataRequest | 

try:
    # Get Metadata for Transaction Construction
    api_response = api_instance.construction_metadata(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ConstructionApi->construction_metadata: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConstructionMetadataRequest**](ConstructionMetadataRequest.md)|  | 

### Return type

[**ConstructionMetadataResponse**](ConstructionMetadataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **construction_parse**
> ConstructionParseResponse construction_parse(body)

Parse a Transaction

Parse is called on both unsigned and signed transactions to understand the intent of the formulated transaction. This is run as a sanity check before signing (after `/construction/payloads`) and before broadcast (after `/construction/combine`). 

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ConstructionApi()
body = swagger_client.ConstructionParseRequest() # ConstructionParseRequest | 

try:
    # Parse a Transaction
    api_response = api_instance.construction_parse(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ConstructionApi->construction_parse: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConstructionParseRequest**](ConstructionParseRequest.md)|  | 

### Return type

[**ConstructionParseResponse**](ConstructionParseResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **construction_payloads**
> ConstructionPayloadsResponse construction_payloads(body)

Generate an Unsigned Transaction and Signing Payloads

Payloads is called with an array of operations and the response from `/construction/metadata`. It returns an unsigned transaction blob and a collection of payloads that must be signed by particular AccountIdentifiers using a certain SignatureType. The array of operations provided in transaction construction often times can not specify all \"effects\" of a transaction (consider invoked transactions in Ethereum). However, they can deterministically specify the \"intent\" of the transaction, which is sufficient for construction. For this reason, parsing the corresponding transaction in the Data API (when it lands on chain) will contain a superset of whatever operations were provided during construction.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ConstructionApi()
body = swagger_client.ConstructionPayloadsRequest() # ConstructionPayloadsRequest | 

try:
    # Generate an Unsigned Transaction and Signing Payloads
    api_response = api_instance.construction_payloads(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ConstructionApi->construction_payloads: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConstructionPayloadsRequest**](ConstructionPayloadsRequest.md)|  | 

### Return type

[**ConstructionPayloadsResponse**](ConstructionPayloadsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **construction_preprocess**
> ConstructionPreprocessResponse construction_preprocess(body)

Create a Request to Fetch Metadata

Preprocess is called prior to `/construction/payloads` to construct a request for any metadata that is needed for transaction construction given (i.e. account nonce). The `options` object returned from this endpoint will be sent to the `/construction/metadata` endpoint UNMODIFIED by the caller (in an offline execution environment). If your Construction API implementation has configuration options, they MUST be specified in the `/construction/preprocess` request (in the `metadata` field).

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ConstructionApi()
body = swagger_client.ConstructionPreprocessRequest() # ConstructionPreprocessRequest | 

try:
    # Create a Request to Fetch Metadata
    api_response = api_instance.construction_preprocess(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ConstructionApi->construction_preprocess: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConstructionPreprocessRequest**](ConstructionPreprocessRequest.md)|  | 

### Return type

[**ConstructionPreprocessResponse**](ConstructionPreprocessResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **construction_submit**
> TransactionIdentifierResponse construction_submit(body)

Submit a Signed Transaction

Submit a pre-signed transaction to the node. This call should not block on the transaction being included in a block. Rather, it should return immediately with an indication of whether or not the transaction was included in the mempool. The transaction submission response should only return a 200 status if the submitted transaction could be included in the mempool. Otherwise, it should return an error.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ConstructionApi()
body = swagger_client.ConstructionSubmitRequest() # ConstructionSubmitRequest | 

try:
    # Submit a Signed Transaction
    api_response = api_instance.construction_submit(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ConstructionApi->construction_submit: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConstructionSubmitRequest**](ConstructionSubmitRequest.md)|  | 

### Return type

[**TransactionIdentifierResponse**](TransactionIdentifierResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

