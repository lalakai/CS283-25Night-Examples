using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice01
{
    internal class position
    {
        public double X;
        public double Y;
    }

    internal class person
    {
        public string Name;
        public position Pos;
        public double Angle;

        public void MoveForward(double d)
        {
            Pos.X = Pos.X + d * Math.Cos(Angle * Math.PI / 180.0);
            Pos.Y = Pos.Y + d * Math.Sin(Angle * Math.PI / 180.0);
            WriteLine();
        }

        public void TurnRight(double angle)
        {
            Angle = (Angle + angle) % 360.0;
            WriteLine();
        }

        public void WriteLine()
        {
            Console.WriteLine("{0}的位置在({1},{2}),方位角:{3}度",
             Name, Pos.X, Pos.Y, Angle);
        }

        public void DrawSquare(double width)
        {
            for (int count = 0; count < 4; count++)
            {
                MoveForward(100);
                TurnRight(90);
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            person Elsa = new person()
            {
                Name = "Elsa",
                Pos = new position()
                {
                    X = 0,
                    Y = 0
                },
                Angle = 0,
            };
            for (int count = 0; count < 4; count++) ;
            {
                Elsa.DrawSquare(100);
                Elsa.TurnRight(90);
            }
        }
    }
}