using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamworkTAMBA
{
    using System.Drawing;

    public class Food : PicableObjects
    {
        public Food(SpriteType sriteType, Point location, int id) :
            base(sriteType, location, id)
        {

        }
    }
}
