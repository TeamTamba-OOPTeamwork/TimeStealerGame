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
        private bool isAlive = true;

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

        }

        public void StartCombat(Player player, Enemy enemy)
        {
            isInCombat = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Combat().ToString());

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isAlive)
            {
                MessageBox.Show(Combat().ToString());
            }
            else
            {
                MessageBox.Show("The homework is dead!");
            }
        }

        private double Combat()
        {
            Refresh();
            Application.DoEvents();
            double newEnemyHealth = enemy.Health -= player.AttackPower;

            if (enemy.Health < 1)
            {
                isAlive = false;
            }
            return newEnemyHealth;
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
            Refresh();
            Application.DoEvents();
            progressBar2.Value = enemy.Health;
        }
    }
}
