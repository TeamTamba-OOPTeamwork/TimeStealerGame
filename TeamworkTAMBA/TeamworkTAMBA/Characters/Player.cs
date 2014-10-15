namespace TeamworkTAMBA
{
    using System.Drawing;
    using System.Windows.Forms;

    public class Player : Characters
    {
        public PictureBox PictureBoxPlayer { get; set; }
        public Player(PictureBox picture = null, int id = 0) :
            base(new Bitmap("index.jpg"),new Point(0,0), id)
        {
            this.PictureBoxPlayer = picture;
        }
    }
}
