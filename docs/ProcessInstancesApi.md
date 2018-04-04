# IO.Swagger.Api.ProcessInstancesApi

All URIs are relative to *http://localhost:8080/activiti-rest/service*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrUpdateProcessVariable**](ProcessInstancesApi.md#createorupdateprocessvariable) | **PUT** /runtime/process-instances/{processInstanceId}/variables | Update a single or binary variable or multiple variables on a process instance
[**CreateProcessInstance**](ProcessInstancesApi.md#createprocessinstance) | **POST** /runtime/process-instances | Start a process instance
[**CreateProcessInstanceIdentityLinks**](ProcessInstancesApi.md#createprocessinstanceidentitylinks) | **POST** /runtime/process-instances/{processInstanceId}/identitylinks | Add an involved user to a process instance
[**CreateProcessInstanceVariable**](ProcessInstancesApi.md#createprocessinstancevariable) | **POST** /runtime/process-instances/{processInstanceId}/variables | Create variables or new binary variable on a process instance
[**DeleteLocalProcessVariable**](ProcessInstancesApi.md#deletelocalprocessvariable) | **DELETE** /runtime/process-instances/{processInstanceId}/variables | Delete all variables
[**DeleteProcessInstance**](ProcessInstancesApi.md#deleteprocessinstance) | **DELETE** /runtime/process-instances/{processInstanceId} | Delete a process instance
[**DeleteProcessInstanceIdentityLinks**](ProcessInstancesApi.md#deleteprocessinstanceidentitylinks) | **DELETE** /runtime/process-instances/{processInstanceId}/identitylinks/users/{identityId}/{type} | Remove an involved user to from process instance
[**DeleteProcessInstanceVariable**](ProcessInstancesApi.md#deleteprocessinstancevariable) | **DELETE** /runtime/process-instances/{processInstanceId}/variables/{variableName} | Delete a variable
[**GetProcessInstance**](ProcessInstancesApi.md#getprocessinstance) | **GET** /runtime/process-instances/{processInstanceId} | Get a process instance
[**GetProcessInstanceDiagram**](ProcessInstancesApi.md#getprocessinstancediagram) | **GET** /runtime/process-instances/{processInstanceId}/diagram | Get diagram for a process instance
[**GetProcessInstanceIdentityLinks**](ProcessInstancesApi.md#getprocessinstanceidentitylinks) | **GET** /runtime/process-instances/{processInstanceId}/identitylinks/users/{identityId}/{type} | Get a specific involved people from process instance
[**GetProcessInstanceVariable**](ProcessInstancesApi.md#getprocessinstancevariable) | **GET** /runtime/process-instances/{processInstanceId}/variables/{variableName} | Get a variable for a process instance
[**GetProcessInstanceVariableData**](ProcessInstancesApi.md#getprocessinstancevariabledata) | **GET** /runtime/process-instances/{processInstanceId}/variables/{variableName}/data | Get the binary data for a variable
[**GetProcessInstances**](ProcessInstancesApi.md#getprocessinstances) | **GET** /runtime/process-instances | List of process instances
[**GetVariables**](ProcessInstancesApi.md#getvariables) | **GET** /runtime/process-instances/{processInstanceId}/variables | List of variables for a process instance
[**ListProcessInstanceIdentityLinks**](ProcessInstancesApi.md#listprocessinstanceidentitylinks) | **GET** /runtime/process-instances/{processInstanceId}/identitylinks | Get involved people for process instance
[**PerformProcessInstanceAction**](ProcessInstancesApi.md#performprocessinstanceaction) | **PUT** /runtime/process-instances/{processInstanceId} | Activate or suspend a process instance
[**QueryProcessInstances**](ProcessInstancesApi.md#queryprocessinstances) | **POST** /query/process-instances | Query process instances
[**UpdateProcessInstanceVariable**](ProcessInstancesApi.md#updateprocessinstancevariable) | **PUT** /runtime/process-instances/{processInstanceId}/variables/{variableName} | Update a single variable on a process instance


<a name="createorupdateprocessvariable"></a>
# **CreateOrUpdateProcessVariable**
> Object CreateOrUpdateProcessVariable (string processInstanceId)

Update a single or binary variable or multiple variables on a process instance

## Update multiples variables   ```JSON [    {       \"name\":\"intProcVar\"       \"type\":\"integer\"       \"value\":123    },     ... ] ```    Any number of variables can be passed into the request body array. More information about the variable format can be found in the REST variables section. Note that scope is ignored, only local variables can be set in a process instance.   ## Update a single variable  ```JSON  {     \"name\":\"intProcVar\"     \"type\":\"integer\"     \"value\":123  } ```   ##  Update an existing binary variable     The request should be of type multipart/form-data. There should be a single file-part included with the binary value of the variable. On top of that, the following additional form-fields can be present:  name: Required name of the variable.  type: Type of variable that is created. If omitted, binary is assumed and the binary data in the request will be stored as an array of bytes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOrUpdateProcessVariableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the process instance to create the new variable for.

            try
            {
                // Update a single or binary variable or multiple variables on a process instance
                Object result = apiInstance.CreateOrUpdateProcessVariable(processInstanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.CreateOrUpdateProcessVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the process instance to create the new variable for. | 

### Return type

**Object**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprocessinstance"></a>
# **CreateProcessInstance**
> ProcessInstanceResponse CreateProcessInstance (ProcessInstanceCreateRequest body = null)

Start a process instance

## Request body (start by process definition id)  ```JSON  {    \"processDefinitionId\":\"oneTaskProcess:1:158\",    \"businessKey\":\"myBusinessKey\",    \"variables\": [       {         \"name\":\"myVar\",         \"value\":\"This is a variable\",       }    ] }```  ## Request body (start by process definition key)  ```JSON  {    \"processDefinitionKey\":\"oneTaskProcess\",    \"businessKey\":\"myBusinessKey\",    \"tenantId\": \"tenant1\",    \"variables\": [       {         \"name\":\"myVar\",         \"value\":\"This is a variable\",       }    ] }```  ## Request body (start by message)  ```JSON {    \"message\":\"newOrderMessage\",    \"businessKey\":\"myBusinessKey\",    \"tenantId\": \"tenant1\",    \"variables\": [       {         \"name\":\"myVar\",         \"value\":\"This is a variable\",       }    ] }```  Note that also a *transientVariables* property is accepted as part of this json, that follows the same structure as the *variables* property.  Only one of *processDefinitionId*, *processDefinitionKey* or *message* can be used in the request body. Parameters *businessKey*, *variables* and *tenantId* are optional. If tenantId is omitted, the default tenant will be used. More information about the variable format can be found in the REST variables section. Note that the variable-scope that is supplied is ignored, process-variables are always local.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateProcessInstanceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var body = new ProcessInstanceCreateRequest(); // ProcessInstanceCreateRequest |  (optional) 

            try
            {
                // Start a process instance
                ProcessInstanceResponse result = apiInstance.CreateProcessInstance(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.CreateProcessInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProcessInstanceCreateRequest**](ProcessInstanceCreateRequest.md)|  | [optional] 

### Return type

[**ProcessInstanceResponse**](ProcessInstanceResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprocessinstanceidentitylinks"></a>
# **CreateProcessInstanceIdentityLinks**
> RestIdentityLink CreateProcessInstanceIdentityLinks (string processInstanceId, RestIdentityLink body = null)

Add an involved user to a process instance

Note that the groupId in Response Body will always be null, as it�s only possible to involve users with a process-instance.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateProcessInstanceIdentityLinksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the process instance to the links for.
            var body = new RestIdentityLink(); // RestIdentityLink |  (optional) 

            try
            {
                // Add an involved user to a process instance
                RestIdentityLink result = apiInstance.CreateProcessInstanceIdentityLinks(processInstanceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.CreateProcessInstanceIdentityLinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the process instance to the links for. | 
 **body** | [**RestIdentityLink**](RestIdentityLink.md)|  | [optional] 

### Return type

[**RestIdentityLink**](RestIdentityLink.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprocessinstancevariable"></a>
# **CreateProcessInstanceVariable**
> Object CreateProcessInstanceVariable (string processInstanceId)

Create variables or new binary variable on a process instance

## Update multiples variables   ```JSON [    {       \"name\":\"intProcVar\"       \"type\":\"integer\"       \"value\":123    },     ... ] ```    Any number of variables can be passed into the request body array. More information about the variable format can be found in the REST variables section. Note that scope is ignored, only local variables can be set in a process instance.   The request should be of type multipart/form-data. There should be a single file-part included with the binary value of the variable. On top of that, the following additional form-fields can be present:  name: Required name of the variable.  type: Type of variable that is created. If omitted, binary is assumed and the binary data in the request will be stored as an array of bytes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateProcessInstanceVariableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the process instance to create the new variable for

            try
            {
                // Create variables or new binary variable on a process instance
                Object result = apiInstance.CreateProcessInstanceVariable(processInstanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.CreateProcessInstanceVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the process instance to create the new variable for | 

### Return type

**Object**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocalprocessvariable"></a>
# **DeleteLocalProcessVariable**
> void DeleteLocalProcessVariable (string processInstanceId)

Delete all variables

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteLocalProcessVariableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | 

            try
            {
                // Delete all variables
                apiInstance.DeleteLocalProcessVariable(processInstanceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.DeleteLocalProcessVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprocessinstance"></a>
# **DeleteProcessInstance**
> void DeleteProcessInstance (string processInstanceId, string deleteReason = null)

Delete a process instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteProcessInstanceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the process instance to delete.
            var deleteReason = deleteReason_example;  // string |  (optional) 

            try
            {
                // Delete a process instance
                apiInstance.DeleteProcessInstance(processInstanceId, deleteReason);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.DeleteProcessInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the process instance to delete. | 
 **deleteReason** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprocessinstanceidentitylinks"></a>
# **DeleteProcessInstanceIdentityLinks**
> void DeleteProcessInstanceIdentityLinks (string processInstanceId, string identityId, string type)

Remove an involved user to from process instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteProcessInstanceIdentityLinksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the process instance.
            var identityId = identityId_example;  // string | The id of the user to delete link for.
            var type = type_example;  // string | Type of link to delete.

            try
            {
                // Remove an involved user to from process instance
                apiInstance.DeleteProcessInstanceIdentityLinks(processInstanceId, identityId, type);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.DeleteProcessInstanceIdentityLinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the process instance. | 
 **identityId** | **string**| The id of the user to delete link for. | 
 **type** | **string**| Type of link to delete. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprocessinstancevariable"></a>
# **DeleteProcessInstanceVariable**
> void DeleteProcessInstanceVariable (string processInstanceId, string variableName, string scope = null)

Delete a variable

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteProcessInstanceVariableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | 
            var variableName = variableName_example;  // string | 
            var scope = scope_example;  // string |  (optional) 

            try
            {
                // Delete a variable
                apiInstance.DeleteProcessInstanceVariable(processInstanceId, variableName, scope);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.DeleteProcessInstanceVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**|  | 
 **variableName** | **string**|  | 
 **scope** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessinstance"></a>
# **GetProcessInstance**
> ProcessInstanceResponse GetProcessInstance (string processInstanceId)

Get a process instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessInstanceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the process instance to get.

            try
            {
                // Get a process instance
                ProcessInstanceResponse result = apiInstance.GetProcessInstance(processInstanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.GetProcessInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the process instance to get. | 

### Return type

[**ProcessInstanceResponse**](ProcessInstanceResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessinstancediagram"></a>
# **GetProcessInstanceDiagram**
> List<byte[]> GetProcessInstanceDiagram (string processInstanceId)

Get diagram for a process instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessInstanceDiagramExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the process instance to get the diagram for.

            try
            {
                // Get diagram for a process instance
                List&lt;byte[]&gt; result = apiInstance.GetProcessInstanceDiagram(processInstanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.GetProcessInstanceDiagram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the process instance to get the diagram for. | 

### Return type

**List<byte[]>**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessinstanceidentitylinks"></a>
# **GetProcessInstanceIdentityLinks**
> RestIdentityLink GetProcessInstanceIdentityLinks (string processInstanceId, string identityId, string type)

Get a specific involved people from process instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessInstanceIdentityLinksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the process instance to get.
            var identityId = identityId_example;  // string | 
            var type = type_example;  // string | 

            try
            {
                // Get a specific involved people from process instance
                RestIdentityLink result = apiInstance.GetProcessInstanceIdentityLinks(processInstanceId, identityId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.GetProcessInstanceIdentityLinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the process instance to get. | 
 **identityId** | **string**|  | 
 **type** | **string**|  | 

### Return type

[**RestIdentityLink**](RestIdentityLink.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessinstancevariable"></a>
# **GetProcessInstanceVariable**
> RestVariable GetProcessInstanceVariable (string processInstanceId, string variableName, string scope = null)

Get a variable for a process instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessInstanceVariableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the process instance to the variables for.
            var variableName = variableName_example;  // string | Name of the variable to get.
            var scope = scope_example;  // string |  (optional) 

            try
            {
                // Get a variable for a process instance
                RestVariable result = apiInstance.GetProcessInstanceVariable(processInstanceId, variableName, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.GetProcessInstanceVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the process instance to the variables for. | 
 **variableName** | **string**| Name of the variable to get. | 
 **scope** | **string**|  | [optional] 

### Return type

[**RestVariable**](RestVariable.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessinstancevariabledata"></a>
# **GetProcessInstanceVariableData**
> List<byte[]> GetProcessInstanceVariableData (string processInstanceId, string variableName, string scope = null)

Get the binary data for a variable

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessInstanceVariableDataExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | 
            var variableName = variableName_example;  // string | 
            var scope = scope_example;  // string |  (optional) 

            try
            {
                // Get the binary data for a variable
                List&lt;byte[]&gt; result = apiInstance.GetProcessInstanceVariableData(processInstanceId, variableName, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.GetProcessInstanceVariableData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**|  | 
 **variableName** | **string**|  | 
 **scope** | **string**|  | [optional] 

### Return type

**List<byte[]>**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessinstances"></a>
# **GetProcessInstances**
> DataResponse GetProcessInstances (string id = null, string processDefinitionKey = null, string processDefinitionId = null, string businessKey = null, string involvedUser = null, bool? suspended = null, string superProcessInstanceId = null, string subProcessInstanceId = null, bool? excludeSubprocesses = null, bool? includeProcessVariables = null, string tenantId = null, string tenantIdLike = null, bool? withoutTenantId = null, string sort = null)

List of process instances

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessInstancesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var id = id_example;  // string | Only return models with the given version. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Only return process instances with the given process definition key. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Only return process instances with the given process definition id. (optional) 
            var businessKey = businessKey_example;  // string | Only return process instances with the given businessKey. (optional) 
            var involvedUser = involvedUser_example;  // string | Only return process instances in which the given user is involved. (optional) 
            var suspended = true;  // bool? | If true, only return process instance which are suspended. If false, only return process instances which are not suspended (active). (optional) 
            var superProcessInstanceId = superProcessInstanceId_example;  // string | Only return process instances which have the given super process-instance id (for processes that have a call-activities). (optional) 
            var subProcessInstanceId = subProcessInstanceId_example;  // string | Only return process instances which have the given sub process-instance id (for processes started as a call-activity). (optional) 
            var excludeSubprocesses = true;  // bool? | Return only process instances which aren�t sub processes. (optional) 
            var includeProcessVariables = true;  // bool? | Indication to include process variables in the result. (optional) 
            var tenantId = tenantId_example;  // string | Only return process instances with the given tenantId. (optional) 
            var tenantIdLike = tenantIdLike_example;  // string | Only return process instances with a tenantId like the given value. (optional) 
            var withoutTenantId = true;  // bool? | If true, only returns process instances without a tenantId set. If false, the withoutTenantId parameter is ignored. (optional) 
            var sort = sort_example;  // string | Property to sort on, to be used together with the order. (optional) 

            try
            {
                // List of process instances
                DataResponse result = apiInstance.GetProcessInstances(id, processDefinitionKey, processDefinitionId, businessKey, involvedUser, suspended, superProcessInstanceId, subProcessInstanceId, excludeSubprocesses, includeProcessVariables, tenantId, tenantIdLike, withoutTenantId, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.GetProcessInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Only return models with the given version. | [optional] 
 **processDefinitionKey** | **string**| Only return process instances with the given process definition key. | [optional] 
 **processDefinitionId** | **string**| Only return process instances with the given process definition id. | [optional] 
 **businessKey** | **string**| Only return process instances with the given businessKey. | [optional] 
 **involvedUser** | **string**| Only return process instances in which the given user is involved. | [optional] 
 **suspended** | **bool?**| If true, only return process instance which are suspended. If false, only return process instances which are not suspended (active). | [optional] 
 **superProcessInstanceId** | **string**| Only return process instances which have the given super process-instance id (for processes that have a call-activities). | [optional] 
 **subProcessInstanceId** | **string**| Only return process instances which have the given sub process-instance id (for processes started as a call-activity). | [optional] 
 **excludeSubprocesses** | **bool?**| Return only process instances which aren�t sub processes. | [optional] 
 **includeProcessVariables** | **bool?**| Indication to include process variables in the result. | [optional] 
 **tenantId** | **string**| Only return process instances with the given tenantId. | [optional] 
 **tenantIdLike** | **string**| Only return process instances with a tenantId like the given value. | [optional] 
 **withoutTenantId** | **bool?**| If true, only returns process instances without a tenantId set. If false, the withoutTenantId parameter is ignored. | [optional] 
 **sort** | **string**| Property to sort on, to be used together with the order. | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvariables"></a>
# **GetVariables**
> List<RestVariable> GetVariables (string processInstanceId, string scope = null)

List of variables for a process instance

In case the variable is a binary variable or serializable, the valueUrl points to an URL to fetch the raw value. If it�s a plain variable, the value is present in the response. Note that only local scoped variables are returned, as there is no global scope for process-instance variables.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVariablesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the process instance to the variables for.
            var scope = scope_example;  // string |  (optional) 

            try
            {
                // List of variables for a process instance
                List&lt;RestVariable&gt; result = apiInstance.GetVariables(processInstanceId, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.GetVariables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the process instance to the variables for. | 
 **scope** | **string**|  | [optional] 

### Return type

[**List<RestVariable>**](RestVariable.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listprocessinstanceidentitylinks"></a>
# **ListProcessInstanceIdentityLinks**
> List<RestIdentityLink> ListProcessInstanceIdentityLinks (string processInstanceId)

Get involved people for process instance

Note that the groupId in Response Body will always be null, as it�s only possible to involve users with a process-instance.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListProcessInstanceIdentityLinksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the process instance to the links for.

            try
            {
                // Get involved people for process instance
                List&lt;RestIdentityLink&gt; result = apiInstance.ListProcessInstanceIdentityLinks(processInstanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.ListProcessInstanceIdentityLinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the process instance to the links for. | 

### Return type

[**List<RestIdentityLink>**](RestIdentityLink.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="performprocessinstanceaction"></a>
# **PerformProcessInstanceAction**
> ProcessInstanceResponse PerformProcessInstanceAction (string processInstanceId, ProcessInstanceActionRequest body = null)

Activate or suspend a process instance

## Activate a process instance   ```JSON {   \"action\" : \"suspend\" } ```   ## Suspend a process instance   ```JSON {   \"action\" : \"activate\" } ```   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PerformProcessInstanceActionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the process instance to activate/suspend.
            var body = new ProcessInstanceActionRequest(); // ProcessInstanceActionRequest |  (optional) 

            try
            {
                // Activate or suspend a process instance
                ProcessInstanceResponse result = apiInstance.PerformProcessInstanceAction(processInstanceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.PerformProcessInstanceAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the process instance to activate/suspend. | 
 **body** | [**ProcessInstanceActionRequest**](ProcessInstanceActionRequest.md)|  | [optional] 

### Return type

[**ProcessInstanceResponse**](ProcessInstanceResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryprocessinstances"></a>
# **QueryProcessInstances**
> DataResponse QueryProcessInstances (ProcessInstanceQueryRequest body = null)

Query process instances

The request body can contain all possible filters that can be used in the List process instances URL query. On top of these, it�s possible to provide an array of variables to include in the query, with their format described here.  The general paging and sorting query-parameters can be used for this URL.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QueryProcessInstancesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var body = new ProcessInstanceQueryRequest(); // ProcessInstanceQueryRequest |  (optional) 

            try
            {
                // Query process instances
                DataResponse result = apiInstance.QueryProcessInstances(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.QueryProcessInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProcessInstanceQueryRequest**](ProcessInstanceQueryRequest.md)|  | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprocessinstancevariable"></a>
# **UpdateProcessInstanceVariable**
> RestVariable UpdateProcessInstanceVariable (string processInstanceId, string variableName)

Update a single variable on a process instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateProcessInstanceVariableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessInstancesApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the process instance to the variables for.
            var variableName = variableName_example;  // string | Name of the variable to get.

            try
            {
                // Update a single variable on a process instance
                RestVariable result = apiInstance.UpdateProcessInstanceVariable(processInstanceId, variableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInstancesApi.UpdateProcessInstanceVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the process instance to the variables for. | 
 **variableName** | **string**| Name of the variable to get. | 

### Return type

[**RestVariable**](RestVariable.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

