using Microsoft.VisualStudio.TestTools.UnitTesting;
using Requests;
using System;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.ThrowsException<Exception>(() => Requests.Auth.AuthenticateUser("", ""));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.ThrowsException<Exception>(() => Requests.Auth.AuthenticateUser("", ""));
        }
    }
}
