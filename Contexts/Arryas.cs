using ooapLab3Startegy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooapLab3Startegy.Contexts
{
    public class Arryas
    {
        public int[] arr { get; set; }


        public Arryas(int count)
        {
            Random rnd = new Random();
            arr = new int[count];
            for (int i = 0; i < arr.Count(); i++)
            {
                arr[i] = rnd.Next(1, 5);        
            }
        }
        private IArrStrategy strategy;

        public void SetStragy(IArrStrategy strategy)
        {
            this.strategy = strategy;
        }

        public double Calcuate()
        {
            if (arr == null)
            {
                throw new Exception(message: "Массив пуст");
            }
            return strategy.Calculate(arr);
        }
    }
}
