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
        private const string Player = "../../Graphics/player.png";
        private const string Enemy = "../../Graphics/monster.jpg";
        private const string Homework = null;
        private const string Exam = null;
        private const string Teamwork = null;
        private const string Didko = null;
        private const string Nakov = null;
        private const string Nasko = null;
        private const string SuperVlado = null;
        private const string Tedi = null;
        private const string Vlado = null;
        private const string Wall = "../../Graphics/wall.jpg";
        private const string Drink = null;
        private const string Food = null;
        private const string Money = null;
        private const string Floor = "../../Graphics/floor.jpg";
        private const string Desk = "../../Graphics/desk.png";
        private const string Air = "../../Graphics/air.png";


        Image playerSpr, enemySpr, homeworkSpr, examSpr, teamworkSpr, didkoSpr, nakovSpr, naskoSpr, superVladoSpr, tediSpr,
        vladoSpr, wallSpr, drinkSpr, foodSpr, moneySpr, floorSpr, deskSpr, airSpr;


        private Graphics device;
        private PictureBox mapSprites;
        private Form form;
        private Image img;

        private IList<GameObject> backgroundItems = new List<GameObject>();

        private IList<GameObject> charactersAndItems = new List<GameObject>();

        private Player player;

        public DrawEngine(Form form, List<GameObject> backgroundItems, List<GameObject> charactersAndItems, Player player)
        {
            this.form = form;
            this.backgroundItems = backgroundItems;
            this.charactersAndItems = charactersAndItems;
            this.player = player;

            this.mapSprites = new PictureBox();
            mapSprites.Width = form.Width;
            mapSprites.Height = form.Height;
            mapSprites.BackColor = Color.Transparent;
            mapSprites.Parent = form;
            this.LoadResources();
        }

        // risuva/prerisuva vsi4ko na formata
        public void Draw()
        {
            img = new Bitmap(this.form.Width, this.form.Height); //o4ertava ramkata na PictureBox-a
            device = Graphics.FromImage(img);

            foreach (var item in this.backgroundItems)
            {
                this.DrawObject(item);
            }

            foreach (var item in this.charactersAndItems)
            {
                this.DrawObject(item);
            }

            this.DrawObject(player);

            mapSprites.Image = img;
        }

        public void Remove(GameObject gameobj)
        {
            this.charactersAndItems.Remove(gameobj);
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
                case SpriteType.Player: image = this.playerSpr;
                    break;
                case SpriteType.Enemy: image = this.enemySpr;
                    break;
                case SpriteType.Homework: image = this.homeworkSpr;
                    break;
                case SpriteType.Exam: image = this.examSpr;
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
                case SpriteType.Wall: image = this.wallSpr;
                    break;
                case SpriteType.Drink:
                    break;
                case SpriteType.Food:
                    break;
                case SpriteType.Money:
                    break;
                case SpriteType.Floor: image = this.floorSpr;
                    break;
                case SpriteType.Desk: image = this.deskSpr;
                    break;
                case SpriteType.Air: image = this.airSpr;
                    break;
                default:
                    break;
            }

            return image;
        }

        public void LoadResources()
        {
            this.playerSpr = Image.FromFile(Player);
            this.enemySpr = Image.FromFile(Enemy);
            this.homeworkSpr = null;
            this.examSpr = null;
            this.teamworkSpr = null;
            this.didkoSpr = null;
            this.nakovSpr = null;
            this.naskoSpr = null;
            this.superVladoSpr = null;
            this.tediSpr = null;
            this.vladoSpr = null;
            this.wallSpr = Image.FromFile(Wall);
            this.drinkSpr = null;
            this.foodSpr = null;
            this.moneySpr = null;
            this.floorSpr = Image.FromFile(Floor);
            this.deskSpr = Image.FromFile(Desk);
            this.airSpr = Image.FromFile(Air);
        }
    }
}
