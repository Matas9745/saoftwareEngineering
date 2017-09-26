using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;

namespace RyanUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RyanUserClass ruc = new RyanUserClass();
            Assert.AreEqual(4, ruc.Addition(2, 2));
        }
    }
}
