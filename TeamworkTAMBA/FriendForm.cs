using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamworkTAMBA.Enums;

namespace TeamworkTAMBA
{
    public partial class FriendForm : Form
    {
        private Player player;
        private Friend friend;
        public FriendForm(Player player, Friend friend)
        {
            InitializeComponent();

            this.player = player;
            this.friend = friend;
            WhoIsIt(this.friend);
        }

        private void WhoIsIt(Friend friend)
        {
            if (this.friend is Nakov)
            {
                speach.Text = "IM NAKOV! Take this Java!";
                foreach (var wep in player.Weapons)
                {
                    if (wep.WeaponType == WeaponTypes.Java)
                    {
                        wep.Power = 100;
                    }
                }
            }
            else if (this.friend is Vlado)
            {
                speach.Text = "Hi, I`m Vlado! Take this HTML!";
                foreach (var wep in player.Weapons)
                {
                    if (wep.WeaponType == WeaponTypes.HTML)
                    {
                        wep.Power = 100;
                    }
                }
            }
            else if (this.friend is Didko)
            {
                speach.Text = "Hi, I`m Didko! Take this JavaScript!";
                foreach (var wep in player.Weapons)
                {
                    if (wep.WeaponType == WeaponTypes.JavaScript)
                    {
                        wep.Power = 100;
                    }
                }
            }
            else if (this.friend is Nasko)
            {
                speach.Text = "Hi, I`m Nasko! Take this PHP!";
                foreach (var wep in player.Weapons)
                {
                    if (wep.WeaponType == WeaponTypes.PHP)
                    {
                        wep.Power = 100;
                    }
                }
            }
            else if (this.friend is SuperVlado)
            {
                speach.Text = "Hi, I`m Super Vlado! Take this CSS!";
                foreach (var wep in player.Weapons)
                {
                    if (wep.WeaponType == WeaponTypes.CSS)
                    {
                        wep.Power = 100;
                    }
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
