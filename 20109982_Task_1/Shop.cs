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
    class Shop
    {
        private Weapon[] WeaponArr = new Weapon[3];
        private Random rng = new Random();
        private Character buyer;

        //The constructor for the class
        public Shop(Character buyer)
        {
            Weapon[] WeaponArr = new Weapon[3];
            Random rng;

            foreach (var item in WeaponArr)
            {
                RandomWeapon();
            }
        }

        /// <summary>
        /// Q.2.5 Randomizes a weapon to be used
        /// </summary>
        /// <returns></returns>
        private Weapon RandomWeapon()
        {
            rng.Next(5);
            MeleeWeapon dagger = new MeleeWeapon(Convert.ToInt32(rng), Convert.ToInt32(rng), 'd', MeleeWeapon.Types.DAGGER);
            MeleeWeapon longsword = new MeleeWeapon(Convert.ToInt32(rng), Convert.ToInt32(rng), 's', MeleeWeapon.Types.LONGSWORD);
            RangedWeapon longbow = new RangedWeapon(Convert.ToInt32(rng), Convert.ToInt32(rng), 'b', RangedWeapon.Types.LONGBOW);
            RangedWeapon rifle = new RangedWeapon(Convert.ToInt32(rng), Convert.ToInt32(rng), 'D', RangedWeapon.Types.RIFLE);
            switch (Convert.ToInt32(rng))
            {
                case 1:
                return dagger;
                    break;
                case 2:
                    return longsword;
                    break;
                case 3:
                    return longbow;
                    break;
                case 4:
                    return rifle;
                    break;
                default:
                    return dagger;
                    break;

            }
        }

        /// <summary>
        /// Q.2.5 Checks if the player can buy an item.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool CanBuy (int num)
        {
            if (buyer.characterGold > WeaponArr[num].Cost_Accessor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Q.2.5 Allows the player to buy an item.
        /// </summary>
        /// <param name="num"></param>
        public void Buy (int num)
        {
            buyer.characterGold -= WeaponArr[num].Cost_Accessor;
            //PickUp(); Don't know where this method is
            WeaponArr[num] = RandomWeapon();
        }

        /// <summary>
        /// Q.2.5 Displays the weapon and its price.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string DisplayWeapon(int num)
        {
            return $"Buy {WeaponArr[num].Weapon_Type_Accessor} ({WeaponArr[num].Cost_Accessor} Gold)";  
        }
    }
}
