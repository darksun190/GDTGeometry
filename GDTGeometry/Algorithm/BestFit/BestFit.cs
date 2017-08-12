using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDTGeometry.Feature;
using GDTGeometry.Collections;
using GDTGeometry.Core;

namespace GDTGeometry.Algorithm.BestFit
{
    public class BestFit
    {
        static public Line BestFitLine(PointSet PS, Unit.EvaluationMethod method)
        {
            if(method == Unit.EvaluationMethod.Gauss)
            {
                return GaussBestFit.GaussFitLine(PS);
            }
            throw new NotImplementedException();
        }
    }
}
