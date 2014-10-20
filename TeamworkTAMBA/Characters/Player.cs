namespace TeamworkTAMBA
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    using TeamworkTAMBA.Enums;

    public class Player : Characters
    {
        private int knowledge;

        public IList<Weapons> Weapons;

        public const int CSHARP_POWER = 100;
        public const int JAVA_POWER = 0;
        public const int CSS_POWER = 0;
        public const int HTML_POWER = 0;
        public const int JAVA_SCRIPT_POWER = 0;
        public const int PHP_POWER = 0;

        // constructor for the Form1
        public Player(SpriteType sriteType, Point location, int id) :
            base(sriteType, location, id)
        {
            this.Knowledge = 100;
            this.InitializeWeapons();
        }

        // constructor for the battle form
        public Player(SpriteType sriteType, int health, int attackPower, int knowledge) :
            base(sriteType, health, attackPower)
        {
            this.Knowledge = knowledge;
            this.InitializeWeapons();
        }

        public int Knowledge { get; set; }

        public void Move(int x, int y)
        {
            this.location.X += x;
            this.location.Y += y;
        }

        private void InitializeWeapons()
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
