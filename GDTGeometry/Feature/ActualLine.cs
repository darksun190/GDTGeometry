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
        /// <summary>
        /// 实际点集
        /// </summary>
        public PointSet Points
        {
            get;
            private set;
        }
        private Unit.EvaluationMethod evaluationmethod;
        /// <summary>
        /// 拟合后的直线结果
        /// </summary>
        Line Actual
        {
            get;
            set;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="PS">点集</param>
        /// <param name="method">拟合方法</param>
        public ActualLine(PointSet PS, Unit.EvaluationMethod method = Unit.EvaluationMethod.Gauss)
        {
            ParasChangedEvent += Calculate;
            Points = PS;
            EvaluationMethod = method;
        }

        /// <summary>
        /// 拟合用的拟合方法
        /// </summary>
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
        /// <summary>
        /// 将所有点重新排序
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// method for event para changed.
        /// re calcuate the actual result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
