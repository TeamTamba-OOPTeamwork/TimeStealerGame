using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamworkTAMBA
{
    using TeamworkTAMBA.Enums;

    public partial class CombatForm : Form
    {
        private Enemy enemy;
        private Player player;
        private bool isEnemyAlive = true;
        private bool isPlayerAlive = true;
        private int knowlageUsage = 0;
        private DrawEngine drowEngine;
        private DeadForm deadForm;


        public CombatForm(Player player, Enemy enemy, DrawEngine drowEngine)
        {
            InitializeComponent();
            this.enemy = enemy;
            this.enemy.AttackPower = 5;
            this.player = player;
            this.player.AttackPower = 10;
            this.drowEngine = drowEngine;
            this.pictureBox2.Image = drowEngine.GetImage(enemy as GameObject);

            //This removex the "x" button to avoid close the battle. It is in comment to easy the tests
            //this.ControlBox = false;

            enemyHealthProgressBar.Maximum = 100;
            playerHealthProgressBar.Maximum = 100;
            playerHealthProgressBar.Value = player.Health;
            playerKnowledgeProgressbar.Value = player.Knowledge;

            labelPlayersTime.Text = "Time: " + player.Health;
            labelPlayerDmg.Text = "Damage: " + "1-" + player.AttackPower;
            labelPlayerKnowlage.Text = "Knowledge: " + player.Knowledge;
            labelEnemyHealth.Text = "Strength: " + enemy.Health;
            labelEnemyDmg.Text = "Damage: " + "1-" + enemy.AttackPower;

            playerMoneyLabel.Text = "Money: " + player.Money;
            killsLabel.Text = "Solved: " + player.KillsCounter;

            //Disables the weapon checkboxes if still not taken from the teacher
            foreach (var weapon in this.player.Weapons)
            {
                if (weapon.Power == 0)
                {
                    switch (weapon.WeaponType)
                    {
                        case WeaponTypes.Java:
                            javaCheckBox.Enabled = false;
                            break;
                        case WeaponTypes.HTML:
                            htmlCheckBox.Enabled = false;
                            break;
                        case WeaponTypes.CSS:
                            cssCheckBox.Enabled = false;
                            break;
                        case WeaponTypes.JavaScript:
                            javascriptCheckBox.Enabled = false;
                            break;
                        case WeaponTypes.PHP:
                            phpCheckBox.Enabled = false;
                            break;
                    }
                }
            }
        }

        //The weapones check boxes
        private void CSharpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CSharpCheckBox.Checked)
            {
            }
            else
            {
                playerTextBox.Text = "You can not solve the Homeworks without programming skills! Learn some! Go and find a teacher!";
                CSharpCheckBox.Checked = true;
            }
        }

        private void javaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (javaCheckBox.Checked)
            {
                player.AttackPower += 10;
                knowlageUsage += 10;
                labelPlayerDmg.Text = "Part solved for: " + "1-" + player.AttackPower;
            }
            else
            {
                player.AttackPower -= 10;
                knowlageUsage -= 10;
                labelPlayerDmg.Text = "Part solved for: " + "1-" + player.AttackPower;
            }
        }

        private void htmlCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (htmlCheckBox.Checked)
            {
                player.AttackPower += 10;
                knowlageUsage += 1;
                labelPlayerDmg.Text = "Part solved for: " + "1-" + player.AttackPower;
            }
            else
            {
                player.AttackPower -= 10;
                knowlageUsage -= 1;
                labelPlayerDmg.Text = "Part solved for: " + "1-" + player.AttackPower;
            }
        }

        private void cssCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cssCheckBox.Checked)
            {
                player.AttackPower += 10;
                knowlageUsage += 1;
                labelPlayerDmg.Text = "Part solved for: " + "1-" + player.AttackPower;
            }
            else
            {
                player.AttackPower -= 10;
                knowlageUsage -= 1;
                labelPlayerDmg.Text = "Part solved for: " + "1-" + player.AttackPower;
            }
        }

        private void javascriptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (javascriptCheckBox.Checked)
            {
                player.AttackPower += 10;
                knowlageUsage += 1;
                labelPlayerDmg.Text = "Part solved for: " + "1-" + player.AttackPower;
            }
            else
            {
                player.AttackPower -= 10;
                knowlageUsage -= 1;
                labelPlayerDmg.Text = "Part solved for: " + "1-" + player.AttackPower;
            }
        }

        private void phpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (phpCheckBox.Checked)
            {
                player.AttackPower += 10;
                knowlageUsage += 1;
                labelPlayerDmg.Text = "Part solved for: " + "1-" + player.AttackPower;
            }
            else
            {
                player.AttackPower -= 10;
                knowlageUsage -= 1;
                labelPlayerDmg.Text = "Part solved for: " + "1-" + player.AttackPower;
            }
        }

        private void checkAllBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAllBox.Checked)
            {
                if (javaCheckBox.Enabled)
                {
                    javaCheckBox.Checked = true;
                }
                if (htmlCheckBox.Enabled)
                {
                    htmlCheckBox.Checked = true;
                }
                if (cssCheckBox.Enabled)
                {
                    cssCheckBox.Checked = true;
                }
                if (javascriptCheckBox.Enabled)
                {
                    javascriptCheckBox.Checked = true;
                }
                if (phpCheckBox.Enabled)
                {
                    phpCheckBox.Checked = true;
                }

                labelPlayerDmg.Text = "Part solved for: " + "1-" + player.AttackPower;
            }
            else
            {
                javaCheckBox.Checked = false;
                htmlCheckBox.Checked = false;
                cssCheckBox.Checked = false;
                javascriptCheckBox.Checked = false;
                phpCheckBox.Checked = false;
                labelPlayerDmg.Text = "Part solved for: " + "1-" + player.AttackPower;
            }
        }

        //The text box. This is useless
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //The "Do it button"
        private void buttonDoIt_Click(object sender, EventArgs e)
        {
            if (isPlayerAlive && isEnemyAlive)
            {
                if (knowlageUsage > player.Knowledge)
                {
                    playerTextBox.Text = "You don't have enough knowledge!";
                    checkAllBox.Checked = false;
                    javaCheckBox.Checked = false;
                    htmlCheckBox.Checked = false;
                    cssCheckBox.Checked = false;
                    javascriptCheckBox.Checked = false;
                    phpCheckBox.Checked = false;

                    javaCheckBox.Enabled = false;
                    htmlCheckBox.Enabled = false;
                    cssCheckBox.Enabled = false;
                    javascriptCheckBox.Enabled = false;
                    phpCheckBox.Enabled = false;
                }
                else
                {
                    Combat();
                    labelPlayersTime.Text = "Time: " + player.Health;
                    labelEnemyHealth.Text = "Strength: " + enemy.Health;
                    labelPlayerKnowlage.Text = "Knowledge: " + player.Knowledge;
                }
            }

        }

        private void Combat()
        {
            player.Knowledge -= knowlageUsage;
            playerKnowledgeProgressbar.Value = player.Knowledge;
            int playerRandomDamage = RandomDamageGenerator(player.AttackPower);
            int newEnemyHealth = enemy.Health -= playerRandomDamage;
            int enemyRandomDamage = RandomDamageGenerator(enemy.AttackPower);
            int newPlayerHealth = player.Health -= enemyRandomDamage;

            if (player.Knowledge < 1)
            {
                player.Knowledge = 0;
                playerKnowledgeProgressbar.Value = playerKnowledgeProgressbar.Minimum;

                javaCheckBox.Checked = false;
                htmlCheckBox.Checked = false;
                cssCheckBox.Checked = false;
                javascriptCheckBox.Checked = false;
                phpCheckBox.Checked = false;

                javaCheckBox.Enabled = false;
                htmlCheckBox.Enabled = false;
                cssCheckBox.Enabled = false;
                javascriptCheckBox.Enabled = false;
                phpCheckBox.Enabled = false;
            }

            if (enemy.Health > 0)
            {
                enemyHealthProgressBar.Value = newEnemyHealth;
                playerTextBox.Text = "You have solved a part of the Homework for " + playerRandomDamage + "\nThe Homework now has " + enemy.Health + " strength.";
            }
            else
            {
                enemyHealthProgressBar.Value = enemyHealthProgressBar.Minimum;
                isEnemyAlive = false;
                playerTextBox.Text = "You have solved a part of the Homework for " + playerRandomDamage + "\nThe Homework is solved!";
                player.Health = newPlayerHealth;
                player.KillsCounter++;
                killsLabel.Text = "Solved: " + player.KillsCounter;
                player.Money += 10;
                playerMoneyLabel.Text = "Money: " + player.Money;

                exit.Visible = true;
            }

            if (player.Health > 0)
            {
                playerHealthProgressBar.Value = newPlayerHealth;
                EnemyTextBox.Text = "But that took you some time - exactly : " + enemyRandomDamage +
                    "\nYou have now " + player.Health + " time left.";
            }
            else
            {
                playerHealthProgressBar.Value = playerHealthProgressBar.Minimum;
                isPlayerAlive = false;
                EnemyTextBox.Text = "The Homework took from you " + enemyRandomDamage +
                                    "\nThe Homework took all your health and you are DONE... You suck!!! You are no good for a developer!";
                exit.Visible = true;
            }
        }

        private int RandomDamageGenerator(int damage)
        {
            Random randomDanage = new Random();
            int currentDamage = randomDanage.Next(1, damage);

            return currentDamage;
        }

        public int GetPlayerHelth()
        {
            return this.player.Health;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            die();
            this.Close();
        }

        private void die()
        {
            if (!isPlayerAlive)
            {
                deadForm = new DeadForm();
                deadForm.Visible = Enabled;
            }
        }
    }
}
