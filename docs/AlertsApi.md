# UkraineAlarm.Api.AlertsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV3AlertsGet**](AlertsApi.md#apiv3alertsget) | **GET** /api/v3/alerts | Області, регіони та громади з тривогами
[**ApiV3AlertsRegionHistoryGet**](AlertsApi.md#apiv3alertsregionhistoryget) | **GET** /api/v3/alerts/regionHistory | Отримати останніх 25 тривог регіону
[**ApiV3AlertsRegionIdGet**](AlertsApi.md#apiv3alertsregionidget) | **GET** /api/v3/alerts/{regionId} | Статус області/регіону/громади
[**ApiV3AlertsStatusGet**](AlertsApi.md#apiv3alertsstatusget) | **GET** /api/v3/alerts/status | Перевірка номеру останньої дії. Використовувати для перевірки необхідності оновлювати дані

<a name="apiv3alertsget"></a>
# **ApiV3AlertsGet**
> List<AlertRegionModel> ApiV3AlertsGet ()

Області, регіони та громади з тривогами

### Example
```csharp
using System;
using System.Diagnostics;
using UkraineAlarm.Api;
using UkraineAlarm.Client;
using UkraineAlarm.Model;

namespace Example
{
    public class ApiV3AlertsGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AlertsApi();

            try
            {
                // Області, регіони та громади з тривогами
                List&lt;AlertRegionModel&gt; result = apiInstance.ApiV3AlertsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.ApiV3AlertsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AlertRegionModel>**](AlertRegionModel.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv3alertsregionhistoryget"></a>
# **ApiV3AlertsRegionHistoryGet**
> List<RegionAlarmsHistory> ApiV3AlertsRegionHistoryGet (string regionId = null)

Отримати останніх 25 тривог регіону

### Example
```csharp
using System;
using System.Diagnostics;
using UkraineAlarm.Api;
using UkraineAlarm.Client;
using UkraineAlarm.Model;

namespace Example
{
    public class ApiV3AlertsRegionHistoryGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AlertsApi();
            var regionId = regionId_example;  // string |  (optional) 

            try
            {
                // Отримати останніх 25 тривог регіону
                List&lt;RegionAlarmsHistory&gt; result = apiInstance.ApiV3AlertsRegionHistoryGet(regionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.ApiV3AlertsRegionHistoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **regionId** | **string**|  | [optional] 

### Return type

[**List<RegionAlarmsHistory>**](RegionAlarmsHistory.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv3alertsregionidget"></a>
# **ApiV3AlertsRegionIdGet**
> List<AlertRegionModel> ApiV3AlertsRegionIdGet (string regionId)

Статус області/регіону/громади

### Example
```csharp
using System;
using System.Diagnostics;
using UkraineAlarm.Api;
using UkraineAlarm.Client;
using UkraineAlarm.Model;

namespace Example
{
    public class ApiV3AlertsRegionIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AlertsApi();
            var regionId = regionId_example;  // string | ID області/регіону/громади

            try
            {
                // Статус області/регіону/громади
                List&lt;AlertRegionModel&gt; result = apiInstance.ApiV3AlertsRegionIdGet(regionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.ApiV3AlertsRegionIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **regionId** | **string**| ID області/регіону/громади | 

### Return type

[**List<AlertRegionModel>**](AlertRegionModel.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiv3alertsstatusget"></a>
# **ApiV3AlertsStatusGet**
> AlertModification ApiV3AlertsStatusGet ()

Перевірка номеру останньої дії. Використовувати для перевірки необхідності оновлювати дані

### Example
```csharp
using System;
using System.Diagnostics;
using UkraineAlarm.Api;
using UkraineAlarm.Client;
using UkraineAlarm.Model;

namespace Example
{
    public class ApiV3AlertsStatusGetExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AlertsApi();

            try
            {
                // Перевірка номеру останньої дії. Використовувати для перевірки необхідності оновлювати дані
                AlertModification result = apiInstance.ApiV3AlertsStatusGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.ApiV3AlertsStatusGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AlertModification**](AlertModification.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
