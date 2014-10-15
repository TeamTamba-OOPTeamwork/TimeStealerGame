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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {

            }
            else if (e.KeyCode == Keys.Right)
            {

            }
            else if (e.KeyCode == Keys.Up)
            {

            }
            else if (e.KeyCode == Keys.Down)
            {
                foreach (var pictureBox in this.game.Map.Cells)
                {
                    pictureBox.Parent = null;
                }

                var moved = false;
                for (int i = 0; i < this.game.Map.Field.Count; i++)
                {
                    for (int j = 0; j < this.game.Map.Field[i].Count; j++)
                    {
                        if (this.game.Map.Field[i][j] == 'p')
                        {
                            this.game.Map.Field[i][j] = '+';
                            this.game.Map.Field[i + 1][j] = 'p';
                            moved = true;
                            
                            break;
                        }
                    }

                    if (moved)
                    {
                        this.game.Map.DrawMap(this);
                        break;
                    }
                }

            }
        }

        
    }
}
