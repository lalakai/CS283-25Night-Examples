using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();
            int total = 0;
            for (int index = 0; index < numbers.Length; index++)
                numbers[index] = random.Next(-1000, 1000);

            foreach (int number in numbers)
                total += number;

            Console.WriteLine(total);
        }
    }
}