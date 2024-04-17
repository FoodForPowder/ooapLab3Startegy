using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooapLab3Startegy.Strategies.ArrStrategy
{
    internal class CommonStrategy : IArrStrategy
    {
        public double Calculate(IEnumerable<int> arr)
        {
            return arr.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key).FirstOrDefault();
        }
    }
}
