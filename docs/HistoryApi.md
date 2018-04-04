# IO.Swagger.Api.HistoryApi

All URIs are relative to *http://localhost:8080/activiti-rest/service*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateComment**](HistoryApi.md#createcomment) | **POST** /history/historic-process-instances/{processInstanceId}/comments | Create a new comment on a historic process instance
[**DeleteComment**](HistoryApi.md#deletecomment) | **DELETE** /history/historic-process-instances/{processInstanceId}/comments/{commentId} | Delete a comment on a historic process instance
[**DeleteHitoricProcessInstance**](HistoryApi.md#deletehitoricprocessinstance) | **DELETE** /history/historic-process-instances/{processInstanceId} |  Delete a historic process instance
[**DeleteTaskInstance**](HistoryApi.md#deletetaskinstance) | **DELETE** /history/historic-task-instances/{taskId} | Delete a historic task instance
[**GetComment**](HistoryApi.md#getcomment) | **GET** /history/historic-process-instances/{processInstanceId}/comments/{commentId} | Get a comment on a historic process instance
[**GetComments**](HistoryApi.md#getcomments) | **GET** /history/historic-process-instances/{processInstanceId}/comments | Get all comments on a historic process instance
[**GetHistoricActivityInstances**](HistoryApi.md#gethistoricactivityinstances) | **GET** /history/historic-activity-instances | Get historic activity instances
[**GetHistoricDetailInfo**](HistoryApi.md#gethistoricdetailinfo) | **GET** /history/historic-detail | Get historic detail
[**GetHistoricDetailVariableData**](HistoryApi.md#gethistoricdetailvariabledata) | **GET** /history/historic-detail/{detailId}/data | Get the binary data for a historic detail variable
[**GetHistoricInstanceVariableData**](HistoryApi.md#gethistoricinstancevariabledata) | **GET** /history/historic-variable-instances/{varInstanceId}/data | Get the binary data for a historic task instance variable
[**GetHistoricProcessInstance**](HistoryApi.md#gethistoricprocessinstance) | **GET** /history/historic-process-instances/{processInstanceId} | Get a historic process instance
[**GetHistoricProcessInstanceVariableData**](HistoryApi.md#gethistoricprocessinstancevariabledata) | **GET** /history/historic-process-instances/{processInstanceId}/variables/{variableName}/data | Get the binary data for a historic process instance variable
[**GetHistoricTaskInstanceVariableData**](HistoryApi.md#gethistorictaskinstancevariabledata) | **GET** /history/historic-task-instances/{taskId}/variables/{variableName}/data | Get the binary data for a historic task instance variable
[**GetHistoricVariableInstances**](HistoryApi.md#gethistoricvariableinstances) | **GET** /history/historic-variable-instances | List of historic variable instances
[**GetProcessIdentityLinks**](HistoryApi.md#getprocessidentitylinks) | **GET** /history/historic-process-instances/{processInstanceId}/identitylinks | Get the identity links of a historic process instance
[**GetTaskIdentityLinks**](HistoryApi.md#gettaskidentitylinks) | **GET** /history/historic-task-instances/{taskId}/identitylinks | Get the identity links of a historic task instance
[**GetTaskInstance**](HistoryApi.md#gettaskinstance) | **GET** /history/historic-task-instances/{taskId} | Get a single historic task instance
[**ListHistoricProcessInstances**](HistoryApi.md#listhistoricprocessinstances) | **GET** /history/historic-process-instances | List of historic process instances
[**ListHistoricTaskInstances**](HistoryApi.md#listhistorictaskinstances) | **GET** /history/historic-task-instances | Get historic task instances
[**QueryActivityInstances**](HistoryApi.md#queryactivityinstances) | **POST** /query/historic-activity-instances | Query for historic activity instances
[**QueryHistoricDetail**](HistoryApi.md#queryhistoricdetail) | **POST** /query/historic-detail | Query for historic details
[**QueryHistoricProcessInstance**](HistoryApi.md#queryhistoricprocessinstance) | **POST** /query/historic-process-instances | Query for historic process instances
[**QueryHistoricTaskInstance**](HistoryApi.md#queryhistorictaskinstance) | **POST** /query/historic-task-instances | Query for historic task instances
[**QueryVariableInstances**](HistoryApi.md#queryvariableinstances) | **POST** /query/historic-variable-instances | Query for historic variable instances


<a name="createcomment"></a>
# **CreateComment**
> CommentResponse CreateComment (string , CommentResponse body = null)

Create a new comment on a historic process instance

Parameter saveProcessInstanceId is optional, if true save process instance id of task with comment.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCommentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var  = _example;  // string | processInstanceId
            var body = new CommentResponse(); // CommentResponse |  (optional) 

            try
            {
                // Create a new comment on a historic process instance
                CommentResponse result = apiInstance.CreateComment(, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.CreateComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **** | **string**| processInstanceId | 
 **body** | [**CommentResponse**](CommentResponse.md)|  | [optional] 

### Return type

[**CommentResponse**](CommentResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecomment"></a>
# **DeleteComment**
> void DeleteComment (string processInstanceId, string commentId)

Delete a comment on a historic process instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCommentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the historic process instance to delete the comment for.
            var commentId = commentId_example;  // string | The id of the comment.

            try
            {
                // Delete a comment on a historic process instance
                apiInstance.DeleteComment(processInstanceId, commentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.DeleteComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the historic process instance to delete the comment for. | 
 **commentId** | **string**| The id of the comment. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletehitoricprocessinstance"></a>
# **DeleteHitoricProcessInstance**
> void DeleteHitoricProcessInstance (string processInstanceId)

 Delete a historic process instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteHitoricProcessInstanceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var processInstanceId = processInstanceId_example;  // string | 

            try
            {
                //  Delete a historic process instance
                apiInstance.DeleteHitoricProcessInstance(processInstanceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.DeleteHitoricProcessInstance: " + e.Message );
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

<a name="deletetaskinstance"></a>
# **DeleteTaskInstance**
> void DeleteTaskInstance (string taskId)

Delete a historic task instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTaskInstanceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var taskId = taskId_example;  // string | 

            try
            {
                // Delete a historic task instance
                apiInstance.DeleteTaskInstance(taskId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.DeleteTaskInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomment"></a>
# **GetComment**
> CommentResponse GetComment (string processInstanceId, string commentId)

Get a comment on a historic process instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCommentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the historic process instance to get the comment for.
            var commentId = commentId_example;  // string | The id of the comment.

            try
            {
                // Get a comment on a historic process instance
                CommentResponse result = apiInstance.GetComment(processInstanceId, commentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.GetComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the historic process instance to get the comment for. | 
 **commentId** | **string**| The id of the comment. | 

### Return type

[**CommentResponse**](CommentResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomments"></a>
# **GetComments**
> List<CommentResponse> GetComments (string processInstanceId)

Get all comments on a historic process instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCommentsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var processInstanceId = processInstanceId_example;  // string | The id of the process instance to get the comments for.

            try
            {
                // Get all comments on a historic process instance
                List&lt;CommentResponse&gt; result = apiInstance.GetComments(processInstanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.GetComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The id of the process instance to get the comments for. | 

### Return type

[**List<CommentResponse>**](CommentResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricactivityinstances"></a>
# **GetHistoricActivityInstances**
> DataResponse GetHistoricActivityInstances (string activityId = null, string activityInstanceId = null, string activityName = null, string activityType = null, string executionId = null, bool? finished = null, string taskAssignee = null, string processInstanceId = null, string processDefinitionId = null, string tenantId = null, string tenantIdLike = null, bool? withoutTenantId = null)

Get historic activity instances

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHistoricActivityInstancesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var activityId = activityId_example;  // string | An id of the activity instance. (optional) 
            var activityInstanceId = activityInstanceId_example;  // string | An id of the historic activity instance. (optional) 
            var activityName = activityName_example;  // string | The name of the historic activity instance. (optional) 
            var activityType = activityType_example;  // string | The element type of the historic activity instance. (optional) 
            var executionId = executionId_example;  // string | The execution id of the historic activity instance. (optional) 
            var finished = true;  // bool? | Indication if the historic activity instance is finished. (optional) 
            var taskAssignee = taskAssignee_example;  // string | The assignee of the historic activity instance. (optional) 
            var processInstanceId = processInstanceId_example;  // string | The process instance id of the historic activity instance. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | The process definition id of the historic activity instance. (optional) 
            var tenantId = tenantId_example;  // string | Only return instances with the given tenantId. (optional) 
            var tenantIdLike = tenantIdLike_example;  // string | Only return instances with a tenantId like the given value. (optional) 
            var withoutTenantId = true;  // bool? | If true, only returns instances without a tenantId set. If false, the withoutTenantId parameter is ignored. (optional) 

            try
            {
                // Get historic activity instances
                DataResponse result = apiInstance.GetHistoricActivityInstances(activityId, activityInstanceId, activityName, activityType, executionId, finished, taskAssignee, processInstanceId, processDefinitionId, tenantId, tenantIdLike, withoutTenantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.GetHistoricActivityInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityId** | **string**| An id of the activity instance. | [optional] 
 **activityInstanceId** | **string**| An id of the historic activity instance. | [optional] 
 **activityName** | **string**| The name of the historic activity instance. | [optional] 
 **activityType** | **string**| The element type of the historic activity instance. | [optional] 
 **executionId** | **string**| The execution id of the historic activity instance. | [optional] 
 **finished** | **bool?**| Indication if the historic activity instance is finished. | [optional] 
 **taskAssignee** | **string**| The assignee of the historic activity instance. | [optional] 
 **processInstanceId** | **string**| The process instance id of the historic activity instance. | [optional] 
 **processDefinitionId** | **string**| The process definition id of the historic activity instance. | [optional] 
 **tenantId** | **string**| Only return instances with the given tenantId. | [optional] 
 **tenantIdLike** | **string**| Only return instances with a tenantId like the given value. | [optional] 
 **withoutTenantId** | **bool?**| If true, only returns instances without a tenantId set. If false, the withoutTenantId parameter is ignored. | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricdetailinfo"></a>
# **GetHistoricDetailInfo**
> DataResponse GetHistoricDetailInfo (string id = null, string processInstanceId = null, string executionId = null, string activityInstanceId = null, string taskId = null, bool? selectOnlyFormProperties = null, bool? selectOnlyVariableUpdates = null)

Get historic detail

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHistoricDetailInfoExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var id = id_example;  // string | The id of the historic detail. (optional) 
            var processInstanceId = processInstanceId_example;  // string | The process instance id of the historic detail. (optional) 
            var executionId = executionId_example;  // string | The execution id of the historic detail. (optional) 
            var activityInstanceId = activityInstanceId_example;  // string | The activity instance id of the historic detail. (optional) 
            var taskId = taskId_example;  // string | The task id of the historic detail. (optional) 
            var selectOnlyFormProperties = true;  // bool? | Indication to only return form properties in the result. (optional) 
            var selectOnlyVariableUpdates = true;  // bool? | Indication to only return variable updates in the result. (optional) 

            try
            {
                // Get historic detail
                DataResponse result = apiInstance.GetHistoricDetailInfo(id, processInstanceId, executionId, activityInstanceId, taskId, selectOnlyFormProperties, selectOnlyVariableUpdates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.GetHistoricDetailInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the historic detail. | [optional] 
 **processInstanceId** | **string**| The process instance id of the historic detail. | [optional] 
 **executionId** | **string**| The execution id of the historic detail. | [optional] 
 **activityInstanceId** | **string**| The activity instance id of the historic detail. | [optional] 
 **taskId** | **string**| The task id of the historic detail. | [optional] 
 **selectOnlyFormProperties** | **bool?**| Indication to only return form properties in the result. | [optional] 
 **selectOnlyVariableUpdates** | **bool?**| Indication to only return variable updates in the result. | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricdetailvariabledata"></a>
# **GetHistoricDetailVariableData**
> List<byte[]> GetHistoricDetailVariableData (string detailId)

Get the binary data for a historic detail variable

The response body contains the binary value of the variable. When the variable is of type binary, the content-type of the response is set to application/octet-stream, regardless of the content of the variable or the request accept-type header. In case of serializable, application/x-java-serialized-object is used as content-type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHistoricDetailVariableDataExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var detailId = detailId_example;  // string | 

            try
            {
                // Get the binary data for a historic detail variable
                List&lt;byte[]&gt; result = apiInstance.GetHistoricDetailVariableData(detailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.GetHistoricDetailVariableData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **detailId** | **string**|  | 

### Return type

**List<byte[]>**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricinstancevariabledata"></a>
# **GetHistoricInstanceVariableData**
> List<byte[]> GetHistoricInstanceVariableData (string varInstanceId)

Get the binary data for a historic task instance variable

The response body contains the binary value of the variable. When the variable is of type binary, the content-type of the response is set to application/octet-stream, regardless of the content of the variable or the request accept-type header. In case of serializable, application/x-java-serialized-object is used as content-type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHistoricInstanceVariableDataExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var varInstanceId = varInstanceId_example;  // string | 

            try
            {
                // Get the binary data for a historic task instance variable
                List&lt;byte[]&gt; result = apiInstance.GetHistoricInstanceVariableData(varInstanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.GetHistoricInstanceVariableData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **varInstanceId** | **string**|  | 

### Return type

**List<byte[]>**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricprocessinstance"></a>
# **GetHistoricProcessInstance**
> HistoricProcessInstanceResponse GetHistoricProcessInstance (string processInstanceId)

Get a historic process instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHistoricProcessInstanceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var processInstanceId = processInstanceId_example;  // string | 

            try
            {
                // Get a historic process instance
                HistoricProcessInstanceResponse result = apiInstance.GetHistoricProcessInstance(processInstanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.GetHistoricProcessInstance: " + e.Message );
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

[**HistoricProcessInstanceResponse**](HistoricProcessInstanceResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricprocessinstancevariabledata"></a>
# **GetHistoricProcessInstanceVariableData**
> List<byte[]> GetHistoricProcessInstanceVariableData (string processInstanceId, string variableName)

Get the binary data for a historic process instance variable

The response body contains the binary value of the variable. When the variable is of type binary, the content-type of the response is set to application/octet-stream, regardless of the content of the variable or the request accept-type header. In case of serializable, application/x-java-serialized-object is used as content-type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHistoricProcessInstanceVariableDataExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var processInstanceId = processInstanceId_example;  // string | 
            var variableName = variableName_example;  // string | 

            try
            {
                // Get the binary data for a historic process instance variable
                List&lt;byte[]&gt; result = apiInstance.GetHistoricProcessInstanceVariableData(processInstanceId, variableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.GetHistoricProcessInstanceVariableData: " + e.Message );
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

### Return type

**List<byte[]>**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistorictaskinstancevariabledata"></a>
# **GetHistoricTaskInstanceVariableData**
> List<byte[]> GetHistoricTaskInstanceVariableData (string taskId, string variableName, string scope = null)

Get the binary data for a historic task instance variable

The response body contains the binary value of the variable. When the variable is of type binary, the content-type of the response is set to application/octet-stream, regardless of the content of the variable or the request accept-type header. In case of serializable, application/x-java-serialized-object is used as content-type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHistoricTaskInstanceVariableDataExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var taskId = taskId_example;  // string | 
            var variableName = variableName_example;  // string | 
            var scope = scope_example;  // string |  (optional) 

            try
            {
                // Get the binary data for a historic task instance variable
                List&lt;byte[]&gt; result = apiInstance.GetHistoricTaskInstanceVariableData(taskId, variableName, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.GetHistoricTaskInstanceVariableData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**|  | 
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

<a name="gethistoricvariableinstances"></a>
# **GetHistoricVariableInstances**
> DataResponse GetHistoricVariableInstances (string processInstanceId = null, string taskId = null, bool? excludeTaskVariables = null, string variableName = null, string variableNameLike = null)

List of historic variable instances

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHistoricVariableInstancesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var processInstanceId = processInstanceId_example;  // string | The process instance id of the historic variable instance. (optional) 
            var taskId = taskId_example;  // string | The task id of the historic variable instance. (optional) 
            var excludeTaskVariables = true;  // bool? | Indication to exclude the task variables from the result. (optional) 
            var variableName = variableName_example;  // string | The variable name of the historic variable instance. (optional) 
            var variableNameLike = variableNameLike_example;  // string | The variable name using the like operator for the historic variable instance. (optional) 

            try
            {
                // List of historic variable instances
                DataResponse result = apiInstance.GetHistoricVariableInstances(processInstanceId, taskId, excludeTaskVariables, variableName, variableNameLike);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.GetHistoricVariableInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| The process instance id of the historic variable instance. | [optional] 
 **taskId** | **string**| The task id of the historic variable instance. | [optional] 
 **excludeTaskVariables** | **bool?**| Indication to exclude the task variables from the result. | [optional] 
 **variableName** | **string**| The variable name of the historic variable instance. | [optional] 
 **variableNameLike** | **string**| The variable name using the like operator for the historic variable instance. | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessidentitylinks"></a>
# **GetProcessIdentityLinks**
> List<HistoricIdentityLinkResponse> GetProcessIdentityLinks (string processInstanceId)

Get the identity links of a historic process instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessIdentityLinksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var processInstanceId = processInstanceId_example;  // string | 

            try
            {
                // Get the identity links of a historic process instance
                List&lt;HistoricIdentityLinkResponse&gt; result = apiInstance.GetProcessIdentityLinks(processInstanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.GetProcessIdentityLinks: " + e.Message );
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

[**List<HistoricIdentityLinkResponse>**](HistoricIdentityLinkResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskidentitylinks"></a>
# **GetTaskIdentityLinks**
> List<HistoricIdentityLinkResponse> GetTaskIdentityLinks (string taskId)

Get the identity links of a historic task instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaskIdentityLinksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var taskId = taskId_example;  // string | 

            try
            {
                // Get the identity links of a historic task instance
                List&lt;HistoricIdentityLinkResponse&gt; result = apiInstance.GetTaskIdentityLinks(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.GetTaskIdentityLinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**|  | 

### Return type

[**List<HistoricIdentityLinkResponse>**](HistoricIdentityLinkResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskinstance"></a>
# **GetTaskInstance**
> HistoricTaskInstanceResponse GetTaskInstance (string taskId)

Get a single historic task instance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaskInstanceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var taskId = taskId_example;  // string | 

            try
            {
                // Get a single historic task instance
                HistoricTaskInstanceResponse result = apiInstance.GetTaskInstance(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.GetTaskInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**|  | 

### Return type

[**HistoricTaskInstanceResponse**](HistoricTaskInstanceResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listhistoricprocessinstances"></a>
# **ListHistoricProcessInstances**
> DataResponse ListHistoricProcessInstances (string processInstanceId = null, string processDefinitionKey = null, string processDefinitionId = null, string businessKey = null, string involvedUser = null, bool? finished = null, string superProcessInstanceId = null, bool? excludeSubprocesses = null, string finishedAfter = null, string finishedBefore = null, string startedAfter = null, string startedBefore = null, string startedBy = null, bool? includeProcessVariables = null, string tenantId = null, string tenantIdLike = null, bool? withoutTenantId = null)

List of historic process instances

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListHistoricProcessInstancesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var processInstanceId = processInstanceId_example;  // string | An id of the historic process instance. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | The process definition key of the historic process instance. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | The process definition id of the historic process instance. (optional) 
            var businessKey = businessKey_example;  // string | The business key of the historic process instance. (optional) 
            var involvedUser = involvedUser_example;  // string | An involved user of the historic process instance. (optional) 
            var finished = true;  // bool? | Indication if the historic process instance is finished. (optional) 
            var superProcessInstanceId = superProcessInstanceId_example;  // string | An optional parent process id of the historic process instance. (optional) 
            var excludeSubprocesses = true;  // bool? | Return only historic process instances which aren�t sub processes. (optional) 
            var finishedAfter = finishedAfter_example;  // string | Return only historic process instances that were finished after this date. (optional) 
            var finishedBefore = finishedBefore_example;  // string | Return only historic process instances that were finished before this date. (optional) 
            var startedAfter = startedAfter_example;  // string | Return only historic process instances that were started after this date. (optional) 
            var startedBefore = startedBefore_example;  // string | Return only historic process instances that were started before this date. (optional) 
            var startedBy = startedBy_example;  // string | Return only historic process instances that were started by this user. (optional) 
            var includeProcessVariables = true;  // bool? | An indication if the historic process instance variables should be returned as well. (optional) 
            var tenantId = tenantId_example;  // string | Only return instances with the given tenantId. (optional) 
            var tenantIdLike = tenantIdLike_example;  // string | Only return instances with a tenantId like the given value. (optional) 
            var withoutTenantId = true;  // bool? | If true, only returns instances without a tenantId set. If false, the withoutTenantId parameter is ignored.  (optional) 

            try
            {
                // List of historic process instances
                DataResponse result = apiInstance.ListHistoricProcessInstances(processInstanceId, processDefinitionKey, processDefinitionId, businessKey, involvedUser, finished, superProcessInstanceId, excludeSubprocesses, finishedAfter, finishedBefore, startedAfter, startedBefore, startedBy, includeProcessVariables, tenantId, tenantIdLike, withoutTenantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.ListHistoricProcessInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processInstanceId** | **string**| An id of the historic process instance. | [optional] 
 **processDefinitionKey** | **string**| The process definition key of the historic process instance. | [optional] 
 **processDefinitionId** | **string**| The process definition id of the historic process instance. | [optional] 
 **businessKey** | **string**| The business key of the historic process instance. | [optional] 
 **involvedUser** | **string**| An involved user of the historic process instance. | [optional] 
 **finished** | **bool?**| Indication if the historic process instance is finished. | [optional] 
 **superProcessInstanceId** | **string**| An optional parent process id of the historic process instance. | [optional] 
 **excludeSubprocesses** | **bool?**| Return only historic process instances which aren�t sub processes. | [optional] 
 **finishedAfter** | **string**| Return only historic process instances that were finished after this date. | [optional] 
 **finishedBefore** | **string**| Return only historic process instances that were finished before this date. | [optional] 
 **startedAfter** | **string**| Return only historic process instances that were started after this date. | [optional] 
 **startedBefore** | **string**| Return only historic process instances that were started before this date. | [optional] 
 **startedBy** | **string**| Return only historic process instances that were started by this user. | [optional] 
 **includeProcessVariables** | **bool?**| An indication if the historic process instance variables should be returned as well. | [optional] 
 **tenantId** | **string**| Only return instances with the given tenantId. | [optional] 
 **tenantIdLike** | **string**| Only return instances with a tenantId like the given value. | [optional] 
 **withoutTenantId** | **bool?**| If true, only returns instances without a tenantId set. If false, the withoutTenantId parameter is ignored.  | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listhistorictaskinstances"></a>
# **ListHistoricTaskInstances**
> DataResponse ListHistoricTaskInstances (string taskId = null, string processInstanceId = null, string processDefinitionKey = null, string processDefinitionKeyLike = null, string processDefinitionId = null, string processDefinitionName = null, string processDefinitionNameLike = null, string processBusinessKey = null, string processBusinessKeyLike = null, string executionId = null, string taskDefinitionKey = null, string taskName = null, string taskNameLike = null, string taskDescription = null, string taskDescriptionLike = null, string taskCategory = null, string taskDeleteReason = null, string taskDeleteReasonLike = null, string taskAssignee = null, string taskAssigneeLike = null, string taskOwner = null, string taskOwnerLike = null, string taskInvolvedUser = null, string taskPriority = null, bool? finished = null, bool? processFinished = null, string parentTaskId = null, string dueDate = null, string dueDateAfter = null, string dueDateBefore = null, bool? withoutDueDate = null, string taskCompletedOn = null, string taskCompletedAfter = null, string taskCompletedBefore = null, string taskCreatedOn = null, string taskCreatedBefore = null, string taskCreatedAfter = null, bool? includeTaskLocalVariables = null, bool? includeProcessVariables = null, string tenantId = null, string tenantIdLike = null, bool? withoutTenantId = null)

Get historic task instances

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListHistoricTaskInstancesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var taskId = taskId_example;  // string | An id of the historic task instance. (optional) 
            var processInstanceId = processInstanceId_example;  // string | The process instance id of the historic task instance. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | The process definition key of the historic task instance. (optional) 
            var processDefinitionKeyLike = processDefinitionKeyLike_example;  // string | The process definition key of the historic task instance, which matches the given value. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | The process definition id of the historic task instance. (optional) 
            var processDefinitionName = processDefinitionName_example;  // string | The process definition name of the historic task instance. (optional) 
            var processDefinitionNameLike = processDefinitionNameLike_example;  // string | The process definition name of the historic task instance, which matches the given value. (optional) 
            var processBusinessKey = processBusinessKey_example;  // string | The process instance business key of the historic task instance. (optional) 
            var processBusinessKeyLike = processBusinessKeyLike_example;  // string | The process instance business key of the historic task instance that matches the given value. (optional) 
            var executionId = executionId_example;  // string | The execution id of the historic task instance. (optional) 
            var taskDefinitionKey = taskDefinitionKey_example;  // string | The task definition key for tasks part of a process (optional) 
            var taskName = taskName_example;  // string | The task name of the historic task instance. (optional) 
            var taskNameLike = taskNameLike_example;  // string | The task name with like operator for the historic task instance. (optional) 
            var taskDescription = taskDescription_example;  // string | The task description of the historic task instance. (optional) 
            var taskDescriptionLike = taskDescriptionLike_example;  // string | The task description with like operator for the historic task instance. (optional) 
            var taskCategory = taskCategory_example;  // string | Select tasks with the given category. Note that this is the task category, not the category of the process definition (namespace within the BPMN Xml). (optional) 
            var taskDeleteReason = taskDeleteReason_example;  // string | The task delete reason of the historic task instance. (optional) 
            var taskDeleteReasonLike = taskDeleteReasonLike_example;  // string | The task delete reason with like operator for the historic task instance. (optional) 
            var taskAssignee = taskAssignee_example;  // string | The assignee of the historic task instance. (optional) 
            var taskAssigneeLike = taskAssigneeLike_example;  // string | The assignee with like operator for the historic task instance. (optional) 
            var taskOwner = taskOwner_example;  // string | The owner of the historic task instance. (optional) 
            var taskOwnerLike = taskOwnerLike_example;  // string | The owner with like operator for the historic task instance. (optional) 
            var taskInvolvedUser = taskInvolvedUser_example;  // string | An involved user of the historic task instance (optional) 
            var taskPriority = taskPriority_example;  // string | The priority of the historic task instance. (optional) 
            var finished = true;  // bool? | Indication if the historic task instance is finished. (optional) 
            var processFinished = true;  // bool? | Indication if the process instance of the historic task instance is finished. (optional) 
            var parentTaskId = parentTaskId_example;  // string | An optional parent task id of the historic task instance. (optional) 
            var dueDate = dueDate_example;  // string | Return only historic task instances that have a due date equal this date. (optional) 
            var dueDateAfter = dueDateAfter_example;  // string | Return only historic task instances that have a due date after this date. (optional) 
            var dueDateBefore = dueDateBefore_example;  // string | Return only historic task instances that have a due date before this date. (optional) 
            var withoutDueDate = true;  // bool? | Return only historic task instances that have no due-date. When false is provided as value, this parameter is ignored. (optional) 
            var taskCompletedOn = taskCompletedOn_example;  // string | Return only historic task instances that have been completed on this date. (optional) 
            var taskCompletedAfter = taskCompletedAfter_example;  // string | Return only historic task instances that have been completed after this date. (optional) 
            var taskCompletedBefore = taskCompletedBefore_example;  // string | Return only historic task instances that have been completed before this date. (optional) 
            var taskCreatedOn = taskCreatedOn_example;  // string | Return only historic task instances that were created on this date. (optional) 
            var taskCreatedBefore = taskCreatedBefore_example;  // string | Return only historic task instances that were created before this date. (optional) 
            var taskCreatedAfter = taskCreatedAfter_example;  // string | Return only historic task instances that were created after this date. (optional) 
            var includeTaskLocalVariables = true;  // bool? | An indication if the historic task instance local variables should be returned as well. (optional) 
            var includeProcessVariables = true;  // bool? | An indication if the historic task instance global variables should be returned as well. (optional) 
            var tenantId = tenantId_example;  // string | Only return historic task instances with the given tenantId. (optional) 
            var tenantIdLike = tenantIdLike_example;  // string | Only return historic task instances with a tenantId like the given value. (optional) 
            var withoutTenantId = true;  // bool? | If true, only returns historic task instances without a tenantId set. If false, the withoutTenantId parameter is ignored. (optional) 

            try
            {
                // Get historic task instances
                DataResponse result = apiInstance.ListHistoricTaskInstances(taskId, processInstanceId, processDefinitionKey, processDefinitionKeyLike, processDefinitionId, processDefinitionName, processDefinitionNameLike, processBusinessKey, processBusinessKeyLike, executionId, taskDefinitionKey, taskName, taskNameLike, taskDescription, taskDescriptionLike, taskCategory, taskDeleteReason, taskDeleteReasonLike, taskAssignee, taskAssigneeLike, taskOwner, taskOwnerLike, taskInvolvedUser, taskPriority, finished, processFinished, parentTaskId, dueDate, dueDateAfter, dueDateBefore, withoutDueDate, taskCompletedOn, taskCompletedAfter, taskCompletedBefore, taskCreatedOn, taskCreatedBefore, taskCreatedAfter, includeTaskLocalVariables, includeProcessVariables, tenantId, tenantIdLike, withoutTenantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.ListHistoricTaskInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| An id of the historic task instance. | [optional] 
 **processInstanceId** | **string**| The process instance id of the historic task instance. | [optional] 
 **processDefinitionKey** | **string**| The process definition key of the historic task instance. | [optional] 
 **processDefinitionKeyLike** | **string**| The process definition key of the historic task instance, which matches the given value. | [optional] 
 **processDefinitionId** | **string**| The process definition id of the historic task instance. | [optional] 
 **processDefinitionName** | **string**| The process definition name of the historic task instance. | [optional] 
 **processDefinitionNameLike** | **string**| The process definition name of the historic task instance, which matches the given value. | [optional] 
 **processBusinessKey** | **string**| The process instance business key of the historic task instance. | [optional] 
 **processBusinessKeyLike** | **string**| The process instance business key of the historic task instance that matches the given value. | [optional] 
 **executionId** | **string**| The execution id of the historic task instance. | [optional] 
 **taskDefinitionKey** | **string**| The task definition key for tasks part of a process | [optional] 
 **taskName** | **string**| The task name of the historic task instance. | [optional] 
 **taskNameLike** | **string**| The task name with like operator for the historic task instance. | [optional] 
 **taskDescription** | **string**| The task description of the historic task instance. | [optional] 
 **taskDescriptionLike** | **string**| The task description with like operator for the historic task instance. | [optional] 
 **taskCategory** | **string**| Select tasks with the given category. Note that this is the task category, not the category of the process definition (namespace within the BPMN Xml). | [optional] 
 **taskDeleteReason** | **string**| The task delete reason of the historic task instance. | [optional] 
 **taskDeleteReasonLike** | **string**| The task delete reason with like operator for the historic task instance. | [optional] 
 **taskAssignee** | **string**| The assignee of the historic task instance. | [optional] 
 **taskAssigneeLike** | **string**| The assignee with like operator for the historic task instance. | [optional] 
 **taskOwner** | **string**| The owner of the historic task instance. | [optional] 
 **taskOwnerLike** | **string**| The owner with like operator for the historic task instance. | [optional] 
 **taskInvolvedUser** | **string**| An involved user of the historic task instance | [optional] 
 **taskPriority** | **string**| The priority of the historic task instance. | [optional] 
 **finished** | **bool?**| Indication if the historic task instance is finished. | [optional] 
 **processFinished** | **bool?**| Indication if the process instance of the historic task instance is finished. | [optional] 
 **parentTaskId** | **string**| An optional parent task id of the historic task instance. | [optional] 
 **dueDate** | **string**| Return only historic task instances that have a due date equal this date. | [optional] 
 **dueDateAfter** | **string**| Return only historic task instances that have a due date after this date. | [optional] 
 **dueDateBefore** | **string**| Return only historic task instances that have a due date before this date. | [optional] 
 **withoutDueDate** | **bool?**| Return only historic task instances that have no due-date. When false is provided as value, this parameter is ignored. | [optional] 
 **taskCompletedOn** | **string**| Return only historic task instances that have been completed on this date. | [optional] 
 **taskCompletedAfter** | **string**| Return only historic task instances that have been completed after this date. | [optional] 
 **taskCompletedBefore** | **string**| Return only historic task instances that have been completed before this date. | [optional] 
 **taskCreatedOn** | **string**| Return only historic task instances that were created on this date. | [optional] 
 **taskCreatedBefore** | **string**| Return only historic task instances that were created before this date. | [optional] 
 **taskCreatedAfter** | **string**| Return only historic task instances that were created after this date. | [optional] 
 **includeTaskLocalVariables** | **bool?**| An indication if the historic task instance local variables should be returned as well. | [optional] 
 **includeProcessVariables** | **bool?**| An indication if the historic task instance global variables should be returned as well. | [optional] 
 **tenantId** | **string**| Only return historic task instances with the given tenantId. | [optional] 
 **tenantIdLike** | **string**| Only return historic task instances with a tenantId like the given value. | [optional] 
 **withoutTenantId** | **bool?**| If true, only returns historic task instances without a tenantId set. If false, the withoutTenantId parameter is ignored. | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryactivityinstances"></a>
# **QueryActivityInstances**
> DataResponse QueryActivityInstances (HistoricActivityInstanceQueryRequest body = null)

Query for historic activity instances

All supported JSON parameter fields allowed are exactly the same as the parameters found for getting a collection of historic task instances, but passed in as JSON-body arguments rather than URL-parameters to allow for more advanced querying and preventing errors with request-uri�s that are too long.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QueryActivityInstancesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var body = new HistoricActivityInstanceQueryRequest(); // HistoricActivityInstanceQueryRequest |  (optional) 

            try
            {
                // Query for historic activity instances
                DataResponse result = apiInstance.QueryActivityInstances(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.QueryActivityInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HistoricActivityInstanceQueryRequest**](HistoricActivityInstanceQueryRequest.md)|  | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryhistoricdetail"></a>
# **QueryHistoricDetail**
> DataResponse QueryHistoricDetail (HistoricDetailQueryRequest body = null)

Query for historic details

All supported JSON parameter fields allowed are exactly the same as the parameters found for getting a collection of historic process instances, but passed in as JSON-body arguments rather than URL-parameters to allow for more advanced querying and preventing errors with request-uri�s that are too long.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QueryHistoricDetailExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var body = new HistoricDetailQueryRequest(); // HistoricDetailQueryRequest |  (optional) 

            try
            {
                // Query for historic details
                DataResponse result = apiInstance.QueryHistoricDetail(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.QueryHistoricDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HistoricDetailQueryRequest**](HistoricDetailQueryRequest.md)|  | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryhistoricprocessinstance"></a>
# **QueryHistoricProcessInstance**
> DataResponse QueryHistoricProcessInstance (HistoricProcessInstanceQueryRequest body = null)

Query for historic process instances

All supported JSON parameter fields allowed are exactly the same as the parameters found for getting a collection of historic process instances, but passed in as JSON-body arguments rather than URL-parameters to allow for more advanced querying and preventing errors with request-uri�s that are too long. On top of that, the query allows for filtering based on process variables. The variables property is a JSON-array containing objects with the format as described here.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QueryHistoricProcessInstanceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var body = new HistoricProcessInstanceQueryRequest(); // HistoricProcessInstanceQueryRequest |  (optional) 

            try
            {
                // Query for historic process instances
                DataResponse result = apiInstance.QueryHistoricProcessInstance(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.QueryHistoricProcessInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HistoricProcessInstanceQueryRequest**](HistoricProcessInstanceQueryRequest.md)|  | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryhistorictaskinstance"></a>
# **QueryHistoricTaskInstance**
> DataResponse QueryHistoricTaskInstance (HistoricTaskInstanceQueryRequest body = null)

Query for historic task instances

All supported JSON parameter fields allowed are exactly the same as the parameters found for getting a collection of historic task instances, but passed in as JSON-body arguments rather than URL-parameters to allow for more advanced querying and preventing errors with request-uri�s that are too long. On top of that, the query allows for filtering based on process variables. The taskVariables and processVariables properties are JSON-arrays containing objects with the format as described here.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QueryHistoricTaskInstanceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var body = new HistoricTaskInstanceQueryRequest(); // HistoricTaskInstanceQueryRequest |  (optional) 

            try
            {
                // Query for historic task instances
                DataResponse result = apiInstance.QueryHistoricTaskInstance(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.QueryHistoricTaskInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HistoricTaskInstanceQueryRequest**](HistoricTaskInstanceQueryRequest.md)|  | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryvariableinstances"></a>
# **QueryVariableInstances**
> DataResponse QueryVariableInstances (HistoricVariableInstanceQueryRequest body = null)

Query for historic variable instances

All supported JSON parameter fields allowed are exactly the same as the parameters found for getting a collection of historic process instances, but passed in as JSON-body arguments rather than URL-parameters to allow for more advanced querying and preventing errors with request-uri�s that are too long. On top of that, the query allows for filtering based on process variables. The variables property is a JSON-array containing objects with the format as described here.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QueryVariableInstancesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new HistoryApi();
            var body = new HistoricVariableInstanceQueryRequest(); // HistoricVariableInstanceQueryRequest |  (optional) 

            try
            {
                // Query for historic variable instances
                DataResponse result = apiInstance.QueryVariableInstances(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.QueryVariableInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HistoricVariableInstanceQueryRequest**](HistoricVariableInstanceQueryRequest.md)|  | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

