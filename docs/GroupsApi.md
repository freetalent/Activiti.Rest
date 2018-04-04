# IO.Swagger.Api.GroupsApi

All URIs are relative to *http://localhost:8080/activiti-rest/service*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGroup**](GroupsApi.md#creategroup) | **POST** /identity/groups | Create a group
[**CreateMembership**](GroupsApi.md#createmembership) | **POST** /identity/groups/{groupId}/members | Add a member to a group
[**DeleteGroup**](GroupsApi.md#deletegroup) | **DELETE** /identity/groups/{groupId} | Delete a group
[**DeleteMembership**](GroupsApi.md#deletemembership) | **DELETE** /identity/groups/{groupId}/members/{userId} | Delete a member from a group
[**GetGroup**](GroupsApi.md#getgroup) | **GET** /identity/groups/{groupId} | Get a single group
[**GetGroups**](GroupsApi.md#getgroups) | **GET** /identity/groups | Get a list of groups
[**UpdateGroup**](GroupsApi.md#updategroup) | **PUT** /identity/groups/{groupId} | Update a group


<a name="creategroup"></a>
# **CreateGroup**
> GroupResponse CreateGroup (GroupRequest body = null)

Create a group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateGroupExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var body = new GroupRequest(); // GroupRequest |  (optional) 

            try
            {
                // Create a group
                GroupResponse result = apiInstance.CreateGroup(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.CreateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GroupRequest**](GroupRequest.md)|  | [optional] 

### Return type

[**GroupResponse**](GroupResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmembership"></a>
# **CreateMembership**
> MembershipResponse CreateMembership (string groupId, MembershipRequest body = null)

Add a member to a group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateMembershipExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | The id of the group to add a member to.
            var body = new MembershipRequest(); // MembershipRequest |  (optional) 

            try
            {
                // Add a member to a group
                MembershipResponse result = apiInstance.CreateMembership(groupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.CreateMembership: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| The id of the group to add a member to. | 
 **body** | [**MembershipRequest**](MembershipRequest.md)|  | [optional] 

### Return type

[**MembershipResponse**](MembershipResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroup"></a>
# **DeleteGroup**
> void DeleteGroup (string groupId)

Delete a group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | The id of the group to delete.

            try
            {
                // Delete a group
                apiInstance.DeleteGroup(groupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| The id of the group to delete. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemembership"></a>
# **DeleteMembership**
> void DeleteMembership (string groupId, string userId)

Delete a member from a group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteMembershipExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | The id of the group to remove a member from.
            var userId = userId_example;  // string | The id of the user to remove.

            try
            {
                // Delete a member from a group
                apiInstance.DeleteMembership(groupId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteMembership: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| The id of the group to remove a member from. | 
 **userId** | **string**| The id of the user to remove. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroup"></a>
# **GetGroup**
> GroupResponse GetGroup (string groupId)

Get a single group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | The id of the group to get.

            try
            {
                // Get a single group
                GroupResponse result = apiInstance.GetGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| The id of the group to get. | 

### Return type

[**GroupResponse**](GroupResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroups"></a>
# **GetGroups**
> DataResponse GetGroups (string id = null, string name = null, string type = null, string nameLike = null, string member = null, string potentialStarter = null, string sort = null)

Get a list of groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var id = id_example;  // string | Only return group with the given id (optional) 
            var name = name_example;  // string | Only return groups with the given name (optional) 
            var type = type_example;  // string | Only return groups with the given type (optional) 
            var nameLike = nameLike_example;  // string | Only return groups with a name like the given value. Use % as wildcard-character. (optional) 
            var member = member_example;  // string | Only return groups which have a member with the given username. (optional) 
            var potentialStarter = potentialStarter_example;  // string | Only return groups which members are potential starters for a process-definition with the given id. (optional) 
            var sort = sort_example;  // string | Property to sort on, to be used together with the order. (optional) 

            try
            {
                // Get a list of groups
                DataResponse result = apiInstance.GetGroups(id, name, type, nameLike, member, potentialStarter, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Only return group with the given id | [optional] 
 **name** | **string**| Only return groups with the given name | [optional] 
 **type** | **string**| Only return groups with the given type | [optional] 
 **nameLike** | **string**| Only return groups with a name like the given value. Use % as wildcard-character. | [optional] 
 **member** | **string**| Only return groups which have a member with the given username. | [optional] 
 **potentialStarter** | **string**| Only return groups which members are potential starters for a process-definition with the given id. | [optional] 
 **sort** | **string**| Property to sort on, to be used together with the order. | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroup"></a>
# **UpdateGroup**
> GroupResponse UpdateGroup (string groupId, GroupRequest body = null)

Update a group

All request values are optional. For example, you can only include the name attribute in the request body JSON-object, only updating the name of the group, leaving all other fields unaffected. When an attribute is explicitly included and is set to null, the group-value will be updated to null.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateGroupExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | 
            var body = new GroupRequest(); // GroupRequest |  (optional) 

            try
            {
                // Update a group
                GroupResponse result = apiInstance.UpdateGroup(groupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**|  | 
 **body** | [**GroupRequest**](GroupRequest.md)|  | [optional] 

### Return type

[**GroupResponse**](GroupResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

