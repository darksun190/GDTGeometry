using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;

namespace GDTGeometry.Core
{
    class CartesianCoordinate : ICoordinate
    {
        Vector axisX, axisY, axisZ;
        Position pos;

        public Vector AxisX { get => axisX; set => axisX = value; }
        public Vector AxisY { get => axisY; set => axisY = value; }
        public Vector AxisZ { get => axisZ; set => axisZ = value; }
        public Position Pos { get => pos; set => pos = value; }

        public DenseMatrix Matrix
        {
            get
            {
                return DenseMatrix.OfColumnVectors(new DenseVector[] { AxisX.Vec4, AxisY.Vec4, AxisZ.Vec4, Pos.Pos4 });
            }
        }
    }
}
