using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTGeometry.Core
{
    class Unit
    {
        internal enum COORD
        {
            CART,
            POL,
            SPHERE
        }
        internal enum Length
        {
            mm,
            inch
        }
        internal enum EvaluationMethod
        {
            Gauss,
            Tschebyscheff,
        }
        internal enum Axis
        {
            X,
            Y,
            Z
        }
    }
}
