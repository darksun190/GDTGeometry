using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;

namespace GDTGeometry.Core
{
    /// <summary>
    /// a 3-dimension densevector 
    /// </summary>
    public class Vector
    {
        public Vector(double i, double j, double k)
        {

            A = i;
            B = j;
            C = k;
        }
        double a, b, c;

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
        public DenseVector Vec
        {
            get
            {
                return DenseVector.OfArray(new double[] { A, B, C });
            }
        }
        public DenseVector Vec4
        {
            get
            {
                return DenseVector.OfArray(new double[] { A, B, C, 0 });
            }
        }
        public static Position operator *(double k, Vector a)
        {
            return new Position(k * a.a, k * a.b, k * a.c);
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
            return string.Format("Vector [{0:F4}, {1:F4}, {2:F4}]\n", A, B, C);
        }

        public Vector CrossMultiply(Vector b)
        {
            var result = new Vector(
                this.B * b.C - this.C * b.B,
                -(this.A * b.C - this.C * b.A),
                this.A * b.B - this.B * b.A
                );
            return result;
        }

    }
}
