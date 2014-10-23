namespace TeamworkTAMBA
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    using TeamworkTAMBA.Enums;
    using TeamworkTAMBA.Interfaces;

    public class Player : Characters, IMovable
    {
        private int knowledge;
        private int money;
        private int killsCounter;
        private int beers;

        public IList<Weapons> Weapons;

        public const int CSHARP_POWER = 100;
        public const int JAVA_POWER = 0;
        public const int CSS_POWER = 0;
        public const int HTML_POWER = 0;
        public const int JAVA_SCRIPT_POWER = 0;
        public const int PHP_POWER = 0;
        public const int MONEY = 10;
        public const int KNOWLEDGE = 100;
        public const int KILLSCOUNTER = 0;
        public const int BEERS = 0;

        public Player(SpriteType sriteType, Point location, int id) :
            base(sriteType, location, id)
        {
            this.Knowledge = KNOWLEDGE;
            this.Money = MONEY;
            this.KillsCounter = KILLSCOUNTER;
            this.beers = BEERS;
            this.InitializeWeapons();
        }

        public Player(SpriteType sriteType, int health, int attackPower) :
            base(sriteType, health, attackPower)
        {
            this.Knowledge = KNOWLEDGE;
            this.Money = MONEY;
            this.KillsCounter = KILLSCOUNTER;
            this.Beers = BEERS;
            this.InitializeWeapons();
        }

        public int Knowledge { get; set; }
        public int Money { get; set; }
        public int KillsCounter { get; set; }
        public int Beers { get; set; }

        public void Move(int x, int y)
        {
            this.location.X += x;
            this.location.Y += y;
        }

        public void InitializeWeapons()
        {
            this.Weapons = new List<Weapons>()
                {
                    new Weapons(CSHARP_POWER, WeaponTypes.CSharp),
                    new Weapons(JAVA_POWER, WeaponTypes.Java),
                    new Weapons(CSS_POWER, WeaponTypes.CSS),
                    new Weapons(HTML_POWER, WeaponTypes.HTML),
                    new Weapons(JAVA_SCRIPT_POWER, WeaponTypes.JavaScript),
                    new Weapons(PHP_POWER, WeaponTypes.PHP)
                };
        }
    }
}
