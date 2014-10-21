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
        private const string Homework = "../../Graphics/homework.png";
        private const string Exam = "../../Graphics/exam.jpg";
        private const string Teamwork = "../../Graphics/teamwork.jpg";
        private const string Didko = "../../Graphics/dido.jpg";
        private const string Nakov = "../../Graphics/player.png"; //TO DO: have to be change
        private const string Nasko = "../../Graphics/nasko.jpg";
        private const string SuperVlado = "../../Graphics/superVlado.jpg";
        private const string Tedi = "../../Graphics/tedi.jpg";
        private const string Vlado = "../../Graphics/vlado.png";
        private const string Wall = "../../Graphics/wall.jpg";
        private const string Coffee = "../../Graphics/coffee.png";
        private const string Floor = "../../Graphics/floor.jpg";
        private const string Desk = "../../Graphics/desk.png";
        private const string Air = "../../Graphics/air.png";


        Image playerSpr, enemySpr, homeworkSpr, examSpr, teamworkSpr, didkoSpr, nakovSpr, naskoSpr, superVladoSpr, tediSpr,
        vladoSpr, wallSpr, coffeeSpr, floorSpr, deskSpr, airSpr;


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

        public void DrawObject(GameObject gameObj)
        {
            if (gameObj.SpiteType != SpriteType.None)
            {
                device.DrawImage(GetImage(gameObj), gameObj.Location);
            }
        }

        public void ChangeMapSprite(List<GameObject> list)
        {
            this.backgroundItems = list;
        }

        public void ChangeCharactersAndItemsSprites(List<GameObject> list)
        {
            this.charactersAndItems = list;
        }

        public Image GetImage(GameObject gameObj)
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
                case SpriteType.Teamwork: image = this.teamworkSpr;
                    break;
                case SpriteType.Didko: image = this.didkoSpr;
                    break;
                case SpriteType.Nakov: image = this.nakovSpr;
                    break;
                case SpriteType.Nasko: image = this.naskoSpr;
                    break;
                case SpriteType.SuperVlado: image = this.superVladoSpr;
                    break;
                case SpriteType.Tedi: image = this.tediSpr;
                    break;
                case SpriteType.Vlado: image = this.vladoSpr;
                    break;
                case SpriteType.Wall: image = this.wallSpr;
                    break;
                case SpriteType.Coffee: image = this.coffeeSpr;
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
            this.homeworkSpr = Image.FromFile(Homework);
            this.examSpr = Image.FromFile(Exam);
            this.teamworkSpr = Image.FromFile(Teamwork);
            this.didkoSpr = Image.FromFile(Didko);
            this.nakovSpr = Image.FromFile(Nakov);
            this.naskoSpr = Image.FromFile(Nasko);
            this.superVladoSpr = Image.FromFile(SuperVlado);
            this.tediSpr = Image.FromFile(Tedi);
            this.vladoSpr = Image.FromFile(Vlado);
            this.wallSpr = Image.FromFile(Wall);
            this.coffeeSpr = Image.FromFile(Coffee);
            this.floorSpr = Image.FromFile(Floor);
            this.deskSpr = Image.FromFile(Desk);
            this.airSpr = Image.FromFile(Air);
        }
    }
}
