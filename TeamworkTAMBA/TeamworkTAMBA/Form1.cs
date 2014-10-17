using System;
using System.Windows.Forms;

namespace TeamworkTAMBA
{
    using System.Drawing;

    public partial class Form1 : Form
    {
        private GameEngine game;

        public Form1()
        {
            InitializeComponent();
            this.game = new GameEngine(this);
        }

        //connects the form Key Listner with the player movment contoller
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            game.MovmentControls(e);
        }        
    }
}
