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
    public partial class StoryForm : Form
    {
        private MainMenuForm main;
        private string str;
        private int time = 0;

        public StoryForm(MainMenuForm mainForm)
        {
            InitializeComponent();
            this.main = mainForm;

            this.str = @"Lorem Ipsum is simply dummy text of the printing and
 typesetting industry. 
Lorem Ipsum has been the industry's standard dummy
 text ever since the 1500s,
 when an unknown printer took a galley of type and 
scrambled it to make a type
 specimen book. It has survived not only five centuries,
 but also the leap into electronic
 typesetting, remaining essentially unchanged. 
It was popularised in the 1960s
 with the release of Letraset sheets containing 
Lorem Ipsum passages, and more 
recently with desktop publishing software like 
Aldus PageMaker including versions 
of Lorem Ipsum.";
        }

        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.main.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.time < this.str.Length)
            {
                this.label1.Text += this.str[this.time];
                this.time++;
            }
            else
            {
                this.timer1.Stop();
            }

        }

        private void AboutForm_Click(object sender, EventArgs e)
        {
            if (this.timer1.Interval - 33 > 0)
            {
                this.timer1.Interval -= 33;
            }
        }
    }
}
