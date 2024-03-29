/* 
 * Ukraine Alert API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3.0
 * Contact: support@stfalcon.com
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

using UkraineAlarm.Client;
using UkraineAlarm.Api;
using UkraineAlarm.Model;

namespace UkraineAlarm.Test
{
    /// <summary>
    ///  Class for testing AlertsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AlertsApiTests
    {
        private AlertsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AlertsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AlertsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AlertsApi
            //Assert.IsInstanceOfType(typeof(AlertsApi), instance, "instance is a AlertsApi");
        }

        /// <summary>
        /// Test ApiV3AlertsGet
        /// </summary>
        [Test]
        public void ApiV3AlertsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiV3AlertsGet();
            //Assert.IsInstanceOf<List<AlertRegionModel>> (response, "response is List<AlertRegionModel>");
        }
        /// <summary>
        /// Test ApiV3AlertsRegionHistoryGet
        /// </summary>
        [Test]
        public void ApiV3AlertsRegionHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string regionId = null;
            //var response = instance.ApiV3AlertsRegionHistoryGet(regionId);
            //Assert.IsInstanceOf<List<RegionAlarmsHistory>> (response, "response is List<RegionAlarmsHistory>");
        }
        /// <summary>
        /// Test ApiV3AlertsRegionIdGet
        /// </summary>
        [Test]
        public void ApiV3AlertsRegionIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string regionId = null;
            //var response = instance.ApiV3AlertsRegionIdGet(regionId);
            //Assert.IsInstanceOf<List<AlertRegionModel>> (response, "response is List<AlertRegionModel>");
        }
        /// <summary>
        /// Test ApiV3AlertsStatusGet
        /// </summary>
        [Test]
        public void ApiV3AlertsStatusGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiV3AlertsStatusGet();
            //Assert.IsInstanceOf<AlertModification> (response, "response is AlertModification");
        }
    }

}
