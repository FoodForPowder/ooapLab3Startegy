using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooapLab3Startegy.Strategies
{
    public interface IArrStrategy
    {
        double Calculate(IEnumerable<int> arr);
    }
}
