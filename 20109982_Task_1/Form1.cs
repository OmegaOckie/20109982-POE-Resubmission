using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20109982_Task_1
{
    public partial class Form1 : Form
    {
        private Map Map;
        private int border;
        private GameEngine gameEng;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture Up arrow key
            if (keyData == Keys.W)
            {
                if (gameEng.MovePlayer(Character.Movement.UP) == false) { };
                updateMap();
                return true;
            }
            //capture Down arrow key
            if (keyData == Keys.S)
            {
                if (gameEng.MovePlayer(Character.Movement.DOWN) == false) { };
                updateMap();
                return true;
            }
            //capture Left arrow key
            if (keyData == Keys.A)
            {
                if (gameEng.MovePlayer(Character.Movement.LEFT) == false) { };
                updateMap();
                return true;
            }
            //capture Right arrow key
            if (keyData == Keys.D)
            {
                if (gameEng.MovePlayer(Character.Movement.RIGHT) == false) { };
                updateMap();
                return true;
            }
            if (keyData == Keys.Space)
            {
                attackButton.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void shopButton_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Determines the minimum width
            int minimumWidthRNG = random.Next(1, 11);
            //Determines the maximum width
            int maximumWidthRNG = random.Next(11, 21);
            //Determines the minimum height
            int minimumHeightRNG = random.Next(1, 11);
            //Determines the maximum height
            int maximumHeightRNG = random.Next(11, 21);
            //Determines the amount of enemies spawning
            int spawnableEnemmiesRNG = random.Next(6);
            //Determines the amount of gold spawning
            int spawnableGoldRNG = random.Next(1, 6);
            //Determines the amount of weapons supposed to spawn.
            int spawnableWeaponsRNG = random.Next(6);
            Map = new Map(minimumWidthRNG, maximumWidthRNG, minimumHeightRNG, maximumHeightRNG, spawnableEnemmiesRNG, spawnableGoldRNG, spawnableWeaponsRNG);
            gameEng = new GameEngine(Map);
            border = gameEng.map.mapWidthAccessor - 1;
            updateMap();
            nameOfHeroLabel.Text = Convert.ToString(heroNameTextBox.Text);
        }

        private void updateMap()
        {
             gameMapRichTextBox.Clear();
            string newLine;
            heroStatsLabel.Text = gameEng.map.hero.ToString();

            // This updates the map every time we move 
            for (int y = 0; y < gameEng.map.mapHeightAccessor; y++)
            {
                if (y != 0) { gameMapRichTextBox.Text += "\n"; };
                for (int x = 0; x < gameEng.map.mapWidthAccessor; x++)
                {
                    switch (gameEng.map.mapArrayAccessor[x, y])
                    {
                        case Tile.EmptyTile _:
                            gameMapRichTextBox.Text += "_";
                            break;
                        case Tile.Obstacle _:
                            gameMapRichTextBox.Text += "X";
                            break;
                        case Hero _:
                            gameMapRichTextBox.Text += "H";
                            break;
                        case Gold _:
                            gameMapRichTextBox.Text += "G";
                            break;
                        case Goblin _:
                            gameMapRichTextBox.Text += "K";
                            break;
                        case Mage _:
                            gameMapRichTextBox.Text += "M";
                            break;
                        case Leader _:
                            gameMapRichTextBox.Text += "L";
                            break;
                        case Weapon _:
                            gameMapRichTextBox.Text += "W";
                            break;

                    }
                }
            }
        }
    }
}
