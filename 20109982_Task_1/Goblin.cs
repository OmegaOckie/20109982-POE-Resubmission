using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    /// <summary>
    /// Q.2.5 Goblin Class
    /// </summary>
    class Goblin : Enemy
    {
        /// <summary>
        /// Q.2.5 Goblin stat Constructor
        /// </summary>
        /// <param name="xPosition"></param>
        /// <param name="yPosition"></param>
        public Goblin( int xPosition, int yPosition) : base(xPosition, yPosition, 1, 10, 'G')
        {
        }

        public Movement getRandomMove()
        {
            Movement selectedMove = Movement.NONE;
            Array values = Enum.GetValues(typeof(Movement));
            Random random = new Random();
            selectedMove = (Movement)values.GetValue(random.Next(values.Length));
            return selectedMove;
        }

        /// <summary>
        /// Q.2.5 Method returns a random direction.
        /// </summary>
        /// <param name="move"></param>
        /// <returns></returns>
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
