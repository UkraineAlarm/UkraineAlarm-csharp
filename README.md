# UkraineAlarm - the C# library for the [Ukraine Alert API](https://api.ukrainealarm.com/)

- API version: 3.0
- SDK version: 1.0.0

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using UkraineAlarm.Api;
using UkraineAlarm.Client;
using UkraineAlarm.Model;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using UkraineAlarm.Api;
using UkraineAlarm.Client;
using UkraineAlarm.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AlertsApi();

            try
            {
                // Області, регіони та громади з тривогами
                List<AlertRegionModel> result = apiInstance.ApiV3AlertsGet();
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to */*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AlertsApi* | [**ApiV3AlertsGet**](docs/AlertsApi.md#apiv3alertsget) | **GET** /api/v3/alerts | Області, регіони та громади з тривогами
*AlertsApi* | [**ApiV3AlertsRegionHistoryGet**](docs/AlertsApi.md#apiv3alertsregionhistoryget) | **GET** /api/v3/alerts/regionHistory | Отримати останніх 25 тривог регіону
*AlertsApi* | [**ApiV3AlertsRegionIdGet**](docs/AlertsApi.md#apiv3alertsregionidget) | **GET** /api/v3/alerts/{regionId} | Статус області/регіону/громади
*AlertsApi* | [**ApiV3AlertsStatusGet**](docs/AlertsApi.md#apiv3alertsstatusget) | **GET** /api/v3/alerts/status | Перевірка номеру останньої дії. Використовувати для перевірки необхідності оновлювати дані
*RegionsApi* | [**ApiV3RegionsGet**](docs/RegionsApi.md#apiv3regionsget) | **GET** /api/v3/regions | Повертає список усіх областей, регіонів та міст
*WebHookApi* | [**ApiV3WebhookDelete**](docs/WebHookApi.md#apiv3webhookdelete) | **DELETE** /api/v3/webhook | Відписка на WebHook про нові сирени та їх відбій
*WebHookApi* | [**ApiV3WebhookPatch**](docs/WebHookApi.md#apiv3webhookpatch) | **PATCH** /api/v3/webhook | Оновлення WebHook посилання про нові сирени та їх відбій
*WebHookApi* | [**ApiV3WebhookPost**](docs/WebHookApi.md#apiv3webhookpost) | **POST** /api/v3/webhook | Підписка на WebHook про нові сирени та їх відбій. У вебхукі відпрявляється подія тривоги/відбою (приклад в відповіді \"200\")

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Alert](docs/Alert.md)
 - [Model.AlertModification](docs/AlertModification.md)
 - [Model.AlertRegionModel](docs/AlertRegionModel.md)
 - [Model.AlertType](docs/AlertType.md)
 - [Model.RegionAlarmModel](docs/RegionAlarmModel.md)
 - [Model.RegionAlarmsHistory](docs/RegionAlarmsHistory.md)
 - [Model.RegionViewModel](docs/RegionViewModel.md)
 - [Model.RegionsViewModel](docs/RegionsViewModel.md)
 - [Model.TimeSpan](docs/TimeSpan.md)
 - [Model.V2RegionType](docs/V2RegionType.md)
 - [Model.WebHookModel](docs/WebHookModel.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Token"></a>
### Token

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

