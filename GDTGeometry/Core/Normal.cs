using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;

namespace GDTGeometry.Core
{
    /// <summary>
    /// a vector which length = 1
    /// </summary>
    class Normal : Vector
    {
        double i, j, k;

        public double I { get => i; set => i = value; }
        public double J { get => j; set => j = value; }
        public double K { get => k; set => k = value; }

        public Normal(double a, double b, double c)
            : base(a, b, c)
        {
            var len = Vec.Normalize(2);
            I = len[0];
            J = len[1];
            K = len[2];
        }
        public DenseVector NormalVec
        {
            get
            {
                return DenseVector.OfArray(new double[] { I, J, K });
            }
        }
        public DenseVector NormalVec4
        {
            get
            {
                return DenseVector.OfArray(new double[] { I, J, K, 0});
            }
        }
        public static Vector operator *(double k, Normal a)
        {
            return new Vector(k * a.I, k * a.J, k * a.K);
        }
        public static Normal operator *(CartesianCoordinate M, Normal v)
        {
            var result = M.Matrix * v.Vec4;
            return new Normal(result[0], result[1], result[2]);
        }
      
    }
}
