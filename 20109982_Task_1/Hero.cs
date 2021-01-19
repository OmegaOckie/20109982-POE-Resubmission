using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    /// <summary>
    /// Q.2.6
    /// </summary>
    class Hero : Character
    {
        public Hero(int xInput, int yInput, int HP, char symbol) : base(xInput, yInput, 'H')
        {

            this.HP = HP;
            maxHP = HP;
            damage = 2;
        }

        public override Movement ReturnMove(Movement move = Movement.NONE)
        {
            int x, y;
            x = 0;
            y = 0;
            Movement selectedMove = move;
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

            if (base.characterVision[x, y] is EmptyTile)
            {
                return selectedMove;
            }
            else
            {
                return Movement.NONE;
            }

        }

        /// <summary>
        /// Q.2.6 Returns the formatted Player Stats
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            bool barehanded = true;
            if (barehanded)
            {
                return $"Player Stats:" +
                                $"\nHP: {HP}/{maxHP}" +
                                $"\nCurrent Weapon: Bare Hands" +
                                $"\nWeapon Range: {1}" +
                                $"\nWeapon Damage: {damage}" +
                            $"\n[{X}, {Y}]";
            }
            else
            {
                return $"Player Stats:" +
                $"HP: {HP}/{maxHP}" +
                $"Current Weapon: {Weapon.TileType.WEAPON}" +
                $"Weapon Range: {1}" +
                $"Weapon Damage: {damage}" +
                $"Durability: 4" +
            $"[{X}, {Y}]";
            }

        }
    }
}
