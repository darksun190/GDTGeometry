using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDTGeometry.Collections;
using GDTGeometry.Core;
using GDTGeometry.Feature;

namespace GDTGeometryTests.Data
{
    /// <summary>
    /// a class generate test data for other tests
    /// </summary>
    class TestData
    {
        /// <summary>
        /// return three points as a simplest circle
        /// </summary>
        /// <returns></returns>
        static PointSet circleData1()
        {
            PointSet ps = new PointSet();
            ps.Add(new GDTGeometry.Core.Point(1, 1, 0));
            ps.Add(new GDTGeometry.Core.Point(-1, 1, 0));
            ps.Add(new GDTGeometry.Core.Point(-1, -1, 0));
            return ps;
        }
        public static PointSet LinePoint_Nominal(int PointNo, Line2D line)
        {
            return new PointSet(GeneratePoint.Line2DNominalPoint(PointNo, line));
        }
        public static PointSet LinePoint_RandomAndSin()
        {
            throw new NotImplementedException();
        }
    }
}
