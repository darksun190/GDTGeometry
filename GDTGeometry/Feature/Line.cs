using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTGeometry.Feature
{
    /// <summary>
    /// 这里的定义是线段，表示为起点和终点
    /// </summary>
    public class Line : IFeature
    {
        public Core.Position Start
        {
            get;
            private set;
        }
        public Core.Position End
        {
            get;
            private set;
        }
        public Core.Vector PointDirection
        {
            get;
            private set;
        }
        public Core.Vector Vec
        {
            get;
            private set;
        }
        public Line(Core.Point P1, Core.Point P2)
        {
            PointDirection = P1.Vec;
            
        }
        public Line(Core.Position P1, Core.Position P2)
            : this(new Core.Point(P1,Core.Vector.Zero),
                  new Core.Point(P2,Core.Vector.Zero)
                  )
        {
            double delta_x = P2.X - P1.X;
            double delta_y = P2.Y - P1.Y;
            double delta_z = P2.Z - P1.Z;
            Start = new Core.Position(P1.X, P1.Y, P1.Z);
            End = new Core.Position(P2.X, P2.Y, P2.Z);
            Vec = new Core.Vector(delta_x, delta_y, delta_z);
            PointDirection = new Core.Vector(0, 0, 0);
        }
     

    }
}
