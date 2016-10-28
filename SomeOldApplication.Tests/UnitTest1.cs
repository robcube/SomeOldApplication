using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeOldApplication.PyUtility;

namespace SomeOldApplication.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var pyUtility = new PyUtility.PyUtility();
            pyUtility.SendMail("rob@rnwood.co.uk", "py@thiscomputer.com", "test subject", "test body", "localhost");
            
        }
    }
}
