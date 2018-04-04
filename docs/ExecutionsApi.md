# IO.Swagger.Api.ExecutionsApi

All URIs are relative to *http://localhost:8080/activiti-rest/service*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateExecutionVariable**](ExecutionsApi.md#createexecutionvariable) | **POST** /runtime/executions/{executionId}/variables | Create variables on an execution
[**CreateOrUpdateExecutionVariable**](ExecutionsApi.md#createorupdateexecutionvariable) | **PUT** /runtime/executions/{executionId}/variables | Update variables on an execution
[**DeleteLocalVariables**](ExecutionsApi.md#deletelocalvariables) | **DELETE** /runtime/executions/{executionId}/variables | Delete all variables for an execution
[**DeletedExecutionVariable**](ExecutionsApi.md#deletedexecutionvariable) | **DELETE** /runtime/executions/{executionId}/variables/{variableName} | Delete a variable for an execution
[**ExecuteExecutionAction**](ExecutionsApi.md#executeexecutionaction) | **PUT** /runtime/executions | Signal event received
[**GetActiveActivities**](ExecutionsApi.md#getactiveactivities) | **GET** /runtime/executions/{executionId}/activities | Get active activities in an execution
[**GetExecution**](ExecutionsApi.md#getexecution) | **GET** /runtime/executions/{executionId} | Get an execution
[**GetExecutionVariable**](ExecutionsApi.md#getexecutionvariable) | **GET** /runtime/executions/{executionId}/variables/{variableName} | Get a variable for an execution
[**GetExecutionVariableData**](ExecutionsApi.md#getexecutionvariabledata) | **GET** /runtime/executions/{executionId}/variables/{variableName}/data | Get the binary data for an execution
[**GetExecutions**](ExecutionsApi.md#getexecutions) | **GET** /runtime/executions | List of executions
[**ListExecutionVariables**](ExecutionsApi.md#listexecutionvariables) | **GET** /runtime/executions/{executionId}/variables | List of variables for an execution
[**PerformExecutionAction**](ExecutionsApi.md#performexecutionaction) | **PUT** /runtime/executions/{executionId} | Execute an action on an execution
[**QueryExecutions**](ExecutionsApi.md#queryexecutions) | **POST** /query/executions | Query executions
[**UpdateExecutionVariable**](ExecutionsApi.md#updateexecutionvariable) | **PUT** /runtime/executions/{executionId}/variables/{variableName} | Update a variable on an execution


<a name="createexecutionvariable"></a>
# **CreateExecutionVariable**
> Object CreateExecutionVariable (string executionId)

Create variables on an execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateExecutionVariableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExecutionsApi();
            var executionId = executionId_example;  // string | The id of the execution to create the new variable for.

            try
            {
                // Create variables on an execution
                Object result = apiInstance.CreateExecutionVariable(executionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecutionsApi.CreateExecutionVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executionId** | **string**| The id of the execution to create the new variable for. | 

### Return type

**Object**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createorupdateexecutionvariable"></a>
# **CreateOrUpdateExecutionVariable**
> Object CreateOrUpdateExecutionVariable (string executionId)

Update variables on an execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOrUpdateExecutionVariableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExecutionsApi();
            var executionId = executionId_example;  // string | The id of the execution to the variables for.

            try
            {
                // Update variables on an execution
                Object result = apiInstance.CreateOrUpdateExecutionVariable(executionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecutionsApi.CreateOrUpdateExecutionVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executionId** | **string**| The id of the execution to the variables for. | 

### Return type

**Object**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocalvariables"></a>
# **DeleteLocalVariables**
> void DeleteLocalVariables (string executionId)

Delete all variables for an execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteLocalVariablesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExecutionsApi();
            var executionId = executionId_example;  // string | 

            try
            {
                // Delete all variables for an execution
                apiInstance.DeleteLocalVariables(executionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecutionsApi.DeleteLocalVariables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executionId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedexecutionvariable"></a>
# **DeletedExecutionVariable**
> void DeletedExecutionVariable (string executionId, string variableName, string scope = null)

Delete a variable for an execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletedExecutionVariableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExecutionsApi();
            var executionId = executionId_example;  // string | 
            var variableName = variableName_example;  // string | 
            var scope = scope_example;  // string |  (optional) 

            try
            {
                // Delete a variable for an execution
                apiInstance.DeletedExecutionVariable(executionId, variableName, scope);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecutionsApi.DeletedExecutionVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executionId** | **string**|  | 
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

<a name="executeexecutionaction"></a>
# **ExecuteExecutionAction**
> void ExecuteExecutionAction (ExecutionActionRequest body = null)

Signal event received

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecuteExecutionActionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExecutionsApi();
            var body = new ExecutionActionRequest(); // ExecutionActionRequest |  (optional) 

            try
            {
                // Signal event received
                apiInstance.ExecuteExecutionAction(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecutionsApi.ExecuteExecutionAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExecutionActionRequest**](ExecutionActionRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactiveactivities"></a>
# **GetActiveActivities**
> List<string> GetActiveActivities (string executionId)

Get active activities in an execution

Returns all activities which are active in the execution and in all child-executions (and their children, recursively), if any.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetActiveActivitiesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExecutionsApi();
            var executionId = executionId_example;  // string | The id of the execution to get activities for.

            try
            {
                // Get active activities in an execution
                List&lt;string&gt; result = apiInstance.GetActiveActivities(executionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecutionsApi.GetActiveActivities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executionId** | **string**| The id of the execution to get activities for. | 

### Return type

**List<string>**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexecution"></a>
# **GetExecution**
> ExecutionResponse GetExecution (string executionId)

Get an execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExecutionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExecutionsApi();
            var executionId = executionId_example;  // string | The id of the execution to get.

            try
            {
                // Get an execution
                ExecutionResponse result = apiInstance.GetExecution(executionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecutionsApi.GetExecution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executionId** | **string**| The id of the execution to get. | 

### Return type

[**ExecutionResponse**](ExecutionResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexecutionvariable"></a>
# **GetExecutionVariable**
> RestVariable GetExecutionVariable (string executionId, string variableName, string scope = null)

Get a variable for an execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExecutionVariableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExecutionsApi();
            var executionId = executionId_example;  // string | The id of the execution to the variables for.
            var variableName = variableName_example;  // string | Name of the variable to get.
            var scope = scope_example;  // string | Either local or global. If omitted, local variable is returned (if exists). If not, a global variable is returned (if exists). (optional) 

            try
            {
                // Get a variable for an execution
                RestVariable result = apiInstance.GetExecutionVariable(executionId, variableName, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecutionsApi.GetExecutionVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executionId** | **string**| The id of the execution to the variables for. | 
 **variableName** | **string**| Name of the variable to get. | 
 **scope** | **string**| Either local or global. If omitted, local variable is returned (if exists). If not, a global variable is returned (if exists). | [optional] 

### Return type

[**RestVariable**](RestVariable.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexecutionvariabledata"></a>
# **GetExecutionVariableData**
> List<byte[]> GetExecutionVariableData (string executionId, string variableName, string scope = null)

Get the binary data for an execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExecutionVariableDataExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExecutionsApi();
            var executionId = executionId_example;  // string | 
            var variableName = variableName_example;  // string | 
            var scope = scope_example;  // string |  (optional) 

            try
            {
                // Get the binary data for an execution
                List&lt;byte[]&gt; result = apiInstance.GetExecutionVariableData(executionId, variableName, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecutionsApi.GetExecutionVariableData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executionId** | **string**|  | 
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

<a name="getexecutions"></a>
# **GetExecutions**
> DataResponse GetExecutions (string id = null, string activityId = null, string processDefinitionKey = null, string processDefinitionId = null, string processInstanceId = null, string messageEventSubscriptionName = null, string signalEventSubscriptionName = null, string parentId = null, string tenantId = null, string tenantIdLike = null, bool? withoutTenantId = null, string sort = null)

List of executions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExecutionsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExecutionsApi();
            var id = id_example;  // string | Only return models with the given version. (optional) 
            var activityId = activityId_example;  // string | Only return executions with the given activity id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Only return process instances with the given process definition key. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Only return process instances with the given process definition id. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Only return executions which are part of the process instance with the given id. (optional) 
            var messageEventSubscriptionName = messageEventSubscriptionName_example;  // string | Only return executions which are subscribed to a message with the given name. (optional) 
            var signalEventSubscriptionName = signalEventSubscriptionName_example;  // string | Only return executions which are subscribed to a signal with the given name. (optional) 
            var parentId = parentId_example;  // string | Only return executions which are a direct child of the given execution. (optional) 
            var tenantId = tenantId_example;  // string | Only return process instances with the given tenantId. (optional) 
            var tenantIdLike = tenantIdLike_example;  // string | Only return process instances with a tenantId like the given value. (optional) 
            var withoutTenantId = true;  // bool? | If true, only returns process instances without a tenantId set. If false, the withoutTenantId parameter is ignored. (optional) 
            var sort = sort_example;  // string | Property to sort on, to be used together with the order. (optional) 

            try
            {
                // List of executions
                DataResponse result = apiInstance.GetExecutions(id, activityId, processDefinitionKey, processDefinitionId, processInstanceId, messageEventSubscriptionName, signalEventSubscriptionName, parentId, tenantId, tenantIdLike, withoutTenantId, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecutionsApi.GetExecutions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Only return models with the given version. | [optional] 
 **activityId** | **string**| Only return executions with the given activity id. | [optional] 
 **processDefinitionKey** | **string**| Only return process instances with the given process definition key. | [optional] 
 **processDefinitionId** | **string**| Only return process instances with the given process definition id. | [optional] 
 **processInstanceId** | **string**| Only return executions which are part of the process instance with the given id. | [optional] 
 **messageEventSubscriptionName** | **string**| Only return executions which are subscribed to a message with the given name. | [optional] 
 **signalEventSubscriptionName** | **string**| Only return executions which are subscribed to a signal with the given name. | [optional] 
 **parentId** | **string**| Only return executions which are a direct child of the given execution. | [optional] 
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

<a name="listexecutionvariables"></a>
# **ListExecutionVariables**
> List<RestVariable> ListExecutionVariables (string executionId, string scope = null)

List of variables for an execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListExecutionVariablesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExecutionsApi();
            var executionId = executionId_example;  // string | The id of the execution to the variables for.
            var scope = scope_example;  // string | Either local or global. If omitted, both local and global scoped variables are returned. (optional) 

            try
            {
                // List of variables for an execution
                List&lt;RestVariable&gt; result = apiInstance.ListExecutionVariables(executionId, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecutionsApi.ListExecutionVariables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executionId** | **string**| The id of the execution to the variables for. | 
 **scope** | **string**| Either local or global. If omitted, both local and global scoped variables are returned. | [optional] 

### Return type

[**List<RestVariable>**](RestVariable.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="performexecutionaction"></a>
# **PerformExecutionAction**
> ExecutionResponse PerformExecutionAction (string executionId, ExecutionActionRequest body = null)

Execute an action on an execution

## Request body (signal an execution):   ```JSON {   \"action\":\"signal\" } ```   Both a variables and transientVariables property is accepted with following structure ```JSON {   \"action\":\"signal\",   \"variables\" : [     {       \"name\": \"myVar\",       \"value\": \"someValue\"     }   ] }```   ## Request body (signal event received for execution)   ```JSON {   \"action\":\"signal\" } ```   Notifies the execution that a signal event has been received, requires a signalName parameter. Optional variables can be passed that are set on the execution before the action is executed.## Request body (signal event received for execution)   ```JSON {   \"action\":\"messageEventReceived\",   \"messageName\":\"myMessage\"   \"variables\": [  ] } ```   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PerformExecutionActionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExecutionsApi();
            var executionId = executionId_example;  // string | The id of the execution to execute action on.
            var body = new ExecutionActionRequest(); // ExecutionActionRequest |  (optional) 

            try
            {
                // Execute an action on an execution
                ExecutionResponse result = apiInstance.PerformExecutionAction(executionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecutionsApi.PerformExecutionAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executionId** | **string**| The id of the execution to execute action on. | 
 **body** | [**ExecutionActionRequest**](ExecutionActionRequest.md)|  | [optional] 

### Return type

[**ExecutionResponse**](ExecutionResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryexecutions"></a>
# **QueryExecutions**
> DataResponse QueryExecutions (ExecutionQueryRequest body = null)

Query executions

The request body can contain all possible filters that can be used in the List executions URL query. On top of these, it�s possible to provide an array of variables and processInstanceVariables to include in the query, with their format described here.  The general paging and sorting query-parameters can be used for this URL.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QueryExecutionsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExecutionsApi();
            var body = new ExecutionQueryRequest(); // ExecutionQueryRequest |  (optional) 

            try
            {
                // Query executions
                DataResponse result = apiInstance.QueryExecutions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecutionsApi.QueryExecutions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExecutionQueryRequest**](ExecutionQueryRequest.md)|  | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateexecutionvariable"></a>
# **UpdateExecutionVariable**
> RestVariable UpdateExecutionVariable (string executionId, string variableName)

Update a variable on an execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateExecutionVariableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ExecutionsApi();
            var executionId = executionId_example;  // string | The id of the execution to create the new variable for.
            var variableName = variableName_example;  // string | The name of the variable to update.

            try
            {
                // Update a variable on an execution
                RestVariable result = apiInstance.UpdateExecutionVariable(executionId, variableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecutionsApi.UpdateExecutionVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executionId** | **string**| The id of the execution to create the new variable for. | 
 **variableName** | **string**| The name of the variable to update. | 

### Return type

[**RestVariable**](RestVariable.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

