using System;
using Xunit;

namespace HelloWorld.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestHelloWorld()
        {
            string result = HelloWorld.Program.GetHelloWorld();
            Assert.Equal("Hello, World!", result);
        }

        [Fact]
        public void TestUnixOnly()
        {
            if (IsUnix())
            {
                // Logic specific to Unix systems
                string result = HelloWorld.Program.GetHelloWorld();
                Assert.Equal("Hello, World!", result);
            }
            else
            {
                // Skip this test if not on Unix-based systems
                Assert.True(true, "Test skipped on non-Unix systems.");
            }
        }

        private bool IsUnix()
        {
            return System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(
                System.Runtime.InteropServices.OSPlatform.Linux) ||
                System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(
                System.Runtime.InteropServices.OSPlatform.OSX);
        }
    }
}
