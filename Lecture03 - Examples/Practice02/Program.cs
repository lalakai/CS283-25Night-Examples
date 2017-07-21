using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person Elsa = new Person()
            {
                Name = "Elsa",
                Pos = new Position()
                {
                    X = 0,
                    Y = 0
                },
                Angle = 0,
            };

            for (var count = 0; count < 4; count++) ;
            Elsa.DrawSquare(100);
            Elsa.TurnRight(120);
        }
    }
}