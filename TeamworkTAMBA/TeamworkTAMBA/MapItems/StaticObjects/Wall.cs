using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamworkTAMBA
{
    using System.Drawing;

    public class Wall : StaticObjects
    {
        public Wall(Image image,Point location,Char id) :
            base(image,location,id)
        {
            
        }
    }
}
