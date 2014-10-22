using System;

namespace TeamworkTAMBA
{
    using System.Drawing;

    public abstract class Characters : GameObject
    {
        private int health;
        private int attackPower;

        public Characters(SpriteType sriteType,Point location,int id) :
            base(sriteType, location, id)
        {
            this.Health = 100;
        }

        public Characters(SpriteType sriteType, int health, int attackPower)
        {
            this.Health = health;
            this.AttackPower = attackPower;
        }

        public int AttackPower { get; set; }

        public int Health { get; set; }
    }
}
