namespace TeamworkTAMBA
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class DrawEngine
    {
        private Graphics device;
        private GameEngine gameEngine;
        private PictureBox mapSprites;
        private Form form;
        private Image img;

        public DrawEngine(GameEngine gameEngine, Form form)
        {
            this.gameEngine = gameEngine;
            this.form = form;

            this.mapSprites = new PictureBox();
            mapSprites.Width = form.Width;
            mapSprites.Height = form.Height;
            mapSprites.BackColor = Color.Transparent;
            mapSprites.Parent = form;
        }

        // risuva/prerisuva vsi4ko na formata
        public void Draw()
        {
            img = new Bitmap(this.form.Width, this.form.Height); //o4ertava ramkata na PictureBox-a
            device = Graphics.FromImage(img);

            this.gameEngine.map.DrawMap(device);

            foreach (var e in this.gameEngine.Enemies)
            {
                this.AddObject(e);
            }

            //foreach (var fr in this.gameEngine.Friends)
            //{
            //     this.AddObject(fr);
            //}

            this.AddObject(this.gameEngine.Player);


            mapSprites.Image = img;
        }

        public void AddObject(GameObject gameObject)
        {
            device.DrawImage(gameObject.Image, gameObject.Location);

        }

        public void RemoveObject(GameObject gameObject)
        {
            gameObject.Image = new Bitmap("../../Graphics/FloorTile.jpg");
        }
    }
}
