using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int total = 0;
            int next = 0;
            while (total < 1000)
            {
                total += ++next;
            }
            Console.WriteLine("next = " + next);
            Console.WriteLine("total = " + total);
        }
    }
}