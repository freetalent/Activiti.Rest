# IO.Swagger.Model.AttachmentResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Url** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**UserId** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Type** | **string** | Can be any arbitrary value. When a valid formatted media-type (e.g. application/xml, text/plain) is included, the binary content HTTP response content-type will be set the the given value. | [optional] 
**TaskUrl** | **string** |  | [optional] 
**ProcessInstanceUrl** | **string** |  | [optional] 
**ExternalUrl** | **string** | contentUrl:In case the attachment is a link to an external resource, the externalUrl contains the URL to the external content. If the attachment content is present in the Activiti engine, the contentUrl will contain an URL where the binary content can be streamed from. | [optional] 
**ContentUrl** | **string** |  | [optional] 
**Time** | **DateTime?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

