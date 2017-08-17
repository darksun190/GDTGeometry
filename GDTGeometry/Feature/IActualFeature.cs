using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTGeometry.Feature
{
    /// <summary>
    /// an ActualFeature is created from a pointset
    /// actual it's a pointset, identified as a feature
    /// </summary>
    interface IActualFeature
    {
        Core.Unit.EvaluationMethod EvaluationMethod
        {
            get;
        }
        double Form
        {
            get;
        }
        double MaxDev
        {
            get;
        }
        double MinDev
        {
            get;
        }
        double Sigma
        {
            get;
        }
        void Calculate(object sender, EventArgs e);
    }
}
