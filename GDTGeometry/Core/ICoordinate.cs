using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra.Double;

namespace GDTGeometry.Core
{
    /// <summary>
    /// 坐标系是一种变换，线性变换可以用4*4矩阵表示
    /// 非线性变换（笛卡尔坐标系到圆柱坐标系）则需要其他运算，这里只考虑线性变换
    /// </summary>
    public interface ICoordinate
    {
        
    }
}
