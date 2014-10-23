using TeamworkTAMBA.Forms;

namespace TeamworkTAMBA
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public class GameEngine
    {

        public readonly int LAST_VISIBLE_CELL = 560;
        public readonly int FIRST_VISIBLE_CELL = 0;

        private Player player;
        private CombatForm combatForm;
        private PickupForm pickupForm;
        private FriendForm friendForm;
        private AlexForm alexfrom;
        private WinForm winForm;
        private Form gameForm;
        private List<GameObject> enemies;
        private Dictionary<int, List<GameObject>> CharatersAndItems;
        private int currentSprite;
        private int solvedToWin = 1;

        private bool isInCombat;
        public Map map;
        private DrawEngine drawEngine;

        public GameEngine(Form form)
        {
            this.gameForm = form;
            this.map = new Map(gameForm);
            this.CharatersAndItems = map.CharatersAndItems;
            this.currentSprite = 1;

            isInCombat = false;
            this.player = new Player(SpriteType.Player, new Point(40, 40), 1);
            this.drawEngine = new DrawEngine(gameForm, this.map.MapTiles, this.CharatersAndItems[this.currentSprite], player);
            drawEngine.Draw();
        }


        public List<GameObject> Enemies
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

        public void MovementControls(KeyEventArgs e)
        {
            Point nextMove = new Point(0, 0);
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

            drawEngine.Draw();
        }

        private void DetectCollision(Point playerNextMove, Map map)
        {
            Point playerNextLocation = new Point(player.location.X + playerNextMove.X, player.Location.Y + playerNextMove.Y);

            var mapItemType = this.map.MapTiles.Find(x => x.Location == playerNextLocation);
            var charactesAndItems = this.CharatersAndItems[this.currentSprite].Find(x => x.Location == playerNextLocation);

            if (mapItemType is Wall)
            {
                player.Move(0, 0);
            }

            if (mapItemType is Floor || mapItemType is Gate)
            {
                player.Move(playerNextMove.X, playerNextMove.Y);
            }

            if (mapItemType is Floor && mapItemType.ID == 1)
            {
                player.Location = new Point(FIRST_VISIBLE_CELL, playerNextLocation.Y);
                this.map.DrawNextSprite();
                this.drawEngine.ChangeMapSprite(this.map.MapTiles);
                this.currentSprite += 1;
                this.drawEngine.ChangeCharactersAndItemsSprites(this.CharatersAndItems[this.currentSprite]);
            }

            if (mapItemType is Floor && mapItemType.ID == 2)
            {
                player.Location = new Point(LAST_VISIBLE_CELL, playerNextLocation.Y);
                this.map.DrawPreviousSprite();
                this.drawEngine.ChangeMapSprite(this.map.MapTiles);
                this.currentSprite -= 1;
                this.drawEngine.ChangeCharactersAndItemsSprites(this.CharatersAndItems[this.currentSprite]);
            }

            if (mapItemType is Floor && mapItemType.ID == 3)
            {
                player.Location = new Point(playerNextLocation.X, FIRST_VISIBLE_CELL);
                this.map.DrawLowerSprite();
                this.drawEngine.ChangeMapSprite(this.map.MapTiles);
                this.currentSprite += 3;
                this.drawEngine.ChangeCharactersAndItemsSprites(this.CharatersAndItems[this.currentSprite]);
            }

            if (mapItemType is Floor && mapItemType.ID == 4)
            {
                player.Location = new Point(playerNextLocation.X, LAST_VISIBLE_CELL);
                this.map.DrawUpperSprite();
                this.drawEngine.ChangeMapSprite(this.map.MapTiles);
                this.currentSprite -= 3;
                this.drawEngine.ChangeCharactersAndItemsSprites(this.CharatersAndItems[this.currentSprite]);
            }

            if (charactesAndItems is Enemy)
            {
                combatForm = new CombatForm(player, charactesAndItems as Enemy, drawEngine, gameForm);
                combatForm.Visible = true;
                player.Health = combatForm.GetPlayerHelth();
                RemoveObject(charactesAndItems);
            }

            if (charactesAndItems is Coffee)
            {
                pickupForm = new PickupForm(player, charactesAndItems as Coffee);
                pickupForm.Visible = true;
            }

            if (charactesAndItems is Friend)
            {
                if (charactesAndItems is Alex)
                {
                    alexfrom = new AlexForm(player, charactesAndItems as Friend);
                    alexfrom.Visible = true;
                }
                else
                {
                    friendForm = new FriendForm(player, charactesAndItems as Friend);
                    friendForm.Visible = true;
                }              
                
            }

            if (charactesAndItems is Padlock)
            {

                if (player.KillsCounter == solvedToWin)
                {
                    friendForm.Hide();
                    RemoveObject(charactesAndItems);

                }
                else
                {
                    player.Move(40, 0);
                    friendForm.Visible = false;
                    MessageBox.Show("You must solve all the 54 Homeworks, Teamworks and Exams to unlock the door!");

                }
            }
        }

        private void RemoveObject(GameObject enemy)
        {
            this.CharatersAndItems[this.currentSprite].Remove(enemy);
            this.drawEngine.Remove(enemy);
        }
    }
}
