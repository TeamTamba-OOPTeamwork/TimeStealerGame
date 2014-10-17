using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamworkTAMBA
{
    using System.Drawing;

    public class Enemy : Characters
    {
        private bool isAlive; // pri == false da trie kartinkata ot ekrana 
                                // na formata i da priklu4va bitkata

        public Enemy(Image image,Point location,int id) :
            base(image,location,id)
        {
            this.IsAlive = true;
        }

        public Enemy(Image image, int health, int attackPower) :
            base(image, health, attackPower)
        {
            
        }

        public bool IsAlive { get; set; }
    }
}
