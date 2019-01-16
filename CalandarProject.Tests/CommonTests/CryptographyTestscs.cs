using System;
using Common.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalandarProject.Tests.CommonTests
{
    [TestClass]
    public class CryptographyTestscs
    {
        private const string _stringToEncode = "123";
        private const string _stringToDecode = "MTIz";

        [TestMethod]
        public void Base64Encode()
        {
            var encodedString = Cryptography.Base64Encrypt(_stringToEncode);

            Assert.IsTrue(encodedString == _stringToDecode);
        }

        [TestMethod]
        public void Base64Decode()
        {
            var decodedString = Cryptography.Base64Decrypt(_stringToDecode);

            Assert.IsTrue(decodedString == _stringToEncode);
        }
    }
}
