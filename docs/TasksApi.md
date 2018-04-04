# IO.Swagger.Api.TasksApi

All URIs are relative to *http://localhost:8080/activiti-rest/service*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAttachment**](TasksApi.md#createattachment) | **POST** /runtime/tasks/{taskId}/attachments | Create a new attachment on a task, containing a link to an external resource or an attached file
[**CreateTask**](TasksApi.md#createtask) | **POST** /runtime/tasks | Create Task
[**CreateTaskComments**](TasksApi.md#createtaskcomments) | **POST** /runtime/tasks/{taskId}/comments | Create a new comment on a task
[**CreateTaskInstanceIdentityLinks**](TasksApi.md#createtaskinstanceidentitylinks) | **POST** /runtime/tasks/{taskId}/identitylinks | Create an identity link on a task
[**CreateTaskVariable**](TasksApi.md#createtaskvariable) | **POST** /runtime/tasks/{taskId}/variables | Create new variables on a task
[**DeleteAllLocalTaskVariables**](TasksApi.md#deletealllocaltaskvariables) | **DELETE** /runtime/tasks/{taskId}/variables | Delete all local variables on a task
[**DeleteAttachment**](TasksApi.md#deleteattachment) | **DELETE** /runtime/tasks/{taskId}/attachments/{attachmentId} | Delete an attachment on a task
[**DeleteEvent**](TasksApi.md#deleteevent) | **DELETE** /runtime/tasks/{taskId}/events/{eventId} | Delete an event on a task
[**DeleteTask**](TasksApi.md#deletetask) | **DELETE** /runtime/tasks/{taskId} | Delete a task
[**DeleteTaskComment**](TasksApi.md#deletetaskcomment) | **DELETE** /runtime/tasks/{taskId}/comments/{commentId} | Delete a comment on a task
[**DeleteTaskInstanceIdentityLinks**](TasksApi.md#deletetaskinstanceidentitylinks) | **DELETE** /runtime/tasks/{taskId}/identitylinks/{family}/{identityId}/{type} | Delete an identity link on a task
[**DeleteTaskInstanceVariable**](TasksApi.md#deletetaskinstancevariable) | **DELETE** /runtime/tasks/{taskId}/variables/{variableName} | Delete a variable on a task
[**ExecuteTaskAction**](TasksApi.md#executetaskaction) | **POST** /runtime/tasks/{taskId} | Tasks actions
[**GeTaskVariableData**](TasksApi.md#getaskvariabledata) | **GET** /runtime/tasks/{taskId}/variables/{variableName}/data | Get the binary data for a variable
[**GetAttachment**](TasksApi.md#getattachment) | **GET** /runtime/tasks/{taskId}/attachments/{attachmentId} | Get an attachment on a task
[**GetAttachmentContent**](TasksApi.md#getattachmentcontent) | **GET** /runtime/tasks/{taskId}/attachments/{attachmentId}/content | Get the content for an attachment
[**GetAttachments**](TasksApi.md#getattachments) | **GET** /runtime/tasks/{taskId}/attachments | Get all attachments on a task
[**GetEvent**](TasksApi.md#getevent) | **GET** /runtime/tasks/{taskId}/events/{eventId} | Get an event on a task
[**GetEvents**](TasksApi.md#getevents) | **GET** /runtime/tasks/{taskId}/events | Get all events for a task
[**GetIdentityLinksForFamily**](TasksApi.md#getidentitylinksforfamily) | **GET** /runtime/tasks/{taskId}/identitylinks/{family} | Get all identitylinks for a task for either groups or users
[**GetQueryResult**](TasksApi.md#getqueryresult) | **POST** /query/tasks | Query for tasks
[**GetSubTasks**](TasksApi.md#getsubtasks) | **GET** /runtime/tasks/{taskId}/subtasks | Get list of sub tasks for a task
[**GetTask**](TasksApi.md#gettask) | **GET** /runtime/tasks/{taskId} | Get a task
[**GetTaskComment**](TasksApi.md#gettaskcomment) | **GET** /runtime/tasks/{taskId}/comments/{commentId} |  Get a comment on a task
[**GetTaskInstanceIdentityLinks**](TasksApi.md#gettaskinstanceidentitylinks) | **GET** /runtime/tasks/{taskId}/identitylinks/{family}/{identityId}/{type} | Get a single identity link on a task
[**GetTaskInstanceVariable**](TasksApi.md#gettaskinstancevariable) | **GET** /runtime/tasks/{taskId}/variables/{variableName} | Get a variable from a task
[**GetTasks**](TasksApi.md#gettasks) | **GET** /runtime/tasks | List of tasks
[**ListTaskComments**](TasksApi.md#listtaskcomments) | **GET** /runtime/tasks/{taskId}/comments | Get all comments on a task
[**ListTaskVariables**](TasksApi.md#listtaskvariables) | **GET** /runtime/tasks/{taskId}/variables | Get all variables for a task
[**ListTasksInstanceIdentityLinks**](TasksApi.md#listtasksinstanceidentitylinks) | **GET** /runtime/tasks/{taskId}/identitylinks | Get all identity links for a task
[**UpdateTask**](TasksApi.md#updatetask) | **PUT** /runtime/tasks/{taskId} | Update a task
[**UpdateTaskInstanceVariable**](TasksApi.md#updatetaskinstancevariable) | **PUT** /runtime/tasks/{taskId}/variables/{variableName} | Update an existing variable on a task


<a name="createattachment"></a>
# **CreateAttachment**
> AttachmentResponse CreateAttachment (string taskId)

Create a new attachment on a task, containing a link to an external resource or an attached file

## Create a new attachment on a task, containing a link to an external resource   ```JSON {   \"name\":\"Simple attachment\",   \"description\":\"Simple attachment description\",   \"type\":\"simpleType\",   \"externalUrl\":\"http://activiti.org\" } ```   Only the attachment name is required to create a new attachment.    ## Create a new attachment on a task, with an attached file  The request should be of type multipart/form-data. There should be a single file-part included with the binary value of the variable. On top of that, the following additional form-fields can be present:  - *name*: Required name of the variable.  - *description*: Description of the attachment, optional.  - *type*: Type of attachment, optional. Supports any arbitrary string or a valid HTTP content-type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAttachmentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to create the attachment for.

            try
            {
                // Create a new attachment on a task, containing a link to an external resource or an attached file
                AttachmentResponse result = apiInstance.CreateAttachment(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.CreateAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to create the attachment for. | 

### Return type

[**AttachmentResponse**](AttachmentResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtask"></a>
# **CreateTask**
> TaskResponse CreateTask (TaskRequest body = null)

Create Task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTaskExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var body = new TaskRequest(); // TaskRequest |  (optional) 

            try
            {
                // Create Task
                TaskResponse result = apiInstance.CreateTask(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.CreateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TaskRequest**](TaskRequest.md)|  | [optional] 

### Return type

[**TaskResponse**](TaskResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtaskcomments"></a>
# **CreateTaskComments**
> CommentResponse CreateTaskComments (string taskId, CommentRequest body = null)

Create a new comment on a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTaskCommentsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to create the comment for.
            var body = new CommentRequest(); // CommentRequest |  (optional) 

            try
            {
                // Create a new comment on a task
                CommentResponse result = apiInstance.CreateTaskComments(taskId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.CreateTaskComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to create the comment for. | 
 **body** | [**CommentRequest**](CommentRequest.md)|  | [optional] 

### Return type

[**CommentResponse**](CommentResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtaskinstanceidentitylinks"></a>
# **CreateTaskInstanceIdentityLinks**
> RestIdentityLink CreateTaskInstanceIdentityLinks (string taskId, RestIdentityLink body = null)

Create an identity link on a task

## Request body (user)   ```JSON {   \"userId\" : \"kermit\",   \"type\" : \"candidate\", } ```   ## Request body (group)   ```JSON {   \"groupId\" : \"sales\",   \"type\" : \"candidate\", } ```   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTaskInstanceIdentityLinksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task .
            var body = new RestIdentityLink(); // RestIdentityLink |  (optional) 

            try
            {
                // Create an identity link on a task
                RestIdentityLink result = apiInstance.CreateTaskInstanceIdentityLinks(taskId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.CreateTaskInstanceIdentityLinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task . | 
 **body** | [**RestIdentityLink**](RestIdentityLink.md)|  | [optional] 

### Return type

[**RestIdentityLink**](RestIdentityLink.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtaskvariable"></a>
# **CreateTaskVariable**
> Object CreateTaskVariable (string taskId)

Create new variables on a task

## Request body for creating simple (non-binary) variables   ```JSON [   {     \"name\" : \"myTaskVariable\",     \"scope\" : \"local\",     \"type\" : \"string\",     \"value\" : \"Hello my friend\"   },   {    } ] ```   The request body should be an array containing one or more JSON-objects representing the variables that should be created.  - *name*: Required name of the variable  scope: Scope of variable that is created. If omitted, local is assumed.  - *type*: Type of variable that is created. If omitted, reverts to raw JSON-value type (string, boolean, integer or double).  - *value*: Variable value.  More information about the variable format can be found in the REST variables section.   ## Request body for Creating a new binary variable  The request should be of type multipart/form-data. There should be a single file-part included with the binary value of the variable. On top of that, the following additional form-fields can be present:  - *name*: Required name of the variable.  scope: Scope of variable that is created. If omitted, local is assumed.  - *type*: Type of variable that is created. If omitted, binary is assumed and the binary data in the request will be stored as an array of bytes.   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTaskVariableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to create the new variable for.

            try
            {
                // Create new variables on a task
                Object result = apiInstance.CreateTaskVariable(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.CreateTaskVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to create the new variable for. | 

### Return type

**Object**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletealllocaltaskvariables"></a>
# **DeleteAllLocalTaskVariables**
> void DeleteAllLocalTaskVariables (string taskId)

Delete all local variables on a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAllLocalTaskVariablesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task the variable to delete belongs to.

            try
            {
                // Delete all local variables on a task
                apiInstance.DeleteAllLocalTaskVariables(taskId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteAllLocalTaskVariables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task the variable to delete belongs to. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteattachment"></a>
# **DeleteAttachment**
> void DeleteAttachment (string taskId, string attachmentId)

Delete an attachment on a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAttachmentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to delete the attachment for.
            var attachmentId = attachmentId_example;  // string | The id of the attachment.

            try
            {
                // Delete an attachment on a task
                apiInstance.DeleteAttachment(taskId, attachmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to delete the attachment for. | 
 **attachmentId** | **string**| The id of the attachment. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteevent"></a>
# **DeleteEvent**
> void DeleteEvent (string taskId, string eventId)

Delete an event on a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteEventExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | 
            var eventId = eventId_example;  // string | 

            try
            {
                // Delete an event on a task
                apiInstance.DeleteEvent(taskId, eventId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**|  | 
 **eventId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetask"></a>
# **DeleteTask**
> void DeleteTask (string taskId)

Delete a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTaskExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to delete.

            try
            {
                // Delete a task
                apiInstance.DeleteTask(taskId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to delete. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetaskcomment"></a>
# **DeleteTaskComment**
> void DeleteTaskComment (string taskId, string commentId)

Delete a comment on a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTaskCommentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to delete the comment for.
            var commentId = commentId_example;  // string | The id of the comment.

            try
            {
                // Delete a comment on a task
                apiInstance.DeleteTaskComment(taskId, commentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteTaskComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to delete the comment for. | 
 **commentId** | **string**| The id of the comment. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetaskinstanceidentitylinks"></a>
# **DeleteTaskInstanceIdentityLinks**
> void DeleteTaskInstanceIdentityLinks (string taskId, string family, string identityId, string type)

Delete an identity link on a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTaskInstanceIdentityLinksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task.
            var family = family_example;  // string | Either groups or users, depending on what kind of identity is targeted.
            var identityId = identityId_example;  // string | The id of the identity.
            var type = type_example;  // string | The type of identity link.

            try
            {
                // Delete an identity link on a task
                apiInstance.DeleteTaskInstanceIdentityLinks(taskId, family, identityId, type);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteTaskInstanceIdentityLinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task. | 
 **family** | **string**| Either groups or users, depending on what kind of identity is targeted. | 
 **identityId** | **string**| The id of the identity. | 
 **type** | **string**| The type of identity link. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetaskinstancevariable"></a>
# **DeleteTaskInstanceVariable**
> void DeleteTaskInstanceVariable (string taskId, string variableName)

Delete a variable on a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTaskInstanceVariableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task the variable to delete belongs to.
            var variableName = variableName_example;  // string | The name of the variable to delete.

            try
            {
                // Delete a variable on a task
                apiInstance.DeleteTaskInstanceVariable(taskId, variableName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteTaskInstanceVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task the variable to delete belongs to. | 
 **variableName** | **string**| The name of the variable to delete. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executetaskaction"></a>
# **ExecuteTaskAction**
> void ExecuteTaskAction (string taskId, TaskActionRequest body = null)

Tasks actions

## Complete a task - Request Body   ```JSON {   \"action\" : \"complete\",   \"variables\" : [] } ```Completes the task. Optional variable array can be passed in using the variables property. More information about the variable format can be found in the REST variables section. Note that the variable-scope that is supplied is ignored and the variables are set on the parent-scope unless a variable exists in a local scope, which is overridden in this case. This is the same behavior as the TaskService.completeTask(taskId, variables) invocation.  Note that also a transientVariables property is accepted as part of this json, that follows the same structure as the variables property.   ## Claim a task - Request Body    ```JSON {   \"action\" : \"claim\",   \"assignee\" : \"userWhoClaims\" } ```   Claims the task by the given assignee. If the assignee is null, the task is assigned to no-one, claimable again.   ## Delegate a task - Request Body    ```JSON {   \"action\" : \"delegate\",   \"assignee\" : \"userToDelegateTo\" } ```   Delegates the task to the given assignee. The assignee is required.   ## Suspend a process instance   ```JSON {   \"action\" : \"resolve\" } ```   Resolves the task delegation. The task is assigned back to the task owner (if any).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecuteTaskActionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | 
            var body = new TaskActionRequest(); // TaskActionRequest |  (optional) 

            try
            {
                // Tasks actions
                apiInstance.ExecuteTaskAction(taskId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.ExecuteTaskAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**|  | 
 **body** | [**TaskActionRequest**](TaskActionRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaskvariabledata"></a>
# **GeTaskVariableData**
> List<byte[]> GeTaskVariableData (string taskId, string variableName)

Get the binary data for a variable

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
    public class GeTaskVariableDataExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to get a variable data for.
            var variableName = variableName_example;  // string | The name of the variable to get data for. Only variables of type binary and serializable can be used. If any other type of variable is used, a 404 is returned.

            try
            {
                // Get the binary data for a variable
                List&lt;byte[]&gt; result = apiInstance.GeTaskVariableData(taskId, variableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GeTaskVariableData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to get a variable data for. | 
 **variableName** | **string**| The name of the variable to get data for. Only variables of type binary and serializable can be used. If any other type of variable is used, a 404 is returned. | 

### Return type

**List<byte[]>**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattachment"></a>
# **GetAttachment**
> AttachmentResponse GetAttachment (string taskId, string attachmentId)

Get an attachment on a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAttachmentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to get the attachment for.
            var attachmentId = attachmentId_example;  // string | The id of the attachment.

            try
            {
                // Get an attachment on a task
                AttachmentResponse result = apiInstance.GetAttachment(taskId, attachmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to get the attachment for. | 
 **attachmentId** | **string**| The id of the attachment. | 

### Return type

[**AttachmentResponse**](AttachmentResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattachmentcontent"></a>
# **GetAttachmentContent**
> List<byte[]> GetAttachmentContent (string taskId, string attachmentId)

Get the content for an attachment

The response body contains the binary content. By default, the content-type of the response is set to application/octet-stream unless the attachment type contains a valid Content-type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAttachmentContentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to get a variable data for.
            var attachmentId = attachmentId_example;  // string | The id of the attachment, a 404 is returned when the attachment points to an external URL rather than content attached in Activiti.

            try
            {
                // Get the content for an attachment
                List&lt;byte[]&gt; result = apiInstance.GetAttachmentContent(taskId, attachmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetAttachmentContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to get a variable data for. | 
 **attachmentId** | **string**| The id of the attachment, a 404 is returned when the attachment points to an external URL rather than content attached in Activiti. | 

### Return type

**List<byte[]>**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattachments"></a>
# **GetAttachments**
> List<AttachmentResponse> GetAttachments (string taskId)

Get all attachments on a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAttachmentsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to get the attachments for.

            try
            {
                // Get all attachments on a task
                List&lt;AttachmentResponse&gt; result = apiInstance.GetAttachments(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to get the attachments for. | 

### Return type

[**List<AttachmentResponse>**](AttachmentResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getevent"></a>
# **GetEvent**
> EventResponse GetEvent (string taskId, string eventId)

Get an event on a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEventExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to get the event for.
            var eventId = eventId_example;  // string | The id of the event.

            try
            {
                // Get an event on a task
                EventResponse result = apiInstance.GetEvent(taskId, eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to get the event for. | 
 **eventId** | **string**| The id of the event. | 

### Return type

[**EventResponse**](EventResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getevents"></a>
# **GetEvents**
> List<EventResponse> GetEvents (string taskId)

Get all events for a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEventsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to get the events for.

            try
            {
                // Get all events for a task
                List&lt;EventResponse&gt; result = apiInstance.GetEvents(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to get the events for. | 

### Return type

[**List<EventResponse>**](EventResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getidentitylinksforfamily"></a>
# **GetIdentityLinksForFamily**
> List<RestIdentityLink> GetIdentityLinksForFamily (string taskId, string family)

Get all identitylinks for a task for either groups or users

## Get all identitylinks for a task URL   ```  GET runtime/tasks/{taskId}/identitylinks/users GET runtime/tasks/{taskId}/identitylinks/groups  ```   Returns only identity links targetting either users or groups. Response body and status-codes are exactly the same as when getting the full list of identity links for a task.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIdentityLinksForFamilyExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | 
            var family = family_example;  // string | 

            try
            {
                // Get all identitylinks for a task for either groups or users
                List&lt;RestIdentityLink&gt; result = apiInstance.GetIdentityLinksForFamily(taskId, family);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetIdentityLinksForFamily: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**|  | 
 **family** | **string**|  | 

### Return type

[**List<RestIdentityLink>**](RestIdentityLink.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getqueryresult"></a>
# **GetQueryResult**
> DataResponse GetQueryResult (TaskQueryRequest body = null)

Query for tasks

All supported JSON parameter fields allowed are exactly the same as the parameters found for getting a collection of tasks (except for candidateGroupIn which is only available in this POST task query REST service), but passed in as JSON-body arguments rather than URL-parameters to allow for more advanced querying and preventing errors with request-uri�s that are too long. On top of that, the query allows for filtering based on task and process variables. The taskVariables and processInstanceVariables are both JSON-arrays containing objects with the format as described here.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQueryResultExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var body = new TaskQueryRequest(); // TaskQueryRequest |  (optional) 

            try
            {
                // Query for tasks
                DataResponse result = apiInstance.GetQueryResult(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetQueryResult: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TaskQueryRequest**](TaskQueryRequest.md)|  | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubtasks"></a>
# **GetSubTasks**
> List<TaskResponse> GetSubTasks (string taskId)

Get list of sub tasks for a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubTasksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | 

            try
            {
                // Get list of sub tasks for a task
                List&lt;TaskResponse&gt; result = apiInstance.GetSubTasks(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetSubTasks: " + e.Message );
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

[**List<TaskResponse>**](TaskResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettask"></a>
# **GetTask**
> TaskResponse GetTask (string taskId)

Get a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaskExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to get.

            try
            {
                // Get a task
                TaskResponse result = apiInstance.GetTask(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to get. | 

### Return type

[**TaskResponse**](TaskResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskcomment"></a>
# **GetTaskComment**
> CommentResponse GetTaskComment (string taskId, string commentId)

 Get a comment on a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaskCommentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to get the comment for.
            var commentId = commentId_example;  // string | The id of the comment.

            try
            {
                //  Get a comment on a task
                CommentResponse result = apiInstance.GetTaskComment(taskId, commentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetTaskComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to get the comment for. | 
 **commentId** | **string**| The id of the comment. | 

### Return type

[**CommentResponse**](CommentResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskinstanceidentitylinks"></a>
# **GetTaskInstanceIdentityLinks**
> RestIdentityLink GetTaskInstanceIdentityLinks (string taskId, string family, string identityId, string type)

Get a single identity link on a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaskInstanceIdentityLinksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task .
            var family = family_example;  // string | Either groups or users, depending on what kind of identity is targeted.
            var identityId = identityId_example;  // string | The id of the identity.
            var type = type_example;  // string | The type of identity link.

            try
            {
                // Get a single identity link on a task
                RestIdentityLink result = apiInstance.GetTaskInstanceIdentityLinks(taskId, family, identityId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetTaskInstanceIdentityLinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task . | 
 **family** | **string**| Either groups or users, depending on what kind of identity is targeted. | 
 **identityId** | **string**| The id of the identity. | 
 **type** | **string**| The type of identity link. | 

### Return type

[**RestIdentityLink**](RestIdentityLink.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskinstancevariable"></a>
# **GetTaskInstanceVariable**
> RestVariable GetTaskInstanceVariable (string taskId, string variableName, string scope = null)

Get a variable from a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaskInstanceVariableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to get a variable for.
            var variableName = variableName_example;  // string | The name of the variable to get.
            var scope = scope_example;  // string | Scope of variable to be returned. When local, only task-local variable value is returned. When global, only variable value from the task�s parent execution-hierarchy are returned. When the parameter is omitted, a local variable will be returned if it exists, otherwise a global variable. (optional) 

            try
            {
                // Get a variable from a task
                RestVariable result = apiInstance.GetTaskInstanceVariable(taskId, variableName, scope);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetTaskInstanceVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to get a variable for. | 
 **variableName** | **string**| The name of the variable to get. | 
 **scope** | **string**| Scope of variable to be returned. When local, only task-local variable value is returned. When global, only variable value from the task�s parent execution-hierarchy are returned. When the parameter is omitted, a local variable will be returned if it exists, otherwise a global variable. | [optional] 

### Return type

[**RestVariable**](RestVariable.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettasks"></a>
# **GetTasks**
> DataResponse GetTasks (string name = null, string nameLike = null, string description = null, string priority = null, string minimumPriority = null, string maximumPriority = null, string assignee = null, string assigneeLike = null, string owner = null, string ownerLike = null, string unassigned = null, string delegationState = null, string candidateUser = null, string candidateGroup = null, string candidateGroups = null, string involvedUser = null, string taskDefinitionKey = null, string taskDefinitionKeyLike = null, string processInstanceId = null, string processInstanceBusinessKey = null, string processInstanceBusinessKeyLike = null, string processDefinitionId = null, string processDefinitionKey = null, string processDefinitionKeyLike = null, string processDefinitionName = null, string processDefinitionNameLike = null, string executionId = null, string createdOn = null, string createdBefore = null, string createdAfter = null, string dueOn = null, string dueBefore = null, string dueAfter = null, bool? withoutDueDate = null, bool? excludeSubTasks = null, bool? active = null, bool? includeTaskLocalVariables = null, bool? includeProcessVariables = null, string tenantId = null, string tenantIdLike = null, bool? withoutTenantId = null, string candidateOrAssigned = null, string category = null)

List of tasks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTasksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var name = name_example;  // string | Only return models with the given version. (optional) 
            var nameLike = nameLike_example;  // string | Only return tasks with a name like the given name. (optional) 
            var description = description_example;  // string | Only return tasks with the given description. (optional) 
            var priority = priority_example;  // string | Only return tasks with the given priority. (optional) 
            var minimumPriority = minimumPriority_example;  // string | Only return tasks with a priority greater than the given value. (optional) 
            var maximumPriority = maximumPriority_example;  // string | Only return tasks with a priority lower than the given value. (optional) 
            var assignee = assignee_example;  // string | Only return tasks assigned to the given user. (optional) 
            var assigneeLike = assigneeLike_example;  // string | Only return tasks assigned with an assignee like the given value. (optional) 
            var owner = owner_example;  // string | Only return tasks owned by the given user. (optional) 
            var ownerLike = ownerLike_example;  // string | Only return tasks assigned with an owner like the given value. (optional) 
            var unassigned = unassigned_example;  // string | Only return tasks that are not assigned to anyone. If false is passed, the value is ignored. (optional) 
            var delegationState = delegationState_example;  // string | Only return tasks that have the given delegation state. Possible values are pending and resolved. (optional) 
            var candidateUser = candidateUser_example;  // string | Only return tasks that can be claimed by the given user. This includes both tasks where the user is an explicit candidate for and task that are claimable by a group that the user is a member of. (optional) 
            var candidateGroup = candidateGroup_example;  // string | Only return tasks that can be claimed by a user in the given group. (optional) 
            var candidateGroups = candidateGroups_example;  // string | Only return tasks that can be claimed by a user in the given groups. Values split by comma. (optional) 
            var involvedUser = involvedUser_example;  // string | Only return tasks in which the given user is involved. (optional) 
            var taskDefinitionKey = taskDefinitionKey_example;  // string | Only return tasks with the given task definition id. (optional) 
            var taskDefinitionKeyLike = taskDefinitionKeyLike_example;  // string | Only return tasks with a given task definition id like the given value. (optional) 
            var processInstanceId = processInstanceId_example;  // string | Only return tasks which are part of the process instance with the given id. (optional) 
            var processInstanceBusinessKey = processInstanceBusinessKey_example;  // string | Only return tasks which are part of the process instance with the given business key. (optional) 
            var processInstanceBusinessKeyLike = processInstanceBusinessKeyLike_example;  // string | Only return tasks which are part of the process instance which has a business key like the given value. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Only return tasks which are part of a process instance which has a process definition with the given id. (optional) 
            var processDefinitionKey = processDefinitionKey_example;  // string | Only return tasks which are part of a process instance which has a process definition with the given key. (optional) 
            var processDefinitionKeyLike = processDefinitionKeyLike_example;  // string | Only return tasks which are part of a process instance which has a process definition with a key like the given value. (optional) 
            var processDefinitionName = processDefinitionName_example;  // string | Only return tasks which are part of a process instance which has a process definition with the given name. (optional) 
            var processDefinitionNameLike = processDefinitionNameLike_example;  // string | Only return tasks which are part of a process instance which has a process definition with a name like the given value. (optional) 
            var executionId = executionId_example;  // string | Only return tasks which are part of the execution with the given id. (optional) 
            var createdOn = createdOn_example;  // string | Only return tasks which are created on the given date. (optional) 
            var createdBefore = createdBefore_example;  // string | Only return tasks which are created before the given date. (optional) 
            var createdAfter = createdAfter_example;  // string | Only return tasks which are created after the given date. (optional) 
            var dueOn = dueOn_example;  // string | Only return tasks which are due on the given date. (optional) 
            var dueBefore = dueBefore_example;  // string | Only return tasks which are due before the given date. (optional) 
            var dueAfter = dueAfter_example;  // string | Only return tasks which are due after the given date. (optional) 
            var withoutDueDate = true;  // bool? | Only return tasks which don�t have a due date. The property is ignored if the value is false. (optional) 
            var excludeSubTasks = true;  // bool? | Only return tasks that are not a subtask of another task. (optional) 
            var active = true;  // bool? | If true, only return tasks that are not suspended (either part of a process that is not suspended or not part of a process at all). If false, only tasks that are part of suspended process instances are returned. (optional) 
            var includeTaskLocalVariables = true;  // bool? | Indication to include task local variables in the result. (optional) 
            var includeProcessVariables = true;  // bool? | Indication to include process variables in the result. (optional) 
            var tenantId = tenantId_example;  // string | Only return tasks with the given tenantId. (optional) 
            var tenantIdLike = tenantIdLike_example;  // string | Only return tasks with a tenantId like the given value. (optional) 
            var withoutTenantId = true;  // bool? | If true, only returns tasks without a tenantId set. If false, the withoutTenantId parameter is ignored. (optional) 
            var candidateOrAssigned = candidateOrAssigned_example;  // string | Select tasks that has been claimed or assigned to user or waiting to claim by user (candidate user or groups). (optional) 
            var category = category_example;  // string | Select tasks with the given category. Note that this is the task category, not the category of the process definition (namespace within the BPMN Xml).  (optional) 

            try
            {
                // List of tasks
                DataResponse result = apiInstance.GetTasks(name, nameLike, description, priority, minimumPriority, maximumPriority, assignee, assigneeLike, owner, ownerLike, unassigned, delegationState, candidateUser, candidateGroup, candidateGroups, involvedUser, taskDefinitionKey, taskDefinitionKeyLike, processInstanceId, processInstanceBusinessKey, processInstanceBusinessKeyLike, processDefinitionId, processDefinitionKey, processDefinitionKeyLike, processDefinitionName, processDefinitionNameLike, executionId, createdOn, createdBefore, createdAfter, dueOn, dueBefore, dueAfter, withoutDueDate, excludeSubTasks, active, includeTaskLocalVariables, includeProcessVariables, tenantId, tenantIdLike, withoutTenantId, candidateOrAssigned, category);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Only return models with the given version. | [optional] 
 **nameLike** | **string**| Only return tasks with a name like the given name. | [optional] 
 **description** | **string**| Only return tasks with the given description. | [optional] 
 **priority** | **string**| Only return tasks with the given priority. | [optional] 
 **minimumPriority** | **string**| Only return tasks with a priority greater than the given value. | [optional] 
 **maximumPriority** | **string**| Only return tasks with a priority lower than the given value. | [optional] 
 **assignee** | **string**| Only return tasks assigned to the given user. | [optional] 
 **assigneeLike** | **string**| Only return tasks assigned with an assignee like the given value. | [optional] 
 **owner** | **string**| Only return tasks owned by the given user. | [optional] 
 **ownerLike** | **string**| Only return tasks assigned with an owner like the given value. | [optional] 
 **unassigned** | **string**| Only return tasks that are not assigned to anyone. If false is passed, the value is ignored. | [optional] 
 **delegationState** | **string**| Only return tasks that have the given delegation state. Possible values are pending and resolved. | [optional] 
 **candidateUser** | **string**| Only return tasks that can be claimed by the given user. This includes both tasks where the user is an explicit candidate for and task that are claimable by a group that the user is a member of. | [optional] 
 **candidateGroup** | **string**| Only return tasks that can be claimed by a user in the given group. | [optional] 
 **candidateGroups** | **string**| Only return tasks that can be claimed by a user in the given groups. Values split by comma. | [optional] 
 **involvedUser** | **string**| Only return tasks in which the given user is involved. | [optional] 
 **taskDefinitionKey** | **string**| Only return tasks with the given task definition id. | [optional] 
 **taskDefinitionKeyLike** | **string**| Only return tasks with a given task definition id like the given value. | [optional] 
 **processInstanceId** | **string**| Only return tasks which are part of the process instance with the given id. | [optional] 
 **processInstanceBusinessKey** | **string**| Only return tasks which are part of the process instance with the given business key. | [optional] 
 **processInstanceBusinessKeyLike** | **string**| Only return tasks which are part of the process instance which has a business key like the given value. | [optional] 
 **processDefinitionId** | **string**| Only return tasks which are part of a process instance which has a process definition with the given id. | [optional] 
 **processDefinitionKey** | **string**| Only return tasks which are part of a process instance which has a process definition with the given key. | [optional] 
 **processDefinitionKeyLike** | **string**| Only return tasks which are part of a process instance which has a process definition with a key like the given value. | [optional] 
 **processDefinitionName** | **string**| Only return tasks which are part of a process instance which has a process definition with the given name. | [optional] 
 **processDefinitionNameLike** | **string**| Only return tasks which are part of a process instance which has a process definition with a name like the given value. | [optional] 
 **executionId** | **string**| Only return tasks which are part of the execution with the given id. | [optional] 
 **createdOn** | **string**| Only return tasks which are created on the given date. | [optional] 
 **createdBefore** | **string**| Only return tasks which are created before the given date. | [optional] 
 **createdAfter** | **string**| Only return tasks which are created after the given date. | [optional] 
 **dueOn** | **string**| Only return tasks which are due on the given date. | [optional] 
 **dueBefore** | **string**| Only return tasks which are due before the given date. | [optional] 
 **dueAfter** | **string**| Only return tasks which are due after the given date. | [optional] 
 **withoutDueDate** | **bool?**| Only return tasks which don�t have a due date. The property is ignored if the value is false. | [optional] 
 **excludeSubTasks** | **bool?**| Only return tasks that are not a subtask of another task. | [optional] 
 **active** | **bool?**| If true, only return tasks that are not suspended (either part of a process that is not suspended or not part of a process at all). If false, only tasks that are part of suspended process instances are returned. | [optional] 
 **includeTaskLocalVariables** | **bool?**| Indication to include task local variables in the result. | [optional] 
 **includeProcessVariables** | **bool?**| Indication to include process variables in the result. | [optional] 
 **tenantId** | **string**| Only return tasks with the given tenantId. | [optional] 
 **tenantIdLike** | **string**| Only return tasks with a tenantId like the given value. | [optional] 
 **withoutTenantId** | **bool?**| If true, only returns tasks without a tenantId set. If false, the withoutTenantId parameter is ignored. | [optional] 
 **candidateOrAssigned** | **string**| Select tasks that has been claimed or assigned to user or waiting to claim by user (candidate user or groups). | [optional] 
 **category** | **string**| Select tasks with the given category. Note that this is the task category, not the category of the process definition (namespace within the BPMN Xml).  | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtaskcomments"></a>
# **ListTaskComments**
> List<CommentResponse> ListTaskComments (string taskId)

Get all comments on a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListTaskCommentsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to get the comments for.

            try
            {
                // Get all comments on a task
                List&lt;CommentResponse&gt; result = apiInstance.ListTaskComments(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.ListTaskComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to get the comments for. | 

### Return type

[**List<CommentResponse>**](CommentResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtaskvariables"></a>
# **ListTaskVariables**
> List<RestVariable> ListTaskVariables (string taskId)

Get all variables for a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListTaskVariablesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to get variables for.

            try
            {
                // Get all variables for a task
                List&lt;RestVariable&gt; result = apiInstance.ListTaskVariables(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.ListTaskVariables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to get variables for. | 

### Return type

[**List<RestVariable>**](RestVariable.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtasksinstanceidentitylinks"></a>
# **ListTasksInstanceIdentityLinks**
> List<RestIdentityLink> ListTasksInstanceIdentityLinks (string taskId)

Get all identity links for a task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListTasksInstanceIdentityLinksExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to get the identity links for.

            try
            {
                // Get all identity links for a task
                List&lt;RestIdentityLink&gt; result = apiInstance.ListTasksInstanceIdentityLinks(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.ListTasksInstanceIdentityLinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to get the identity links for. | 

### Return type

[**List<RestIdentityLink>**](RestIdentityLink.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetask"></a>
# **UpdateTask**
> TaskResponse UpdateTask (string taskId, TaskRequest body = null)

Update a task

All request values are optional. For example, you can only include the assignee attribute in the request body JSON-object, only updating the assignee of the task, leaving all other fields unaffected. When an attribute is explicitly included and is set to null, the task-value will be updated to null. Example: {\"dueDate\" : null} will clear the duedate of the task).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTaskExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | 
            var body = new TaskRequest(); // TaskRequest |  (optional) 

            try
            {
                // Update a task
                TaskResponse result = apiInstance.UpdateTask(taskId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.UpdateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**|  | 
 **body** | [**TaskRequest**](TaskRequest.md)|  | [optional] 

### Return type

[**TaskResponse**](TaskResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetaskinstancevariable"></a>
# **UpdateTaskInstanceVariable**
> RestVariable UpdateTaskInstanceVariable (string taskId, string variableName)

Update an existing variable on a task

## Request body for updating simple (non-binary) variables   ```JSON {   \"name\" : \"myTaskVariable\",   \"scope\" : \"local\",   \"type\" : \"string\",   \"value\" : \"Hello my friend\" } ```   - *name*: Required name of the variable  - *scope*: Scope of variable that is updated. If omitted, local is assumed.  - *type*: Type of variable that is updated. If omitted, reverts to raw JSON-value type (string, boolean, integer or double).  - *value*: Variable value.   ## Request body for updating simple (non-binary) variables  The request should be of type multipart/form-data. There should be a single file-part included with the binary value of the variable. On top of that, the following additional form-fields can be present:  - *name*: Required name of the variable.  - *scope*: Scope of variable that is updated. If omitted, local is assumed.  - *type*: Type of variable that is updated. If omitted, binary is assumed and the binary data in the request will be stored as an array of bytes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTaskInstanceVariableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | The id of the task to update the variable for.
            var variableName = variableName_example;  // string | The name of the variable to update.

            try
            {
                // Update an existing variable on a task
                RestVariable result = apiInstance.UpdateTaskInstanceVariable(taskId, variableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.UpdateTaskInstanceVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The id of the task to update the variable for. | 
 **variableName** | **string**| The name of the variable to update. | 

### Return type

[**RestVariable**](RestVariable.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

