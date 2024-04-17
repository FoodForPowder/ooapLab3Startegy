using ooapLab3Startegy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooapLab3Startegy.Contexts
{
    public class Points
    {
        public double x1, x2, y1, y2;

        public Points(double x1, double x2, double y1, double y2)
        {         
                this.x1 = x1;
                this.x2 = x2;
                this.y1 = y1;
                this.y2 = y2;            
        }

        private IPointStrategy strategy;
         
        public void SetStragy (IPointStrategy strategy)
        {
            this.strategy = strategy;
        }

        public double Calcuate()
        {
            return strategy.Calculate(x1,y1, x2, y2);
        }    
        
    }
}
