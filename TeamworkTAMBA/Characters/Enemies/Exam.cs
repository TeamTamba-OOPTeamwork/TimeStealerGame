using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamworkTAMBA
{
    using System.Drawing;

    public class Exam : Enemy
    {
        public Exam(SpriteType spriteType,Point location,int id) :
            base(spriteType, location, id)
        {
            
        }
    }
}
