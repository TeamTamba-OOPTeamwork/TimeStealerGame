namespace TeamworkTAMBA
{
    using System.Drawing;
    using System.Windows.Forms;

    public class Player : Characters
    {
        // constructor for the Form1
        public Player(Image image, Point location, int id) :
            base(image, location, id)
        {

        }

        // constructor for the battle form
        public Player(Image image, int health, int attackPower) :
            base(image, health, attackPower)
        {

        }

        public void Move(int x, int y)
        {
            this.location.X += x;
            this.location.Y += y;
        }
    }
}
