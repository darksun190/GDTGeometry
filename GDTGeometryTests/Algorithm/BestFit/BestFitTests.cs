using NUnit.Framework;
using GDTGeometry.Algorithm.BestFit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDTGeometry.Core;
using GDTGeometry.Collections;
using GDTGeometry.Feature;
using GDTGeometryTests.Data;

namespace GDTGeometry.Algorithm.BestFit.Tests
{
    [TestFixture()]
    public class BestFitTests
    {
        [Test()]
        public void BestFitLineTest()
        {
            Point start = new Point(new Position(1, 1, 1), new Vector(-1, -1, 1));
            Point end = new Point(new Position(3, 3, 3), new Vector(-1, -1, 1));
            var line = new Line2D(start, end);
            var data = TestData.LinePoint_Nominal(100, line);
            var result1 = BestFit.BestFitLine(data, Unit.EvaluationMethod.Gauss);
        }
    }
}