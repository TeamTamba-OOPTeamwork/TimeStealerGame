using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamworkTAMBA
{
    using System.Drawing;

    public class GameObject
    {
        public Image Image { get; set; }

        public Point Location { get; set; }

        public Char ID { get; set; }

        public GameObject(Image image, Point location, Char id)
        {
            this.Image = image;
            this.Location = location;
            this.ID = id;
        }
    }
}
