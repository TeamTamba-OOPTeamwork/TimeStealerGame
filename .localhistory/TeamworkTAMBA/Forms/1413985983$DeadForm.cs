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
    public partial class DeadForm : Form
    {
        private StoryForm storyForm;
        private MainMenuForm mineForm;
        public DeadForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            mineForm = new MainMenuForm();
            mineForm.Visible = Enabled;
            this.Close();
        }
    }
}
