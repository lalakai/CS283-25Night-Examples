using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace PokemonLibrary
{
    public class Pokemon
    {
        public int NationalNumber;
        public string Name;
        public int CurrentHp;
        public int Hp;
        public string[] Types;
        public float Height;
        public float Weight;
        public int PowerUpStardust;
        public int PowerUpCandy;
        public int EvolveCandy;
        public int count;

        public void PowerUp()
        {
            EasyRandom random = new EasyRandom();
            if (NationalNumber == 1)
            {
                int deltaHp = (int)((random.NextDouble(5.0, 15.0) / 100.0) * Hp);
                Hp += deltaHp;
                CurrentHp += deltaHp;
            }
            else if (NationalNumber == 2)
            {
                int deltaHp = (int)((random.NextDouble(6.0, 15.0) / 100.0) * Hp);
                Hp += deltaHp;
                CurrentHp += deltaHp;
            }
            else if (NationalNumber == 3)
            {
                int deltaHp = (int)((random.NextDouble(7.0, 15.0) / 100.0) * Hp);
                Hp += deltaHp;
                CurrentHp += deltaHp;
            }
        }
    }
}