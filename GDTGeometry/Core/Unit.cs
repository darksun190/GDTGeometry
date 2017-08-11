using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTGeometry.Core
{
    public class Unit
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
        public enum Axis
        {
            X,
            Y,
            Z
        }
    }
}
