/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.7.10
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

using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Model;

namespace Kubernetes.DotNet.Test
{
    /// <summary>
    ///  Class for testing Admissionregistration_v1alpha1Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Admissionregistration_v1alpha1ApiTests
    {
        private Admissionregistration_v1alpha1Api instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Admissionregistration_v1alpha1Api();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Admissionregistration_v1alpha1Api
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Admissionregistration_v1alpha1Api
            //Assert.IsInstanceOfType(typeof(Admissionregistration_v1alpha1Api), instance, "instance is a Admissionregistration_v1alpha1Api");
        }

        
        /// <summary>
        /// Test CreateExternalAdmissionHookConfiguration
        /// </summary>
        [Test]
        public void CreateExternalAdmissionHookConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //V1alpha1ExternalAdmissionHookConfiguration body = null;
            //string pretty = null;
            //var response = instance.CreateExternalAdmissionHookConfiguration(body, pretty);
            //Assert.IsInstanceOf<V1alpha1ExternalAdmissionHookConfiguration> (response, "response is V1alpha1ExternalAdmissionHookConfiguration");
        }
        
        /// <summary>
        /// Test CreateInitializerConfiguration
        /// </summary>
        [Test]
        public void CreateInitializerConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //V1alpha1InitializerConfiguration body = null;
            //string pretty = null;
            //var response = instance.CreateInitializerConfiguration(body, pretty);
            //Assert.IsInstanceOf<V1alpha1InitializerConfiguration> (response, "response is V1alpha1InitializerConfiguration");
        }
        
        /// <summary>
        /// Test DeleteCollectionExternalAdmissionHookConfiguration
        /// </summary>
        [Test]
        public void DeleteCollectionExternalAdmissionHookConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pretty = null;
            //string fieldSelector = null;
            //bool? includeUninitialized = null;
            //string labelSelector = null;
            //string resourceVersion = null;
            //int? timeoutSeconds = null;
            //bool? watch = null;
            //var response = instance.DeleteCollectionExternalAdmissionHookConfiguration(pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
            //Assert.IsInstanceOf<V1Status> (response, "response is V1Status");
        }
        
        /// <summary>
        /// Test DeleteCollectionInitializerConfiguration
        /// </summary>
        [Test]
        public void DeleteCollectionInitializerConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pretty = null;
            //string fieldSelector = null;
            //bool? includeUninitialized = null;
            //string labelSelector = null;
            //string resourceVersion = null;
            //int? timeoutSeconds = null;
            //bool? watch = null;
            //var response = instance.DeleteCollectionInitializerConfiguration(pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
            //Assert.IsInstanceOf<V1Status> (response, "response is V1Status");
        }
        
        /// <summary>
        /// Test DeleteExternalAdmissionHookConfiguration
        /// </summary>
        [Test]
        public void DeleteExternalAdmissionHookConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //V1DeleteOptions body = null;
            //string pretty = null;
            //int? gracePeriodSeconds = null;
            //bool? orphanDependents = null;
            //string propagationPolicy = null;
            //var response = instance.DeleteExternalAdmissionHookConfiguration(name, body, pretty, gracePeriodSeconds, orphanDependents, propagationPolicy);
            //Assert.IsInstanceOf<V1Status> (response, "response is V1Status");
        }
        
        /// <summary>
        /// Test DeleteInitializerConfiguration
        /// </summary>
        [Test]
        public void DeleteInitializerConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //V1DeleteOptions body = null;
            //string pretty = null;
            //int? gracePeriodSeconds = null;
            //bool? orphanDependents = null;
            //string propagationPolicy = null;
            //var response = instance.DeleteInitializerConfiguration(name, body, pretty, gracePeriodSeconds, orphanDependents, propagationPolicy);
            //Assert.IsInstanceOf<V1Status> (response, "response is V1Status");
        }
        
        /// <summary>
        /// Test GetAPIResources
        /// </summary>
        [Test]
        public void GetAPIResourcesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAPIResources();
            //Assert.IsInstanceOf<V1APIResourceList> (response, "response is V1APIResourceList");
        }
        
        /// <summary>
        /// Test ListExternalAdmissionHookConfiguration
        /// </summary>
        [Test]
        public void ListExternalAdmissionHookConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pretty = null;
            //string fieldSelector = null;
            //bool? includeUninitialized = null;
            //string labelSelector = null;
            //string resourceVersion = null;
            //int? timeoutSeconds = null;
            //bool? watch = null;
            //var response = instance.ListExternalAdmissionHookConfiguration(pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
            //Assert.IsInstanceOf<V1alpha1ExternalAdmissionHookConfigurationList> (response, "response is V1alpha1ExternalAdmissionHookConfigurationList");
        }
        
        /// <summary>
        /// Test ListInitializerConfiguration
        /// </summary>
        [Test]
        public void ListInitializerConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pretty = null;
            //string fieldSelector = null;
            //bool? includeUninitialized = null;
            //string labelSelector = null;
            //string resourceVersion = null;
            //int? timeoutSeconds = null;
            //bool? watch = null;
            //var response = instance.ListInitializerConfiguration(pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
            //Assert.IsInstanceOf<V1alpha1InitializerConfigurationList> (response, "response is V1alpha1InitializerConfigurationList");
        }
        
        /// <summary>
        /// Test PatchExternalAdmissionHookConfiguration
        /// </summary>
        [Test]
        public void PatchExternalAdmissionHookConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //Object body = null;
            //string pretty = null;
            //var response = instance.PatchExternalAdmissionHookConfiguration(name, body, pretty);
            //Assert.IsInstanceOf<V1alpha1ExternalAdmissionHookConfiguration> (response, "response is V1alpha1ExternalAdmissionHookConfiguration");
        }
        
        /// <summary>
        /// Test PatchInitializerConfiguration
        /// </summary>
        [Test]
        public void PatchInitializerConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //Object body = null;
            //string pretty = null;
            //var response = instance.PatchInitializerConfiguration(name, body, pretty);
            //Assert.IsInstanceOf<V1alpha1InitializerConfiguration> (response, "response is V1alpha1InitializerConfiguration");
        }
        
        /// <summary>
        /// Test ReadExternalAdmissionHookConfiguration
        /// </summary>
        [Test]
        public void ReadExternalAdmissionHookConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string pretty = null;
            //bool? exact = null;
            //bool? export = null;
            //var response = instance.ReadExternalAdmissionHookConfiguration(name, pretty, exact, export);
            //Assert.IsInstanceOf<V1alpha1ExternalAdmissionHookConfiguration> (response, "response is V1alpha1ExternalAdmissionHookConfiguration");
        }
        
        /// <summary>
        /// Test ReadInitializerConfiguration
        /// </summary>
        [Test]
        public void ReadInitializerConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string pretty = null;
            //bool? exact = null;
            //bool? export = null;
            //var response = instance.ReadInitializerConfiguration(name, pretty, exact, export);
            //Assert.IsInstanceOf<V1alpha1InitializerConfiguration> (response, "response is V1alpha1InitializerConfiguration");
        }
        
        /// <summary>
        /// Test ReplaceExternalAdmissionHookConfiguration
        /// </summary>
        [Test]
        public void ReplaceExternalAdmissionHookConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //V1alpha1ExternalAdmissionHookConfiguration body = null;
            //string pretty = null;
            //var response = instance.ReplaceExternalAdmissionHookConfiguration(name, body, pretty);
            //Assert.IsInstanceOf<V1alpha1ExternalAdmissionHookConfiguration> (response, "response is V1alpha1ExternalAdmissionHookConfiguration");
        }
        
        /// <summary>
        /// Test ReplaceInitializerConfiguration
        /// </summary>
        [Test]
        public void ReplaceInitializerConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //V1alpha1InitializerConfiguration body = null;
            //string pretty = null;
            //var response = instance.ReplaceInitializerConfiguration(name, body, pretty);
            //Assert.IsInstanceOf<V1alpha1InitializerConfiguration> (response, "response is V1alpha1InitializerConfiguration");
        }
        
    }

}