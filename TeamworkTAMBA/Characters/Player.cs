namespace TeamworkTAMBA
{
    using System.Drawing;
    using System.Windows.Forms;

    public class Player : Characters
    {
        private int knowledge;

        // constructor for the Form1
        public Player(SpriteType sriteType, Point location, int id) :
            base(sriteType, location, id)
        {
            this.Knowledge = 100;
        }

        // constructor for the battle form
        public Player(SpriteType sriteType, int health, int attackPower, int knowledge) :
            base(sriteType, health, attackPower)
        {
            this.Knowledge = knowledge;
        }

        public int Knowledge { get; set; }

        public void Move(int x, int y)
        {
            this.location.X += x;
            this.location.Y += y;
        }
    }
}
