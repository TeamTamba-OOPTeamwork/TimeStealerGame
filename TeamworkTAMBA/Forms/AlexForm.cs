using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamworkTAMBA.Forms
{
    public partial class AlexForm : Form
    {
        private Player player;
        private Friend friend;


        public AlexForm(Player player, Friend friend)
        {
            this.player = player;
            this.friend = friend;
            InitializeComponent();

            alexSpeach.Text = "Hi! My name is Alex! " +
                              "\nCongratulations! " +
                              "\nYou are a student of SoftUni now! " +
                              "\nYou voluntary gave us your FREE TIME. Now you have none. " +
                              "\nIn order to gain it back, finish all the Homeworks, Teamworks and Exams in the SoftUni!" +
                              "\nGood luck!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
