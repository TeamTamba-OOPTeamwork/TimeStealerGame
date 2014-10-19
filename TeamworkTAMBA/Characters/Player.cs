namespace TeamworkTAMBA
{
    using System.Drawing;
    using System.Windows.Forms;

    public class Player : Characters
    {
        // constructor for the Form1
        public Player(SpriteType sriteType, Point location, int id) :
            base(sriteType, location, id)
        {

        }

        // constructor for the battle form
        public Player(SpriteType sriteType, int health, int attackPower) :
            base(sriteType, health, attackPower)
        {

        }

        public void Move(int x, int y)
        {
            this.location.X += x;
            this.location.Y += y;
        }
    }
}
