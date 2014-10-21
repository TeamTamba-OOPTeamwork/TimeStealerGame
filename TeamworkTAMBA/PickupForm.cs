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
    public partial class PickupForm : Form
    {
        private Coffee coffee;
        private Player player;
        public PickupForm(Player player, Coffee coffee)
        {
            InitializeComponent();

            this.player = player;
            this.coffee = coffee;

            player.Health = 100;
            //theTextBox.Text = "You have drinked a Coffee! \nNow you are refreshed and ready for more Homeworks!";
            takeNotofication.Text = "You have drinked a Coffee! \nNow you are refreshed and ready for more Homeworks!";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
