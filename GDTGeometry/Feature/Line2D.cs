using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDTGeometry.Core;

namespace GDTGeometry.Feature
{
    /// <summary>
    /// Line2D is a line with a point direction 
    /// which means all points in this line has a fixed vector
    /// </summary>
    public class Line2D: Line
    {
        public Line2D(Point P1, Point P2)
            :base(P1,P2)
        {
            Vector v = P1.Vec;
            if(v == Vector.Zero)
            {
                double x, y, z;
                x = Math.Abs(Vec.I);
                y = Math.Abs(Vec.J);
                z = Math.Abs(Vec.K);
                if(x>y&&x>z)
                {
                    v = new Vector(
                        y * z,
                        -0.5 * x * z,
                        -0.5 * y * x
                        );
                }
                else if(y>x&&y>z)
                {
                    v = new Vector(
                        -0.5 * y * z,
                        x * z,
                        -0.5 * x * y
                        );
                }
                else
                {
                    v = new Vector(
                        -0.5 * y * z,
                        -0.5 * x * z,
                        x * y
                        );
                }
            }
            PointDirection = v;
        }
        CartesianCoordinate FeatureAlignment
        {
            get
            {
                Vector x = this.Vec;
                Vector z = this.PointDirection;
                Vector y = z.CrossMultiply(x);
                Position p = Start;
                return new CartesianCoordinate(x, y, z, p);
            }
        }
    }
}
