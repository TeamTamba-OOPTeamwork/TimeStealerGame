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
        private bool isInCombat;
        private bool isEnemyAlive = true;
        private bool isPlayerAlive = true;
        private int knowlageUsage = 0;
        private bool isWeaponAllowed = true;

        // TO DO: da se inicializirat igra4a i gadinata v constructora
        // Da se vikne StartCombat
        // Da se napravi logika za bitka
        // Da se naredqt buttoni i poleta prez Disgna na Formata
        // Da se sloji text box i da se varje s butonite

        public CombatForm(Player player, Enemy enemy)
        {
            InitializeComponent();
            this.enemy = enemy;
            this.enemy.AttackPower = 5;
            this.player = player;
            this.player.AttackPower = 10;
            

            progressBar2.Maximum = 100;
            progressBar1.Maximum = 100;
            progressBar1.Value = player.Health;
            playerKnowledgeProgressbar.Value = player.Knowledge;

            //this.ControlBox = false;
           
            labelPlayersHealth.Text = "Health: " + player.Health;
            labelPlayerDmg.Text = "Damage: " + "1-" + player.AttackPower;
            labelEnemyHealth.Text = "Health: " + enemy.Health;
            labelEnemyDmg.Text = "Damage: " + "1-" + enemy.AttackPower;
            playerKnowlageLabel.Text = "Knowlage: " + player.Knowledge;

            foreach (var weapon in this.player.Weapons)
            {
                if (weapon.Power == 0)
                { 
                    switch (weapon.WeaponType)
                    {
                        case WeaponTypes.Java:
                            checkBox2.Enabled = false;
                            isWeaponAllowed = false;
                            break;
                        case WeaponTypes.HTML:
                            checkBox3.Enabled = false;
                            isWeaponAllowed = false;
                            break;
                        case WeaponTypes.CSS:
                            checkBox4.Enabled = false;
                            isWeaponAllowed = false;
                            break;
                        case WeaponTypes.JavaScript:
                            checkBox5.Enabled = false;
                            isWeaponAllowed = false;
                            break;
                        case WeaponTypes.PHP:
                            checkBox6.Enabled = false;
                            isWeaponAllowed = false;
                            break;
                    }
                }
            }
        }

        //The weapones check boxes
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
            }
            else
            {
                richTextBox1.Text = "You can not fight the Homeworks without programing skills!";
                checkBox1.Checked = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                player.AttackPower += 10;
                knowlageUsage += 10;
                labelPlayerDmg.Text = "Damage: " + "1-" + player.AttackPower;
            }
            else
            {
                player.AttackPower -= 10;
                knowlageUsage -= 10;
                labelPlayerDmg.Text = "Damage: " + "1-" + player.AttackPower;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked)
            {
                player.AttackPower += 10;
                knowlageUsage += 1;
                labelPlayerDmg.Text = "Damage: " + "1-" + player.AttackPower;
            }
            else
            {
                player.AttackPower -= 10;
                knowlageUsage -= 1;
                labelPlayerDmg.Text = "Damage: " + "1-" + player.AttackPower;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                player.AttackPower += 10;
                knowlageUsage += 1;
                labelPlayerDmg.Text = "Damage: " + "1-" + player.AttackPower;
            }
            else
            {
                player.AttackPower -= 10;
                knowlageUsage -= 1;
                labelPlayerDmg.Text = "Damage: " + "1-" + player.AttackPower;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                player.AttackPower += 10;
                knowlageUsage += 1;
                labelPlayerDmg.Text = "Damage: " + "1-" + player.AttackPower;
            }
            else
            {
                player.AttackPower -= 10;
                knowlageUsage -= 1;
                labelPlayerDmg.Text = "Damage: " + "1-" + player.AttackPower;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                player.AttackPower += 10;
                knowlageUsage += 1;
                labelPlayerDmg.Text = "Damage: " + "1-" + player.AttackPower;
            }
            else
            {
                player.AttackPower -= 10;
                knowlageUsage -= 1;
                labelPlayerDmg.Text = "Damage: " + "1-" + player.AttackPower;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                if (isWeaponAllowed)
                {
                    checkBox2.Checked = true;
                }
                if (isWeaponAllowed)
                {
                    checkBox3.Checked = true;
                }
                if (isWeaponAllowed)
                {
                    checkBox4.Checked = true;
                }
                if (isWeaponAllowed)
                {
                    checkBox5.Checked = true;
                }
                if (isWeaponAllowed)
                {
                    checkBox6.Checked = true;
                }
                
                labelPlayerDmg.Text = "Damage: " + "1-" + player.AttackPower;
            }
            else
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                labelPlayerDmg.Text = "Damage: " + "1-" + player.AttackPower;
            }
        }

        //The text box
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //The "Do it button"
        private void button1_Click(object sender, EventArgs e)
        {
            if (isPlayerAlive && isEnemyAlive)
            {
                Combat();
                labelPlayersHealth.Text = "Health: " + player.Health;
                labelEnemyHealth.Text = "Health: " + enemy.Health;
                playerKnowlageLabel.Text = "Knowlage: " + player.Knowledge;
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
                
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;

                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
            }

            if (enemy.Health > 0)
            {
                progressBar2.Value = newEnemyHealth;
                richTextBox1.Text = "You have hit the Homework for " + playerRandomDamage + "\nThe Homework now have " + enemy.Health + " health.";
            }
            else
            {
                progressBar2.Value = progressBar2.Minimum;
                isEnemyAlive = false;
                richTextBox1.Text = "You have hit the Homework for " + playerRandomDamage + "\nThe Homework is dead!";
                player.Health = newPlayerHealth;
                
                exit.Visible = true;
            }

            if (player.Health > 0)
            {
                progressBar1.Value = newPlayerHealth;
                richTextBox2.Text = "But the Homework hit you back for " + enemyRandomDamage +
                    "\nYou have now " + player.Health + " health";
            }
            else
            {
                progressBar1.Value = progressBar1.Minimum;
                isPlayerAlive = false;
                richTextBox2.Text = "The Homework hit you back for " + enemyRandomDamage +
                                    "\nYou were killed form a Homework.. You sux!";
            }

            //return newEnemyHealth;
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
            this.Close();
        }
    }
}
