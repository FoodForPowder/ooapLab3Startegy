using ooapLab3Startegy.Strategies;
using ooapLab3Startegy.Strategies.ArrStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

        public double Calcuate(string strategyName)
        {
            if (arr == null)
            {
                throw new Exception(message: "Массив пуст");
            }
            switch (strategyName)
            {
                case "Найти медианный элемент.":
                    return arr.ElementAt(arr.Count() / 2 - 1); ;
                    break;
                case "Найти самый частый элемент.":
                    return arr.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key).FirstOrDefault();
                    break;
                case "Найти среднее значение.":
                    return arr.Average();
                    break;
                default:
                    throw new Exception(message: "Неизвестная стратегия.");

            }
            
        }
    }
}
