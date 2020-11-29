using System;
using System.Collections.Generic;
using System.Linq;
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
            Map map = new Map();
        }

        private Map Map;

        public Map map
        {
            get
            {
                return Map;
            }
            set
            {
                map = value;
            }
        }
        public bool MovePlayer(Character.Movement direction)
        {
            return true;
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
            FileStream outputFile = new FileStream("gameMap.binary", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(outputFile, Map);
            outputFile.Close();

        }
        public void Load()
        {
            FileStream inputFile = new FileStream("gameMap.binary", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Map fromFile= (Map)binaryFormatter.Deserialize(inputFile);
            inputFile.Close();
        }
    }
}
