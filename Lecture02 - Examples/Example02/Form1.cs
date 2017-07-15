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

namespace Example02
{
    public partial class Form1 : Form
    {
        public Pokemon pokemon;
        public int UserStardust;
        public int UserCandy;

        public Form1()
        {
            InitializeComponent();
            UserStardust = 10000;
            UserCandy = 300;

            pokemon = new Pokemon()
            {
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

            NameLabel.Text = pokemon.Name;
            HpLabel.Text = pokemon.CurrentHp + " / " + pokemon.Hp + "Hp";
            HeightLabel.Text = pokemon.Height.ToString() + "m";
            TypesLabel.Text = pokemon.Types[0] + " / " + pokemon.Types[1];
            WeightLabel.Text = pokemon.Weight.ToString() + "kg";
            PowerUpCandyLabel.Text = pokemon.PowerUpCandy.ToString();
            PowerUpStardustLabel.Text = pokemon.PowerUpStardust.ToString();
            EvolveCandyLabel.Text = pokemon.EvolveCandy.ToString();
            UserStardustLabel.Text = UserStardust.ToString();
            UserCandyLabel.Text = UserCandy.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserStardust = UserStardust - pokemon.PowerUpStardust;
            UserCandy = UserCandy - pokemon.PowerUpCandy;
            pokemon.Hp = pokemon.Hp + 20;
            pokemon.CurrentHp = pokemon.CurrentHp + 20;
            UserStardustLabel.Text = UserStardust.ToString();
            UserCandyLabel.Text = UserCandy.ToString();
            HpLabel.Text = pokemon.CurrentHp + " / " + pokemon.Hp + "Hp";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserCandy = UserCandy - pokemon.EvolveCandy;
            pokemon = new Pokemon()
            {
                Name = "妙蛙草",
                CurrentHp = 150,
                Hp = 160,
                Height = 1.76f,
                Types = new string[] { "草", "毒" },
                Weight = 10.94f,
                PowerUpCandy = 3,
                PowerUpStardust = 3000,
                EvolveCandy = 100
            };

            NameLabel.Text = pokemon.Name;
            HpLabel.Text = pokemon.CurrentHp + " / " + pokemon.Hp + "Hp";
            HeightLabel.Text = pokemon.Height.ToString() + "m";
            TypesLabel.Text = pokemon.Types[0] + " / " + pokemon.Types[1];
            WeightLabel.Text = pokemon.Weight.ToString() + "kg";
            PowerUpCandyLabel.Text = pokemon.PowerUpCandy.ToString();
            PowerUpStardustLabel.Text = pokemon.PowerUpStardust.ToString();
            EvolveCandyLabel.Text = pokemon.EvolveCandy.ToString();
            UserStardustLabel.Text = UserStardust.ToString();
            UserCandyLabel.Text = UserCandy.ToString();
        }
    }
}