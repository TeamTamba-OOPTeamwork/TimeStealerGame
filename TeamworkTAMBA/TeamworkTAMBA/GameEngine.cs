namespace TeamworkTAMBA
{
    using System.Drawing;
    using System.Windows.Forms;

    public class GameEngine
    {
        private Map map;

        private Player player;

        private Form gameForm;

        private Graphics GFX;

        public GameEngine(Form form)
        {
            gameForm = form;
            gameForm.Width = 420; //Map.mapRowSize * Map.mapCellSize;
            gameForm.Height = 430; //Map.mapColSize * Map.mapCellSize;
            
            map = new Map(gameForm);
            

        }

        public Player Player { get; set; }
        public Map Map { get; set; }

        //void Draw()
        //{
        //    Graphics device;
        //    Image img = new Bitmap(gameForm.Width,gameForm.Height);
        //    device = Graphics.FromImage(img);
        //}
    }
}
