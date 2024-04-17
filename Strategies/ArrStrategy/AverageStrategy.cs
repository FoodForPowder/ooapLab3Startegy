using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooapLab3Startegy.Strategies.ArrStrategy
{
    internal class AverageStrategy : IArrStrategy
    {
        public double Calculate(IEnumerable<int> arr)
        {
            return arr.Average();
        }
    }
}
