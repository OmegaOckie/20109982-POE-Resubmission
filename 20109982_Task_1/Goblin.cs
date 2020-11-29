using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    /// <summary>
    /// Q.2.5
    /// </summary>
    class Goblin : Enemy
    {
        public Goblin( int xPosition, int yPosition) : base(xPosition, yPosition, 1, 10, 'G')
        {
        }


        public override Movement ReturnMove(Movement move = Movement.NONE)
        {
            int randomDirectionGenerator = rng.Next(5);
            Movement randomDirection = Movement.NONE;
            switch (randomDirectionGenerator)
            {
                case 0:
                    randomDirection = Movement.NONE;
                    break;
                case 1:
                    randomDirection = Movement.UP;
                    break;
                case 2:
                    randomDirection = Movement.DOWN;
                    break;
                case 3:
                    randomDirection = Movement.LEFT;
                    break;
                case 4:
                    randomDirection = Movement.RIGHT;
                    break;
                default:
                    break;
            }
            return randomDirection;
        }
    }
}
