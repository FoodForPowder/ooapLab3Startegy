using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooapLab3Startegy.Strategies.PointsStrategy
{
    internal class SumStrategy : IPointStrategy
    {
        public double Calculate(double x1, double y1, double x2, double y2)
        {
            return (Math.Abs(x1-x2)+Math.Abs(y1-y2));
        }
    }
}
