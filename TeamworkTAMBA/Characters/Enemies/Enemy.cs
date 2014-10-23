namespace TeamworkTAMBA
{
    using System.Drawing;

    public class Enemy : Characters
    {
        private bool isAlive;

        public Enemy(SpriteType sriteType, Point location, int id, int attackPower) :
            base(sriteType, location, id, attackPower)
        {
            this.IsAlive = true;
        }

        public bool IsAlive { get; set; }
    }
}
