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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form game = new GameForm();
            game.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void storyBtn_Click(object sender, EventArgs e)
        {
            Form about = new StoryForm(this);
            about.Show();
            this.Hide();
        }

        private void hotToPlayBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How to play the game? You need to solve all the Homeworks, " +
                            "Teamworks and Exams in order to get to your free time. " +
                            "Before you do that the door to your Private Life is gonna be locked." +
                            " You can solve the Homeworks, Teamworks and Exams by using coding skills. " +
                            "You start by coding on C#. When you solve certain amount of homeworks, " +
                            "you can go to your Mentors – the SoftUni team, and they will give you new knowledge. " +
                            "During the entire game you have own time – it ticks out. In order to reload it you can buy coffee," +
                            " cola etc from the café and earn time. From the café you can buy beer as well. With beer you can bribe" +
                            " your mentors to get knowledge sooner.Enjoy you quest for Saving your Private Life!");
        }
    }
}
