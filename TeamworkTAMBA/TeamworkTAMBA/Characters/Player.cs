using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkTAMBA
{
    public class Player : Characters
    {
        private string name;

        public Player(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
