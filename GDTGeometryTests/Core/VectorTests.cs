using NUnit.Framework;
using GDTGeometry.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTGeometry.Core.Tests
{
    [TestFixture()]
    public class VectorTests
    {
        [Test()]
        public void CrossMultiplyTest()
        {
            var unit_z = Vector.UnitX.CrossMultiply(Vector.UnitY);
            Assert.AreEqual(Vector.UnitZ.Vec, unit_z.Vec);
            var unit_z_minus = Vector.UnitY.CrossMultiply(Vector.UnitX);
            Assert.AreEqual(Vector.UnitZ.Vec, -unit_z_minus.Vec);

            var x = new Vector(0.69171, -0.42326, -0.58514);
            var y = new Vector(0.68108, 0.65177, 0.33366);
            var z = new Vector(0.24015, -0.62932, 0.73911);


            Assert.Less((z.Vec - x.CrossMultiply(y).Vec).L2Norm(), 0.00001);
            Assert.Less((x.Vec - y.CrossMultiply(z).Vec).L2Norm(), 0.00001);
            Assert.Less((-y.Vec - x.CrossMultiply(z).Vec).L2Norm(), 0.00001);

        }
    }
}