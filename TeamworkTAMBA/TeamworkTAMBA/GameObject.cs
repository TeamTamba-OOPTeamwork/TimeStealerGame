using System;

namespace TeamworkTAMBA
{
    using System.Drawing;
    using System.Windows.Forms;

    public class GameObject
    {
        public Point location;
        public Image Image { get; set; }

        public Point Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }

        public int ID { get; set; }

        public GameObject(Image image, Point location, int id)
        {
            this.Image = image;
            this.Location = location;
            this.ID = id;
        }
    }
}
