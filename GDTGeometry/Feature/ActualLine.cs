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
        Line Actual
        {
            get
            {
                if (Points == null )
                    throw new NullReferenceException("no Points defined.");
                return Algorithm.BestFit.BestFit.BestFitLine(Points, EvaluationMethod);
            }
        }
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
            }
        }
        ListPointSet Sort()
        {
            var y = Actual.Vec;
            var z = Actual.PointDirection;
            var x = y.CrossMultiply(z);
            var p = Actual.Start;

            var feature_alignment = new CartesianCoordinate(x, y, z, p);

            ListPointSet LPS = new ListPointSet();
            foreach(var point in Points)
            {
                LPS.Add(point.NewCoordinate(feature_alignment));
            }
            return LPS;
        }
       

        public double Form => throw new NotImplementedException();

        public double MaxDev => throw new NotImplementedException();

        public double MinDev => throw new NotImplementedException();

        public double Sigma => throw new NotImplementedException();
    }
}
