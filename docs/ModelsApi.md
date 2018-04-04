# IO.Swagger.Api.ModelsApi

All URIs are relative to *http://localhost:8080/activiti-rest/service*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateModel**](ModelsApi.md#createmodel) | **POST** /repository/models | Create a model
[**DeleteModel**](ModelsApi.md#deletemodel) | **DELETE** /repository/models/{modelId} | Delete a model
[**GetModel**](ModelsApi.md#getmodel) | **GET** /repository/models/{modelId} | Get a model
[**GetModels**](ModelsApi.md#getmodels) | **GET** /repository/models | Get a list of models
[**UpdateModel**](ModelsApi.md#updatemodel) | **PUT** /repository/models/{modelId} | Update a model


<a name="createmodel"></a>
# **CreateModel**
> ModelResponse CreateModel (ModelRequest body = null)

Create a model

All request values are optional. For example, you can only include the name attribute in the request body JSON-object, only setting the name of the model, leaving all other fields null.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateModelExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ModelsApi();
            var body = new ModelRequest(); // ModelRequest |  (optional) 

            try
            {
                // Create a model
                ModelResponse result = apiInstance.CreateModel(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.CreateModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ModelRequest**](ModelRequest.md)|  | [optional] 

### Return type

[**ModelResponse**](ModelResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemodel"></a>
# **DeleteModel**
> void DeleteModel (string modelId)

Delete a model

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteModelExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ModelsApi();
            var modelId = modelId_example;  // string | The id of the model to delete.

            try
            {
                // Delete a model
                apiInstance.DeleteModel(modelId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.DeleteModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **modelId** | **string**| The id of the model to delete. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmodel"></a>
# **GetModel**
> ModelResponse GetModel (string modelId)

Get a model

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetModelExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ModelsApi();
            var modelId = modelId_example;  // string | The id of the model to get.

            try
            {
                // Get a model
                ModelResponse result = apiInstance.GetModel(modelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.GetModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **modelId** | **string**| The id of the model to get. | 

### Return type

[**ModelResponse**](ModelResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmodels"></a>
# **GetModels**
> DataResponse GetModels (string id = null, string category = null, string categoryLike = null, string categoryNotEquals = null, string name = null, string nameLike = null, string key = null, string deploymentId = null, int? version = null, bool? latestVersion = null, bool? deployed = null, string tenantId = null, string tenantIdLike = null, bool? withoutTenantId = null, string sort = null)

Get a list of models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetModelsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ModelsApi();
            var id = id_example;  // string | Only return models with the given version. (optional) 
            var category = category_example;  // string | Only return models with the given category. (optional) 
            var categoryLike = categoryLike_example;  // string | Only return models with a category like the given name. (optional) 
            var categoryNotEquals = categoryNotEquals_example;  // string | Only return models which don�t have the given category. (optional) 
            var name = name_example;  // string | Only return models with the given name. (optional) 
            var nameLike = nameLike_example;  // string | Only return models with a name like the given name. (optional) 
            var key = key_example;  // string | Only return models with the given key. (optional) 
            var deploymentId = deploymentId_example;  // string | Only return models with the given category. (optional) 
            var version = 56;  // int? | Only return models with the given version. (optional) 
            var latestVersion = true;  // bool? | If true, only return models which are the latest version. Best used in combination with key. If false is passed in as value, this is ignored and all versions are returned. (optional) 
            var deployed = true;  // bool? | If true, only deployed models are returned. If false, only undeployed models are returned (deploymentId is null). (optional) 
            var tenantId = tenantId_example;  // string | Only return models with the given tenantId. (optional) 
            var tenantIdLike = tenantIdLike_example;  // string | Only return models with a tenantId like the given value. (optional) 
            var withoutTenantId = true;  // bool? | If true, only returns models without a tenantId set. If false, the withoutTenantId parameter is ignored. (optional) 
            var sort = sort_example;  // string | Property to sort on, to be used together with the order. (optional) 

            try
            {
                // Get a list of models
                DataResponse result = apiInstance.GetModels(id, category, categoryLike, categoryNotEquals, name, nameLike, key, deploymentId, version, latestVersion, deployed, tenantId, tenantIdLike, withoutTenantId, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.GetModels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Only return models with the given version. | [optional] 
 **category** | **string**| Only return models with the given category. | [optional] 
 **categoryLike** | **string**| Only return models with a category like the given name. | [optional] 
 **categoryNotEquals** | **string**| Only return models which don�t have the given category. | [optional] 
 **name** | **string**| Only return models with the given name. | [optional] 
 **nameLike** | **string**| Only return models with a name like the given name. | [optional] 
 **key** | **string**| Only return models with the given key. | [optional] 
 **deploymentId** | **string**| Only return models with the given category. | [optional] 
 **version** | **int?**| Only return models with the given version. | [optional] 
 **latestVersion** | **bool?**| If true, only return models which are the latest version. Best used in combination with key. If false is passed in as value, this is ignored and all versions are returned. | [optional] 
 **deployed** | **bool?**| If true, only deployed models are returned. If false, only undeployed models are returned (deploymentId is null). | [optional] 
 **tenantId** | **string**| Only return models with the given tenantId. | [optional] 
 **tenantIdLike** | **string**| Only return models with a tenantId like the given value. | [optional] 
 **withoutTenantId** | **bool?**| If true, only returns models without a tenantId set. If false, the withoutTenantId parameter is ignored. | [optional] 
 **sort** | **string**| Property to sort on, to be used together with the order. | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemodel"></a>
# **UpdateModel**
> ModelResponse UpdateModel (string modelId, ModelRequest body = null)

Update a model

All request values are optional. For example, you can only include the name attribute in the request body JSON-object, only updating the name of the model, leaving all other fields unaffected. When an attribute is explicitly included and is set to null, the model-value will be updated to null. Example: ```JSON  {\"metaInfo\" : null}``` will clear the metaInfo of the model).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateModelExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ModelsApi();
            var modelId = modelId_example;  // string | 
            var body = new ModelRequest(); // ModelRequest |  (optional) 

            try
            {
                // Update a model
                ModelResponse result = apiInstance.UpdateModel(modelId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.UpdateModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **modelId** | **string**|  | 
 **body** | [**ModelRequest**](ModelRequest.md)|  | [optional] 

### Return type

[**ModelResponse**](ModelResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

