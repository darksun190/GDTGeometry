using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;


namespace GDTGeometry.Core
{
    /// <summary>
    /// Point is a special Feature, it can be a individal feature
    /// or can be part of other features
    /// here is a base class for all kind of Points
    /// </summary>
    public class Point
    {
        public Position Pos
        {
            get;
            set;
        }
        public Vector Vec
        {
            get;
            set;
        }
      
        public Point(double x, double y, double z)
            : this(x, y, z, 0, 0, 0)
        {

        }
        public double X { get => Pos.X; }
        public double Y { get => Pos.Y; }
        public double Z { get => Pos.Z; }
        public double I { get => Vec.A; }
        public double J { get => Vec.B; }
        public double K { get => Vec.C; }


        public Point(double x, double y, double z, double i, double j, double k)
            : this(new Position(x, y, z), new Vector(i, j, k))
        {

        }
        public Point(Position P, Vector V)
        {
            Pos = new Position(P.X, P.Y, P.Z);
            Vec = new Vector(V.A, V.B, V.C);
        }
        public Point NewCoordinate(CartesianCoordinate Coord)
        {
            var pos_new = Coord * Pos;
            var vec_new = Coord * Vec;
            return new Point(pos_new, vec_new);
        }
        public override string ToString()
        {
            return string.Format("{0},{1}",Pos,Vec);
        }
        
    }
}
