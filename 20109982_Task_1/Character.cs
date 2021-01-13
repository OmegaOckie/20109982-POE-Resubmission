using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    /// <summary>
    /// Task 1 Q.2.2
    /// </summary>
    abstract class Character : Tile
    {

        /// <summary>
        /// Task 1 Q.2.2 List of available movement.
        /// </summary>
        public enum Movement
        {
            NONE, UP, DOWN, LEFT, RIGHT
        }

        /// <summary>
        /// The HP of the character.
        /// </summary>
        protected int HP { get; set; }

        /// <summary>
        /// The Max HP of the Character
        /// </summary>
        protected int maxHP { get; set; } 

        /// <summary>
        /// The damage a character can do.
        /// </summary>
        protected int damage { get; set; }

        /// <summary>
        /// An array that is used to check for valid movement.
        /// </summary>
        protected Tile[,] characterVisionArray;

        /// <summary>
        /// The amount of gold a character has.
        /// </summary>
        public int characterGold;

        /// <summary>
        /// Q.2.3 A constructor that delegates the settings of the variables to the Tile class.
        /// </summary>
        /// <param name="xInput"></param>
        /// <param name="yInput"></param>
        /// <param name="symbol"></param>
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

        /// <summary>
        /// Q.2.3 Method that decreases a targets HP.
        /// </summary>
        /// <param name="target"></param>
        public virtual void Attack(Character target)
        {
            target.HP -= damage;
        }

        /// <summary>
        /// Q.2.3 Checks if a character is dead.
        /// </summary>
        /// <returns></returns>
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
        /// Q.2.3 Checks if a character is within range of it's target.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public virtual bool CheckRange(Character target)
        {

            //Unable to calculate range if there is no way to find where the origin point is in acoordance with the target point
            int distanceToTarget = DistanceTo(target);

            if (distanceToTarget <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines the distance between a character and it's target.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        private int DistanceTo(Character target)
        {
            int distanceX, distanceY, tempX, tempY;
            distanceX = 0;
            distanceY = 0;
            bool isPosititiveOrNegative;
            if (target.X > X) 
            {
                isPosititiveOrNegative = true; 
            } 
            else 
            { 
                isPosititiveOrNegative = false; 
            }
            tempX = X;
            while (tempX != target.X)
            {
                if (isPosititiveOrNegative)
                {
                    tempX++;
                    distanceX++;
                }
                else
                {
                    tempX--;
                    distanceX++;
                }
            }
            if (target.Y > Y) 
            { 
                isPosititiveOrNegative = true; 
            } 
            else 
            { 
                isPosititiveOrNegative = false; 
            }
            tempY = Y;
            while (tempY != target.Y)
            {
                if (isPosititiveOrNegative)
                {
                    tempY++;
                    distanceY++;
                }
                else
                {
                    tempY--;
                    distanceY++;
                }
            }
            return distanceX + distanceY;

        }

        /// <summary>
        /// Edit's a unit's X and Y values to move it dufferent directions
        /// </summary>
        /// <param name="move"></param>
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
                case Gold gold:
                    characterGold += gold.goldDrop;
                    break;
                default:
                    break;
	}
        }

        public abstract override string ToString();
    }
}
