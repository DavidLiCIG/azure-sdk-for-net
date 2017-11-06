using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace FaceSDK.Tests
{
    public class FaceDetectionTests : FaceBaseTests
    {
        [Fact]
        public void FaceDetection()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                HttpMockServer.Initialize(this.GetType().FullName, "FaceDetection");

                IFaceAPI client = GetClient(HttpMockServer.CreateInstance());
                using (FileStream stream = new FileStream(Path.Combine("TestImages", "detection1.jpg"), FileMode.Open))
                {
                    IList<DetectedFace> faceList = client.Face.DetectInStreamAsync(stream).Result;
                    Assert.Equal(1, faceList.Count);
                }
            }
        }
    }
}
