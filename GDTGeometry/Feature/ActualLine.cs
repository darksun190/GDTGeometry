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
        delegate void ParasChangedEventHandler(object sender, EventArgs e);
        event ParasChangedEventHandler ParasChangedEvent;

        public PointSet Points
        {
            get;
            private set;
        }
        private Unit.EvaluationMethod evaluationmethod;
        Line Actual
        {
            get;
            set;
        }
        public ActualLine(PointSet PS, Unit.EvaluationMethod method = Unit.EvaluationMethod.Gauss)
        {
            ParasChangedEvent += Calculate;
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
                if (evaluationmethod != value)
                {
                    evaluationmethod = value;
                    ParasChangedEvent(this, new EventArgs());
                }
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
            foreach (var point in Points)
            {
                LPS.Add(point.NewCoordinate(feature_alignment));
            }
            return LPS;
        }

        public void Calculate(object sender, EventArgs e)
        {
            Actual = GDTGeometry.Algorithm.BestFit.BestFit.BestFitLine(Points, evaluationmethod);
        }

        public double Form => throw new NotImplementedException();

        public double MaxDev => throw new NotImplementedException();

        public double MinDev => throw new NotImplementedException();

        public double Sigma => throw new NotImplementedException();
    }
}
