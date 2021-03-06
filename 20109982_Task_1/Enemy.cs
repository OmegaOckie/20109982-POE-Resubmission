﻿using System;
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
        /// Task 1 Q.2.4 The enemy Constructor that receives X and Y positions, an enemy’s damage and it is starting HP(and thus also max HP) and its symbol.
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
            damage = enemyDamage;
        }

        /// <summary>
        /// Q.2.4 Displays Movement
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //return $"{Enemy.TileType.ENEMY}: {weaponType}: { this.GetType().FullName } ({HP}  at [ { X } , { Y } ] (  {damage} DMG)";

            //Previous output version
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

        private Character leaderTargetCharacter;
        public Tile Leader_Target_Accessor
        {
            get
            {
                return leaderTargetCharacter;
            }
            set
            {
                Leader_Target = leaderTargetCharacter;
            }
        }

        /// <summary>
        /// Q.2.4 A constructor that sets the stats of the Leader.
        /// Leaders have 20 HP
        /// Leaders do 2 damage
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
            if (leaderTargetCharacter.X < X)
            {
                X -= 1;
            }
            Movement selectedMove = getRandomMove();
            int x, y;
            x = 0;
            y = 0;
            switch (selectedMove)
            {
                case Movement.NONE:
                    x += 0;
                    y += 0;
                    break;
                case Movement.UP:
                    y += 1;
                    break;
                case Movement.DOWN:
                    y += -1;
                    break;
                case Movement.LEFT:
                    x += -1;
                    break;
                case Movement.RIGHT:
                    x += 1;
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
                        x += 0;
                        y += 0;
                        break;
                    case Movement.UP:
                        y += 1;
                        break;
                    case Movement.DOWN:
                        y += -1;
                        break;
                    case Movement.LEFT:
                        x += -1;
                        break;
                    case Movement.RIGHT:
                        x += 1;
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
