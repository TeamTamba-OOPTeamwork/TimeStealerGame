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
        public int mapRowSize, mapColSize;
        public const int mapCellSize = 40;

        private List<PictureBox> cells; 
        public List<List<char>> Field { get; set; }
        
        public Map(Form1 form)
        {
            this.Field = new List<List<char>>();
            cells = new List<PictureBox>();

            for (int row = 0; row < mapRowSize; row++)
            {
                for (int col = 0; col < mapColSize; col++)
                {
                    PictureBox pb = new PictureBox();
                    switch (this.Field[row][col])
                    {
                        case '+': 
                            break;
                        case '1':
                            pb.BackColor = Color.Gray;
                            break;
                        case '2':
                            pb.BackColor = Color.White;
                            break;
                        case '@':
                            pb.BackColor = Color.Red;
                            break;
                        case '#':
                            pb.BackColor = Color.Green;
                            break;
                        case 'p':
                            pb.BackColor = Color.Yellow;
                            break;
                        case '!':
                            pb.BackColor = Color.Blue;
                            break;
                        default: break;
                    }
                    pb.Width = mapCellSize;
                    pb.Height = mapCellSize;
                    pb.Location = new Point(row * mapCellSize, col * mapCellSize);
                    pb.Parent = form;
                    this.cells.Add(pb);
                }
            }
        }
        public void Initiaize(string file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    int countRow = 0;
                    String line = sr.ReadToEnd();
                    var array  = line.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    mapRowSize = array.Length;
                    mapColSize = array[0].Length;
                    foreach (var singleLine in array)
                    {
                        List<char> currentRowList = new List<char>();
                        for (int i = 0; i < singleLine.Length; i++)
                        {
                            currentRowList.Add(singleLine[i]);
                        }
                        this.Field.Add(currentRowList);
                        countRow++;
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
