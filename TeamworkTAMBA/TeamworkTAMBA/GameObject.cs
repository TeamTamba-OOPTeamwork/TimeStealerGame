using System;

namespace TeamworkTAMBA
{
    using System.Drawing;
    using System.Windows.Forms;

    public class GameObject
    {
        public Point location;
        public Image Image { get; set; }
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
        public GameObject(Image image, Point location, int id)
        {
            this.Image = image;
            this.Location = location;
            this.ID = id;
        }
        
        // za sega trqbva za da ne davat gre6ki klasovete koito go naslqdavat bez da polzvat nqkoi ot parametrite po-gore
        public GameObject() { }

        // pokazva parametrite po koito 6te se risuvat obektite
        public void Draw(Graphics device)
        {
            device.DrawImage(Image, Location);
        }
    }
}
