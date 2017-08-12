using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTGeometry.Core
{
    public class Unit
    {
        public enum COORD
        {
            CART,
            POL,
            SPHERE
        }
        public enum Length
        {
            mm,
            inch
        }
        public enum EvaluationMethod
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
