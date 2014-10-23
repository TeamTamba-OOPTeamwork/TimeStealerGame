namespace TeamworkTAMBA
{
    using System.Drawing;

    public abstract class MapItems : GameObject
    {
        protected MapItems(SpriteType sriteType, Point location, int id) :
            base(sriteType, location, id)
        {

        }

        protected MapItems()
        {
        }
    }
}
