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

            playerHealthLabel.Text = "Time: " + player.Health;
            playerKnowledgeLabel.Text = "Knowledge: " + player.Knowledge;
            playerSolvedLabel.Text = "Solved: " + player.KillsCounter;
        }

        private void WhoIsIt(Friend friend)
        {
            if (this.friend is Nakov)
            {
                foreach (var weapon in player.Weapons)
                {
                    if (weapon.WeaponType == WeaponTypes.Java)
                    {
                        if (player.KillsCounter > 0)
                        {
                            speach.Text = "Im Nakov! Take this Java!";
                            weapon.Power = 100;
                            player.Knowledge = 100;
                        }
                        else
                        {
                            speach.Text = "Im Nakov! \nYou must kill at least 1 Homework to earn Java!";
                        }
                    }
                }
            }
            else if (this.friend is Vlado)
            {

                foreach (var weapon in player.Weapons)
                {
                    if (weapon.WeaponType == WeaponTypes.HTML)
                    {
                        if (player.KillsCounter > 1)
                        {
                            speach.Text = "Hi, I`m Vlado! Take this HTML!";
                            weapon.Power = 100;
                            player.Knowledge = 100;
                        }
                        else
                        {
                            speach.Text = "Hi, I`m Vlado! \nYou must kill at least 2 Homework to earn HTML!";
                        }
                    }
                }
            }
            else if (this.friend is Didko)
            {
                foreach (var weapon in player.Weapons)
                {
                    if (weapon.WeaponType == WeaponTypes.JavaScript)
                    {
                        if (player.KillsCounter > 2)
                        {
                            speach.Text = "Hi, I`m Didko! Take this JavaScript!";
                            weapon.Power = 100;
                            player.Knowledge = 100;
                        }
                        else
                        {
                            speach.Text = "Hi, I`m Didko! \nYou must kill at least 3 Homework to earn JavaScript!";
                        }
                    }
                }
            }
            else if (this.friend is Nasko)
            {
                foreach (var weapon in player.Weapons)
                {
                    if (weapon.WeaponType == WeaponTypes.PHP)
                    {
                        if (player.KillsCounter > 3)
                        {
                            speach.Text = "Hi, I`m Nasko! Take this PHP!";
                            weapon.Power = 100;
                            player.Knowledge = 100;
                        }
                        else
                        {
                            speach.Text = "Hi, I`m Nasko! \nYou must kill at least 4 Homework to earn PHP!";
                        }
                    }
                }
            }
            else if (this.friend is SuperVlado)
            {
                
                foreach (var weapon in player.Weapons)
                {
                    if (weapon.WeaponType == WeaponTypes.CSS)
                    {
                        if (player.KillsCounter > 4)
                        {
                            speach.Text = "Hi, I`m Super Vlado! Take this CSS!";
                            weapon.Power = 100;
                            player.Knowledge = 100;
                        }
                        else
                        {
                            speach.Text = "Hi, I`m Super Vlado! \nYou must kill at least 5 Homework to earn CSS!";
                        }
                    }
                }
            }
            else if (this.friend is Tedi)
            {
                speach.Text = "Hi, I`m Teodor! I dont know what to give you yet!";
                //foreach (var wep in player.Weapons)
                //{
                //    if (player.KillsCounter > )
                //    {
                //        wep.Power = 100;
                //    }
                //    else
                //    {
                //        speach.Text = "You must kill at least 5 Homework to earn PHP!";
                //    }
                //}
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
