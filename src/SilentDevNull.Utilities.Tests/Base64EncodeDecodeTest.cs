using System;
using Xunit;

using SilentDevNull.Utilities.Helpers;

namespace SilentDevNull.Utilities.Tests
{
    public class Base64EncodeDecodeTest
    {
        [Fact]
        public void EncodeTest()
        {
            var testEncode = "Test".Base64Encode();
            //output.WriteLine(testEncode);
            Assert.Contains(testEncode,"VGVzdA==");
        }

        [Fact]
        public void DecodeTest()
        {
            var testDecode = "VGVzdA==".Base64Decode();
            //output.WriteLine(testDecode);
            Assert.Contains(testDecode,"Test");
        }
    }
}
