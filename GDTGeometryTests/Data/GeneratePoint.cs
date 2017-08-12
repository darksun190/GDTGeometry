using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDTGeometry.Feature;
using GDTGeometry.Core;

namespace GDTGeometryTests.Data
{
    internal class GeneratePoint
    {
        public static List<double> RandomDeviation(int PointNo, double maxDev)
        {
            List<double> result = new List<double>();
            Random r = new Random();
            for (int i = 0; i < PointNo; ++i)
            {
                result.Add((r.NextDouble() - 0.5) * maxDev);
            }
            return result;
        }
        public static List<double> SinDeviation(int PointNo, double amplitude, int freq, double angle = 0)
        {
            List<double> result = new List<double>();
            for (int i = 0; i < PointNo; ++i)
            {
                result.Add(
                    amplitude * Math.Sin(2 * Math.PI * (i * freq / PointNo))
                    );
            }
            return result;
        }
        public static List<Point> Line2DNominalPoint(int PointNo, Line2D line)
        {
            List<Point> result = new List<Point>();

            double PN = PointNo - 1;
            for (int i = 0; i < PointNo; i++)
            {
                result.Add(new Point(
                     (line.Start + line.Length * (i / PN) * line.Vec), line.PointDirection));
            }
            return result;
        }
    }
}
