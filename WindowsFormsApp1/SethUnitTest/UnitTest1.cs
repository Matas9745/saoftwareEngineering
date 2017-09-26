using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;

namespace SethUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        SethsFunZone testZone = new SethsFunZone();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreNotEqual(null, testZone.mathFun(1, 2));
        }
    }
}
