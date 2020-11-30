using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    /// <summary>
    /// Q.2.1 Tile abstract class. Base class needed for all objects with a position in-game.
    /// </summary>
    abstract class Tile
    {
        /// <summary>
        /// Q.2.1 Defines the type of tile of a coordinate.
        /// </summary>
            public enum TileType
        {
            HERO, ENEMY, GOLD, WEAPON
        };

        /// <summary>
        /// X and Y are the variable coordinates of the Tile.
        /// </summary>
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



        /// <summary>
        /// Q.2.1 Tile Constructor that sets the initial values for the Tile
        /// </summary>
        public Tile()
        {
            X = 0;
            Y = 0;
            tile = TileType.HERO;
        }

        /// <summary>
        /// Q.2.1 Exists to border the map
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
