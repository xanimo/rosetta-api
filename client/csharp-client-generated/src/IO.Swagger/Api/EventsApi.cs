/* 
 * Rosetta
 *
 * Build Once. Integrate Your Blockchain Everywhere.
 *
 * OpenAPI spec version: 1.4.10
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IEventsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [INDEXER] Get a range of BlockEvents
        /// </summary>
        /// <remarks>
        /// &#x60;/events/blocks&#x60; allows the caller to query a sequence of BlockEvents indicating which blocks were added and removed from storage to reach the current state. Following BlockEvents allows lightweight clients to update their state without needing to implement their own syncing logic (like finding the common parent in a reorg). &#x60;/events/blocks&#x60; is considered an \&quot;indexer\&quot; endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \&quot;indexer\&quot; MUST support this endpoint.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>EventsBlocksResponse</returns>
        EventsBlocksResponse EventsBlocks (EventsBlocksRequest body);

        /// <summary>
        /// [INDEXER] Get a range of BlockEvents
        /// </summary>
        /// <remarks>
        /// &#x60;/events/blocks&#x60; allows the caller to query a sequence of BlockEvents indicating which blocks were added and removed from storage to reach the current state. Following BlockEvents allows lightweight clients to update their state without needing to implement their own syncing logic (like finding the common parent in a reorg). &#x60;/events/blocks&#x60; is considered an \&quot;indexer\&quot; endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \&quot;indexer\&quot; MUST support this endpoint.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EventsBlocksResponse</returns>
        ApiResponse<EventsBlocksResponse> EventsBlocksWithHttpInfo (EventsBlocksRequest body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// [INDEXER] Get a range of BlockEvents
        /// </summary>
        /// <remarks>
        /// &#x60;/events/blocks&#x60; allows the caller to query a sequence of BlockEvents indicating which blocks were added and removed from storage to reach the current state. Following BlockEvents allows lightweight clients to update their state without needing to implement their own syncing logic (like finding the common parent in a reorg). &#x60;/events/blocks&#x60; is considered an \&quot;indexer\&quot; endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \&quot;indexer\&quot; MUST support this endpoint.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of EventsBlocksResponse</returns>
        System.Threading.Tasks.Task<EventsBlocksResponse> EventsBlocksAsync (EventsBlocksRequest body);

        /// <summary>
        /// [INDEXER] Get a range of BlockEvents
        /// </summary>
        /// <remarks>
        /// &#x60;/events/blocks&#x60; allows the caller to query a sequence of BlockEvents indicating which blocks were added and removed from storage to reach the current state. Following BlockEvents allows lightweight clients to update their state without needing to implement their own syncing logic (like finding the common parent in a reorg). &#x60;/events/blocks&#x60; is considered an \&quot;indexer\&quot; endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \&quot;indexer\&quot; MUST support this endpoint.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EventsBlocksResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EventsBlocksResponse>> EventsBlocksAsyncWithHttpInfo (EventsBlocksRequest body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class EventsApi : IEventsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventsApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class
        /// </summary>
        /// <returns></returns>
        public EventsApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EventsApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// [INDEXER] Get a range of BlockEvents &#x60;/events/blocks&#x60; allows the caller to query a sequence of BlockEvents indicating which blocks were added and removed from storage to reach the current state. Following BlockEvents allows lightweight clients to update their state without needing to implement their own syncing logic (like finding the common parent in a reorg). &#x60;/events/blocks&#x60; is considered an \&quot;indexer\&quot; endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \&quot;indexer\&quot; MUST support this endpoint.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>EventsBlocksResponse</returns>
        public EventsBlocksResponse EventsBlocks (EventsBlocksRequest body)
        {
             ApiResponse<EventsBlocksResponse> localVarResponse = EventsBlocksWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [INDEXER] Get a range of BlockEvents &#x60;/events/blocks&#x60; allows the caller to query a sequence of BlockEvents indicating which blocks were added and removed from storage to reach the current state. Following BlockEvents allows lightweight clients to update their state without needing to implement their own syncing logic (like finding the common parent in a reorg). &#x60;/events/blocks&#x60; is considered an \&quot;indexer\&quot; endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \&quot;indexer\&quot; MUST support this endpoint.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EventsBlocksResponse</returns>
        public ApiResponse< EventsBlocksResponse > EventsBlocksWithHttpInfo (EventsBlocksRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling EventsApi->EventsBlocks");

            var localVarPath = "/events/blocks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EventsBlocks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EventsBlocksResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EventsBlocksResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventsBlocksResponse)));
        }

        /// <summary>
        /// [INDEXER] Get a range of BlockEvents &#x60;/events/blocks&#x60; allows the caller to query a sequence of BlockEvents indicating which blocks were added and removed from storage to reach the current state. Following BlockEvents allows lightweight clients to update their state without needing to implement their own syncing logic (like finding the common parent in a reorg). &#x60;/events/blocks&#x60; is considered an \&quot;indexer\&quot; endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \&quot;indexer\&quot; MUST support this endpoint.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of EventsBlocksResponse</returns>
        public async System.Threading.Tasks.Task<EventsBlocksResponse> EventsBlocksAsync (EventsBlocksRequest body)
        {
             ApiResponse<EventsBlocksResponse> localVarResponse = await EventsBlocksAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [INDEXER] Get a range of BlockEvents &#x60;/events/blocks&#x60; allows the caller to query a sequence of BlockEvents indicating which blocks were added and removed from storage to reach the current state. Following BlockEvents allows lightweight clients to update their state without needing to implement their own syncing logic (like finding the common parent in a reorg). &#x60;/events/blocks&#x60; is considered an \&quot;indexer\&quot; endpoint and Rosetta implementations are not required to complete it to adhere to the Rosetta spec. However, any Rosetta \&quot;indexer\&quot; MUST support this endpoint.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EventsBlocksResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EventsBlocksResponse>> EventsBlocksAsyncWithHttpInfo (EventsBlocksRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling EventsApi->EventsBlocks");

            var localVarPath = "/events/blocks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EventsBlocks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EventsBlocksResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EventsBlocksResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventsBlocksResponse)));
        }

    }
}
