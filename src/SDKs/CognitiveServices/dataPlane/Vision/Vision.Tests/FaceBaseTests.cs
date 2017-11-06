using Microsoft.Azure.CognitiveServices.Vision;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using Microsoft.Rest;
using System;
using System.Net.Http;

namespace FaceSDK.Tests
{
    public abstract class FaceBaseTests
    {
        public static bool IsTestTenant = false;
        private static string SubscriptionKey = "";

        static FaceBaseTests()
        {
            // Retrieve the configuration information.
            SubscriptionKey = "";
            // Environment.SetEnvironmentVariable("AZURE_TEST_MODE", "Record");
        }

        protected IFaceAPI GetClient(DelegatingHandler handler)
        {
            IFaceAPI client = null;
            client = new FaceAPI(new ApiKeyServiceClientCredentials(SubscriptionKey), handler);
            client.AzureRegion = AzureRegions.Westus;

            return client;
        }
    }
}
