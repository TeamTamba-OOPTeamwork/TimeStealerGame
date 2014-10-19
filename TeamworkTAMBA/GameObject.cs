using System;

namespace TeamworkTAMBA
{
    using System.Drawing;
    using System.Windows.Forms;

    public class GameObject : IDrawable
    {
        public Point location;
        public int ID { get; set; }
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

        // id parmatera mai e izli6en za momenta
        public GameObject(SpriteType spriteType, Point location, int id)
        {
            this.SpiteType = spriteType;
            this.Location = location;
            this.ID = id;
        }

        // za sega trqbva za da ne davat gre6ki klasovete koito go naslqdavat bez da polzvat nqkoi ot parametrite po-gore
        public GameObject() { }

        public SpriteType SpiteType { get; set; }
    }
}
