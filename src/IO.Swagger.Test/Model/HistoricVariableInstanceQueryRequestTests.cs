/* 
 * Activiti REST API
 *
 * # activiti     - Activiti is battle-tested Business Process Management. Organizations across the world depend on the open source platform in a huge range of demanding situations. It supports open standards with BPMN and DMN so you can create processes that suit you.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Activiti.Rest.Api;
using Activiti.Rest.Model;
using Activiti.Rest.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Activiti.Rest.Test
{
    /// <summary>
    ///  Class for testing HistoricVariableInstanceQueryRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class HistoricVariableInstanceQueryRequestTests
    {
        // TODO uncomment below to declare an instance variable for HistoricVariableInstanceQueryRequest
        //private HistoricVariableInstanceQueryRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of HistoricVariableInstanceQueryRequest
            //instance = new HistoricVariableInstanceQueryRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HistoricVariableInstanceQueryRequest
        /// </summary>
        [Test]
        public void HistoricVariableInstanceQueryRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" HistoricVariableInstanceQueryRequest
            //Assert.IsInstanceOfType<HistoricVariableInstanceQueryRequest> (instance, "variable 'instance' is a HistoricVariableInstanceQueryRequest");
        }


        /// <summary>
        /// Test the property 'ExcludeTaskVariables'
        /// </summary>
        [Test]
        public void ExcludeTaskVariablesTest()
        {
            // TODO unit test for the property 'ExcludeTaskVariables'
        }
        /// <summary>
        /// Test the property 'TaskId'
        /// </summary>
        [Test]
        public void TaskIdTest()
        {
            // TODO unit test for the property 'TaskId'
        }
        /// <summary>
        /// Test the property 'ExecutionId'
        /// </summary>
        [Test]
        public void ExecutionIdTest()
        {
            // TODO unit test for the property 'ExecutionId'
        }
        /// <summary>
        /// Test the property 'ProcessInstanceId'
        /// </summary>
        [Test]
        public void ProcessInstanceIdTest()
        {
            // TODO unit test for the property 'ProcessInstanceId'
        }
        /// <summary>
        /// Test the property 'VariableName'
        /// </summary>
        [Test]
        public void VariableNameTest()
        {
            // TODO unit test for the property 'VariableName'
        }
        /// <summary>
        /// Test the property 'VariableNameLike'
        /// </summary>
        [Test]
        public void VariableNameLikeTest()
        {
            // TODO unit test for the property 'VariableNameLike'
        }
        /// <summary>
        /// Test the property 'Variables'
        /// </summary>
        [Test]
        public void VariablesTest()
        {
            // TODO unit test for the property 'Variables'
        }

    }

}