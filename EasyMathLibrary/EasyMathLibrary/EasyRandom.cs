using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public class EasyRandom
    {
        private Random random;
        // .NET 裡所給的亂數值為0<= X < 1(※end為小於，因此如需34 則end需填35)
        //如間距需更改 需用 (end-start)* X + start

        public EasyRandom()
        {
            random = new Random();
        }

        public double NextDouble(double start, double end)
        {
            double x = random.NextDouble();
            return (end - start) * x + start;
        }

        public double[] NextDouble(double start, double end, int length)
        {
            double[] numbers = new double[length];
            for (int index = 0; index < length; index++)
            {
                numbers[index] = NextDouble(start, end);
            }

            return numbers;
        }

        public int Next(int start, int end)
        {
            return random.Next(start, end);
        }

        public int Next()
        {
            return random.Next();
        }
    }
}