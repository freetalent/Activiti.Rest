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
    ///  Class for testing DeploymentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DeploymentApiTests
    {
        private DeploymentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DeploymentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DeploymentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DeploymentApi
            //Assert.IsInstanceOfType(typeof(DeploymentApi), instance, "instance is a DeploymentApi");
        }

        
        /// <summary>
        /// Test DeleteDeployment
        /// </summary>
        [Test]
        public void DeleteDeploymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentId = null;
            //bool? cascade = null;
            //instance.DeleteDeployment(deploymentId, cascade);
            
        }
        
        /// <summary>
        /// Test GetDeployment
        /// </summary>
        [Test]
        public void GetDeploymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentId = null;
            //var response = instance.GetDeployment(deploymentId);
            //Assert.IsInstanceOf<DeploymentResponse> (response, "response is DeploymentResponse");
        }
        
        /// <summary>
        /// Test GetDeploymentResource
        /// </summary>
        [Test]
        public void GetDeploymentResourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentId = null;
            //var response = instance.GetDeploymentResource(deploymentId);
            //Assert.IsInstanceOf<DeploymentResourceResponse> (response, "response is DeploymentResourceResponse");
        }
        
        /// <summary>
        /// Test GetDeploymentResourceData
        /// </summary>
        [Test]
        public void GetDeploymentResourceDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentId = null;
            //string resourceId = null;
            //var response = instance.GetDeploymentResourceData(deploymentId, resourceId);
            //Assert.IsInstanceOf<List<byte[]>> (response, "response is List<byte[]>");
        }
        
        /// <summary>
        /// Test GetDeploymentResources
        /// </summary>
        [Test]
        public void GetDeploymentResourcesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentId = null;
            //var response = instance.GetDeploymentResources(deploymentId);
            //Assert.IsInstanceOf<List<DeploymentResourceResponse>> (response, "response is List<DeploymentResourceResponse>");
        }
        
        /// <summary>
        /// Test GetDeployments
        /// </summary>
        [Test]
        public void GetDeploymentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string nameLike = null;
            //string category = null;
            //string categoryNotEquals = null;
            //string tenantId = null;
            //string tenantIdLike = null;
            //string withoutTenantId = null;
            //string sort = null;
            //var response = instance.GetDeployments(name, nameLike, category, categoryNotEquals, tenantId, tenantIdLike, withoutTenantId, sort);
            //Assert.IsInstanceOf<DataResponse> (response, "response is DataResponse");
        }
        
        /// <summary>
        /// Test UploadDeployment
        /// </summary>
        [Test]
        public void UploadDeploymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //var response = instance.UploadDeployment(tenantId);
            //Assert.IsInstanceOf<DeploymentResponse> (response, "response is DeploymentResponse");
        }
        
    }

}
