using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    class RangedWeapon : Weapon
    {
        public enum Types
        {
            RIFLE,
            LONGBOW
        }

        public override int Range_Accessor { get => base.Range_Accessor; set => base.Range_Accessor = value; }

        public RangedWeapon(int xPosition, int yPosition, char symbol, Types Weapon_Type) : base(xPosition, yPosition, symbol)
        {
            if (Weapon_Type == Types.RIFLE)
            {
                Weapon_Type_Accessor = "Rifle";
                Durability_Accessor = 3;
                Range_Accessor = 3;
                Damage_Accessor = 5;
                Cost_Accessor = 7;
            }

            if (Weapon_Type == Types.LONGBOW)
            {
                Weapon_Type_Accessor = "Longbow";
                Durability_Accessor = 4;
                Range_Accessor = 2;
                Damage_Accessor = 4;
                Cost_Accessor = 6;
            }
        }


        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
