using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    abstract class Weapon : Item
    {
        //Q.2.1 Protected Weapon Variables
        protected int Damage;
        public int Damage_Accessor
        {
            get
            {
                return Damage;
            }
            set
            {
                Damage = value;
            }
        }
        protected int Range;
        public virtual int Range_Accessor
        {
            get
            {
                return Range;
            }
            set
            {
                Range = value;
            }
        }
        protected int Durability;
        public int Durability_Accessor
        {
            get
            {
                return Durability;
            }
            set
            {
                Durability = value;
            }
        }
        protected int Cost;
        public int Cost_Accessor
        {
            get
            {
                return Cost;
            }
            set
            {
                Cost = value;
            }
        }

        protected string Weapon_Type;
        public string Weapon_Type_Accessor
        {
            get
            {
                return Weapon_Type;
            }
            set
            {
                Weapon_Type = value;
            }
        }


        public Weapon(int xPosition, int yPosition, char symbol) : base(xPosition, yPosition)
        {
        }
    }

    /// <summary>
    /// Q.2.2 Melee Weapon subclass
    /// </summary>
    class MeleeWeapon : Weapon
    {

        /// <summary>
        /// Q.2.2 Lists the types of melee Weapons able to be found
        /// </summary>
        public enum Types
        {
            DAGGER,
            LONGSWORD
        }

        /// <summary>
        /// Q.2.2 Sets the range of melee weapons to be 1.
        /// </summary>
        public override int Range_Accessor
        {
            get
            {
                return Range_Accessor;
            }
            set
            {
                Range_Accessor = 1;
            }
        }

        /// <summary>
        /// Q.2.2 The constructor for the subclass where, depending on the weapon type, will display either Dagger or Longsword stats.
        /// </summary>
        /// <param name="xPosition"></param>
        /// <param name="yPosition"></param>
        /// <param name="symbol"></param>
        /// <param name="Weapon_Type"></param>
        public MeleeWeapon(int xPosition, int yPosition, char symbol, Types Weapon_Type) : base(xPosition, yPosition, symbol)
        {
            if (Weapon_Type == Types.DAGGER)
            {
                Weapon_Type_Accessor = "Dagger";
                Durability_Accessor = 10;
                Damage_Accessor = 3;
                Cost_Accessor = 3;
            }

            if (Weapon_Type == Types.LONGSWORD)
            {
                Weapon_Type_Accessor = "Longsword";
                Durability_Accessor = 6;
                Damage_Accessor = 4;
                Cost_Accessor = 5;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
