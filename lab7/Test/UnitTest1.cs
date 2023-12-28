using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab7;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Program.findDistanceBetweenPoints(0, 0, 0, 1), 1);
            Assert.AreEqual(Program.findDistanceBetweenPoints(0, 0, 0, -2), 2);
        }
    }
}
