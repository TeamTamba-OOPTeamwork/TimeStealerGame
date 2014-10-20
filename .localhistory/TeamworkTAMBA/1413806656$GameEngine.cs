namespace TeamworkTAMBA
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Linq;
    using System.Diagnostics;

    // Glavnata logika
    // TO DO: mnogo metodi mnogo ne6to trqbva da se podredqt po regioni mojebi 
    // i da se optimizirat malko ?

    public class GameEngine
    {

        public readonly int LAST_VISIBLE_CELL = 560; // 14 * 40 for x
        public readonly int FIRST_VISIBLE_CELL = 0;

        private Player player;
        private CombatForm combatForm;
        private Form gameForm;
        private List<Enemy> enemies;
        private List<Friend> friends;
        private bool isInCombat;
        public Map map;
        private DrawEngine drawEngine;

        public GameEngine(Form form)
        {
            this.gameForm = form;
            this.map = new Map(gameForm);

            isInCombat = false;
            // Bitmap playerSpr = new Bitmap("../../Graphics/Player.png");
            this.player = new Player(SpriteType.Player, new Point(0, 0), 1);



            // TO DO: da se iznese v metod i da se mahnat izmislenite kordinati
            // za da se polu4at to4ni kordinati trqbva da sa kratni na goleminata na 1 Tile(40 v momenta)
            // Bitmap monsterSpr = new Bitmap("../../Graphics/monster.jpg");
            enemies = new List<Enemy>(){
                new Enemy(SpriteType.Enemy, new Point(240, 280), 0),
                new Enemy(SpriteType.Enemy, new Point(80, 80), 0)
            };

            var listOfObjects = new List<GameObject>();
            listOfObjects.AddRange(map.MapTiles);
            listOfObjects.AddRange(enemies);
            listOfObjects.Add(player);
            this.drawEngine = new DrawEngine(gameForm, listOfObjects);
            drawEngine.Draw();

            // Draw();
        }
        public List<Friend> Friends
        {
            get
            {
                return this.friends;
            }

            set
            {
                this.friends = value;
            }
        }

        public List<Enemy> Enemies
        {
            get
            {
                return this.enemies;
            }

            set
            {
                this.enemies = value;
            }
        }

        public Player Player
        {
            get
            {
                return this.player;
            }

            set
            {
                this.player = value;
            }
        }


        // risuva/prerisuva vsi4ko na formata
        //private void Draw()
        //{

        //    Image img = new Bitmap(gameForm.Width, gameForm.Height); //o4ertava ramkata na PictureBox-a
        //    device = Graphics.FromImage(img);

        //    // kolkoto po nadolu se risuva obekt tolkova po-napred sedi vav formata
        //    map.DrawMap(device);

        //    // risuva celiq list sas jivotni posle 6te se pravi koliziq 
        //    // sas sa6tiqt list

        //    foreach (Enemy en in enemies)
        //    {
        //        en.Draw(device);
        //    }

        //    player.Draw(device);
        //    mapSprites.Image = img; // slaga vsi4ki spritove v pictureboxa
        //}

        // sybira skorossta na igra4a sas sega6nite mu kordinata i polu4ava novite
        // vrazva se sas Form1.cs za da se dviji po neq
        public void MovementControls(KeyEventArgs e)
        {
            Point nextMove = new Point(0, 0);
            // mojebi trqbva da se zade kato field v Player.cs
            // Problem!? Ako e razli4no ot razmera na 1 Tile ili "n" Tile-a ne se dviji 
            int playerSpeed = 40;

            if (e.KeyCode == Keys.Left)
            {
                nextMove = new Point(-playerSpeed, 0);
            }
            if (e.KeyCode == Keys.Right)
            {
                nextMove = new Point(playerSpeed, 0);
            }
            if (e.KeyCode == Keys.Up)
            {
                nextMove = new Point(0, -playerSpeed);
            }
            if (e.KeyCode == Keys.Down)
            {
                nextMove = new Point(0, playerSpeed);
            }

            // drawEngine.RemoveObject(player);

            DetectCollision(nextMove, map);

            //drawEngine.AddObject(player);
            drawEngine.Draw();
        }

        // TO DO: logika za koliziq s jivotnite
        private void DetectCollision(Point playerNextMove, Map map)
        {
            Point playerNextLocation = new Point(player.location.X + playerNextMove.X, player.Location.Y + playerNextMove.Y);

            var mapItemType = map.MapTiles.Find(x => x.Location == playerNextLocation);
            var enemy = enemies.Find(x => x.Location == playerNextLocation);

            if (mapItemType is Wall)
            {
                player.Move(0, 0);
            }

            if (mapItemType is Floor)
            {
                player.Move(playerNextMove.X, playerNextMove.Y);
            }

            if (mapItemType is Floor && mapItemType.ID == 2)
            {
                player.Location = new Point(FIRST_VISIBLE_CELL, playerNextLocation.Y);
                map.DrawNextSprite();
            }

            if (mapItemType is Floor && mapItemType.ID == 1)
            {
                player.Location = new Point(LAST_VISIBLE_CELL, playerNextLocation.Y);
                map.DrawPreviousSprite();

            }

            //to do: same thing for friends
            if (enemy is Enemy)
            {
                combatForm = new CombatForm(player, enemy);
                combatForm.Visible = true;
                player.Health = combatForm.GetPlayerHelth();
                RemoveObject(enemy);
            }
        }

        private void RemoveObject(Enemy enemy)
        {
            this.enemies.Remove(enemy);
            this.drawEngine.Remove(enemy);
        }
    }
}
