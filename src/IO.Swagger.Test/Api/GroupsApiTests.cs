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
    ///  Class for testing GroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GroupsApiTests
    {
        private GroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GroupsApi
            //Assert.IsInstanceOfType(typeof(GroupsApi), instance, "instance is a GroupsApi");
        }

        
        /// <summary>
        /// Test CreateGroup
        /// </summary>
        [Test]
        public void CreateGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GroupRequest body = null;
            //var response = instance.CreateGroup(body);
            //Assert.IsInstanceOf<GroupResponse> (response, "response is GroupResponse");
        }
        
        /// <summary>
        /// Test CreateMembership
        /// </summary>
        [Test]
        public void CreateMembershipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupId = null;
            //MembershipRequest body = null;
            //var response = instance.CreateMembership(groupId, body);
            //Assert.IsInstanceOf<MembershipResponse> (response, "response is MembershipResponse");
        }
        
        /// <summary>
        /// Test DeleteGroup
        /// </summary>
        [Test]
        public void DeleteGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupId = null;
            //instance.DeleteGroup(groupId);
            
        }
        
        /// <summary>
        /// Test DeleteMembership
        /// </summary>
        [Test]
        public void DeleteMembershipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupId = null;
            //string userId = null;
            //instance.DeleteMembership(groupId, userId);
            
        }
        
        /// <summary>
        /// Test GetGroup
        /// </summary>
        [Test]
        public void GetGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupId = null;
            //var response = instance.GetGroup(groupId);
            //Assert.IsInstanceOf<GroupResponse> (response, "response is GroupResponse");
        }
        
        /// <summary>
        /// Test GetGroups
        /// </summary>
        [Test]
        public void GetGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string name = null;
            //string type = null;
            //string nameLike = null;
            //string member = null;
            //string potentialStarter = null;
            //string sort = null;
            //var response = instance.GetGroups(id, name, type, nameLike, member, potentialStarter, sort);
            //Assert.IsInstanceOf<DataResponse> (response, "response is DataResponse");
        }
        
        /// <summary>
        /// Test UpdateGroup
        /// </summary>
        [Test]
        public void UpdateGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupId = null;
            //GroupRequest body = null;
            //var response = instance.UpdateGroup(groupId, body);
            //Assert.IsInstanceOf<GroupResponse> (response, "response is GroupResponse");
        }
        
    }

}