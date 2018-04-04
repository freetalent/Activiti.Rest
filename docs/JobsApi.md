# IO.Swagger.Api.JobsApi

All URIs are relative to *http://localhost:8080/activiti-rest/service*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteDeadLetterJob**](JobsApi.md#deletedeadletterjob) | **DELETE** /management/deadletter-jobs/{jobId} | Delete a deadletter job
[**DeleteJob**](JobsApi.md#deletejob) | **DELETE** /management/jobs/{jobId} | Delete a job
[**DeleteTimerJob**](JobsApi.md#deletetimerjob) | **DELETE** /management/timer-jobs/{jobId} | Delete a timer job
[**ExecuteJobAction**](JobsApi.md#executejobaction) | **POST** /management/jobs/{jobId} | Execute a single job
[**GetDeadLetterJobStacktrace**](JobsApi.md#getdeadletterjobstacktrace) | **GET** /management/deadletter-jobs/{jobId}/exception-stacktrace | Get the exception stacktrace for a deadletter job
[**GetDeadletterJob**](JobsApi.md#getdeadletterjob) | **GET** /management/deadletter-jobs/{jobId} | Get a single deadletter job
[**GetJob**](JobsApi.md#getjob) | **GET** /management/jobs/{jobId} | Get a single job
[**GetJobStacktrace**](JobsApi.md#getjobstacktrace) | **GET** /management/jobs/{jobId}/exception-stacktrace | Get the exception stacktrace for a job
[**GetSuspendedJob**](JobsApi.md#getsuspendedjob) | **GET** /management/suspended-jobs/{jobId} | Get a single suspended job
[**GetSuspendedJobStacktrace**](JobsApi.md#getsuspendedjobstacktrace) | **GET** /management/suspended-jobs/{jobId}/exception-stacktrace | Get the exception stacktrace for a suspended job
[**GetTimerJob**](JobsApi.md#gettimerjob) | **GET** /management/timer-jobs/{jobId} | Get a single timer job
[**GetTimerJobStacktrace**](JobsApi.md#gettimerjobstacktrace) | **GET** /management/timer-jobs/{jobId}/exception-stacktrace | Get the exception stacktrace for a timer job
[**ListDeadLetterJobs**](JobsApi.md#listdeadletterjobs) | **GET** /management/deadletter-jobs | Get a list of deadletter jobs
[**ListJobs**](JobsApi.md#listjobs) | **GET** /management/jobs | Get a list of jobs
[**ListSuspendedJobs**](JobsApi.md#listsuspendedjobs) | **GET** /management/suspended-jobs | Get a list of suspended jobs
[**ListTimerJobs**](JobsApi.md#listtimerjobs) | **GET** /management/timer-jobs | Get a list of timer jobs


<a name="deletedeadletterjob"></a>
# **DeleteDeadLetterJob**
> void DeleteDeadLetterJob (string jobId)

Delete a deadletter job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDeadLetterJobExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var jobId = jobId_example;  // string | 

            try
            {
                // Delete a deadletter job
                apiInstance.DeleteDeadLetterJob(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.DeleteDeadLetterJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejob"></a>
# **DeleteJob**
> void DeleteJob (string jobId)

Delete a job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteJobExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var jobId = jobId_example;  // string | The id of the job to delete.

            try
            {
                // Delete a job
                apiInstance.DeleteJob(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.DeleteJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**| The id of the job to delete. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetimerjob"></a>
# **DeleteTimerJob**
> void DeleteTimerJob (string jobId)

Delete a timer job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTimerJobExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var jobId = jobId_example;  // string | 

            try
            {
                // Delete a timer job
                apiInstance.DeleteTimerJob(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.DeleteTimerJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executejobaction"></a>
# **ExecuteJobAction**
> void ExecuteJobAction (string jobId, RestActionRequest actionRequest = null)

Execute a single job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecuteJobActionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var jobId = jobId_example;  // string | 
            var actionRequest = new RestActionRequest(); // RestActionRequest | Action to perform. Only execute is supported. (optional) 

            try
            {
                // Execute a single job
                apiInstance.ExecuteJobAction(jobId, actionRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ExecuteJobAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**|  | 
 **actionRequest** | [**RestActionRequest**](RestActionRequest.md)| Action to perform. Only execute is supported. | [optional] 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeadletterjobstacktrace"></a>
# **GetDeadLetterJobStacktrace**
> string GetDeadLetterJobStacktrace (string jobId)

Get the exception stacktrace for a deadletter job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDeadLetterJobStacktraceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var jobId = jobId_example;  // string | 

            try
            {
                // Get the exception stacktrace for a deadletter job
                string result = apiInstance.GetDeadLetterJobStacktrace(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.GetDeadLetterJobStacktrace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**|  | 

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeadletterjob"></a>
# **GetDeadletterJob**
> JobResponse GetDeadletterJob (string jobId)

Get a single deadletter job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDeadletterJobExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var jobId = jobId_example;  // string | 

            try
            {
                // Get a single deadletter job
                JobResponse result = apiInstance.GetDeadletterJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.GetDeadletterJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**|  | 

### Return type

[**JobResponse**](JobResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjob"></a>
# **GetJob**
> JobResponse GetJob (string jobId)

Get a single job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJobExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var jobId = jobId_example;  // string | The id of the job to get.

            try
            {
                // Get a single job
                JobResponse result = apiInstance.GetJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.GetJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**| The id of the job to get. | 

### Return type

[**JobResponse**](JobResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjobstacktrace"></a>
# **GetJobStacktrace**
> string GetJobStacktrace (string jobId)

Get the exception stacktrace for a job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJobStacktraceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var jobId = jobId_example;  // string | Id of the job to get the stacktrace for.

            try
            {
                // Get the exception stacktrace for a job
                string result = apiInstance.GetJobStacktrace(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.GetJobStacktrace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**| Id of the job to get the stacktrace for. | 

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsuspendedjob"></a>
# **GetSuspendedJob**
> JobResponse GetSuspendedJob (string jobId)

Get a single suspended job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSuspendedJobExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var jobId = jobId_example;  // string | 

            try
            {
                // Get a single suspended job
                JobResponse result = apiInstance.GetSuspendedJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.GetSuspendedJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**|  | 

### Return type

[**JobResponse**](JobResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsuspendedjobstacktrace"></a>
# **GetSuspendedJobStacktrace**
> string GetSuspendedJobStacktrace (string jobId)

Get the exception stacktrace for a suspended job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSuspendedJobStacktraceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var jobId = jobId_example;  // string | 

            try
            {
                // Get the exception stacktrace for a suspended job
                string result = apiInstance.GetSuspendedJobStacktrace(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.GetSuspendedJobStacktrace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**|  | 

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimerjob"></a>
# **GetTimerJob**
> JobResponse GetTimerJob (string jobId)

Get a single timer job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTimerJobExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var jobId = jobId_example;  // string | 

            try
            {
                // Get a single timer job
                JobResponse result = apiInstance.GetTimerJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.GetTimerJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**|  | 

### Return type

[**JobResponse**](JobResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimerjobstacktrace"></a>
# **GetTimerJobStacktrace**
> string GetTimerJobStacktrace (string jobId)

Get the exception stacktrace for a timer job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTimerJobStacktraceExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var jobId = jobId_example;  // string | 

            try
            {
                // Get the exception stacktrace for a timer job
                string result = apiInstance.GetTimerJobStacktrace(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.GetTimerJobStacktrace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**|  | 

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdeadletterjobs"></a>
# **ListDeadLetterJobs**
> DataResponse ListDeadLetterJobs (string id = null, string processInstanceId = null, string executionId = null, string processDefinitionId = null, bool? timersOnly = null, bool? messagesOnly = null, bool? withException = null, string dueBefore = null, string dueAfter = null, string exceptionMessage = null, string tenantId = null, string tenantIdLike = null, bool? withoutTenantId = null, bool? locked = null, bool? unlocked = null, string sort = null)

Get a list of deadletter jobs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListDeadLetterJobsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var id = id_example;  // string | Only return job with the given id (optional) 
            var processInstanceId = processInstanceId_example;  // string | Only return jobs part of a process with the given id (optional) 
            var executionId = executionId_example;  // string | Only return jobs part of an execution with the given id (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Only return jobs with the given process definition id (optional) 
            var timersOnly = true;  // bool? | If true, only return jobs which are timers. If false, this parameter is ignored. Cannot be used together with 'messagesOnly'. (optional) 
            var messagesOnly = true;  // bool? | If true, only return jobs which are messages. If false, this parameter is ignored. Cannot be used together with 'timersOnly' (optional) 
            var withException = true;  // bool? | If true, only return jobs for which an exception occurred while executing it. If false, this parameter is ignored. (optional) 
            var dueBefore = dueBefore_example;  // string | Only return jobs which are due to be executed before the given date. Jobs without duedate are never returned using this parameter. (optional) 
            var dueAfter = dueAfter_example;  // string | Only return jobs which are due to be executed after the given date. Jobs without duedate are never returned using this parameter. (optional) 
            var exceptionMessage = exceptionMessage_example;  // string | Only return jobs with the given exception message (optional) 
            var tenantId = tenantId_example;  // string | Only return jobs with the given tenantId. (optional) 
            var tenantIdLike = tenantIdLike_example;  // string | Only return jobs with a tenantId like the given value. (optional) 
            var withoutTenantId = true;  // bool? | If true, only returns jobs without a tenantId set. If false, the withoutTenantId parameter is ignored. (optional) 
            var locked = true;  // bool? | If true, only return jobs which are locked.  If false, this parameter is ignored. (optional) 
            var unlocked = true;  // bool? | If true, only return jobs which are unlocked. If false, this parameter is ignored. (optional) 
            var sort = sort_example;  // string | Property to sort on, to be used together with the order. (optional) 

            try
            {
                // Get a list of deadletter jobs
                DataResponse result = apiInstance.ListDeadLetterJobs(id, processInstanceId, executionId, processDefinitionId, timersOnly, messagesOnly, withException, dueBefore, dueAfter, exceptionMessage, tenantId, tenantIdLike, withoutTenantId, locked, unlocked, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ListDeadLetterJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Only return job with the given id | [optional] 
 **processInstanceId** | **string**| Only return jobs part of a process with the given id | [optional] 
 **executionId** | **string**| Only return jobs part of an execution with the given id | [optional] 
 **processDefinitionId** | **string**| Only return jobs with the given process definition id | [optional] 
 **timersOnly** | **bool?**| If true, only return jobs which are timers. If false, this parameter is ignored. Cannot be used together with &#39;messagesOnly&#39;. | [optional] 
 **messagesOnly** | **bool?**| If true, only return jobs which are messages. If false, this parameter is ignored. Cannot be used together with &#39;timersOnly&#39; | [optional] 
 **withException** | **bool?**| If true, only return jobs for which an exception occurred while executing it. If false, this parameter is ignored. | [optional] 
 **dueBefore** | **string**| Only return jobs which are due to be executed before the given date. Jobs without duedate are never returned using this parameter. | [optional] 
 **dueAfter** | **string**| Only return jobs which are due to be executed after the given date. Jobs without duedate are never returned using this parameter. | [optional] 
 **exceptionMessage** | **string**| Only return jobs with the given exception message | [optional] 
 **tenantId** | **string**| Only return jobs with the given tenantId. | [optional] 
 **tenantIdLike** | **string**| Only return jobs with a tenantId like the given value. | [optional] 
 **withoutTenantId** | **bool?**| If true, only returns jobs without a tenantId set. If false, the withoutTenantId parameter is ignored. | [optional] 
 **locked** | **bool?**| If true, only return jobs which are locked.  If false, this parameter is ignored. | [optional] 
 **unlocked** | **bool?**| If true, only return jobs which are unlocked. If false, this parameter is ignored. | [optional] 
 **sort** | **string**| Property to sort on, to be used together with the order. | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listjobs"></a>
# **ListJobs**
> DataResponse ListJobs (string id = null, string processInstanceId = null, string executionId = null, string processDefinitionId = null, bool? timersOnly = null, bool? messagesOnly = null, bool? withException = null, string dueBefore = null, string dueAfter = null, string exceptionMessage = null, string tenantId = null, string tenantIdLike = null, bool? withoutTenantId = null, bool? locked = null, bool? unlocked = null, string sort = null)

Get a list of jobs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListJobsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var id = id_example;  // string | Only return job with the given id (optional) 
            var processInstanceId = processInstanceId_example;  // string | Only return jobs part of a process with the given id (optional) 
            var executionId = executionId_example;  // string | Only return jobs part of an execution with the given id (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Only return jobs with the given process definition id (optional) 
            var timersOnly = true;  // bool? | If true, only return jobs which are timers. If false, this parameter is ignored. Cannot be used together with 'messagesOnly'. (optional) 
            var messagesOnly = true;  // bool? | If true, only return jobs which are messages. If false, this parameter is ignored. Cannot be used together with 'timersOnly' (optional) 
            var withException = true;  // bool? | If true, only return jobs for which an exception occurred while executing it. If false, this parameter is ignored. (optional) 
            var dueBefore = dueBefore_example;  // string | Only return jobs which are due to be executed before the given date. Jobs without duedate are never returned using this parameter. (optional) 
            var dueAfter = dueAfter_example;  // string | Only return jobs which are due to be executed after the given date. Jobs without duedate are never returned using this parameter. (optional) 
            var exceptionMessage = exceptionMessage_example;  // string | Only return jobs with the given exception message (optional) 
            var tenantId = tenantId_example;  // string | Only return jobs with the given tenantId. (optional) 
            var tenantIdLike = tenantIdLike_example;  // string | Only return jobs with a tenantId like the given value. (optional) 
            var withoutTenantId = true;  // bool? | If true, only returns jobs without a tenantId set. If false, the withoutTenantId parameter is ignored. (optional) 
            var locked = true;  // bool? | If true, only return jobs which are locked.  If false, this parameter is ignored. (optional) 
            var unlocked = true;  // bool? | If true, only return jobs which are unlocked. If false, this parameter is ignored. (optional) 
            var sort = sort_example;  // string | Property to sort on, to be used together with the order. (optional) 

            try
            {
                // Get a list of jobs
                DataResponse result = apiInstance.ListJobs(id, processInstanceId, executionId, processDefinitionId, timersOnly, messagesOnly, withException, dueBefore, dueAfter, exceptionMessage, tenantId, tenantIdLike, withoutTenantId, locked, unlocked, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ListJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Only return job with the given id | [optional] 
 **processInstanceId** | **string**| Only return jobs part of a process with the given id | [optional] 
 **executionId** | **string**| Only return jobs part of an execution with the given id | [optional] 
 **processDefinitionId** | **string**| Only return jobs with the given process definition id | [optional] 
 **timersOnly** | **bool?**| If true, only return jobs which are timers. If false, this parameter is ignored. Cannot be used together with &#39;messagesOnly&#39;. | [optional] 
 **messagesOnly** | **bool?**| If true, only return jobs which are messages. If false, this parameter is ignored. Cannot be used together with &#39;timersOnly&#39; | [optional] 
 **withException** | **bool?**| If true, only return jobs for which an exception occurred while executing it. If false, this parameter is ignored. | [optional] 
 **dueBefore** | **string**| Only return jobs which are due to be executed before the given date. Jobs without duedate are never returned using this parameter. | [optional] 
 **dueAfter** | **string**| Only return jobs which are due to be executed after the given date. Jobs without duedate are never returned using this parameter. | [optional] 
 **exceptionMessage** | **string**| Only return jobs with the given exception message | [optional] 
 **tenantId** | **string**| Only return jobs with the given tenantId. | [optional] 
 **tenantIdLike** | **string**| Only return jobs with a tenantId like the given value. | [optional] 
 **withoutTenantId** | **bool?**| If true, only returns jobs without a tenantId set. If false, the withoutTenantId parameter is ignored. | [optional] 
 **locked** | **bool?**| If true, only return jobs which are locked.  If false, this parameter is ignored. | [optional] 
 **unlocked** | **bool?**| If true, only return jobs which are unlocked. If false, this parameter is ignored. | [optional] 
 **sort** | **string**| Property to sort on, to be used together with the order. | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsuspendedjobs"></a>
# **ListSuspendedJobs**
> DataResponse ListSuspendedJobs (string id = null, string processInstanceId = null, string executionId = null, string processDefinitionId = null, bool? timersOnly = null, bool? messagesOnly = null, bool? withException = null, string dueBefore = null, string dueAfter = null, string exceptionMessage = null, string tenantId = null, string tenantIdLike = null, bool? withoutTenantId = null, bool? locked = null, bool? unlocked = null, string sort = null)

Get a list of suspended jobs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListSuspendedJobsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var id = id_example;  // string | Only return job with the given id (optional) 
            var processInstanceId = processInstanceId_example;  // string | Only return jobs part of a process with the given id (optional) 
            var executionId = executionId_example;  // string | Only return jobs part of an execution with the given id (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Only return jobs with the given process definition id (optional) 
            var timersOnly = true;  // bool? | If true, only return jobs which are timers. If false, this parameter is ignored. Cannot be used together with 'messagesOnly'. (optional) 
            var messagesOnly = true;  // bool? | If true, only return jobs which are messages. If false, this parameter is ignored. Cannot be used together with 'timersOnly' (optional) 
            var withException = true;  // bool? | If true, only return jobs for which an exception occurred while executing it. If false, this parameter is ignored. (optional) 
            var dueBefore = dueBefore_example;  // string | Only return jobs which are due to be executed before the given date. Jobs without duedate are never returned using this parameter. (optional) 
            var dueAfter = dueAfter_example;  // string | Only return jobs which are due to be executed after the given date. Jobs without duedate are never returned using this parameter. (optional) 
            var exceptionMessage = exceptionMessage_example;  // string | Only return jobs with the given exception message (optional) 
            var tenantId = tenantId_example;  // string | Only return jobs with the given tenantId. (optional) 
            var tenantIdLike = tenantIdLike_example;  // string | Only return jobs with a tenantId like the given value. (optional) 
            var withoutTenantId = true;  // bool? | If true, only returns jobs without a tenantId set. If false, the withoutTenantId parameter is ignored. (optional) 
            var locked = true;  // bool? | If true, only return jobs which are locked.  If false, this parameter is ignored. (optional) 
            var unlocked = true;  // bool? | If true, only return jobs which are unlocked. If false, this parameter is ignored. (optional) 
            var sort = sort_example;  // string | Property to sort on, to be used together with the order. (optional) 

            try
            {
                // Get a list of suspended jobs
                DataResponse result = apiInstance.ListSuspendedJobs(id, processInstanceId, executionId, processDefinitionId, timersOnly, messagesOnly, withException, dueBefore, dueAfter, exceptionMessage, tenantId, tenantIdLike, withoutTenantId, locked, unlocked, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ListSuspendedJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Only return job with the given id | [optional] 
 **processInstanceId** | **string**| Only return jobs part of a process with the given id | [optional] 
 **executionId** | **string**| Only return jobs part of an execution with the given id | [optional] 
 **processDefinitionId** | **string**| Only return jobs with the given process definition id | [optional] 
 **timersOnly** | **bool?**| If true, only return jobs which are timers. If false, this parameter is ignored. Cannot be used together with &#39;messagesOnly&#39;. | [optional] 
 **messagesOnly** | **bool?**| If true, only return jobs which are messages. If false, this parameter is ignored. Cannot be used together with &#39;timersOnly&#39; | [optional] 
 **withException** | **bool?**| If true, only return jobs for which an exception occurred while executing it. If false, this parameter is ignored. | [optional] 
 **dueBefore** | **string**| Only return jobs which are due to be executed before the given date. Jobs without duedate are never returned using this parameter. | [optional] 
 **dueAfter** | **string**| Only return jobs which are due to be executed after the given date. Jobs without duedate are never returned using this parameter. | [optional] 
 **exceptionMessage** | **string**| Only return jobs with the given exception message | [optional] 
 **tenantId** | **string**| Only return jobs with the given tenantId. | [optional] 
 **tenantIdLike** | **string**| Only return jobs with a tenantId like the given value. | [optional] 
 **withoutTenantId** | **bool?**| If true, only returns jobs without a tenantId set. If false, the withoutTenantId parameter is ignored. | [optional] 
 **locked** | **bool?**| If true, only return jobs which are locked.  If false, this parameter is ignored. | [optional] 
 **unlocked** | **bool?**| If true, only return jobs which are unlocked. If false, this parameter is ignored. | [optional] 
 **sort** | **string**| Property to sort on, to be used together with the order. | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtimerjobs"></a>
# **ListTimerJobs**
> DataResponse ListTimerJobs (string id = null, string processInstanceId = null, string executionId = null, string processDefinitionId = null, bool? timersOnly = null, bool? messagesOnly = null, bool? withException = null, string dueBefore = null, string dueAfter = null, string exceptionMessage = null, string tenantId = null, string tenantIdLike = null, bool? withoutTenantId = null, bool? locked = null, bool? unlocked = null, string sort = null)

Get a list of timer jobs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListTimerJobsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JobsApi();
            var id = id_example;  // string | Only return job with the given id (optional) 
            var processInstanceId = processInstanceId_example;  // string | Only return jobs part of a process with the given id (optional) 
            var executionId = executionId_example;  // string | Only return jobs part of an execution with the given id (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | Only return jobs with the given process definition id (optional) 
            var timersOnly = true;  // bool? | If true, only return jobs which are timers. If false, this parameter is ignored. Cannot be used together with 'messagesOnly'. (optional) 
            var messagesOnly = true;  // bool? | If true, only return jobs which are messages. If false, this parameter is ignored. Cannot be used together with 'timersOnly' (optional) 
            var withException = true;  // bool? | If true, only return jobs for which an exception occurred while executing it. If false, this parameter is ignored. (optional) 
            var dueBefore = dueBefore_example;  // string | Only return jobs which are due to be executed before the given date. Jobs without duedate are never returned using this parameter. (optional) 
            var dueAfter = dueAfter_example;  // string | Only return jobs which are due to be executed after the given date. Jobs without duedate are never returned using this parameter. (optional) 
            var exceptionMessage = exceptionMessage_example;  // string | Only return jobs with the given exception message (optional) 
            var tenantId = tenantId_example;  // string | Only return jobs with the given tenantId. (optional) 
            var tenantIdLike = tenantIdLike_example;  // string | Only return jobs with a tenantId like the given value. (optional) 
            var withoutTenantId = true;  // bool? | If true, only returns jobs without a tenantId set. If false, the withoutTenantId parameter is ignored. (optional) 
            var locked = true;  // bool? | If true, only return jobs which are locked.  If false, this parameter is ignored. (optional) 
            var unlocked = true;  // bool? | If true, only return jobs which are unlocked. If false, this parameter is ignored. (optional) 
            var sort = sort_example;  // string | Property to sort on, to be used together with the order. (optional) 

            try
            {
                // Get a list of timer jobs
                DataResponse result = apiInstance.ListTimerJobs(id, processInstanceId, executionId, processDefinitionId, timersOnly, messagesOnly, withException, dueBefore, dueAfter, exceptionMessage, tenantId, tenantIdLike, withoutTenantId, locked, unlocked, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.ListTimerJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Only return job with the given id | [optional] 
 **processInstanceId** | **string**| Only return jobs part of a process with the given id | [optional] 
 **executionId** | **string**| Only return jobs part of an execution with the given id | [optional] 
 **processDefinitionId** | **string**| Only return jobs with the given process definition id | [optional] 
 **timersOnly** | **bool?**| If true, only return jobs which are timers. If false, this parameter is ignored. Cannot be used together with &#39;messagesOnly&#39;. | [optional] 
 **messagesOnly** | **bool?**| If true, only return jobs which are messages. If false, this parameter is ignored. Cannot be used together with &#39;timersOnly&#39; | [optional] 
 **withException** | **bool?**| If true, only return jobs for which an exception occurred while executing it. If false, this parameter is ignored. | [optional] 
 **dueBefore** | **string**| Only return jobs which are due to be executed before the given date. Jobs without duedate are never returned using this parameter. | [optional] 
 **dueAfter** | **string**| Only return jobs which are due to be executed after the given date. Jobs without duedate are never returned using this parameter. | [optional] 
 **exceptionMessage** | **string**| Only return jobs with the given exception message | [optional] 
 **tenantId** | **string**| Only return jobs with the given tenantId. | [optional] 
 **tenantIdLike** | **string**| Only return jobs with a tenantId like the given value. | [optional] 
 **withoutTenantId** | **bool?**| If true, only returns jobs without a tenantId set. If false, the withoutTenantId parameter is ignored. | [optional] 
 **locked** | **bool?**| If true, only return jobs which are locked.  If false, this parameter is ignored. | [optional] 
 **unlocked** | **bool?**| If true, only return jobs which are unlocked. If false, this parameter is ignored. | [optional] 
 **sort** | **string**| Property to sort on, to be used together with the order. | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

