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
                        if (player.KillsCounter > 0)
                        {
                            wep.Power = 100;
                        }
                        else
                        {
                            speach.Text = "You must kill at least 1 Homework to earn Java!";
                        }
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
                        if (player.KillsCounter > 1)
                        {
                            wep.Power = 100;
                        }
                        else
                        {
                            speach.Text = "You must kill at least 1 Homework to earn HTML!";
                        }
                    }
                }
            }
            else if (this.friend is Didko)
            {
                speach.Text = "Hi, I`m Didko! Take this JavaScript!";
                foreach (var wep in player.Weapons)
                {
                    if (player.KillsCounter > 2)
                    {
                        wep.Power = 100;
                    }
                    else
                    {
                        speach.Text = "You must kill at least 2 Homework to earn JavaScript!";
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
                        if (player.KillsCounter > 3)
                        {
                            wep.Power = 100;
                        }
                        else
                        {
                            speach.Text = "You must kill at least 3 Homework to earn PHP!";
                        }
                    }
                }
            }
            else if (this.friend is SuperVlado)
            {
                speach.Text = "Hi, I`m Super Vlado! Take this CSS!";
                foreach (var wep in player.Weapons)
                {
                    if (player.KillsCounter > 4)
                    {
                        wep.Power = 100;
                    }
                    else
                    {
                        speach.Text = "You must kill at least 4 Homework to earn PHP!";
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
