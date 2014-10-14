using System;
using System.Windows.Forms;

namespace TeamworkTAMBA
{
    using System.Security.Cryptography.X509Certificates;

    public partial class Form1 : Form
    {
        private GameEngine game;
        public Form1()
        {
            InitializeComponent();
            game = new GameEngine(this);

            //Player player = new Player("pesho");
            //Map map = new Map();
            //GameEngine engine = new GameEngine(map, player);
            //map.Initiaize(@"C:\Users\zonta_000\Desktop\map.txt");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
