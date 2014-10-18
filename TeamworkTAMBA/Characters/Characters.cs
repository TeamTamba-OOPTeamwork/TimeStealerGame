using System;

namespace TeamworkTAMBA
{
    using System.Drawing;

    public class Characters : GameObject
    {
        private int health;
        private int attackPower;

        public Characters(Image image,Point location,int id) :
            base(image,location,id)
        {
            
        }

        public Characters(Image image, int health, int attackPower)
        {
            this.Health = health;
            this.AttackPower = attackPower;
        }

        public int AttackPower { get; set; }

        public int Health { get; set; }
    }
}
