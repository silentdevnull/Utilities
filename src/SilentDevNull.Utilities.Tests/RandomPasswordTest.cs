using System;
using Xunit;

using SilentDevNull.Utilities.Security;

namespace SilentDevNull.Utilities.Tests
{
    public class RandomPasswordTest
    {
        [Fact]
        public void CreateRandomPasswordTest()
        {
            var pwdLength = RandomPassword.CreateRandomPassword();
            Console.WriteLine(pwdLength);
            Assert.Equal(20,pwdLength.Length);
        }
    }
}
