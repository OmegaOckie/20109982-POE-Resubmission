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
                attack_BTN.PerformClick();
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
            int rng1 = random.Next(1, 11);
            //Determines the maximum width
            int rng2 = random.Next(11, 21);
            //Determines the minimum height
            int rng3 = random.Next(1, 11);
            //Determines the maximum height
            int rng4 = random.Next(11, 21);
            //Determines the amount of enemies spawning
            int rng5 = random.Next(6);
            //Determines the amount of gold spawning
            int rng6 = random.Next(1, 6);
            //Determines the amount of weapons supposed to spawn.
            int rng7 = random.Next(6);
            Map = new Map(rng1, rng2, rng3, rng4, rng5, rng6, rng7);
            gameEng = new GameEngine(Map);
            border = gameEng.map.mapWidthAccessor - 1;
            updateMap();
            heroNameTextBox.Text = Convert.ToString(heroNameTextBox.Text);
        }

        private void updateMap()
        {
             ;
            string newLine;
            heroStats_LB.Text = gameEng.map.hero.ToString();

            // This updates the map every time we move 
            for (int y = 0; y < gameEng.map.MapHeightGrab; y++)
            {
                if (y != 0) { map.Text += "\n"; };
                for (int x = 0; x < gameEng.map.MapWidthGrab; x++)
                {
                    switch (gameEng.map.MapGrab[x, y])
                    {
                        case EmptyTile _:
                            map.Text += "_";
                            break;
                        case Obstacle _:
                            map.Text += "X";
                            break;
                        case Hero _:
                            map.Text += "H";
                            break;
                        case Gold _:
                            map.Text += "G";
                            break;
                        case Goblin _:
                            map.Text += "K";
                            break;
                        case Mage _:
                            map.Text += "M";
                            break;
                        case Leader _:
                            map.Text += "L";
                            break;
                        case Weapon _:
                            map.Text += "W";
                            break;

                    }
                }
            }
        }
    }
}
