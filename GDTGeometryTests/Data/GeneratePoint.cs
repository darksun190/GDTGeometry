using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDTGeometry.Feature;
using GDTGeometry.Core;

namespace GDTGeometryTests.Data
{
    class GeneratePoint
    {
        List<double> RandomDeviation(int PointNo, double maxDev)
        {
            List<double> result = new List<double>();
            Random r = new Random();
            for(int i=0;i<PointNo;++i)
            {
                result.Add((r.NextDouble() - 0.5) * maxDev);
            }
            return result;
        }
        List<double> SinDeviation(int PointNo, double amplitude, int freq, double angle = 0)
        {
            List<double> result = new List<double>();
            for(int i=0;i<PointNo;++i)
            {
                result.Add(
                    amplitude * Math.Sin(2 * Math.PI * (i * freq / PointNo))
                    );
            }
            return result;
        }
        List<Point> LineNominalPoint(int PointNo, Line line)
        {
            List<Point> result = new List<Point>();
            Vector v=line.PointDirection;
          
            double PN = PointNo;
            for(int i=0;i<PointNo;i++)
            {
                result.Add(new Point(
                     (line.Start+(i/PN)*line.Vec),))
            }
        }
    }
}
