using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    [Serializable]
    /// <summary>
    /// Task 1 Q.3.1 Map Class
    /// </summary>
    class Map
    {
        /// <summary>
        /// Task 1 Q.3.1 The variables are declared here.
        /// </summary>
        protected Tile[,] mapArray;
        public Tile[,] mapArrayAccessor
        {
            get
            {
                return mapArray;
            }

        }
        protected Hero myHero;
        public Hero hero
        {
            get
            {
                return myHero;
            }

        }
        protected Enemy[] myEnemies;
        public Enemy[] myEnemiesArr
        {
            get 
            {
                return myEnemies;
            }
        }
        protected int mapWidth;
        public int mapWidthAccessor
        {
            get
            {
                return mapWidth;
            }
        }
        protected int mapHeight;
        protected Random rng = new Random();
        protected Item[] mapItems;
        public Item[] mapItemsArr
            {
        get{
            return mapItems;
            }
            set{
            mapItems = value;
            }
            }


        /// <summary>
        /// Q.3.1 The constructor for the Map class
        /// </summary>
        /// <param name="minimumWidth"></param>
        /// <param name="maximumWidth"></param>
        /// <param name="minimumHeight"></param>
        /// <param name="maximumHeight"></param>
        /// <param name="numberOfEnemies"></param>
        /// <param name="amountOfGoldDrops"></param>
        public Map(int minimumWidth, int maximumWidth, int minimumHeight, int maximumHeight, int numberOfEnemies, int amountOfGoldDrops, int weaponDrops)
        {

            //Randomised the dimensions of the map.
            int mapWidth = rng.Next(minimumWidth, maximumWidth);
            int mapHeight = rng.Next(minimumHeight, maximumHeight);

            mapArray = new Tile[mapWidth, mapHeight];
            for (int y = 0; y < mapHeight; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    if (y == 0 || y == mapHeight - 1)
                    {
                        mapArray[x, y] = new Obstacle(x, y);
                    }
                    else
                    {
                        if (x == 0 || x == mapWidth - 1)
                        {
                            mapArray[x, y] = new Obstacle(x, y);
                        }
                        else
                        {
                            mapArray[x, y] = new EmptyTile(x, y);
                        }
                    }
                }
            }
            myEnemies = new Enemy[(mapWidth + mapHeight) / 3];

            myHero = (Hero)Create(Tile.TileType.HERO);

            for (int i = 0; i < myEnemies.Count(); i++)
            {
                myEnemies[i] = (Enemy)Create(Tile.TileType.ENEMY);
            }
            UpdateVision();

            //mapItems[amountOfGoldDrops] = new Item[];
        }

        public Map()
        {
        }

        public void UpdateMap()
        {
            foreach (Tile item in mapArray)
            {
                mapArray[item.X, item.Y] = item;
            }
        }
        /// <summary>
        /// Q.3.1 Updates the vision array for each character.
        /// </summary>
        public void UpdateVision()
        {
            Tile[,] tileTemp;
            tileTemp = new Tile[mapWidth, mapHeight];

            foreach (Tile temporaryVariable in myEnemies)
            {
                for (int i = -1; i < 2; i++)
                {
                    if (i + temporaryVariable.X > mapHeight || i + temporaryVariable.X < 0) { continue; }
                    for (int k = -1; k < 2; k++)
                    {
                        if (k + temporaryVariable.Y > mapHeight || k + temporaryVariable.Y < 0) { continue; }
                        tileTemp[temporaryVariable.X + i, temporaryVariable.Y + k] = mapArray[temporaryVariable.X + i, temporaryVariable.Y + k];
                        //temporaryVariable.characterVision = tileTemp;
                    }
                }
            }
        }

        private Tile Create(Tile.TileType type)
        {
            int counter = 0;
            Tile tempTile = null;
            int randomX = rng.Next(1, mapWidth);
            int randomY = rng.Next(1, mapHeight);
            int heroHP = 0;
            char heroSymbol = 'H';
            while (mapArray[randomX, randomY] != null)
            {
                 randomX = rng.Next(1, mapWidth);
                 randomY = rng.Next(1, mapHeight);
            }

            switch (type)
            {

                case Tile.TileType.HERO:

                    tempTile = new Hero(randomX, randomY, heroHP, heroSymbol);
                    break;
                case Tile.TileType.ENEMY:
                    int enemyType = rng.Next(4);
                    if (enemyType <= 1)
	{
                        tempTile = new Mage(randomX, randomY);
	}
                    else if (enemyType == 2)
                    {
                        tempTile = new Goblin(randomX, randomY);
                    }
                    else
                    {
                        tempTile = new Leader(randomX, randomY);
                    }
	
                    break;
                case Tile.TileType.GOLD:
                    Gold(randomX, randomY);
                    break;
                case Tile.TileType.WEAPON:
                    int weaponType = rng.Next(4);
                    if (weaponType <= 1)
                    {
                        tempTile = new MeleeWeapon(randomX, randomY, 'D', MeleeWeapon.Types.DAGGER);
                    }
                    else if (weaponType <= 2)
                    {
                        tempTile = new MeleeWeapon(randomX, randomY, 'S', MeleeWeapon.Types.LONGSWORD);
                    }
                    else if (weaponType <= 3)
                    {
                        tempTile = new RangedWeapon(randomX, randomY, 'R', RangedWeapon.Types.RIFLE);
                    }
                    else if (weaponType <= 4)
                    {
                        tempTile = new RangedWeapon(randomX, randomY, 'B', RangedWeapon.Types.LONGBOW);
                    }
                    break;
                default:
                    break;
            }
            mapArray[randomX, randomY] = tempTile;
            return tempTile;


        }

        private void Gold(int randomX, int randomY)
        {
            throw new NotImplementedException();
        }

        public Item GetItemAtPosition(int x, int y)
        {
            try
            {
                return (Item)mapArray[x, y];
            }
            catch (InvalidCastException e)
            {
            }
            return null;
        }
    }
}
