using NUnit.Framework;
using GDTGeometry.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;
using System.Diagnostics;

namespace GDTGeometry.Core.Tests
{
    [TestFixture()]
    public class CoordinatesCartesianTests
    {
        [Test()]
        public void CoordinatesCartesianTest()
        {
            DenseVector AxisX, AxisY, AxisZ;
             AxisX = DenseVector.OfArray(new double[] { 1, 0, 0 });
             AxisY = DenseVector.OfArray(new double[] { 0, 1, 0 });
             AxisZ = DenseVector.OfArray(new double[] { 0, 0, 1 });

            CoordinatesCartesian cc = new CoordinatesCartesian(AxisX, AxisY, AxisZ);
            Debug.WriteLine(cc.Matrix);

            AxisX = DenseVector.OfArray(new double[] { 1, 1, 0 });
            AxisY = DenseVector.OfArray(new double[] { -1, 1, 0 });
            AxisZ = DenseVector.OfArray(new double[] { 0, 0, 1 });

            CoordinatesCartesian cc1 = new CoordinatesCartesian(AxisX, AxisY, AxisZ);
            Debug.WriteLine(cc1.Matrix);

            GDTGeometry.Feature.Point A = new Feature.Point(1, 1, 0);
            Debug.WriteLine(A.Coordinate(cc1));

        }
    }
}