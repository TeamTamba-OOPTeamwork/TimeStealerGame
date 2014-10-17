namespace TeamworkTAMBA
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    // Glavnata logika
    // TO DO: mnogo metodi mnogo ne6to trqbva da se podredqt po regioni mojebi 
    // i da se optimizirat malko ?
    public class GameEngine
    {

        private Player player;
        private CombatForm combatForm;
        private Form gameForm;
        private List<Enemy> enemies;
        private PictureBox mapSprites;
        private bool isInCombat; 
        private Map map;

        public GameEngine(Form form)
        {
            gameForm = form;          
            map = new Map(gameForm);
            // TO DO: da se startira pri koliziq s enemy, a ne 
            // pri puskane na igrata
            combatForm = new CombatForm();
            combatForm.Visible = true;

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
            Graphics device;
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
        public void MovmentControls(KeyEventArgs e)
        {
            Point p = new Point(0, 0);
            // mojebi trqbva da se zade kato field v Player.cs
            // Problem!? Ako e razli4no ot razmera na 1 Tile ili "n" Tile-a ne se dviji 
            int playerSpeed = 40; 

            if (e.KeyCode == Keys.Left)
            {
                p = new Point(-playerSpeed, 0);
            }
            if (e.KeyCode == Keys.Right)
            {
                p = new Point(playerSpeed, 0);
            }
            if (e.KeyCode == Keys.Up)
            {
                p = new Point(0, -playerSpeed);
            }
            if (e.KeyCode == Keys.Down)
            {
                p = new Point(0, playerSpeed);
            }
            if (map.IsWalkable(new Point
                (p.X + player.Location.X, p.Y + player.Location.Y)))
            {
                player.Move(p.X, p.Y);
            }

            Draw();// prerisuva novata poziciq na geroq na kartata
        }
        
        // TO DO: logika za koliziq s jivotnite
        private void DetectCollision()
        {
            
        }
    }
}
