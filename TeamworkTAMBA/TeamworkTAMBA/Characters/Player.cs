namespace TeamworkTAMBA
{
    using System.Drawing;

    public class Player : Characters
    {
        enum Position
        {
            Left, Right, Up, Down
        }
        public Player() :
            base(new Bitmap("index.jpg"),new Point(0,0), 'p')
        {
        }

        //public void Move(int x, int y)
        //{
        //    location.X += x * Map.mapCellSize;
        //    location.Y += x * Map.mapCellSize;
        //}
    }
}
