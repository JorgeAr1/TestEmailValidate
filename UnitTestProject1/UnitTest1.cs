using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("jlarreygue@sciodev.com", true)]
        [DataRow("jlarreygue@sciodev", true)]
        [DataRow("jlarreygue@s@ciodev.com", false)]
        [DataRow("@sciodev.com", false)]
        [DataRow("jlarreygue@sciodev.com.com", true)]
        [DataRow("jlarreyguesciodev.com", false)]
        [DataRow("jlarreygue@", false)]
        [DataRow("jlarrey_gue@sciodev.com", true)]
        [DataRow("jlarreygue@scio_dev.com", true)]
        public void TestMethod1(String email, bool res)
        {
            ValidateMail val = new ValidateMail();
            Assert.AreEqual(val.validateMail(email), res);

        }
    }
}
