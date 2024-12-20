/*
 * 02_Messwerte
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing MessStationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MessStationApiTests : IDisposable
    {
        private MessStationApi instance;

        public MessStationApiTests()
        {
            instance = new MessStationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MessStationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MessStationApi
            //Assert.IsType<MessStationApi>(instance);
        }

        /// <summary>
        /// Test ApiMesstationenGet
        /// </summary>
        [Fact]
        public void ApiMesstationenGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiMesstationenGet();
            //Assert.IsType<List<GetMessStationDto>>(response);
        }

        /// <summary>
        /// Test ApiMesstationenIdDelete
        /// </summary>
        [Fact]
        public void ApiMesstationenIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.ApiMesstationenIdDelete(id);
        }

        /// <summary>
        /// Test ApiMesstationenIdGet
        /// </summary>
        [Fact]
        public void ApiMesstationenIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.ApiMesstationenIdGet(id);
            //Assert.IsType<GetMessStationDto>(response);
        }

        /// <summary>
        /// Test ApiMesstationenIdPut
        /// </summary>
        [Fact]
        public void ApiMesstationenIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //PostMessStationDto? postMessStationDto = null;
            //instance.ApiMesstationenIdPut(id, postMessStationDto);
        }

        /// <summary>
        /// Test ApiMesstationenPost
        /// </summary>
        [Fact]
        public void ApiMesstationenPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostMessStationDto? postMessStationDto = null;
            //var response = instance.ApiMesstationenPost(postMessStationDto);
            //Assert.IsType<GetMessStationDto>(response);
        }

        /// <summary>
        /// Test ApiMesstationenStationIdMesswerteGet
        /// </summary>
        [Fact]
        public void ApiMesstationenStationIdMesswerteGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int stationId = null;
            //var response = instance.ApiMesstationenStationIdMesswerteGet(stationId);
            //Assert.IsType<GetMessStationDto>(response);
        }

        /// <summary>
        /// Test ApiMesstationenStationIdMesswerteMessWertIdDelete
        /// </summary>
        [Fact]
        public void ApiMesstationenStationIdMesswerteMessWertIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int stationId = null;
            //int messWertId = null;
            //var response = instance.ApiMesstationenStationIdMesswerteMessWertIdDelete(stationId, messWertId);
            //Assert.IsType<GetMessStationDto>(response);
        }

        /// <summary>
        /// Test ApiMesstationenStationIdMesswerteMessWertIdGet
        /// </summary>
        [Fact]
        public void ApiMesstationenStationIdMesswerteMessWertIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int stationId = null;
            //int messWertId = null;
            //var response = instance.ApiMesstationenStationIdMesswerteMessWertIdGet(stationId, messWertId);
            //Assert.IsType<GetMessStationDto>(response);
        }

        /// <summary>
        /// Test ApiMesstationenStationIdMesswertePost
        /// </summary>
        [Fact]
        public void ApiMesstationenStationIdMesswertePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int stationId = null;
            //PostMessWertDto? postMessWertDto = null;
            //var response = instance.ApiMesstationenStationIdMesswertePost(stationId, postMessWertDto);
            //Assert.IsType<GetMessStationDto>(response);
        }
    }
}
