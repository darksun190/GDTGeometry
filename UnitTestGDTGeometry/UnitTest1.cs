using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GDTGeometry;

namespace UnitTestGDTGeometry
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void TestCreatePoint()
        {
            GDTGeometry.Feature.Point a = new GDTGeometry.Feature.Point(1, 2, 3);
            Assert.AreEqual(1, a.X);
            Assert.AreEqual(2, a.Y);
            Assert.AreEqual(3, a.Z);
        }
    }
}
