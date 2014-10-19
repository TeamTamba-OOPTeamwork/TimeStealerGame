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
    public partial class CombatForm : Form
    {
        Enemy enemy;
        Player player;
        bool isInCombat;
        private bool isEnemyAlive = true;
        bool isPlayerAlive = true;

        // TO DO: da se inicializirat igra4a i gadinata v constructora
        // Da se vikne StartCombat
        // Da se napravi logika za bitka
        // Da se naredqt buttoni i poleta prez Disgna na Formata
        // Da se sloji text box i da se varje s butonite

        public CombatForm()
        {
            InitializeComponent();
            var pic = "";
            Bitmap playerSpr = new Bitmap("../../Graphics/Player.png");
            this.player = new Player(playerSpr, 100, 10);
            Bitmap monsterSpr = new Bitmap("../../Graphics/monster.jpg");
            this.enemy = new Enemy(monsterSpr, 50, 5);

            progressBar2.Maximum = enemy.Health;
            progressBar1.Maximum = player.Health;


        }

        public void StartCombat(Player player, Enemy enemy)
        {
            isInCombat = true;

        }
        
        //The picture boxes
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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
            }
            else
            {
                player.AttackPower -= 10;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked)
            {
                player.AttackPower += 10;
            }
            else
            {
                player.AttackPower -= 10;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                player.AttackPower += 10;
            }
            else
            {
                player.AttackPower -= 10;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                player.AttackPower += 10;
            }
            else
            {
                player.AttackPower -= 10;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                player.AttackPower += 10;
            }
            else
            {
                player.AttackPower -= 10;
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
            }
            
        }

        private void Combat()
        {
            int playerRandomDamage = RandomDamageGenerator(player.AttackPower);
            int newEnemyHealth = enemy.Health -= playerRandomDamage;
            int enemyRandomDamage = RandomDamageGenerator(enemy.AttackPower);
            int newPlayerHealth = player.Health -= enemyRandomDamage;

            if (enemy.Health > 0)
            {
                progressBar2.Value = newEnemyHealth;
                richTextBox1.Text = "You have hit the homework for " + playerRandomDamage + "\nThe home work now have " + enemy.Health + " health.";
            }
            else
            {
                progressBar2.Value = progressBar2.Minimum;
                isEnemyAlive = false;
                richTextBox1.Text = "You have hit the homework for " + playerRandomDamage + "\nThe homework is dead!";
                player.Health = newPlayerHealth;
            }

            if (player.Health > 0)
            {
                progressBar1.Value = newPlayerHealth;
                richTextBox2.Text = "But the Home Work hit you back for " + enemyRandomDamage + 
                    "\nYou have now " + player.Health + " health";
            }
            else
            {
                progressBar1.Value = progressBar1.Minimum;
                isPlayerAlive = false;
                richTextBox2.Text = "The Homework hit you back for " + enemyRandomDamage +
                                    "\nYou were killed form a Home work.. You sux!";
            }
            
            //return newEnemyHealth;
        }

        private int RandomDamageGenerator(int damage)
        {
            Random randomDanage = new Random();
            int currentDamage = randomDanage.Next(1, damage);

            return currentDamage;
        }
    }
}
