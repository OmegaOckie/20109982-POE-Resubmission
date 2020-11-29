using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    abstract class Enemy : Character
    {
        protected Random rng = new Random();

        public Enemy(int xPosition, int yPosition, int enemyDamage, int startingHP, char symbol = 'E') : base(xPosition, yPosition, symbol)
        {
            X = xPosition;
            Y = yPosition;
            maxHP = startingHP;
            HP = startingHP;
        }

        public override string ToString()
        {
            //Following line of code will throw errors since no Enemy Classes exist yet.
            return "Enemy" + " at " + "[" + X + ", " + Y + "]" + "(" + damage + ")";
        }
    }
}
