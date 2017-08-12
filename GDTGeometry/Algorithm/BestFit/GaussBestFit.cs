using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDTGeometry.Feature;
using GDTGeometry.Collections;
using GDTGeometry.Core;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Factorization;
using MathNet.Numerics.LinearAlgebra;
using Vector = GDTGeometry.Core.Vector;

namespace GDTGeometry.Algorithm.BestFit
{
    class GaussBestFit
    {
        static public Plane GaussFitPlane(Collections.PointSet PS)
        {
            throw new NotImplementedException();
        }
        static public Line GaussFitLine(PointSet PS)
        {
            Position pos_average = Position.Zero;
            foreach(var p in PS)
            {
                pos_average += p.Pos;
            }
            pos_average /= PS.Count;
            DenseMatrix jacobian = new DenseMatrix(PS.Count, 3);
            foreach (var p in PS)
            {
                var gradient = (p.Pos - pos_average).Pos;
                jacobian.SetRow(PS.IndexOf(p), gradient);
            }
            Svd<double> svd = jacobian.Svd(true);
            // get matrix of left singular vectors with first n columns of U
            Matrix<double> U1 = svd.U.SubMatrix(0, PS.Count, 0, 3);
            // get matrix of singular values
            Matrix<double> S = new DiagonalMatrix(3, 3, svd.S.ToArray());
            // get matrix of right singular vectors
            Matrix<double> V = svd.VT.Transpose();

            Vector<double> parameters = new DenseVector(3);
            parameters = V.Column(0);
            
            Line result = new Line(pos_average, new Vector(parameters[0], parameters[1], parameters[2]), 1);
            return result;
        }
    }
}
