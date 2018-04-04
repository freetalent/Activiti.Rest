# IO.Swagger.Model.HistoricProcessInstanceQueryRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Start** | **int?** |  | [optional] 
**Size** | **int?** |  | [optional] 
**Sort** | **string** |  | [optional] 
**Order** | **string** |  | [optional] 
**ProcessInstanceId** | **string** |  | [optional] 
**ProcessInstanceIds** | **List&lt;string&gt;** |  | [optional] 
**ProcessBusinessKey** | **string** |  | [optional] 
**ProcessDefinitionId** | **string** |  | [optional] 
**ProcessDefinitionKey** | **string** |  | [optional] 
**SuperProcessInstanceId** | **string** |  | [optional] 
**ExcludeSubprocesses** | **bool?** |  | [optional] [default to false]
**Finished** | **bool?** |  | [optional] [default to false]
**InvolvedUser** | **string** |  | [optional] 
**FinishedAfter** | **DateTime?** |  | [optional] 
**FinishedBefore** | **DateTime?** |  | [optional] 
**StartedAfter** | **DateTime?** |  | [optional] 
**StartedBefore** | **DateTime?** |  | [optional] 
**StartedBy** | **string** |  | [optional] 
**IncludeProcessVariables** | **bool?** |  | [optional] [default to false]
**Variables** | [**List&lt;QueryVariable&gt;**](QueryVariable.md) |  | [optional] 
**TenantId** | **string** |  | [optional] 
**TenantIdLike** | **string** |  | [optional] 
**WithoutTenantId** | **bool?** |  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

