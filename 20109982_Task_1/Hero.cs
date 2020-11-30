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
        public Hero(int xInput,int yInput, int HP,char symbol) : base(xInput, yInput, 'H')
        {

            this.HP = HP;
            maxHP = HP;
            damage = 2;
        }

        public override Movement ReturnMove(Movement move = Movement.NONE)
        {
            return Movement.NONE;
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
                                $"HP: {HP}/{maxHP}" +
                                $"Current Weapon: Bare Hands" +
                                $"Weapon Range: {1}" +
                                $"Weapon Damage: {damage}" +
                            $"[{X}, {Y}]";
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
