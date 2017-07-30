using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;


namespace GDTGeometry.Feature
{
    public class Point : IFeature
    {
        double x, y, z;

        public Point(double x, double y, double z)
            : this(x, y, z, 0, 0, 0)
        {

        }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }
        public double I { get => i; set => i = value; }
        public double J { get => j; set => j = value; }
        public double K { get => k; set => k = value; }

        double i, j, k;

        public Point(double x, double y, double z, double i, double j, double k)
        {
            X = x;
            Y = y;
            Z = z;
            I = i;
            J = j;
            K = k;
        }
    }
}
