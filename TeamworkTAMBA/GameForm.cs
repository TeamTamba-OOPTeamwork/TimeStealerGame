using System;
using System.Windows.Forms;

namespace TeamworkTAMBA
{
    using System.Drawing;

    public partial class GameForm : Form
    {
        private GameEngine game;

        public GameForm()
        {
            InitializeComponent();
            this.game = new GameEngine(this);
        }

        //connects the form Key Listner with the player movment contoller
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            game.MovementControls(e);
        }        
    }
}
