# IO.Swagger.Api.ProcessDefinitionsApi

All URIs are relative to *http://localhost:8080/activiti-rest/service*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateIdentityLink**](ProcessDefinitionsApi.md#createidentitylink) | **POST** /repository/process-definitions/{processDefinitionId}/identitylinks | Add a candidate starter to a process definition
[**DeleteIdentityLink**](ProcessDefinitionsApi.md#deleteidentitylink) | **DELETE** /repository/process-definitions/{processDefinitionId}/identitylinks/{family}/{identityId} | Delete a candidate starter from a process definition
[**ExecuteProcessDefinitionAction**](ProcessDefinitionsApi.md#executeprocessdefinitionaction) | **PUT** /repository/process-definitions/{processDefinitionId} | Execute actions for a process definition (Update category, Suspend or Activate)
[**GetBpmnModelResource**](ProcessDefinitionsApi.md#getbpmnmodelresource) | **GET** /repository/process-definitions/{processDefinitionId}/model | Get a process definition BPMN model
[**GetIdentityLink**](ProcessDefinitionsApi.md#getidentitylink) | **GET** /repository/process-definitions/{processDefinitionId}/identitylinks/{family}/{identityId} | Get a candidate starter from a process definition
[**GetIdentityLinks**](ProcessDefinitionsApi.md#getidentitylinks) | **GET** /repository/process-definitions/{processDefinitionId}/identitylinks | Get all candidate starters for a process-definition
[**GetModelResource**](ProcessDefinitionsApi.md#getmodelresource) | **GET** /repository/process-definitions/{processDefinitionId}/image | Get a process definition image
[**GetProcessDefinition**](ProcessDefinitionsApi.md#getprocessdefinition) | **GET** /repository/process-definitions/{processDefinitionId} | Get a process definition
[**GetProcessDefinitionResource**](ProcessDefinitionsApi.md#getprocessdefinitionresource) | **GET** /repository/process-definitions/{processDefinitionId}/resourcedata | Get a process definition resource content
[**GetProcessDefinitions**](ProcessDefinitionsApi.md#getprocessdefinitions) | **GET** /repository/process-definitions | List of process definitions


<a name="createidentitylink"></a>
# **CreateIdentityLink**
> RestIdentityLink CreateIdentityLink (string processDefinitionId, RestIdentityLink body = null)

Add a candidate starter to a process definition

## For a User   ```JSON {   \"user\" : \"kermit\" } ```  ## For a Group   ```JSON {   \"groupId\" : \"sales\" } ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateIdentityLinkExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessDefinitionsApi();
            var processDefinitionId = processDefinitionId_example;  // string | The id of the process definition.
            var body = new RestIdentityLink(); // RestIdentityLink |  (optional) 

            try
            {
                // Add a candidate starter to a process definition
                RestIdentityLink result = apiInstance.CreateIdentityLink(processDefinitionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessDefinitionsApi.CreateIdentityLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDefinitionId** | **string**| The id of the process definition. | 
 **body** | [**RestIdentityLink**](RestIdentityLink.md)|  | [optional] 

### Return type

[**RestIdentityLink**](RestIdentityLink.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteidentitylink"></a>
# **DeleteIdentityLink**
> void DeleteIdentityLink (string processDefinitionId, string family, string identityId)

Delete a candidate starter from a process definition

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteIdentityLinkExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessDefinitionsApi();
            var processDefinitionId = processDefinitionId_example;  // string | The id of the process definition.
            var family = family_example;  // string | Either users or groups, depending on the type of identity link.
            var identityId = identityId_example;  // string | Either the user or group of the identity to remove as candidate starter.

            try
            {
                // Delete a candidate starter from a process definition
                apiInstance.DeleteIdentityLink(processDefinitionId, family, identityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessDefinitionsApi.DeleteIdentityLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDefinitionId** | **string**| The id of the process definition. | 
 **family** | **string**| Either users or groups, depending on the type of identity link. | 
 **identityId** | **string**| Either the user or group of the identity to remove as candidate starter. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executeprocessdefinitionaction"></a>
# **ExecuteProcessDefinitionAction**
> ProcessDefinitionResponse ExecuteProcessDefinitionAction (string processDefinitionId, ProcessDefinitionActionRequest body)

Execute actions for a process definition (Update category, Suspend or Activate)

## Update category for a process definition   ```JSON {   \"category\" : \"updatedcategory\" } ```   ## Suspend a process definition  ```JSON  {   \"action\" : \"suspend\",   \"includeProcessInstances\" : \"false\",   \"date\" : \"2013-04-15T00:42:12Z\" } ```   ## Activate a process definition  ```JSON  {   \"action\" : \"activate\",   \"includeProcessInstances\" : \"true\",   \"date\" : \"2013-04-15T00:42:12Z\" } ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecuteProcessDefinitionActionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessDefinitionsApi();
            var processDefinitionId = processDefinitionId_example;  // string | 
            var body = new ProcessDefinitionActionRequest(); // ProcessDefinitionActionRequest | 

            try
            {
                // Execute actions for a process definition (Update category, Suspend or Activate)
                ProcessDefinitionResponse result = apiInstance.ExecuteProcessDefinitionAction(processDefinitionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessDefinitionsApi.ExecuteProcessDefinitionAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDefinitionId** | **string**|  | 
 **body** | [**ProcessDefinitionActionRequest**](ProcessDefinitionActionRequest.md)|  | 

### Return type

[**ProcessDefinitionResponse**](ProcessDefinitionResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbpmnmodelresource"></a>
# **GetBpmnModelResource**
> BpmnModel GetBpmnModelResource (string processDefinitionId)

Get a process definition BPMN model

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBpmnModelResourceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessDefinitionsApi();
            var processDefinitionId = processDefinitionId_example;  // string | The id of the process definition to get the model for.

            try
            {
                // Get a process definition BPMN model
                BpmnModel result = apiInstance.GetBpmnModelResource(processDefinitionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessDefinitionsApi.GetBpmnModelResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDefinitionId** | **string**| The id of the process definition to get the model for. | 

### Return type

[**BpmnModel**](BpmnModel.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidentitylink"></a>
# **GetIdentityLink**
> RestIdentityLink GetIdentityLink (string processDefinitionId, string family, string identityId)

Get a candidate starter from a process definition

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIdentityLinkExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessDefinitionsApi();
            var processDefinitionId = processDefinitionId_example;  // string | The id of the process definition.
            var family = family_example;  // string | Either users or groups, depending on the type of identity link.
            var identityId = identityId_example;  // string | Either the user or group of the identity to get as candidate starter.

            try
            {
                // Get a candidate starter from a process definition
                RestIdentityLink result = apiInstance.GetIdentityLink(processDefinitionId, family, identityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessDefinitionsApi.GetIdentityLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDefinitionId** | **string**| The id of the process definition. | 
 **family** | **string**| Either users or groups, depending on the type of identity link. | 
 **identityId** | **string**| Either the user or group of the identity to get as candidate starter. | 

### Return type

[**RestIdentityLink**](RestIdentityLink.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidentitylinks"></a>
# **GetIdentityLinks**
> List<RestIdentityLink> GetIdentityLinks (string processDefinitionId)

Get all candidate starters for a process-definition

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIdentityLinksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessDefinitionsApi();
            var processDefinitionId = processDefinitionId_example;  // string | The id of the process definition to get the identity links for.

            try
            {
                // Get all candidate starters for a process-definition
                List&lt;RestIdentityLink&gt; result = apiInstance.GetIdentityLinks(processDefinitionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessDefinitionsApi.GetIdentityLinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDefinitionId** | **string**| The id of the process definition to get the identity links for. | 

### Return type

[**List<RestIdentityLink>**](RestIdentityLink.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmodelresource"></a>
# **GetModelResource**
> List<byte[]> GetModelResource (string processDefinitionId)

Get a process definition image

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetModelResourceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessDefinitionsApi();
            var processDefinitionId = processDefinitionId_example;  // string | 

            try
            {
                // Get a process definition image
                List&lt;byte[]&gt; result = apiInstance.GetModelResource(processDefinitionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessDefinitionsApi.GetModelResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDefinitionId** | **string**|  | 

### Return type

**List<byte[]>**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessdefinition"></a>
# **GetProcessDefinition**
> ProcessDefinitionResponse GetProcessDefinition (string processDefinitionId)

Get a process definition

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessDefinitionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessDefinitionsApi();
            var processDefinitionId = processDefinitionId_example;  // string | The id of the process definition to get.

            try
            {
                // Get a process definition
                ProcessDefinitionResponse result = apiInstance.GetProcessDefinition(processDefinitionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessDefinitionsApi.GetProcessDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDefinitionId** | **string**| The id of the process definition to get. | 

### Return type

[**ProcessDefinitionResponse**](ProcessDefinitionResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessdefinitionresource"></a>
# **GetProcessDefinitionResource**
> List<byte[]> GetProcessDefinitionResource (string processDefinitionId)

Get a process definition resource content

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessDefinitionResourceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessDefinitionsApi();
            var processDefinitionId = processDefinitionId_example;  // string | The id of the process definition to get the resource data for.

            try
            {
                // Get a process definition resource content
                List&lt;byte[]&gt; result = apiInstance.GetProcessDefinitionResource(processDefinitionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessDefinitionsApi.GetProcessDefinitionResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDefinitionId** | **string**| The id of the process definition to get the resource data for. | 

### Return type

**List<byte[]>**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessdefinitions"></a>
# **GetProcessDefinitions**
> DataResponse GetProcessDefinitions (int? version = null, string name = null, string nameLike = null, string key = null, string keyLike = null, string resourceName = null, string resourceNameLike = null, string category = null, string categoryLike = null, string categoryNotEquals = null, string deploymentId = null, string startableByUser = null, bool? latest = null, bool? suspended = null, string sort = null)

List of process definitions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessDefinitionsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessDefinitionsApi();
            var version = 56;  // int? | Only return process definitions with the given version. (optional) 
            var name = name_example;  // string | Only return process definitions with the given name. (optional) 
            var nameLike = nameLike_example;  // string | Only return process definitions with a name like the given name. (optional) 
            var key = key_example;  // string | Only return process definitions with the given key. (optional) 
            var keyLike = keyLike_example;  // string | Only return process definitions with a name like the given key. (optional) 
            var resourceName = resourceName_example;  // string | Only return process definitions with the given resource name. (optional) 
            var resourceNameLike = resourceNameLike_example;  // string | Only return process definitions with a name like the given resource name. (optional) 
            var category = category_example;  // string | Only return process definitions with the given category. (optional) 
            var categoryLike = categoryLike_example;  // string | Only return process definitions with a category like the given name. (optional) 
            var categoryNotEquals = categoryNotEquals_example;  // string | Only return process definitions which don�t have the given category. (optional) 
            var deploymentId = deploymentId_example;  // string | Only return process definitions with the given category. (optional) 
            var startableByUser = startableByUser_example;  // string | Only return process definitions which are part of a deployment with the given id. (optional) 
            var latest = true;  // bool? | Only return the latest process definition versions. Can only be used together with key and keyLike parameters, using any other parameter will result in a 400-response. (optional) 
            var suspended = true;  // bool? | If true, only returns process definitions which are suspended. If false, only active process definitions (which are not suspended) are returned. (optional) 
            var sort = sort_example;  // string | Property to sort on, to be used together with the order. (optional) 

            try
            {
                // List of process definitions
                DataResponse result = apiInstance.GetProcessDefinitions(version, name, nameLike, key, keyLike, resourceName, resourceNameLike, category, categoryLike, categoryNotEquals, deploymentId, startableByUser, latest, suspended, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessDefinitionsApi.GetProcessDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **int?**| Only return process definitions with the given version. | [optional] 
 **name** | **string**| Only return process definitions with the given name. | [optional] 
 **nameLike** | **string**| Only return process definitions with a name like the given name. | [optional] 
 **key** | **string**| Only return process definitions with the given key. | [optional] 
 **keyLike** | **string**| Only return process definitions with a name like the given key. | [optional] 
 **resourceName** | **string**| Only return process definitions with the given resource name. | [optional] 
 **resourceNameLike** | **string**| Only return process definitions with a name like the given resource name. | [optional] 
 **category** | **string**| Only return process definitions with the given category. | [optional] 
 **categoryLike** | **string**| Only return process definitions with a category like the given name. | [optional] 
 **categoryNotEquals** | **string**| Only return process definitions which don�t have the given category. | [optional] 
 **deploymentId** | **string**| Only return process definitions with the given category. | [optional] 
 **startableByUser** | **string**| Only return process definitions which are part of a deployment with the given id. | [optional] 
 **latest** | **bool?**| Only return the latest process definition versions. Can only be used together with key and keyLike parameters, using any other parameter will result in a 400-response. | [optional] 
 **suspended** | **bool?**| If true, only returns process definitions which are suspended. If false, only active process definitions (which are not suspended) are returned. | [optional] 
 **sort** | **string**| Property to sort on, to be used together with the order. | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

