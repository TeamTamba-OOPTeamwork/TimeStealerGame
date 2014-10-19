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
        private const string Player = "../../Graphics/Player.png";
        private const string Enemy = "../../Graphics/monster.jpg";
        private const string Homework = null;
        private const string Lecture = null;
        private const string Teamwork = null;
        private const string Didko = null;
        private const string Nakov = null;
        private const string Nasko = null;
        private const string SuperVlado = null;
        private const string Tedi = null;
        private const string Vlado = null;
        private const string Wall = "../../Graphics/WallTile.jpg";
        private const string Drink = null;
        private const string Food = null;
        private const string Money = null;
        private const string Floor = "../../Graphics/FloorTile.jpg";
        private const string Furniture = null;
        private const string Column = null;




        private Graphics device;
        private PictureBox mapSprites;
        private Form form;
        private Image img;

        private IList<GameObject> drawableList = new List<GameObject>();

        public DrawEngine(Form form, IList<GameObject> drawableList)
        {

            this.form = form;
            this.drawableList = drawableList;

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

            foreach (var item in drawableList)
            {
                DrawObject(item);
            }


            mapSprites.Image = img;
        }

        public void Add(GameObject gameobj)
        {
            this.drawableList.Add(gameobj);
        }

        public void Remove(GameObject gameobj)
        {
            this.drawableList.Remove(gameobj);
        }


        private void DrawObject(GameObject gameObj)
        {
            device.DrawImage(GetImage(gameObj), gameObj.Location);

        }

        

        private Image GetImage(GameObject gameObj)
        {
            Image image = null;
            switch (gameObj.SpiteType)
            {
                case SpriteType.Player: image = Image.FromFile(Player);
                    break;
                case SpriteType.Enemy: image = Image.FromFile(Enemy);
                    break;
                case SpriteType.Homework:
                    break;
                case SpriteType.Lecture:
                    break;
                case SpriteType.Teamwork:
                    break;
                case SpriteType.Didko:
                    break;
                case SpriteType.Nakov:
                    break;
                case SpriteType.Nasko:
                    break;
                case SpriteType.SuperVlado:
                    break;
                case SpriteType.Tedi:
                    break;
                case SpriteType.Vlado:
                    break;
                case SpriteType.Wall: image = Image.FromFile(Wall);
                    break;
                case SpriteType.Drink:
                    break;
                case SpriteType.Food:
                    break;
                case SpriteType.Money:
                    break;
                case SpriteType.Floor: image = Image.FromFile(Floor);
                    break;
                case SpriteType.Furniture:
                    break;
                case SpriteType.Column:
                    break;
                default:
                    break;
            }

            return image;
        }
    }
}
