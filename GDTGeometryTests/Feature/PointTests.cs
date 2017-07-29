using NUnit.Framework;
using GDTGeometry.Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTGeometry.Feature.Tests
{
    [TestFixture()]
    public class PointTests
    {
        [Test()]
        
        public void PointTest()
        {
            ///create test
            Point A = new Point(1, 2, 3);
            Assert.AreEqual(1, A.X);
            Assert.AreEqual(2, A.Y);
            Assert.AreEqual(3, A.Z);

        }
    }
}