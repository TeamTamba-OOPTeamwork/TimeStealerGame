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
    public partial class HostesForm : Form
    {
        private Player player;
        private Friend friend;

        public HostesForm(Friend friend)
        {
            InitializeComponent();

            this.friend = friend;
            WhoIsIt(this.friend);
        }
        public HostesForm(Player player, Friend friend)
        {
            InitializeComponent();

            this.player = player;
            this.friend = friend;
            WhoIsIt(this.friend);

            playerHealthLabel.Text = "Time: " + player.Health;
            playerKnowledgeLabel.Text = "Knowledge: " + player.Knowledge;
            playerSolvedLabel.Text = "Solved: " + player.KillsCounter;
            beersLabel.Text = "Beers: " + player.Beers;
        }

        private void WhoIsIt(Friend friend)
        {
            if (this.friend is Nakov)
            {
                foreach (var weapon in player.Weapons)
                {
                    if (weapon.WeaponType == WeaponTypes.Java)
                    {
                        if (player.KillsCounter > 0 && weapon.Power == 0)
                        {
                            bribeBeerCheckbox.Visible = false;
                            speach.Text = "Im Nakov! Take this Java!";
                            weapon.Power = 100;
                            player.Knowledge = 100;
                            break;
                        }
                        else
                        {
                            bribeBeerCheckbox.Visible = false;
                            speach.Text = "Im Nakov! \nYou must kill at least 1 Homework to earn Java!";
                        }

                        if (weapon.Power == 100)
                        {
                            bribeBeerCheckbox.Visible = true;
                            BeersCheck();
                            speach.Text = "Bribe me a beer and I will give you more knowledge";

                            
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
                        if (player.KillsCounter > 1 && weapon.Power == 0)
                        {
                            bribeBeerCheckbox.Visible = false;
                            speach.Text = "Hi, I`m Vlado! Take this HTML!";
                            weapon.Power = 100;
                            player.Knowledge = 100;
                            break;
                        }
                        else
                        {
                            bribeBeerCheckbox.Visible = false;
                            speach.Text = "Hi, I`m Vlado! \nYou must kill at least 2 Homework to earn HTML!";
                        }

                        if (weapon.Power == 100)
                        {
                            bribeBeerCheckbox.Visible = true;
                            BeersCheck();
                            speach.Text = "Bribe me a beer and I will give you more knowledge";
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
                        if (player.KillsCounter > 2 && weapon.Power == 0)
                        {
                            bribeBeerCheckbox.Visible = false;
                            speach.Text = "Hi, I`m Didko! Take this JavaScript!";
                            weapon.Power = 100;
                            player.Knowledge = 100;
                            break;
                        }
                        else
                        {
                            bribeBeerCheckbox.Visible = false;
                            speach.Text = "Hi, I`m Didko! \nYou must kill at least 3 Homework to earn JavaScript!";
                        }

                        if (weapon.Power == 100)
                        {
                            bribeBeerCheckbox.Visible = true;
                            BeersCheck();
                            speach.Text = "Bribe me a beer and I will give you more knowledge";
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
                        if (player.KillsCounter > 3 && weapon.Power == 0)
                        {
                            bribeBeerCheckbox.Visible = false;
                            speach.Text = "Hi, I`m Nasko! Take this PHP!";
                            weapon.Power = 100;
                            player.Knowledge = 100;
                            break;
                        }
                        else
                        {
                            bribeBeerCheckbox.Visible = false;
                            speach.Text = "Hi, I`m Nasko! \nYou must kill at least 4 Homework to earn PHP!";
                        }

                        if (weapon.Power == 100)
                        {
                            bribeBeerCheckbox.Visible = true;
                            BeersCheck();
                            speach.Text = "Bribe me a beer and I will give you more knowledge";
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
                        if (player.KillsCounter > 4 && weapon.Power == 0)
                        {
                            bribeBeerCheckbox.Visible = false;
                            speach.Text = "Hi, I`m Super Vlado! Take this CSS!";
                            weapon.Power = 100;
                            player.Knowledge = 100;
                            break;
                        }
                        else
                        {
                            bribeBeerCheckbox.Visible = false;
                            speach.Text = "Hi, I`m Super Vlado! \nYou must kill at least 5 Homework to earn CSS!";
                        }

                        if (weapon.Power == 100)
                        {
                            bribeBeerCheckbox.Visible = true;
                            BeersCheck();
                            speach.Text = "Bribe me a beer and I will give you more knowledge";
                        }
                    }
                }
            }

            //else if (this.friend is Alex)
            //{
            //    speach.Text = "Hi! My name is Alex! Congratulations! You are a student of SoftUni now! You voluntary gave us your FREE TIME. Now you have none. In order to gain it back, finish all the Homeworks, Teamworks and Exams in the SoftUni! Good luck!";
            //    //foreach (var wep in player.Weapons)
            //    //{
            //    //    if (player.KillsCounter > )
            //    //    {
            //    //        wep.Power = 100;
            //    //    }
            //    //    else
            //    //    {
            //    //        speach.Text = "You must kill at least 5 Homework to earn PHP!";
            //    //    }
            //    //}
            //}
        }

        private void bribeBeerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (bribeBeerCheckbox.Checked)
            {
                player.Beers--;
                player.Knowledge = 100;
            }
            this.Close();
        }

        private void BeersCheck()
        {
            if (player.Beers < 1)
            {
                bribeBeerCheckbox.Enabled = false;
            }
        }
    }
}
