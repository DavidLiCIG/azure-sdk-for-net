using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace VisionSDK.Tests
{
    public class VisionAnalyzeTests : ComputerVisionBaseTests
    {
        [Fact]
        public void AnalyzeImageTest()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                HttpMockServer.Initialize(this.GetType().FullName, "AnalyzeImage");
                IComputerVisionAPI client = GetClient(HttpMockServer.CreateInstance());

                using (FileStream stream = new FileStream(Path.Combine("TestImages", "detection1.jpg"), FileMode.Open))
                {
                    ImageAnalysis imageAnalysis = client.AnalyzeImageInStreamAsync(
                        stream,
                        new List<VisualFeatureTypes>()
                        {
                            VisualFeatureTypes.Faces,
                            VisualFeatureTypes.Adult,
                            VisualFeatureTypes.Categories,
                            VisualFeatureTypes.Color,
                            VisualFeatureTypes.Description,
                            VisualFeatureTypes.ImageType,
                            VisualFeatureTypes.Tags
                        }).Result;

                    Assert.Equal(1, imageAnalysis.Faces.Count);
                }
            }
        }
    }
}
