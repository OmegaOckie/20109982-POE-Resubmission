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

    /// <summary>
    /// Q.2.4 Leader Subclass
    /// </summary>
    class Leader : Enemy
    {
        /// <summary>
        /// Q.2.4 Denotes the Leader's Target
        /// </summary>
        private Tile Leader_Target
        {
            get
            {
                return Leader_Target;
            }
            set
            {
                Leader_Target = value;
            }
        }

        /// <summary>
        /// Q.2.4 A constructor that sets the stats of the Leader.
        /// </summary>
        /// <param name="xPosition"></param>
        /// <param name="yPosition"></param>
        public Leader(int xPosition, int yPosition) : base(xPosition, yPosition, 2, 20, 'L')
        {
        }

        public override Movement ReturnMove(Movement move = Movement.NONE)
        {
            throw new NotImplementedException();
        }
    }
}
