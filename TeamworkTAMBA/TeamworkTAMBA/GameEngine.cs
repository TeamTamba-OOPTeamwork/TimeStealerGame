namespace TeamworkTAMBA
{
    using System.Drawing;
    using System.Windows.Forms;

    public class GameEngine
    {

        private Player player;

        private Form gameForm;

        private Graphics GFX;

        public GameEngine(Form form)
        {
            gameForm = form;
            gameForm.Width = 420; //Map.mapRowSize * Map.mapCellSize;
            gameForm.Height = 430; //Map.mapColSize * Map.mapCellSize;

            this.Map = new Map(@"C:\Users\zonta_000\Desktop\map.txt");
            this.Map.DrawMap(gameForm);
        }

        public Player Player { get; set; }
        public Map Map { get; set; }
    }
}
