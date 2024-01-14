# UkraineAlarm.Api.RegionsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV3RegionsGet**](RegionsApi.md#apiv3regionsget) | **GET** /api/v3/regions | Повертає список усіх областей, регіонів та міст

<a name="apiv3regionsget"></a>
# **ApiV3RegionsGet**
> RegionsViewModel ApiV3RegionsGet ()

Повертає список усіх областей, регіонів та міст

### Example
```csharp
using System;
using System.Diagnostics;
using UkraineAlarm.Api;
using UkraineAlarm.Client;
using UkraineAlarm.Model;

namespace Example
{
    public class ApiV3RegionsGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RegionsApi();

            try
            {
                // Повертає список усіх областей, регіонів та міст
                RegionsViewModel result = apiInstance.ApiV3RegionsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegionsApi.ApiV3RegionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RegionsViewModel**](RegionsViewModel.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
