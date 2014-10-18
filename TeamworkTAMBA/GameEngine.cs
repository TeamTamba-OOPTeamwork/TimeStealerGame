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
        private PictureBox mapSprites;
        private bool isInCombat;
        private Map map;
        private Graphics device;

        public GameEngine(Form form)
        {
            gameForm = form;
            map = new Map(gameForm);
            // TO DO: da se startira pri koliziq s enemy, a ne 
            // pri puskane na igrata


            isInCombat = false;
            Bitmap playerSpr = new Bitmap("../../Graphics/Player.png");
            player = new Player(playerSpr, new Point(0, 0), 1);

            mapSprites = new PictureBox();

            mapSprites.Width = gameForm.Width;
            mapSprites.Height = gameForm.Height;
            mapSprites.BackColor = Color.Transparent;
            mapSprites.Parent = gameForm;

            // TO DO: da se iznese v metod i da se mahnat izmislenite kordinati
            // za da se polu4at to4ni kordinati trqbva da sa kratni na goleminata na 1 Tile(40 v momenta)
            Bitmap monsterSpr = new Bitmap("../../Graphics/monster.jpg");
            enemies = new List<Enemy>(){
                new Enemy(monsterSpr, new Point(240, 280), 0),
                new Enemy(monsterSpr, new Point(80, 80), 0)
            };

            Draw();
        }

        // risuva/prerisuva vsi4ko na formata
        private void Draw()
        {

            Image img = new Bitmap(gameForm.Width, gameForm.Height); //o4ertava ramkata na PictureBox-a
            device = Graphics.FromImage(img);

            // kolkoto po nadolu se risuva obekt tolkova po-napred sedi vav formata
            map.DrawMap(device);

            // risuva celiq list sas jivotni posle 6te se pravi koliziq 
            // sas sa6tiqt list

            foreach (Enemy en in enemies)
            {
                en.Draw(device);
            }

            player.Draw(device);
            mapSprites.Image = img; // slaga vsi4ki spritove v pictureboxa
        }

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

            DetectCollision(nextMove, map);

            Draw();// prerisuva novata poziciq na geroq na kartata
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
                map.DrawNextLevel();

            }
            if (mapItemType is Floor && mapItemType.ID == 1)
            {
                player.Location = new Point(LAST_VISIBLE_CELL, playerNextLocation.Y);
                map.DrowPreviusNextLevel();

            }

            //to do same think for friends
            if (enemy is Enemy)
            {
                combatForm = new CombatForm();
                combatForm.Visible = true;
                enemy.Image = new Bitmap("../../Graphics/FloorTile.jpg");
            }
        }
    }
}
