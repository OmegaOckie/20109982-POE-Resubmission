using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    /// <summary>
    /// Q.2.1
    /// </summary>
    abstract class Tile
    {

            public enum TileType
        {
            HERO, ENEMY, GOLD, WEAPON
        };

        protected int x;
        protected int y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                X = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                Y = value;
            }
        }
        protected TileType tile { get; set; }


        //Created the relevant constructor for Q.2.1

        public Tile()
        {
            X = 0;
            Y = 0;
            tile = TileType.HERO;
        }

        /// <summary>
        /// Exists to border the map
        /// </summary>
        class Obstacle : Tile
    {
            public Obstacle(int xInput, int yInput) : base()
            {
                Console.WriteLine("X");
            }
    }

        class EmptyTile : Tile
        {
            public EmptyTile(int xInput, int yInput) : base()
            {
                Console.WriteLine(".");
            }
        }
    }


}
