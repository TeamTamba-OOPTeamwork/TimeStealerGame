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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            game.MovementControls(e);
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }        
    }
}
