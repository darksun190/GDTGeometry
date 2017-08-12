using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDTGeometry.Core;

namespace GDTGeometry.Feature
{
    class ActualPlane : IActualFeature
    {

        /// <param name="LPS"></param>
        public ActualPlane(Collections.PointSet LPS)
        {

        }

        public Unit.EvaluationMethod EvaluationMethod => throw new NotImplementedException();

        public double Form => throw new NotImplementedException();

        public double MaxDev => throw new NotImplementedException();

        public double MinDev => throw new NotImplementedException();

        public double Sigma => throw new NotImplementedException();
    }
}
