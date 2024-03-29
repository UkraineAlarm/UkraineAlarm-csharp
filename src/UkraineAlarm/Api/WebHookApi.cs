/* 
 * Ukraine Alert API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3.0
 * Contact: support@stfalcon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using UkraineAlarm.Client;
using UkraineAlarm.Model;

namespace UkraineAlarm.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IWebHookApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Відписка на WebHook про нові сирени та їх відбій
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void ApiV3WebhookDelete (WebHookModel body = null);

        /// <summary>
        /// Відписка на WebHook про нові сирени та їх відбій
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ApiV3WebhookDeleteWithHttpInfo (WebHookModel body = null);
        /// <summary>
        /// Оновлення WebHook посилання про нові сирени та їх відбій
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void ApiV3WebhookPatch (WebHookModel body = null);

        /// <summary>
        /// Оновлення WebHook посилання про нові сирени та їх відбій
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ApiV3WebhookPatchWithHttpInfo (WebHookModel body = null);
        /// <summary>
        /// Підписка на WebHook про нові сирени та їх відбій. У вебхукі відпрявляється подія тривоги/відбою (приклад в відповіді \&quot;200\&quot;)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>AlertRegionModel</returns>
        AlertRegionModel ApiV3WebhookPost (WebHookModel body = null);

        /// <summary>
        /// Підписка на WebHook про нові сирени та їх відбій. У вебхукі відпрявляється подія тривоги/відбою (приклад в відповіді \&quot;200\&quot;)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of AlertRegionModel</returns>
        ApiResponse<AlertRegionModel> ApiV3WebhookPostWithHttpInfo (WebHookModel body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Відписка на WebHook про нові сирени та їх відбій
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ApiV3WebhookDeleteAsync (WebHookModel body = null);

        /// <summary>
        /// Відписка на WebHook про нові сирени та їх відбій
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApiV3WebhookDeleteAsyncWithHttpInfo (WebHookModel body = null);
        /// <summary>
        /// Оновлення WebHook посилання про нові сирени та їх відбій
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ApiV3WebhookPatchAsync (WebHookModel body = null);

        /// <summary>
        /// Оновлення WebHook посилання про нові сирени та їх відбій
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApiV3WebhookPatchAsyncWithHttpInfo (WebHookModel body = null);
        /// <summary>
        /// Підписка на WebHook про нові сирени та їх відбій. У вебхукі відпрявляється подія тривоги/відбою (приклад в відповіді \&quot;200\&quot;)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of AlertRegionModel</returns>
        System.Threading.Tasks.Task<AlertRegionModel> ApiV3WebhookPostAsync (WebHookModel body = null);

        /// <summary>
        /// Підписка на WebHook про нові сирени та їх відбій. У вебхукі відпрявляється подія тривоги/відбою (приклад в відповіді \&quot;200\&quot;)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (AlertRegionModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlertRegionModel>> ApiV3WebhookPostAsyncWithHttpInfo (WebHookModel body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class WebHookApi : IWebHookApi
    {
        private UkraineAlarm.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebHookApi(String basePath)
        {
            this.Configuration = new UkraineAlarm.Client.Configuration { BasePath = basePath };

            ExceptionFactory = UkraineAlarm.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookApi"/> class
        /// </summary>
        /// <returns></returns>
        public WebHookApi()
        {
            this.Configuration = UkraineAlarm.Client.Configuration.Default;

            ExceptionFactory = UkraineAlarm.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WebHookApi(UkraineAlarm.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = UkraineAlarm.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = UkraineAlarm.Client.Configuration.DefaultExceptionFactory;
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
        public UkraineAlarm.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public UkraineAlarm.Client.ExceptionFactory ExceptionFactory
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
        /// Відписка на WebHook про нові сирени та їх відбій 
        /// </summary>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void ApiV3WebhookDelete (WebHookModel body = null)
        {
             ApiV3WebhookDeleteWithHttpInfo(body);
        }

        /// <summary>
        /// Відписка на WebHook про нові сирени та їх відбій 
        /// </summary>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ApiV3WebhookDeleteWithHttpInfo (WebHookModel body = null)
        {

            var localVarPath = "/api/v3/webhook";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            // authentication (Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV3WebhookDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Відписка на WebHook про нові сирени та їх відбій 
        /// </summary>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ApiV3WebhookDeleteAsync (WebHookModel body = null)
        {
             await ApiV3WebhookDeleteAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Відписка на WebHook про нові сирени та їх відбій 
        /// </summary>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ApiV3WebhookDeleteAsyncWithHttpInfo (WebHookModel body = null)
        {

            var localVarPath = "/api/v3/webhook";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            // authentication (Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV3WebhookDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Оновлення WebHook посилання про нові сирени та їх відбій 
        /// </summary>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void ApiV3WebhookPatch (WebHookModel body = null)
        {
             ApiV3WebhookPatchWithHttpInfo(body);
        }

        /// <summary>
        /// Оновлення WebHook посилання про нові сирени та їх відбій 
        /// </summary>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ApiV3WebhookPatchWithHttpInfo (WebHookModel body = null)
        {

            var localVarPath = "/api/v3/webhook";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            // authentication (Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV3WebhookPatch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Оновлення WebHook посилання про нові сирени та їх відбій 
        /// </summary>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ApiV3WebhookPatchAsync (WebHookModel body = null)
        {
             await ApiV3WebhookPatchAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Оновлення WebHook посилання про нові сирени та їх відбій 
        /// </summary>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ApiV3WebhookPatchAsyncWithHttpInfo (WebHookModel body = null)
        {

            var localVarPath = "/api/v3/webhook";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
            // authentication (Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV3WebhookPatch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Підписка на WebHook про нові сирени та їх відбій. У вебхукі відпрявляється подія тривоги/відбою (приклад в відповіді \&quot;200\&quot;) 
        /// </summary>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>AlertRegionModel</returns>
        public AlertRegionModel ApiV3WebhookPost (WebHookModel body = null)
        {
             ApiResponse<AlertRegionModel> localVarResponse = ApiV3WebhookPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Підписка на WebHook про нові сирени та їх відбій. У вебхукі відпрявляється подія тривоги/відбою (приклад в відповіді \&quot;200\&quot;) 
        /// </summary>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of AlertRegionModel</returns>
        public ApiResponse< AlertRegionModel > ApiV3WebhookPostWithHttpInfo (WebHookModel body = null)
        {

            var localVarPath = "/api/v3/webhook";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
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
            // authentication (Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV3WebhookPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AlertRegionModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AlertRegionModel) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AlertRegionModel)));
        }

        /// <summary>
        /// Підписка на WebHook про нові сирени та їх відбій. У вебхукі відпрявляється подія тривоги/відбою (приклад в відповіді \&quot;200\&quot;) 
        /// </summary>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of AlertRegionModel</returns>
        public async System.Threading.Tasks.Task<AlertRegionModel> ApiV3WebhookPostAsync (WebHookModel body = null)
        {
             ApiResponse<AlertRegionModel> localVarResponse = await ApiV3WebhookPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Підписка на WebHook про нові сирени та їх відбій. У вебхукі відпрявляється подія тривоги/відбою (приклад в відповіді \&quot;200\&quot;) 
        /// </summary>
        /// <exception cref="UkraineAlarm.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (AlertRegionModel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AlertRegionModel>> ApiV3WebhookPostAsyncWithHttpInfo (WebHookModel body = null)
        {

            var localVarPath = "/api/v3/webhook";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
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
            // authentication (Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV3WebhookPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AlertRegionModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AlertRegionModel) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AlertRegionModel)));
        }

    }
}
