# Org.OpenAPITools.Api.MessStationApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiMesstationenGet**](MessStationApi.md#apimesstationenget) | **GET** /api/messtationen |  |
| [**ApiMesstationenIdDelete**](MessStationApi.md#apimesstationeniddelete) | **DELETE** /api/messtationen/{id} |  |
| [**ApiMesstationenIdGet**](MessStationApi.md#apimesstationenidget) | **GET** /api/messtationen/{id} |  |
| [**ApiMesstationenIdPut**](MessStationApi.md#apimesstationenidput) | **PUT** /api/messtationen/{id} |  |
| [**ApiMesstationenPost**](MessStationApi.md#apimesstationenpost) | **POST** /api/messtationen |  |
| [**ApiMesstationenStationIdMesswerteGet**](MessStationApi.md#apimesstationenstationidmesswerteget) | **GET** /api/messtationen/{stationId}/messwerte |  |
| [**ApiMesstationenStationIdMesswerteMessWertIdDelete**](MessStationApi.md#apimesstationenstationidmesswertemesswertiddelete) | **DELETE** /api/messtationen/{stationId}/messwerte/{messWertId} |  |
| [**ApiMesstationenStationIdMesswerteMessWertIdGet**](MessStationApi.md#apimesstationenstationidmesswertemesswertidget) | **GET** /api/messtationen/{stationId}/messwerte/{messWertId} |  |
| [**ApiMesstationenStationIdMesswertePost**](MessStationApi.md#apimesstationenstationidmesswertepost) | **POST** /api/messtationen/{stationId}/messwerte |  |

<a id="apimesstationenget"></a>
# **ApiMesstationenGet**
> List&lt;GetMessStationDto&gt; ApiMesstationenGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessStationApi(config);

            try
            {
                List<GetMessStationDto> result = apiInstance.ApiMesstationenGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessStationApi.ApiMesstationenGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationenGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<GetMessStationDto>> response = apiInstance.ApiMesstationenGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessStationApi.ApiMesstationenGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;GetMessStationDto&gt;**](GetMessStationDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apimesstationeniddelete"></a>
# **ApiMesstationenIdDelete**
> void ApiMesstationenIdDelete (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationenIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessStationApi(config);
            var id = 56;  // int | 

            try
            {
                apiInstance.ApiMesstationenIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessStationApi.ApiMesstationenIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationenIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiMesstationenIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessStationApi.ApiMesstationenIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apimesstationenidget"></a>
# **ApiMesstationenIdGet**
> GetMessStationDto ApiMesstationenIdGet (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationenIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessStationApi(config);
            var id = 56;  // int | 

            try
            {
                GetMessStationDto result = apiInstance.ApiMesstationenIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessStationApi.ApiMesstationenIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationenIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetMessStationDto> response = apiInstance.ApiMesstationenIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessStationApi.ApiMesstationenIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**GetMessStationDto**](GetMessStationDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apimesstationenidput"></a>
# **ApiMesstationenIdPut**
> void ApiMesstationenIdPut (int id, PostMessStationDto? postMessStationDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationenIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessStationApi(config);
            var id = 56;  // int | 
            var postMessStationDto = new PostMessStationDto?(); // PostMessStationDto? |  (optional) 

            try
            {
                apiInstance.ApiMesstationenIdPut(id, postMessStationDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessStationApi.ApiMesstationenIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationenIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiMesstationenIdPutWithHttpInfo(id, postMessStationDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessStationApi.ApiMesstationenIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **postMessStationDto** | [**PostMessStationDto?**](PostMessStationDto?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apimesstationenpost"></a>
# **ApiMesstationenPost**
> GetMessStationDto ApiMesstationenPost (PostMessStationDto? postMessStationDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessStationApi(config);
            var postMessStationDto = new PostMessStationDto?(); // PostMessStationDto? |  (optional) 

            try
            {
                GetMessStationDto result = apiInstance.ApiMesstationenPost(postMessStationDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessStationApi.ApiMesstationenPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationenPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetMessStationDto> response = apiInstance.ApiMesstationenPostWithHttpInfo(postMessStationDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessStationApi.ApiMesstationenPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postMessStationDto** | [**PostMessStationDto?**](PostMessStationDto?.md) |  | [optional]  |

### Return type

[**GetMessStationDto**](GetMessStationDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apimesstationenstationidmesswerteget"></a>
# **ApiMesstationenStationIdMesswerteGet**
> GetMessStationDto ApiMesstationenStationIdMesswerteGet (int stationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationenStationIdMesswerteGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessStationApi(config);
            var stationId = 56;  // int | 

            try
            {
                GetMessStationDto result = apiInstance.ApiMesstationenStationIdMesswerteGet(stationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessStationApi.ApiMesstationenStationIdMesswerteGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationenStationIdMesswerteGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetMessStationDto> response = apiInstance.ApiMesstationenStationIdMesswerteGetWithHttpInfo(stationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessStationApi.ApiMesstationenStationIdMesswerteGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationId** | **int** |  |  |

### Return type

[**GetMessStationDto**](GetMessStationDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apimesstationenstationidmesswertemesswertiddelete"></a>
# **ApiMesstationenStationIdMesswerteMessWertIdDelete**
> GetMessStationDto ApiMesstationenStationIdMesswerteMessWertIdDelete (int stationId, int messWertId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationenStationIdMesswerteMessWertIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessStationApi(config);
            var stationId = 56;  // int | 
            var messWertId = 56;  // int | 

            try
            {
                GetMessStationDto result = apiInstance.ApiMesstationenStationIdMesswerteMessWertIdDelete(stationId, messWertId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessStationApi.ApiMesstationenStationIdMesswerteMessWertIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationenStationIdMesswerteMessWertIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetMessStationDto> response = apiInstance.ApiMesstationenStationIdMesswerteMessWertIdDeleteWithHttpInfo(stationId, messWertId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessStationApi.ApiMesstationenStationIdMesswerteMessWertIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationId** | **int** |  |  |
| **messWertId** | **int** |  |  |

### Return type

[**GetMessStationDto**](GetMessStationDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apimesstationenstationidmesswertemesswertidget"></a>
# **ApiMesstationenStationIdMesswerteMessWertIdGet**
> GetMessStationDto ApiMesstationenStationIdMesswerteMessWertIdGet (int stationId, int messWertId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationenStationIdMesswerteMessWertIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessStationApi(config);
            var stationId = 56;  // int | 
            var messWertId = 56;  // int | 

            try
            {
                GetMessStationDto result = apiInstance.ApiMesstationenStationIdMesswerteMessWertIdGet(stationId, messWertId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessStationApi.ApiMesstationenStationIdMesswerteMessWertIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationenStationIdMesswerteMessWertIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetMessStationDto> response = apiInstance.ApiMesstationenStationIdMesswerteMessWertIdGetWithHttpInfo(stationId, messWertId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessStationApi.ApiMesstationenStationIdMesswerteMessWertIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationId** | **int** |  |  |
| **messWertId** | **int** |  |  |

### Return type

[**GetMessStationDto**](GetMessStationDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apimesstationenstationidmesswertepost"></a>
# **ApiMesstationenStationIdMesswertePost**
> GetMessStationDto ApiMesstationenStationIdMesswertePost (int stationId, PostMessWertDto? postMessWertDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiMesstationenStationIdMesswertePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MessStationApi(config);
            var stationId = 56;  // int | 
            var postMessWertDto = new PostMessWertDto?(); // PostMessWertDto? |  (optional) 

            try
            {
                GetMessStationDto result = apiInstance.ApiMesstationenStationIdMesswertePost(stationId, postMessWertDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessStationApi.ApiMesstationenStationIdMesswertePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiMesstationenStationIdMesswertePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetMessStationDto> response = apiInstance.ApiMesstationenStationIdMesswertePostWithHttpInfo(stationId, postMessWertDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessStationApi.ApiMesstationenStationIdMesswertePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stationId** | **int** |  |  |
| **postMessWertDto** | [**PostMessWertDto?**](PostMessWertDto?.md) |  | [optional]  |

### Return type

[**GetMessStationDto**](GetMessStationDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

