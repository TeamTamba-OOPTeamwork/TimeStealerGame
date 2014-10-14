using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkTAMBA
{
    public class GameEngine
    {
        private Map map;

        private Player player;

        private Form1 gameForm;

        public GameEngine(Form1 form)
        {
            gameForm = form;
            gameForm.Width = Map.mapRowSize * Map.mapCellSize;
            gameForm.Height = Map.mapColSize * Map.mapCellSize;

            map = new Map(form);
        }

        public Player Player { get; set; }
        public Map Map { get; set; }
    }
}
