using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{

    abstract class Item : Tile
    {
        public Item(int xPosition, int yPosition) : base()
        {
            //Constructor is to be empty
        }

        public abstract override string ToString();
    }
}
