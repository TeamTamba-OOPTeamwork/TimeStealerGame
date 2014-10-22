using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamworkTAMBA
{
    using System.Drawing;

    public abstract class StaticObjects : MapItems
    {
        public StaticObjects(SpriteType sriteType, Point location, int id) :
            base(sriteType, location, id)
        {

        }
    }
}
