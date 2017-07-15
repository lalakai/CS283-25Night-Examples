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
        private int PowerUpTimes = 0;
        private int EvolveTimes = 0;

        public Form1()
        {
            InitializeComponent();
            UserStardust = 100000;
            UserCandy = 1000;

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
            if (PowerUpTimes < 20)
            {
                if (UserStardust >= 3000 && UserCandy >= 3)
                {
                    UserStardust = UserStardust - pokemon.PowerUpStardust;
                    UserCandy = UserCandy - pokemon.PowerUpCandy;
                    pokemon.Hp = pokemon.Hp + 20;
                    pokemon.CurrentHp = pokemon.CurrentHp + 20;
                    UserStardustLabel.Text = UserStardust.ToString();
                    UserCandyLabel.Text = UserCandy.ToString();
                    HpLabel.Text = pokemon.CurrentHp + " / " + pokemon.Hp + "Hp";
                    PowerUpTimes++;
                }
                else
                {
                    MessageBox.Show("你的材料不夠囉!");
                }
            }
            else
            {
                MessageBox.Show("已強化至最高級別!");
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EvolveTimes++;
            if (EvolveTimes == 1)
            {
                if (UserCandy >= 25)
                {
                    UserCandy = UserCandy - pokemon.EvolveCandy;
                    pokemon = new Pokemon()
                    {
                        Name = "妙蛙草",
                        CurrentHp = 550,
                        Hp = 560,
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
                    PowerUpTimes = 0;
                    button1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("你的材料不夠囉!");
                    EvolveTimes = 0;
                }
            }
            if (EvolveTimes == 2)
            {
                if (UserCandy >= 100)
                {
                    UserCandy = UserCandy - pokemon.EvolveCandy;
                    pokemon = new Pokemon()
                    {
                        Name = "妙蛙花",
                        CurrentHp = 1250,
                        Hp = 1260,
                        Height = 2.54f,
                        Types = new string[] { "草", "毒" },
                        Weight = 15.94f,
                        PowerUpCandy = 3,
                        PowerUpStardust = 3000,
                        EvolveCandy = 0,
                    };
                    NameLabel.Text = pokemon.Name;
                    HpLabel.Text = pokemon.CurrentHp + " / " + pokemon.Hp + "Hp";
                    HeightLabel.Text = pokemon.Height.ToString() + "m";
                    TypesLabel.Text = pokemon.Types[0] + " / " + pokemon.Types[1];
                    WeightLabel.Text = pokemon.Weight.ToString() + "kg";
                    PowerUpCandyLabel.Text = pokemon.PowerUpCandy.ToString();
                    PowerUpStardustLabel.Text = pokemon.PowerUpStardust.ToString();
                    EvolveCandyLabel.Text = "已進化至最高級別";
                    UserStardustLabel.Text = UserStardust.ToString();
                    UserCandyLabel.Text = UserCandy.ToString();
                    PowerUpTimes = 0;
                    button1.Enabled = true;
                    button2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("你的材料不夠囉!");
                    EvolveTimes = 1;
                }
            }
        }
    }
}