namespace TeamworkTAMBA
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Security.Cryptography.X509Certificates;
    using System.Windows.Forms;

    public class Map
    {
        public const int mapTileSize = 40;    

        // malko se povtarq koda s Gameobject mojebi moje da se prigodi napravo
        // toi da se polzva bez structora
        private struct Tile
        {
            public Image img;
            public Point loc;
            public bool walkable;
        }

        private List<Tile> mapTiles;

        public Map(Form form)
        {
            mapTiles = new List<Tile>();
            Initiaize("Level1.txt");
        }

        public void DrawMap(Graphics device)
        {
            foreach (Tile t in mapTiles)
            {
                device.DrawImage(t.img, t.loc);
            }
        }

        // ednovremmeno 4ete ot file red po red i preobrazuva char-ovete v Tile (40X40) ot kartata
        // TO DO: da se slojat razmera na bloka koito 6te se polzva v igrata
        // da se narisuva nivoto realno kak 6te izglejda
        // da se slojat kartinkite i drugite nedvijimi predmeti koito 6te se polzvat
        private void Initiaize(string mapName)
        {
            try
            {
                using (StreamReader sr = new StreamReader(mapName))
                {
                    int col = 0;
                   
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        for (int row = 0; row < line.Length; row++)
                        {
                            Tile t = new Tile();
                            t.loc = new Point(row * mapTileSize, col * mapTileSize);
                            switch (line[row].ToString())
                            {
                                case "+": 
                                    t.img = new Bitmap("../../Graphics/FloorTile.jpg");
                                    t.walkable = true; 
                                    break;
                                case "-":
                                    t.img = new Bitmap("../../Graphics/WallTile.jpg");
                                    t.walkable = false;
                                    break;
                                default:
                                    break;
                            }
                            mapTiles.Add(t);
                        }
                        col++;
                    }                   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }         
        }
        // proverqva kade ima ne6ta prez koito ne se minava
        // vklu4itelno i ramkite na Formata
        public bool IsWalkable(Point loc)
        {
            foreach (Tile t in mapTiles)
            {
                if (t.loc == loc)
                {
                    if (t.walkable)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
