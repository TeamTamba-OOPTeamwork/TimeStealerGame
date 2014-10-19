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
        private int currentLevel;

        // malko se povtarq koda s Gameobject mojebi moje da se prigodi napravo
        // toi da se polzva bez structora
        private GameObject mapItem;


        private List<GameObject> mapTiles;

        public List<GameObject> MapTiles
        {
            get
            {
                return this.mapTiles;
            }

            set
            {
                this.mapTiles = value;
            }
        }

        public Map(Form form)
        {
            DrawNextLevel();
        }

        public void DrawNextLevel()
        {
            currentLevel++;
            this.MapTiles = new List<GameObject>();
            Initiaize("../../Levels/Level" + currentLevel.ToString("0#") + ".txt");
        }

        public void DrawPreviusNextLevel()
        {
            currentLevel--;
            this.MapTiles = new List<GameObject>();
            Initiaize("../../Levels/Level" + currentLevel.ToString("0#") + ".txt");
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
                            GameObject item = new GameObject();
                            //-40 so we can hide first tile from screen
                            var itemlocation = new Point(row * mapTileSize - 40, col * mapTileSize);

                            switch (line[row].ToString())
                            {
                                case "+":
                                    item = new Floor(SpriteType.Floor, itemlocation, 0);
                                    break;
                                case "-":
                                    item = new Wall(SpriteType.Wall, itemlocation, 0);
                                    break;
                                case "n":
                                    item = new Floor(SpriteType.Floor, itemlocation, 2); //next level
                                    break;
                                case "l":
                                    item = new Floor(SpriteType.Floor, itemlocation, 1); //previus level
                                    break;
                                default:
                                    break;
                            }
                            this.MapTiles.Add(item);
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
    }
}
