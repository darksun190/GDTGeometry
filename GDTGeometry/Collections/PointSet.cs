using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDTGeometry.Core;

namespace GDTGeometry.Collections
{
    /// <summary>
    /// 点集，用于保存一组测量点，或一组名义点集
    /// 集合中所有点是无序的
    /// </summary>
    public class PointSet : List<Core.Point>
    {
        public PointSet()
        {

        }
        public PointSet(List<Point> list)
        {
            foreach(var p in list)
            {
                this.Add(p);
            }
        }
        public void merge(List<double> list)
        {
            if (Count != list.Count)
                return;
            for(int i=0;i<Count;++i)
            {
                this[i].Pos += list[i] * this[i].Vec;
            }
        }
    }
}
