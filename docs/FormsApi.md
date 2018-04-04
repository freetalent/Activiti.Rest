# IO.Swagger.Api.FormsApi

All URIs are relative to *http://localhost:8080/activiti-rest/service*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFormData**](FormsApi.md#getformdata) | **GET** /form/form-data | Get form data
[**SubmitForm**](FormsApi.md#submitform) | **POST** /form/form-data | Submit task form data


<a name="getformdata"></a>
# **GetFormData**
> FormDataResponse GetFormData (string taskId = null, string processDefinitionId = null)

Get form data

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFormDataExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FormsApi();
            var taskId = taskId_example;  // string | The task id corresponding to the form data that needs to be retrieved. (optional) 
            var processDefinitionId = processDefinitionId_example;  // string | The process definition id corresponding to the start event form data that needs to be retrieved. (optional) 

            try
            {
                // Get form data
                FormDataResponse result = apiInstance.GetFormData(taskId, processDefinitionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FormsApi.GetFormData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| The task id corresponding to the form data that needs to be retrieved. | [optional] 
 **processDefinitionId** | **string**| The process definition id corresponding to the start event form data that needs to be retrieved. | [optional] 

### Return type

[**FormDataResponse**](FormDataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitform"></a>
# **SubmitForm**
> ProcessInstanceResponse SubmitForm (SubmitFormRequest body = null)

Submit task form data

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SubmitFormExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FormsApi();
            var body = new SubmitFormRequest(); // SubmitFormRequest |  (optional) 

            try
            {
                // Submit task form data
                ProcessInstanceResponse result = apiInstance.SubmitForm(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FormsApi.SubmitForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmitFormRequest**](SubmitFormRequest.md)|  | [optional] 

### Return type

[**ProcessInstanceResponse**](ProcessInstanceResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

