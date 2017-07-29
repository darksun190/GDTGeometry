using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTGeometry.Feature
{
    public class Point : IFeature
    {
        double x, y, z;

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }
        public double I { get => i; set => i = value; }
        public double J { get => j; set => j = value; }
        public double K { get => k; set => k = value; }

        double i, j, k;
    }
}
