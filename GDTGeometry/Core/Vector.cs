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
        public static Position operator *(double k, Vector a)
        {
            return new Position(k * a.i, k * a.j, k * a.k);
        }
        public static Vector Zero => new Vector(0, 0, 0);
    }
}
