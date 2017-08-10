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
    }
}
