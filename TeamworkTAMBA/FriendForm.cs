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
                nakovSpeach.Text = "IM NAKOV! Take this Java!";
                foreach (var wep in player.Weapons)
                {
                    if (wep.WeaponType == WeaponTypes.Java)
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
