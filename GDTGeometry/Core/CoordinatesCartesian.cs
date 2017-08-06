using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;

namespace GDTGeometry.Core
{
    public class CoordinatesCartesian : ICoordinate
    {
        DenseVector axis1, axis2, axis3;
        DenseMatrix matrix;

        public DenseVector Axis1 { get => axis1; set => axis1 = value; }
        public DenseVector Axis2 { get => axis2; set => axis2 = value; }
        public DenseVector Axis3 { get => axis3; set => axis3 = value; }
        public DenseMatrix Matrix { get => matrix; set => matrix = value; }

        public CoordinatesCartesian(DenseVector axis1, DenseVector axis2, DenseVector axis3)
        {
            Axis1 = DenseVector.OfVector(axis1.Normalize(2));
            Axis2 = DenseVector.OfVector(axis2.Normalize(2));
            Axis3 = DenseVector.OfVector(axis3.Normalize(2));
            List<DenseVector> list = new List<DenseVector>();
            list.Add(Axis1);
            list.Add(Axis2);
            list.Add(Axis3);

            Matrix = DenseMatrix.OfColumnVectors(list);
        }
    }
}
