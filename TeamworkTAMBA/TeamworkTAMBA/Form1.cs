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

        public GameEngine Game
        {
            get
            {
                return this.game;
            }
            set
            {
                this.game = value;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("index.jpg"), 430, 430, 40, 40);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
