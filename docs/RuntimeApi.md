# IO.Swagger.Api.RuntimeApi

All URIs are relative to *http://localhost:8080/activiti-rest/service*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SignalEventReceived**](RuntimeApi.md#signaleventreceived) | **POST** /runtime/signals | Signal event received


<a name="signaleventreceived"></a>
# **SignalEventReceived**
> void SignalEventReceived (SignalEventReceivedRequest body = null)

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
    public class SignalEventReceivedExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RuntimeApi();
            var body = new SignalEventReceivedRequest(); // SignalEventReceivedRequest |  (optional) 

            try
            {
                // Signal event received
                apiInstance.SignalEventReceived(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RuntimeApi.SignalEventReceived: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SignalEventReceivedRequest**](SignalEventReceivedRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

