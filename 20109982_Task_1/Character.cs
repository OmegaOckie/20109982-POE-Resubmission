using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    /// <summary>
    /// Q.2.2
    /// </summary>
    abstract class Character : Tile
    {
        public enum Movement
        {
            NONE, UP, DOWN, LEFT, RIGHT
        }
        protected int HP { get; set; }
        protected int maxHP { get; set; } 
        protected int damage { get; set; }
        protected Tile[,] characterVisionArray;
        public int characterGold;

        //The start of Q.2.3
        public Character(int xInput,int yInput, char symbol) : base()
        {
            X = xInput;
            Y = yInput;
        }

        public Tile[,] characterVision
        {
            get
            {
                return characterVisionArray;
            }
            set
            {
                characterVisionArray = value;
            }

        }

        public virtual void Attack(Character target)
        {
            target.HP -= damage;
        }

        public bool isDead()
        {
            if(HP < 1)
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if a character is within range of it's target.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public virtual bool CheckRange(Character target)
        {

            //Unable to calculate range if there is no way to find where the origin point is in acoordance with the target point
            int distanceToTarget = DistanceTo(target);
            bool bareHanded = true;
            if (bareHanded)
            {
                distanceToTarget = 1;
            }
            return true;
        }

        /// <summary>
        /// Determines the distance between a character and it's target.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        private int DistanceTo(Character target)
        {

            
            //The target's coordinates
            int targetXPos, targetYPos;
            targetXPos = target.X;
            targetYPos = target.Y;

                return 1;
        }

        public void Move(Movement move)
        { 
            //NONE, UP, DOWN, LEFT, RIGHT
            switch (move)
            {
                case Movement.UP:
                    Y -= 1;
                    break;

                case Movement.DOWN:
                    Y += 1;
                    break;

                case Movement.LEFT:
                    X -= 1;
                    break;

                case Movement.RIGHT:
                    X += 1;
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// the method returns a direction of movement
        /// </summary>
        /// <param name="move"></param>
        /// <returns></returns>
        public abstract Movement ReturnMove(Movement move = 0);

        public void Pickup(Item i){
            switch (i)
	{
                case TileType.GOLD:
                    characterGold += Gold();
                    break;
		default:
 break;
	}
        }

        public abstract override string ToString();
    }
}
