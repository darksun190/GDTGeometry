using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;

namespace GDTGeometry.Core
{
    public class CartesianCoordinate : ICoordinate
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

        public CartesianCoordinate(Vector x,Vector y,Vector z, Position p)
        {
            AxisX = x;
            AxisY = y;
            AxisZ = z;
            Pos = p;
        }
        public CartesianCoordinate(DenseMatrix M)
        {
            var c1 = M.Column(0).SubVector(0,3);
            var c2 = M.Column(1).SubVector(0, 3);
            var c3 = M.Column(2).SubVector(0, 3);
            var c4 = M.Column(3).SubVector(0, 3);
            AxisX = new Vector(c1[0], c1[1], c1[2]);
            AxisY = new Vector(c2[0], c2[1], c2[2]);
            AxisZ = new Vector(c3[0], c3[1], c3[2]);
            Pos = new Position(c4[0], c4[1], c4[2]);
        }
        public static CartesianCoordinate operator* (CartesianCoordinate A, CartesianCoordinate B)
        {
            var C = A.Matrix * B.Matrix;
            return new CartesianCoordinate(C);
        }
        public static CartesianCoordinate UnitCoordinate => new CartesianCoordinate(Vector.UnitX, Vector.UnitY, Vector.UnitZ, Position.Zero);
        public CartesianCoordinate Rotate(Unit.Axis axis, double angle)
        {
            Vector x, y, z;
            x = Vector.UnitX;
            y = Vector.UnitY;
            z = Vector.UnitZ;
            if(axis == Unit.Axis.X)
            {
                y = new Vector(0, Math.Cos(angle), Math.Sin(angle));
                z = new Vector(0, -Math.Sin(angle), Math.Cos(angle));
            }
            else if (axis == Unit.Axis.Y)
            {
                x = new Vector(Math.Cos(angle), 0, -Math.Sin(angle));
                z = new Vector(Math.Sin(angle), 0, Math.Cos(angle));
            }
            else
            {
                x = new Vector(Math.Cos(angle), Math.Sin(angle), 0);
                y = new Vector(Math.Sin(angle), Math.Cos(angle), 0);
            }
            return this * new CartesianCoordinate(x, y, z, Position.Zero);
        }
        public CartesianCoordinate Offset(double x,double y, double z)
        {
            return this * new CartesianCoordinate(Vector.UnitX, Vector.UnitY, Vector.UnitZ, new Position(x, y, z));
        }
    }
}
