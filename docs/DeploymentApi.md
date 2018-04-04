# IO.Swagger.Api.DeploymentApi

All URIs are relative to *http://localhost:8080/activiti-rest/service*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteDeployment**](DeploymentApi.md#deletedeployment) | **DELETE** /repository/deployments/{deploymentId} | Delete a deployment
[**GetDeployment**](DeploymentApi.md#getdeployment) | **GET** /repository/deployments/{deploymentId} | Get a deployment
[**GetDeploymentResource**](DeploymentApi.md#getdeploymentresource) | **GET** /repository/deployments/{deploymentId}/resources/** | Get a deployment resource
[**GetDeploymentResourceData**](DeploymentApi.md#getdeploymentresourcedata) | **GET** /repository/deployments/{deploymentId}/resourcedata/{resourceId} | Get a deployment resource content
[**GetDeploymentResources**](DeploymentApi.md#getdeploymentresources) | **GET** /repository/deployments/{deploymentId}/resources | List resources in a deployment
[**GetDeployments**](DeploymentApi.md#getdeployments) | **GET** /repository/deployments | List of Deployments
[**UploadDeployment**](DeploymentApi.md#uploaddeployment) | **POST** /repository/deployments | Create a new deployment


<a name="deletedeployment"></a>
# **DeleteDeployment**
> void DeleteDeployment (string deploymentId, bool? cascade = null)

Delete a deployment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDeploymentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DeploymentApi();
            var deploymentId = deploymentId_example;  // string | The id of the deployment to delete.
            var cascade = true;  // bool? |  (optional) 

            try
            {
                // Delete a deployment
                apiInstance.DeleteDeployment(deploymentId, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeploymentApi.DeleteDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentId** | **string**| The id of the deployment to delete. | 
 **cascade** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeployment"></a>
# **GetDeployment**
> DeploymentResponse GetDeployment (string deploymentId)

Get a deployment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDeploymentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DeploymentApi();
            var deploymentId = deploymentId_example;  // string | The id of the deployment to get.

            try
            {
                // Get a deployment
                DeploymentResponse result = apiInstance.GetDeployment(deploymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeploymentApi.GetDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentId** | **string**| The id of the deployment to get. | 

### Return type

[**DeploymentResponse**](DeploymentResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeploymentresource"></a>
# **GetDeploymentResource**
> DeploymentResourceResponse GetDeploymentResource (string deploymentId)

Get a deployment resource

Replace ** by ResourceId

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDeploymentResourceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DeploymentApi();
            var deploymentId = deploymentId_example;  // string | The id of the deployment the requested resource is part of.

            try
            {
                // Get a deployment resource
                DeploymentResourceResponse result = apiInstance.GetDeploymentResource(deploymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeploymentApi.GetDeploymentResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentId** | **string**| The id of the deployment the requested resource is part of. | 

### Return type

[**DeploymentResourceResponse**](DeploymentResourceResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeploymentresourcedata"></a>
# **GetDeploymentResourceData**
> List<byte[]> GetDeploymentResourceData (string deploymentId, string resourceId)

Get a deployment resource content

The response body will contain the binary resource-content for the requested resource. The response content-type will be the same as the type returned in the resources mimeType property. Also, a content-disposition header is set, allowing browsers to download the file instead of displaying it.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDeploymentResourceDataExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DeploymentApi();
            var deploymentId = deploymentId_example;  // string | The id of the deployment the requested resource is part of.
            var resourceId = resourceId_example;  // string | The id of the resource to get the data for. Make sure you URL-encode the resourceId in case it contains forward slashes. Eg: use diagrams%2Fmy-process.bpmn20.xml instead of diagrams/Fmy-process.bpmn20.xml.

            try
            {
                // Get a deployment resource content
                List&lt;byte[]&gt; result = apiInstance.GetDeploymentResourceData(deploymentId, resourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeploymentApi.GetDeploymentResourceData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentId** | **string**| The id of the deployment the requested resource is part of. | 
 **resourceId** | **string**| The id of the resource to get the data for. Make sure you URL-encode the resourceId in case it contains forward slashes. Eg: use diagrams%2Fmy-process.bpmn20.xml instead of diagrams/Fmy-process.bpmn20.xml. | 

### Return type

**List<byte[]>**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeploymentresources"></a>
# **GetDeploymentResources**
> List<DeploymentResourceResponse> GetDeploymentResources (string deploymentId)

List resources in a deployment

The dataUrl property in the resulting JSON for a single resource contains the actual URL to use for retrieving the binary resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDeploymentResourcesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DeploymentApi();
            var deploymentId = deploymentId_example;  // string | The id of the deployment to get the resources for.

            try
            {
                // List resources in a deployment
                List&lt;DeploymentResourceResponse&gt; result = apiInstance.GetDeploymentResources(deploymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeploymentApi.GetDeploymentResources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deploymentId** | **string**| The id of the deployment to get the resources for. | 

### Return type

[**List<DeploymentResourceResponse>**](DeploymentResourceResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeployments"></a>
# **GetDeployments**
> DataResponse GetDeployments (string name = null, string nameLike = null, string category = null, string categoryNotEquals = null, string tenantId = null, string tenantIdLike = null, string withoutTenantId = null, string sort = null)

List of Deployments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDeploymentsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DeploymentApi();
            var name = name_example;  // string | Only return deployments with the given name. (optional) 
            var nameLike = nameLike_example;  // string | Only return deployments with a name like the given name. (optional) 
            var category = category_example;  // string | Only return deployments with the given category. (optional) 
            var categoryNotEquals = categoryNotEquals_example;  // string | Only return deployments which don�t have the given category. (optional) 
            var tenantId = tenantId_example;  // string | Only return deployments with the given tenantId. (optional) 
            var tenantIdLike = tenantIdLike_example;  // string | Only return deployments with a tenantId like the given value. (optional) 
            var withoutTenantId = withoutTenantId_example;  // string | If true, only returns deployments without a tenantId set. If false, the withoutTenantId parameter is ignored. (optional) 
            var sort = sort_example;  // string | Property to sort on, to be used together with the order. (optional) 

            try
            {
                // List of Deployments
                DataResponse result = apiInstance.GetDeployments(name, nameLike, category, categoryNotEquals, tenantId, tenantIdLike, withoutTenantId, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeploymentApi.GetDeployments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Only return deployments with the given name. | [optional] 
 **nameLike** | **string**| Only return deployments with a name like the given name. | [optional] 
 **category** | **string**| Only return deployments with the given category. | [optional] 
 **categoryNotEquals** | **string**| Only return deployments which don�t have the given category. | [optional] 
 **tenantId** | **string**| Only return deployments with the given tenantId. | [optional] 
 **tenantIdLike** | **string**| Only return deployments with a tenantId like the given value. | [optional] 
 **withoutTenantId** | **string**| If true, only returns deployments without a tenantId set. If false, the withoutTenantId parameter is ignored. | [optional] 
 **sort** | **string**| Property to sort on, to be used together with the order. | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploaddeployment"></a>
# **UploadDeployment**
> DeploymentResponse UploadDeployment (string tenantId = null)

Create a new deployment

The request body should contain data of type multipart/form-data. There should be exactly one file in the request, any additional files will be ignored. If multiple resources need to be deployed in a single deployment, compress the resources in a zip and make sure the file-name ends with .bar or .zip.  An additional parameter (form-field) can be passed in the request body with name tenantId. The value of this field will be used as the id of the tenant this deployment is done in.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadDeploymentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DeploymentApi();
            var tenantId = tenantId_example;  // string |  (optional) 

            try
            {
                // Create a new deployment
                DeploymentResponse result = apiInstance.UploadDeployment(tenantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeploymentApi.UploadDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenantId** | **string**|  | [optional] 

### Return type

[**DeploymentResponse**](DeploymentResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

