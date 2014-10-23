namespace TeamworkTAMBA
{
    using System.Drawing;

    class Homework : Enemy
    {
        private const int ATTACK_POWER = 3;

        public Homework(SpriteType spriteType,  Point location, int id) :
            base(spriteType, location, id, ATTACK_POWER)
        {
        }
       
    }
}
