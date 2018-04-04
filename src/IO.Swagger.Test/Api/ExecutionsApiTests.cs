/* 
 * Activiti REST API
 *
 * # activiti     - Activiti is battle-tested Business Process Management. Organizations across the world depend on the open source platform in a huge range of demanding situations. It supports open standards with BPMN and DMN so you can create processes that suit you.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Activiti.Rest.Client;
using Activiti.Rest.Api;
using Activiti.Rest.Model;

namespace Activiti.Rest.Test
{
    /// <summary>
    ///  Class for testing ExecutionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ExecutionsApiTests
    {
        private ExecutionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExecutionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExecutionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ExecutionsApi
            //Assert.IsInstanceOfType(typeof(ExecutionsApi), instance, "instance is a ExecutionsApi");
        }

        
        /// <summary>
        /// Test CreateExecutionVariable
        /// </summary>
        [Test]
        public void CreateExecutionVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string executionId = null;
            //var response = instance.CreateExecutionVariable(executionId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test CreateOrUpdateExecutionVariable
        /// </summary>
        [Test]
        public void CreateOrUpdateExecutionVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string executionId = null;
            //var response = instance.CreateOrUpdateExecutionVariable(executionId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DeleteLocalVariables
        /// </summary>
        [Test]
        public void DeleteLocalVariablesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string executionId = null;
            //instance.DeleteLocalVariables(executionId);
            
        }
        
        /// <summary>
        /// Test DeletedExecutionVariable
        /// </summary>
        [Test]
        public void DeletedExecutionVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string executionId = null;
            //string variableName = null;
            //string scope = null;
            //instance.DeletedExecutionVariable(executionId, variableName, scope);
            
        }
        
        /// <summary>
        /// Test ExecuteExecutionAction
        /// </summary>
        [Test]
        public void ExecuteExecutionActionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ExecutionActionRequest body = null;
            //instance.ExecuteExecutionAction(body);
            
        }
        
        /// <summary>
        /// Test GetActiveActivities
        /// </summary>
        [Test]
        public void GetActiveActivitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string executionId = null;
            //var response = instance.GetActiveActivities(executionId);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetExecution
        /// </summary>
        [Test]
        public void GetExecutionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string executionId = null;
            //var response = instance.GetExecution(executionId);
            //Assert.IsInstanceOf<ExecutionResponse> (response, "response is ExecutionResponse");
        }
        
        /// <summary>
        /// Test GetExecutionVariable
        /// </summary>
        [Test]
        public void GetExecutionVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string executionId = null;
            //string variableName = null;
            //string scope = null;
            //var response = instance.GetExecutionVariable(executionId, variableName, scope);
            //Assert.IsInstanceOf<RestVariable> (response, "response is RestVariable");
        }
        
        /// <summary>
        /// Test GetExecutionVariableData
        /// </summary>
        [Test]
        public void GetExecutionVariableDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string executionId = null;
            //string variableName = null;
            //string scope = null;
            //var response = instance.GetExecutionVariableData(executionId, variableName, scope);
            //Assert.IsInstanceOf<List<byte[]>> (response, "response is List<byte[]>");
        }
        
        /// <summary>
        /// Test GetExecutions
        /// </summary>
        [Test]
        public void GetExecutionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string activityId = null;
            //string processDefinitionKey = null;
            //string processDefinitionId = null;
            //string processInstanceId = null;
            //string messageEventSubscriptionName = null;
            //string signalEventSubscriptionName = null;
            //string parentId = null;
            //string tenantId = null;
            //string tenantIdLike = null;
            //bool? withoutTenantId = null;
            //string sort = null;
            //var response = instance.GetExecutions(id, activityId, processDefinitionKey, processDefinitionId, processInstanceId, messageEventSubscriptionName, signalEventSubscriptionName, parentId, tenantId, tenantIdLike, withoutTenantId, sort);
            //Assert.IsInstanceOf<DataResponse> (response, "response is DataResponse");
        }
        
        /// <summary>
        /// Test ListExecutionVariables
        /// </summary>
        [Test]
        public void ListExecutionVariablesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string executionId = null;
            //string scope = null;
            //var response = instance.ListExecutionVariables(executionId, scope);
            //Assert.IsInstanceOf<List<RestVariable>> (response, "response is List<RestVariable>");
        }
        
        /// <summary>
        /// Test PerformExecutionAction
        /// </summary>
        [Test]
        public void PerformExecutionActionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string executionId = null;
            //ExecutionActionRequest body = null;
            //var response = instance.PerformExecutionAction(executionId, body);
            //Assert.IsInstanceOf<ExecutionResponse> (response, "response is ExecutionResponse");
        }
        
        /// <summary>
        /// Test QueryExecutions
        /// </summary>
        [Test]
        public void QueryExecutionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ExecutionQueryRequest body = null;
            //var response = instance.QueryExecutions(body);
            //Assert.IsInstanceOf<DataResponse> (response, "response is DataResponse");
        }
        
        /// <summary>
        /// Test UpdateExecutionVariable
        /// </summary>
        [Test]
        public void UpdateExecutionVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string executionId = null;
            //string variableName = null;
            //var response = instance.UpdateExecutionVariable(executionId, variableName);
            //Assert.IsInstanceOf<RestVariable> (response, "response is RestVariable");
        }
        
    }

}