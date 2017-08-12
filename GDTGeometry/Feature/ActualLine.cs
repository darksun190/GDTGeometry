using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDTGeometry.Core;
using GDTGeometry.Collections;
using GDTGeometry.Algorithm;

namespace GDTGeometry.Feature
{
    class ActualLine : IActualFeature
    {
        public PointSet Points
        {
            get;
            private set;
        }
        private Unit.EvaluationMethod evaluationmethod;
        Line actual;
        public ActualLine(PointSet PS, Unit.EvaluationMethod method = Unit.EvaluationMethod.Gauss)
        {
            Points = PS;
            EvaluationMethod = method;
        }
        public Unit.EvaluationMethod EvaluationMethod
        {
            get
            {
                return evaluationmethod;
            }
            set
            {
                evaluationmethod = value;
                Calculate();
            }
        }

        private void Calculate()
        {
            actual = Algorithm.BestFit.BestFit.BestFitLine(Points, EvaluationMethod);
            throw new NotImplementedException();
        }

        public double Form => throw new NotImplementedException();

        public double MaxDev => throw new NotImplementedException();

        public double MinDev => throw new NotImplementedException();

        public double Sigma => throw new NotImplementedException();
    }
}
