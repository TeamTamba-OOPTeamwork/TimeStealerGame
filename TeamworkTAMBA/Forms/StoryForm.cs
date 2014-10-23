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

            this.str = @"You are taking a stroll in Software University, after you have passed the entry 
C# exam, daydream of how awesome it would be to become a software engineer, 
when you suddenly realize that your Private Life is missing!
“Where is it!?!” – You shout!
You start looking all over for it and ask everyone if they have seen it, 
but no one have. The hope inside you that you will find it starts to 
slip away, when suddenly a voice from behind calls you. You turn around 
and see a girl standing behind the lobby desk and waving at you.
You approach her and she says:
“Hi there, I am Alex.
Congratulations! You are now a student of Software University! 
You “voluntary” gave us your Private Life and now you have none. In order
to gain it back, you must finish all the Homeworks, Teamworks and Exams 
in the Software University. Have a nice day!”
(Alex smiles and gets back to doing her stuff.)
After two minutes of staring at the wall and making sense of what she 
just said, you realize that you are on a never-ending quest of 
Saving Private Life!
";
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
