using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonLibrary;
using UserLibrary;

namespace Example01
{
    public partial class Form1 : Form
    {
        public Pokemon pokemon;

        public Form1()
        {
            InitializeComponent();

            pokemon = new Pokemon()
            {
                NationalNumber = 1,
                Name = "妙蛙種子",
                CurrentHp = 50,
                Hp = 60,
                Height = 0.76f,
                Types = new string[] { "草", "毒" },
                Weight = 5.94f,
                PowerUpCandy = 3,
                PowerUpStardust = 3000,
                EvolveCandy = 25
            };

            Render();
        }

        private User user = new User()
        {
            Name = "小智",
            UserStardust = 100000,
            UserCandy = 300,
        };

        private int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.UserStardust >= 3000 && user.UserCandy >= 3 && count < 10)
            {
                user.UserStardust = user.UserStardust - pokemon.PowerUpStardust;
                user.UserCandy = user.UserCandy - pokemon.PowerUpCandy;
                pokemon.PowerUp();
                Render();
                count++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pokemon.NationalNumber == 1 && user.UserCandy >= 25)
            {
                user.UserCandy = user.UserCandy - pokemon.EvolveCandy;
                pokemon = new Pokemon()
                {
                    NationalNumber = 2,
                    Name = "妙蛙草",
                    CurrentHp = pokemon.CurrentHp + 100,
                    Hp = pokemon.Hp + 100,
                    Height = 1.76f,
                    Types = new string[] { "草", "毒" },
                    Weight = 10.94f,
                    PowerUpCandy = 3,
                    PowerUpStardust = 3000,
                    EvolveCandy = 100
                };
                Render();
                count = 0;
            }
            else if (pokemon.NationalNumber == 2 && user.UserCandy >= 100)
            {
                user.UserCandy = user.UserCandy - pokemon.EvolveCandy;
                pokemon = new Pokemon()
                {
                    NationalNumber = 3,
                    Name = "妙蛙花",
                    CurrentHp = pokemon.CurrentHp + 200,
                    Hp = pokemon.Hp + 200,
                    Height = 3.26f,
                    Types = new string[] { "草", "毒" },
                    Weight = 15.94f,
                    PowerUpCandy = 3,
                    PowerUpStardust = 3000,
                };
                Render();
                count = 0;
            }
        }

        private void Render()
        {
            NameLabel.Text = pokemon.Name;
            HpLabel.Text = pokemon.CurrentHp + " / " + pokemon.Hp + "Hp";
            HeightLabel.Text = pokemon.Height.ToString() + "m";
            TypesLabel.Text = pokemon.Types[0] + " / " + pokemon.Types[1];
            WeightLabel.Text = pokemon.Weight.ToString() + "kg";
            PowerUpCandyLabel.Text = pokemon.PowerUpCandy.ToString();
            PowerUpStardustLabel.Text = pokemon.PowerUpStardust.ToString();
            EvolveCandyLabel.Text = pokemon.EvolveCandy.ToString();
            UserStardustLabel.Text = user.UserStardust.ToString();
            UserCandyLabel.Text = user.UserCandy.ToString();
        }
    }
}