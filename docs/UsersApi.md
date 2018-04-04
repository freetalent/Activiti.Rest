# IO.Swagger.Api.UsersApi

All URIs are relative to *http://localhost:8080/activiti-rest/service*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUser**](UsersApi.md#createuser) | **POST** /identity/users | Create a user
[**CreateUserInfo**](UsersApi.md#createuserinfo) | **POST** /identity/users/{userId}/info | Create a new user�s info entry
[**DeleteUser**](UsersApi.md#deleteuser) | **DELETE** /identity/users/{userId} | Delete a user
[**DeleteUserInfo**](UsersApi.md#deleteuserinfo) | **DELETE** /identity/users/{userId}/info/{key} | Delete a user�s info
[**GetUser**](UsersApi.md#getuser) | **GET** /identity/users/{userId} | Get a single user
[**GetUserInfo**](UsersApi.md#getuserinfo) | **GET** /identity/users/{userId}/info/{key} | Get a user�s info
[**GetUserPicture**](UsersApi.md#getuserpicture) | **GET** /identity/users/{userId}/picture | Get a user�s picture
[**GetUsers**](UsersApi.md#getusers) | **GET** /identity/users | Get a list of users
[**ListUsersInfo**](UsersApi.md#listusersinfo) | **GET** /identity/users/{userId}/info | List a user�s info
[**UpdateUser**](UsersApi.md#updateuser) | **PUT** /identity/users/{userId} | Update a user
[**UpdateUserInfo**](UsersApi.md#updateuserinfo) | **PUT** /identity/users/{userId}/info/{key} | Update a user�s info
[**UpdateUserPicture**](UsersApi.md#updateuserpicture) | **PUT** /identity/users/{userId}/picture | Updating a user�s picture


<a name="createuser"></a>
# **CreateUser**
> UserResponse CreateUser (UserRequest body = null)

Create a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateUserExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var body = new UserRequest(); // UserRequest |  (optional) 

            try
            {
                // Create a user
                UserResponse result = apiInstance.CreateUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserRequest**](UserRequest.md)|  | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuserinfo"></a>
# **CreateUserInfo**
> UserInfoResponse CreateUserInfo (string userId, UserInfoRequest body = null)

Create a new user�s info entry

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateUserInfoExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | The id of the user to create the info for.
            var body = new UserInfoRequest(); // UserInfoRequest |  (optional) 

            try
            {
                // Create a new user�s info entry
                UserInfoResponse result = apiInstance.CreateUserInfo(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUserInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user to create the info for. | 
 **body** | [**UserInfoRequest**](UserInfoRequest.md)|  | [optional] 

### Return type

[**UserInfoResponse**](UserInfoResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string userId)

Delete a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | The id of the user to delete.

            try
            {
                // Delete a user
                apiInstance.DeleteUser(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user to delete. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuserinfo"></a>
# **DeleteUserInfo**
> void DeleteUserInfo (string userId, string key)

Delete a user�s info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUserInfoExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | The id of the user to delete the info for.
            var key = key_example;  // string | The key of the user info to delete.

            try
            {
                // Delete a user�s info
                apiInstance.DeleteUserInfo(userId, key);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user to delete the info for. | 
 **key** | **string**| The key of the user info to delete. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> UserResponse GetUser (string userId)

Get a single user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | The id of the user to get.

            try
            {
                // Get a single user
                UserResponse result = apiInstance.GetUser(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user to get. | 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserinfo"></a>
# **GetUserInfo**
> UserInfoResponse GetUserInfo (string userId, string key)

Get a user�s info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserInfoExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | The id of the user to get the info for.
            var key = key_example;  // string | The key of the user info to get.

            try
            {
                // Get a user�s info
                UserInfoResponse result = apiInstance.GetUserInfo(userId, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user to get the info for. | 
 **key** | **string**| The key of the user info to get. | 

### Return type

[**UserInfoResponse**](UserInfoResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserpicture"></a>
# **GetUserPicture**
> List<byte[]> GetUserPicture (string userId)

Get a user�s picture

The response body contains the raw picture data, representing the user�s picture. The Content-type of the response corresponds to the mimeType that was set when creating the picture.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserPictureExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | The id of the user to get the picture for.

            try
            {
                // Get a user�s picture
                List&lt;byte[]&gt; result = apiInstance.GetUserPicture(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user to get the picture for. | 

### Return type

**List<byte[]>**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusers"></a>
# **GetUsers**
> DataResponse GetUsers (string id = null, string firstName = null, string lastName = null, string email = null, string firstNameLike = null, string lastNameLike = null, string emailLike = null, string memberOfGroup = null, string potentialStarter = null, string sort = null)

Get a list of users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var id = id_example;  // string | Only return group with the given id (optional) 
            var firstName = firstName_example;  // string | Only return users with the given firstname (optional) 
            var lastName = lastName_example;  // string | Only return users with the given lastname (optional) 
            var email = email_example;  // string | Only return users with the given email (optional) 
            var firstNameLike = firstNameLike_example;  // string | Only return userswith a firstname like the given value. Use % as wildcard-character. (optional) 
            var lastNameLike = lastNameLike_example;  // string | Only return users with a lastname like the given value. Use % as wildcard-character. (optional) 
            var emailLike = emailLike_example;  // string | Only return users with an email like the given value. Use % as wildcard-character. (optional) 
            var memberOfGroup = memberOfGroup_example;  // string | Only return users which are a member of the given group. (optional) 
            var potentialStarter = potentialStarter_example;  // string | Only return users  which members are potential starters for a process-definition with the given id. (optional) 
            var sort = sort_example;  // string | Field  to sort on, to be used together with the order. (optional) 

            try
            {
                // Get a list of users
                DataResponse result = apiInstance.GetUsers(id, firstName, lastName, email, firstNameLike, lastNameLike, emailLike, memberOfGroup, potentialStarter, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Only return group with the given id | [optional] 
 **firstName** | **string**| Only return users with the given firstname | [optional] 
 **lastName** | **string**| Only return users with the given lastname | [optional] 
 **email** | **string**| Only return users with the given email | [optional] 
 **firstNameLike** | **string**| Only return userswith a firstname like the given value. Use % as wildcard-character. | [optional] 
 **lastNameLike** | **string**| Only return users with a lastname like the given value. Use % as wildcard-character. | [optional] 
 **emailLike** | **string**| Only return users with an email like the given value. Use % as wildcard-character. | [optional] 
 **memberOfGroup** | **string**| Only return users which are a member of the given group. | [optional] 
 **potentialStarter** | **string**| Only return users  which members are potential starters for a process-definition with the given id. | [optional] 
 **sort** | **string**| Field  to sort on, to be used together with the order. | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listusersinfo"></a>
# **ListUsersInfo**
> List<UserInfoResponse> ListUsersInfo (string userId)

List a user�s info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListUsersInfoExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | The id of the user to get the info for.

            try
            {
                // List a user�s info
                List&lt;UserInfoResponse&gt; result = apiInstance.ListUsersInfo(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ListUsersInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user to get the info for. | 

### Return type

[**List<UserInfoResponse>**](UserInfoResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> UserResponse UpdateUser (string userId, UserRequest body = null)

Update a user

All request values are optional. For example, you can only include the firstName attribute in the request body JSON-object, only updating the firstName of the user, leaving all other fields unaffected. When an attribute is explicitly included and is set to null, the user-value will be updated to null. Example: {\"firstName\" : null} will clear the firstName of the user).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | 
            var body = new UserRequest(); // UserRequest |  (optional) 

            try
            {
                // Update a user
                UserResponse result = apiInstance.UpdateUser(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **body** | [**UserRequest**](UserRequest.md)|  | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserinfo"></a>
# **UpdateUserInfo**
> UserInfoResponse UpdateUserInfo (string userId, string key, UserInfoRequest body = null)

Update a user�s info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserInfoExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | The id of the user to update the info for.
            var key = key_example;  // string | The key of the user info to update.
            var body = new UserInfoRequest(); // UserInfoRequest |  (optional) 

            try
            {
                // Update a user�s info
                UserInfoResponse result = apiInstance.UpdateUserInfo(userId, key, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUserInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user to update the info for. | 
 **key** | **string**| The key of the user info to update. | 
 **body** | [**UserInfoRequest**](UserInfoRequest.md)|  | [optional] 

### Return type

[**UserInfoResponse**](UserInfoResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserpicture"></a>
# **UpdateUserPicture**
> void UpdateUserPicture (string userId)

Updating a user�s picture

The request should be of type multipart/form-data. There should be a single file-part included with the binary value of the picture. On top of that, the following additional form-fields can be present:  mimeType: Optional mime-type for the uploaded picture. If omitted, the default of image/jpeg is used as a mime-type for the picture.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserPictureExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | The id of the user to get the picture for.

            try
            {
                // Updating a user�s picture
                apiInstance.UpdateUserPicture(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUserPicture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user to get the picture for. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

