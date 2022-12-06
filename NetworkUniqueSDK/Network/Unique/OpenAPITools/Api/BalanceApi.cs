/*
 * Unique SDK
 *
 * Unique SDK HTTP API  <b>Main connection to wss://ws-opal.unique.network (<a target=\"_blank\" href=\"https://polkadot.js.org/apps/?rpc=wss://ws-opal.unique.network\">apps ↗</a>)</b>  Secondary substrate connection to wss://ws-relay-bench.unique.network  (<a target=\"_blank\" href=\"https://polkadot.js.org/apps/?rpc=wss://ws-relay-bench.unique.network\">apps ↗</a>). Go to <a href=\"/relay/swagger\">/relay/swagger</a>  Consumable OpenAPI specification - (<a target=\"_blank\" href=\"/swagger-json\">JSON ↗</a>) (<a target=\"_blank\" href=\"/swagger-yaml\">YAML ↗</a>)
 *
 * The version of the OpenAPI document: 0.6.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBalanceApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AllBalancesResponse</returns>
        AllBalancesResponse BalanceControllerGetBalance(string address, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AllBalancesResponse</returns>
        ApiResponse<AllBalancesResponse> BalanceControllerGetBalanceWithHttpInfo(string address, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferMutationRequest"></param>
        /// <param name="use"> (optional)</param>
        /// <param name="withFee"> (optional, default to false) (deprecated)</param>
        /// <param name="verify"> (optional, default to false)</param>
        /// <param name="callbackUrl"> (optional)</param>
        /// <param name="nonce"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TransferMutationDefaultResponse</returns>
        TransferMutationDefaultResponse TransferMutation(TransferMutationRequest transferMutationRequest, string use = default(string), bool? withFee = default(bool?), bool? verify = default(bool?), string callbackUrl = default(string), decimal? nonce = default(decimal?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferMutationRequest"></param>
        /// <param name="use"> (optional)</param>
        /// <param name="withFee"> (optional, default to false) (deprecated)</param>
        /// <param name="verify"> (optional, default to false)</param>
        /// <param name="callbackUrl"> (optional)</param>
        /// <param name="nonce"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TransferMutationDefaultResponse</returns>
        ApiResponse<TransferMutationDefaultResponse> TransferMutationWithHttpInfo(TransferMutationRequest transferMutationRequest, string use = default(string), bool? withFee = default(bool?), bool? verify = default(bool?), string callbackUrl = default(string), decimal? nonce = default(decimal?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBalanceApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AllBalancesResponse</returns>
        System.Threading.Tasks.Task<AllBalancesResponse> BalanceControllerGetBalanceAsync(string address, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AllBalancesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AllBalancesResponse>> BalanceControllerGetBalanceWithHttpInfoAsync(string address, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferMutationRequest"></param>
        /// <param name="use"> (optional)</param>
        /// <param name="withFee"> (optional, default to false) (deprecated)</param>
        /// <param name="verify"> (optional, default to false)</param>
        /// <param name="callbackUrl"> (optional)</param>
        /// <param name="nonce"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TransferMutationDefaultResponse</returns>
        System.Threading.Tasks.Task<TransferMutationDefaultResponse> TransferMutationAsync(TransferMutationRequest transferMutationRequest, string use = default(string), bool? withFee = default(bool?), bool? verify = default(bool?), string callbackUrl = default(string), decimal? nonce = default(decimal?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferMutationRequest"></param>
        /// <param name="use"> (optional)</param>
        /// <param name="withFee"> (optional, default to false) (deprecated)</param>
        /// <param name="verify"> (optional, default to false)</param>
        /// <param name="callbackUrl"> (optional)</param>
        /// <param name="nonce"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TransferMutationDefaultResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransferMutationDefaultResponse>> TransferMutationWithHttpInfoAsync(TransferMutationRequest transferMutationRequest, string use = default(string), bool? withFee = default(bool?), bool? verify = default(bool?), string callbackUrl = default(string), decimal? nonce = default(decimal?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBalanceApi : IBalanceApiSync, IBalanceApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BalanceApi : IBalanceApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BalanceApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BalanceApi(string basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BalanceApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public BalanceApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
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
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AllBalancesResponse</returns>
        public AllBalancesResponse BalanceControllerGetBalance(string address, int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<AllBalancesResponse> localVarResponse = BalanceControllerGetBalanceWithHttpInfo(address);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AllBalancesResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<AllBalancesResponse> BalanceControllerGetBalanceWithHttpInfo(string address, int operationIndex = 0)
        {
            // verify the required parameter 'address' is set
            if (address == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'address' when calling BalanceApi->BalanceControllerGetBalance");
            }

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "address", address));

            localVarRequestOptions.Operation = "BalanceApi.BalanceControllerGetBalance";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<AllBalancesResponse>("/v1/balance", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BalanceControllerGetBalance", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AllBalancesResponse</returns>
        public async System.Threading.Tasks.Task<AllBalancesResponse> BalanceControllerGetBalanceAsync(string address, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<AllBalancesResponse> localVarResponse = await BalanceControllerGetBalanceWithHttpInfoAsync(address, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AllBalancesResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<AllBalancesResponse>> BalanceControllerGetBalanceWithHttpInfoAsync(string address, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'address' is set
            if (address == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'address' when calling BalanceApi->BalanceControllerGetBalance");
            }


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "address", address));

            localVarRequestOptions.Operation = "BalanceApi.BalanceControllerGetBalance";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AllBalancesResponse>("/v1/balance", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BalanceControllerGetBalance", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferMutationRequest"></param>
        /// <param name="use"> (optional)</param>
        /// <param name="withFee"> (optional, default to false) (deprecated)</param>
        /// <param name="verify"> (optional, default to false)</param>
        /// <param name="callbackUrl"> (optional)</param>
        /// <param name="nonce"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TransferMutationDefaultResponse</returns>
        public TransferMutationDefaultResponse TransferMutation(TransferMutationRequest transferMutationRequest, string use = default(string), bool? withFee = default(bool?), bool? verify = default(bool?), string callbackUrl = default(string), decimal? nonce = default(decimal?), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<TransferMutationDefaultResponse> localVarResponse = TransferMutationWithHttpInfo(transferMutationRequest, use, withFee, verify, callbackUrl, nonce);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferMutationRequest"></param>
        /// <param name="use"> (optional)</param>
        /// <param name="withFee"> (optional, default to false) (deprecated)</param>
        /// <param name="verify"> (optional, default to false)</param>
        /// <param name="callbackUrl"> (optional)</param>
        /// <param name="nonce"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TransferMutationDefaultResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<TransferMutationDefaultResponse> TransferMutationWithHttpInfo(TransferMutationRequest transferMutationRequest, string use = default(string), bool? withFee = default(bool?), bool? verify = default(bool?), string callbackUrl = default(string), decimal? nonce = default(decimal?), int operationIndex = 0)
        {
            // verify the required parameter 'transferMutationRequest' is set
            if (transferMutationRequest == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'transferMutationRequest' when calling BalanceApi->TransferMutation");
            }

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (use != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "use", use));
            }
            if (withFee != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "withFee", withFee));
            }
            if (verify != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "verify", verify));
            }
            if (callbackUrl != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "callbackUrl", callbackUrl));
            }
            if (nonce != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "nonce", nonce));
            }
            localVarRequestOptions.Data = transferMutationRequest;

            localVarRequestOptions.Operation = "BalanceApi.TransferMutation";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (SeedAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<TransferMutationDefaultResponse>("/v1/balance/transfer", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TransferMutation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferMutationRequest"></param>
        /// <param name="use"> (optional)</param>
        /// <param name="withFee"> (optional, default to false) (deprecated)</param>
        /// <param name="verify"> (optional, default to false)</param>
        /// <param name="callbackUrl"> (optional)</param>
        /// <param name="nonce"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TransferMutationDefaultResponse</returns>
        public async System.Threading.Tasks.Task<TransferMutationDefaultResponse> TransferMutationAsync(TransferMutationRequest transferMutationRequest, string use = default(string), bool? withFee = default(bool?), bool? verify = default(bool?), string callbackUrl = default(string), decimal? nonce = default(decimal?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<TransferMutationDefaultResponse> localVarResponse = await TransferMutationWithHttpInfoAsync(transferMutationRequest, use, withFee, verify, callbackUrl, nonce, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transferMutationRequest"></param>
        /// <param name="use"> (optional)</param>
        /// <param name="withFee"> (optional, default to false) (deprecated)</param>
        /// <param name="verify"> (optional, default to false)</param>
        /// <param name="callbackUrl"> (optional)</param>
        /// <param name="nonce"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TransferMutationDefaultResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<TransferMutationDefaultResponse>> TransferMutationWithHttpInfoAsync(TransferMutationRequest transferMutationRequest, string use = default(string), bool? withFee = default(bool?), bool? verify = default(bool?), string callbackUrl = default(string), decimal? nonce = default(decimal?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'transferMutationRequest' is set
            if (transferMutationRequest == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'transferMutationRequest' when calling BalanceApi->TransferMutation");
            }


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (use != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "use", use));
            }
            if (withFee != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "withFee", withFee));
            }
            if (verify != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "verify", verify));
            }
            if (callbackUrl != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "callbackUrl", callbackUrl));
            }
            if (nonce != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "nonce", nonce));
            }
            localVarRequestOptions.Data = transferMutationRequest;

            localVarRequestOptions.Operation = "BalanceApi.TransferMutation";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (SeedAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<TransferMutationDefaultResponse>("/v1/balance/transfer", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TransferMutation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}