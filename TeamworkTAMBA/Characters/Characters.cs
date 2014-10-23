namespace TeamworkTAMBA
{
    using System.Drawing;

    public abstract class Characters : GameObject
    {
        
        public Characters(SpriteType sriteType, Point location, int id, int attackPower) :
            base(sriteType, location, id)
        {
            this.Health = 100;
            this.AttackPower = attackPower;
        }

        public int AttackPower { get; set; }

        public int Health { get; set; }
    }
}
