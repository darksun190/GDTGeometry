using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;

namespace GDTGeometry.Core
{
    /// <summary>
    /// a 3-dimension densevector which lense is 1
    /// </summary>
    public class Vector
    {
        public Vector(double i, double j, double k)
        {
            double len = Math.Sqrt(i * i + j * j + k * k);
            I = i / len;
            J = j / len;
            K = k / len;
        }
        double i, j, k;

        public double I { get => i; set => i = value; }
        public double J { get => j; set => j = value; }
        public double K { get => k; set => k = value; }
        public DenseVector Vec
        {
            get
            {
                return DenseVector.OfArray(new double[] { I, J, K });
            }
        }
        public DenseVector Vec4
        {
            get
            {
                return DenseVector.OfArray(new double[] { I, J, K, 0 });
            }
        }
        public static Position operator *(double k, Vector a)
        {
            return new Position(k * a.i, k * a.j, k * a.k);
        }
        public static Vector operator *(CartesianCoordinate M, Vector v)
        {
            var result = M.Matrix * v.Vec4;
            return new Vector(result[0], result[1], result[2]);
        }
        public static Vector Zero => new Vector(0, 0, 0);
        public static Vector UnitX => new Vector(1, 0, 0);
        public static Vector UnitY => new Vector(0, 1, 0);
        public static Vector UnitZ => new Vector(0, 0, 1);


        public static double AngleBetweenTwoVector(Vector v1, Vector v2)
        {
            double valueUp = v1.Vec * v2.Vec;
            double valueDown = v1.Vec.L2Norm() * v2.Vec.L2Norm();
            return Math.Atan2(valueUp, valueDown);
        }

        public override string ToString()
        {
            return string.Format("Vector [{0:F4}, {1:F4}, {2:F4}]\n", I, J, K);
        }
    }
}
