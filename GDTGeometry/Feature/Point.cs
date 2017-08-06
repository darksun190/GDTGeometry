using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;


namespace GDTGeometry.Feature
{
    /// <summary>
    /// Point is a special Feature, it can be a individal feature
    /// or can be part of other features
    /// here is a base class for all kind of Points
    /// </summary>
    public class Point 
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

        public Point Coordinate(Core.ICoordinate Coord)
        {
            DenseVector v = DenseVector.OfArray(new double[] { X, Y, Z });
            var r = v * Coord.Matrix;
            return new Point(r[0], r[1], r[2]);
        }
        public override string ToString()
        {
            return string.Format("x:{0}\ty:{1}\tz:{2}\n", X, Y, Z);
        }
    }
}
