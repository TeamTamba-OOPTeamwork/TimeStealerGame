using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkTAMBA
{
    using System.Drawing;

    class Homework : Enemy
    {
        public Homework(SpriteType spriteType,Point location,int id) :
            base(spriteType,location,id)
        {
            
        }
    }
}
