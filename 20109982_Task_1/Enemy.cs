using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    /// <summary>
    /// Q.2.4 The enemy class
    /// </summary>
    abstract class Enemy : Character
    {
        protected Random rng = new Random();

        /// <summary>
        /// Task 1 Q.2.4 The enemy Constructor
        /// </summary>
        /// <param name="xPosition"></param>
        /// <param name="yPosition"></param>
        /// <param name="enemyDamage"></param>
        /// <param name="startingHP"></param>
        /// <param name="symbol"></param>
        public Enemy(int xPosition, int yPosition, int enemyDamage, int startingHP, char symbol = 'E') : base(xPosition, yPosition, symbol)
        {
            X = xPosition;
            Y = yPosition;
            maxHP = startingHP;
            HP = startingHP;
        }

        /// <summary>
        /// Q.2.4 Displays Movement
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Enemy.TileType.ENEMY} at [{X},{Y}] ({damage} DMG)";
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
        public Tile Leader_Target_Accessor
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

        public Movement getRandomMove()
        {
            Movement selectedMove = Movement.NONE;
            Array values = Enum.GetValues(typeof(Movement));
            Random random = new Random();
            selectedMove = (Movement)values.GetValue(random.Next(values.Length));
            return selectedMove;
        }

        public override Movement ReturnMove(Movement move = Movement.NONE)
        {
            Movement selectedMove = getRandomMove();
            int x, y;
            x = 0;
            y = 0;
            switch (selectedMove)
            {
                case Movement.NONE:
                    selectedMove = Movement.NONE;
                    break;
                case Movement.UP:
                    x = 0;
                    y = 1;
                    break;
                case Movement.DOWN:
                    x = 0;
                    y = -1;
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

            while (base.characterVision[x, y] != null)
            {
                selectedMove = getRandomMove();
                switch (selectedMove)
                {
                    case Movement.NONE:
                        selectedMove = Movement.NONE;
                        break;
                    case Movement.UP:
                        x = 0;
                        y = 1;
                        break;
                    case Movement.DOWN:
                        x = 0;
                        y = -1;
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
            }

            return selectedMove;

        }
    }
}
