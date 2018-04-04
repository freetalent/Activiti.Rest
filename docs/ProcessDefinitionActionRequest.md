# IO.Swagger.Model.ProcessDefinitionActionRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** |  | [optional] 
**IncludeProcessInstances** | **bool?** | Whether or not to suspend/activate running process-instances for this process-definition. If omitted, the process-instances are left in the state they are | [optional] [default to false]
**Date** | **DateTime?** | Date (ISO-8601) when the suspension/activation should be executed. If omitted, the suspend/activation is effective immediately. | [optional] 
**Category** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

