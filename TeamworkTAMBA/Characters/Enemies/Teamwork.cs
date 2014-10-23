namespace TeamworkTAMBA
{
    using System.Drawing;

    public class Teamwork : Enemy
    {
        private const int ATTACK_POWER = 5;

        public Teamwork(SpriteType spriteType, Point location, int id) :
            base(spriteType, location, id, ATTACK_POWER)
        {
        }
    }
}
