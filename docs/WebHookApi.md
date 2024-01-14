# UkraineAlarm.Api.WebHookApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV3WebhookDelete**](WebHookApi.md#apiv3webhookdelete) | **DELETE** /api/v3/webhook | Відписка на WebHook про нові сирени та їх відбій
[**ApiV3WebhookPatch**](WebHookApi.md#apiv3webhookpatch) | **PATCH** /api/v3/webhook | Оновлення WebHook посилання про нові сирени та їх відбій
[**ApiV3WebhookPost**](WebHookApi.md#apiv3webhookpost) | **POST** /api/v3/webhook | Підписка на WebHook про нові сирени та їх відбій. У вебхукі відпрявляється подія тривоги/відбою (приклад в відповіді \&quot;200\&quot;)

<a name="apiv3webhookdelete"></a>
# **ApiV3WebhookDelete**
> void ApiV3WebhookDelete (WebHookModel body = null)

Відписка на WebHook про нові сирени та їх відбій

### Example
```csharp
using System;
using System.Diagnostics;
using UkraineAlarm.Api;
using UkraineAlarm.Client;
using UkraineAlarm.Model;

namespace Example
{
    public class ApiV3WebhookDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebHookApi();
            var body = new WebHookModel(); // WebHookModel |  (optional) 

            try
            {
                // Відписка на WebHook про нові сирени та їх відбій
                apiInstance.ApiV3WebhookDelete(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHookApi.ApiV3WebhookDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebHookModel**](WebHookModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv3webhookpatch"></a>
# **ApiV3WebhookPatch**
> void ApiV3WebhookPatch (WebHookModel body = null)

Оновлення WebHook посилання про нові сирени та їх відбій

### Example
```csharp
using System;
using System.Diagnostics;
using UkraineAlarm.Api;
using UkraineAlarm.Client;
using UkraineAlarm.Model;

namespace Example
{
    public class ApiV3WebhookPatchExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebHookApi();
            var body = new WebHookModel(); // WebHookModel |  (optional) 

            try
            {
                // Оновлення WebHook посилання про нові сирени та їх відбій
                apiInstance.ApiV3WebhookPatch(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHookApi.ApiV3WebhookPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebHookModel**](WebHookModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv3webhookpost"></a>
# **ApiV3WebhookPost**
> AlertRegionModel ApiV3WebhookPost (WebHookModel body = null)

Підписка на WebHook про нові сирени та їх відбій. У вебхукі відпрявляється подія тривоги/відбою (приклад в відповіді \"200\")

### Example
```csharp
using System;
using System.Diagnostics;
using UkraineAlarm.Api;
using UkraineAlarm.Client;
using UkraineAlarm.Model;

namespace Example
{
    public class ApiV3WebhookPostExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebHookApi();
            var body = new WebHookModel(); // WebHookModel |  (optional) 

            try
            {
                // Підписка на WebHook про нові сирени та їх відбій. У вебхукі відпрявляється подія тривоги/відбою (приклад в відповіді \"200\")
                AlertRegionModel result = apiInstance.ApiV3WebhookPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHookApi.ApiV3WebhookPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebHookModel**](WebHookModel.md)|  | [optional] 

### Return type

[**AlertRegionModel**](AlertRegionModel.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
