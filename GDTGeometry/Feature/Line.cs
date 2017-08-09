using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDTGeometry.Core;

namespace GDTGeometry.Feature
{
    /// <summary>
    /// 这里的定义是线段，表示为起点和终点
    /// </summary>
    public class Line : IFeature
    {
        public Position Start
        {
            get;
            private set;
        }
        public Position End
        {
            get;
            private set;
        }
        public Vector PointDirection
        {
            get;
            protected set;
        }
        public Vector Vec => new Vector(
            End.X - Start.X, End.Y - Start.Y, End.Z - Start.Z);

        public Line(Point P1, Point P2)
        {
            Start = new Position(P1.X, P1.Y, P1.Z);
            End = new Position(P2.X, P2.Y, P2.Z);
        }
        public Line(Position P1, Position P2)
        : this(new Point(P1, Vector.Zero), new Point(P2, Vector.Zero))
        {

        }
        public Line(Point P1, Vector V1, double len)
            : this(P1.Pos, P1.Pos + len * V1)
        {

        }
        public Line(Position P1, Vector V1, double len)
            : this(P1, P1 + len * V1)
        {

        }


    }
}
