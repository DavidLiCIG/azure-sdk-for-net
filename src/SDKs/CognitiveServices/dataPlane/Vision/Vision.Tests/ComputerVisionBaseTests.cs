using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace VisionSDK.Tests
{
    public abstract class ComputerVisionBaseTests
    {
        public static bool IsTestTenant = false;
        private static string SubscriptionKey = "";

        static ComputerVisionBaseTests()
        {
            // Retrieve the configuration information.
            SubscriptionKey = "e1abd8bcba914ee18ad65041587c9cea";
            Environment.SetEnvironmentVariable("AZURE_TEST_MODE", "Record");
        }

        protected IComputerVisionAPI GetClient(DelegatingHandler handler)
        {
            IComputerVisionAPI client=null;
            client = new ComputerVisionAPI(new ApiKeyServiceClientCredentials handlers: handler);
            client.AzureRegion = AzureRegions.Westus;

            return client;
        }
    }
}
