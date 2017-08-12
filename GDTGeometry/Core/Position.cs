using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;

namespace GDTGeometry.Core
{
    public class Position
    {
        public Position(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Position(Position position)
            : this(position.X, position.Y, position.Z)
        {
        }

        double x, y, z;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }

        public DenseVector Pos
        {
            get
            {
                return DenseVector.OfArray(new double[] { X, Y, Z });
            }
        }
        public DenseVector Pos4
        {
            get
            {
                return DenseVector.OfArray(new double[] { X, Y, Z, 1 });
            }
        }
        public static Position operator +(Position a, Position b)
        {
            return new Position(
                a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        public static Position operator -(Position a, Position b)
        {
            return new Position(
                a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        public static Position operator *(double k, Position a)
        {
            return new Position(k * a.X, k * a.Y, k * a.Z);
        }
        public static Position operator *(Position a, double k)
        {
            return k * a;
        }
        public static Position operator /(Position a, double k)
        {
            return (1 / k) * a;
        }
        public static Position operator *(CartesianCoordinate M, Position p)
        {
            var result = M.Matrix * p.Pos4;
            return new Position(result[0], result[1], result[2]);
        }

        public static Position Zero => new Position(0, 0, 0);
        public static Position One => new Position(1, 1, 1);
        public override string ToString()
        {
            return string.Format("Position [{0:F4}, {1:F4}, {2:F4}]\n", X, Y, Z);
        }
    }
}
