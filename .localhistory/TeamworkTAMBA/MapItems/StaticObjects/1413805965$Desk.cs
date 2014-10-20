using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamworkTAMBA
{
    using System.Drawing;

    public class Furniture : StaticObjects
    {
        public Furniture(SpriteType sriteType, Point location, int id) :
            base(sriteType, location, id)
        {

        }
    }
}
