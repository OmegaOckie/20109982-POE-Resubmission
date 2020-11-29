using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    class Mage : Enemy
    {
        public Mage(int xPosition, int yPosition) : base(xPosition, yPosition, 5, 5, 'M')
        {

        }

        public virtual int ReturnMove()
        {
            return 0;
        }

        public override bool CheckRange(Character target)
        {
            //left
            if (target.X == X - 1 && target.Y == Y)
            {
                return true;
            }
            //top left
            else if (target.X == X - 1 && target.Y == Y - 1)
            {
                return true;
            }
            //above
            else if (target.X == X && target.Y == Y - 1)
            {
                return true;
            }
            //top right
            else if (target.X == X + 1 && target.Y == Y - 1)
            {
                return true;
            }
            //right
            else if (target.X == X + 1 && target.Y == Y)
            {
                return true;
            }
            //bottom right
            else if (target.X == X + 1 && target.Y == Y + 1)
            {
                return true;
            }
            //below
            else if (target.X == X && target.Y == Y + 1)
            {
                return true;
            }
            //bottom left
            else if (target.X == X - 1 && target.Y == Y + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
