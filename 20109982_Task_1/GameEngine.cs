using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static _20109982_Task_1.Character;

namespace _20109982_Task_1
{
    /// <summary>
    /// Q.3.3
    /// </summary>
    class GameEngine
    {



        public GameEngine(Map map)
        {
            this.map = map;
            //Shop myShop = new Shop();
        }

        protected Map Map;
        private string fileName = "Map.txt";

        public Map map
        {
            get
            {
                return Map;
            }
            set
            {
                Map = value;
            }
        }
        public bool MovePlayer(Character.Movement direction)
        {
            int x, y, tempx, tempy;
            x = this.Map.hero.X;
            y = this.Map.hero.Y;

            Character.Movement selectedMove = direction;
            switch (selectedMove)
            {
                case Movement.NONE:
                    selectedMove = Movement.NONE;
                    break;

                case Movement.UP:
                    x = 0;
                    y = -1;
                    break;

                case Movement.DOWN:
                    x = 0;
                    y = 1;
                    break;

                case Movement.LEFT:
                    x = -1;
                    y = 0;
                    break;

                case Movement.RIGHT:
                    x = 1;
                    y = 0;
                    break;

                default:
                    selectedMove = Movement.NONE;
                    break;
            }

            // Check for valid move

            if (Map.mapArrayAccessor[Map.hero.X + x, Map.hero.Y + y] is EmptyTile || Map.GetItemAtPosition(Map.hero.X + x, Map.hero.Y + y) is Gold)
            {
                // Valid

                Map.hero.Move(selectedMove);
                Map.UpdateMap();
                Map.mapArrayAccessor[Map.hero.X - x, Map.hero.Y - y] = new EmptyTile(Map.hero.X - x, Map.hero.Y - y);
                return true;

            }
            else { return false; }
        }

        public override string ToString()
        {
            return null;
        }

        public void EnemyAttacks() 
        {
            foreach (var item in Map.myEnemiesArr)
	{

	}
        }
        public void Save()
        {
            FileStream outputFile = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(outputFile, Map);
            outputFile.Close();
        }
        public void Load()
        {
            FileStream inputFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Map fromFile= (Map)binaryFormatter.Deserialize(inputFile);
            inputFile.Close();
        }
    }
}
