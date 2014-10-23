namespace TeamworkTAMBA
{
    using TeamworkTAMBA.Enums;

    public class Weapons
    {
        private int power;

        private WeaponTypes weaponType;

        public Weapons(int power, WeaponTypes weaponType)
        {
            this.WeaponType = weaponType;
            this.Power = power;
        }

        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }

        public WeaponTypes WeaponType
        {
            get
            {
                return this.weaponType;
            }
            set
            {
                this.weaponType = value;
            }
        }
    }
}
