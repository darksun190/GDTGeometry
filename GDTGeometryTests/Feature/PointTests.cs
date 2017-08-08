using NUnit.Framework;
using GDTGeometry.Core;
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
        //[Test()]
        [TestCase (1,2,3)]
        [TestCase(double.PositiveInfinity, 0, double.NegativeInfinity)]
        [TestCase(-10, 10, 0)]
        public void PointTest(double x, double y, double z)
        {
            ///create test
            Point A = new Point(x, y, z);
            Assert.AreEqual(x, A.X);
            Assert.AreEqual(y, A.Y);
            Assert.AreEqual(z, A.Z);

        }
    }
}