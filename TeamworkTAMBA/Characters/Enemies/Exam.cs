namespace TeamworkTAMBA
{
    using System.Drawing;

    public class Exam : Enemy
    {
        private const int ATTACK_POWER = 10;

        public Exam(SpriteType spriteType, Point location, int id) :
            base(spriteType, location, id, ATTACK_POWER)
        {
        }
    }
}
