namespace TeamworkTAMBA
{
    using System.Drawing;

    using TeamworkTAMBA.Interfaces;

    public class Alex : Friend, IDanceable
    {
        public Alex(SpriteType spriteType,Point location,int id) :
            base(spriteType, location, id)
        {
            
        }

        public void Chaka_RakaDance()
        {
            throw new System.NotImplementedException();
        }
    }
}
