# IO.Swagger.Model.SignalEventReceivedRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SignalName** | **string** | Name of the signal | [optional] 
**Variables** | [**List&lt;RestVariable&gt;**](RestVariable.md) | Array of variables (in the general variables format) to use as payload to pass along with the signal. Cannot be used in case async is set to true, this will result in an error. | [optional] 
**TenantId** | **string** | ID of the tenant that the signal event should be processed in | [optional] 
**Async** | **bool?** | If true, handling of the signal will happen asynchronously. Return code will be 202 - Accepted to indicate the request is accepted but not yet executed. If false,                     handling the signal will be done immediately and result (200 - OK) will only return after this completed successfully. Defaults to false if omitted. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

