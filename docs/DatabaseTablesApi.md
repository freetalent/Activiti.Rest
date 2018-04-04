# IO.Swagger.Api.DatabaseTablesApi

All URIs are relative to *http://localhost:8080/activiti-rest/service*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTable**](DatabaseTablesApi.md#gettable) | **GET** /management/tables/{tableName} | Get a single table
[**GetTableData**](DatabaseTablesApi.md#gettabledata) | **GET** /management/tables/{tableName}/data | Get row data for a single table
[**GetTableMetaData**](DatabaseTablesApi.md#gettablemetadata) | **GET** /management/tables/{tableName}/columns | Get column info for a single table
[**GetTables**](DatabaseTablesApi.md#gettables) | **GET** /management/tables |  List of tables


<a name="gettable"></a>
# **GetTable**
> TableResponse GetTable (string tableName)

Get a single table

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTableExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DatabaseTablesApi();
            var tableName = tableName_example;  // string | The name of the table to get.

            try
            {
                // Get a single table
                TableResponse result = apiInstance.GetTable(tableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatabaseTablesApi.GetTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| The name of the table to get. | 

### Return type

[**TableResponse**](TableResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettabledata"></a>
# **GetTableData**
> DataResponse GetTableData (string tableName, int? start = null, int? size = null, string orderAscendingColumn = null, string orderDescendingColumn = null)

Get row data for a single table

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTableDataExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DatabaseTablesApi();
            var tableName = tableName_example;  // string | The name of the table to get.
            var start = 56;  // int? | Index of the first row to fetch. Defaults to 0. (optional) 
            var size = 56;  // int? | Number of rows to fetch, starting from start. Defaults to 10. (optional) 
            var orderAscendingColumn = orderAscendingColumn_example;  // string | Name of the column to sort the resulting rows on, ascending. (optional) 
            var orderDescendingColumn = orderDescendingColumn_example;  // string | Name of the column to sort the resulting rows on, descending. (optional) 

            try
            {
                // Get row data for a single table
                DataResponse result = apiInstance.GetTableData(tableName, start, size, orderAscendingColumn, orderDescendingColumn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatabaseTablesApi.GetTableData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| The name of the table to get. | 
 **start** | **int?**| Index of the first row to fetch. Defaults to 0. | [optional] 
 **size** | **int?**| Number of rows to fetch, starting from start. Defaults to 10. | [optional] 
 **orderAscendingColumn** | **string**| Name of the column to sort the resulting rows on, ascending. | [optional] 
 **orderDescendingColumn** | **string**| Name of the column to sort the resulting rows on, descending. | [optional] 

### Return type

[**DataResponse**](DataResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettablemetadata"></a>
# **GetTableMetaData**
> TableMetaData GetTableMetaData (string tableName)

Get column info for a single table

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTableMetaDataExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DatabaseTablesApi();
            var tableName = tableName_example;  // string | The name of the table to get.

            try
            {
                // Get column info for a single table
                TableMetaData result = apiInstance.GetTableMetaData(tableName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatabaseTablesApi.GetTableMetaData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| The name of the table to get. | 

### Return type

[**TableMetaData**](TableMetaData.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettables"></a>
# **GetTables**
> List<TableResponse> GetTables ()

 List of tables

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTablesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DatabaseTablesApi();

            try
            {
                //  List of tables
                List&lt;TableResponse&gt; result = apiInstance.GetTables();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatabaseTablesApi.GetTables: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TableResponse>**](TableResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

