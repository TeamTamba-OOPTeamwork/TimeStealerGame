namespace TeamworkTAMBA
{
    using System.Drawing;

    public class Enemy : Characters
    {
        private bool isAlive;

        public Enemy(SpriteType sriteType, Point location, int id) :
            base(sriteType, location, id)
        {
            this.IsAlive = true;
        }

        public Enemy(SpriteType sriteType, int health, int attackPower) :
            base(sriteType, health, attackPower)
        {
            
        }

        public bool IsAlive { get; set; }
    }
}
