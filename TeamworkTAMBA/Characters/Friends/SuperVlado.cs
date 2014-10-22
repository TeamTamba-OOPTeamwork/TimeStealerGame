
namespace TeamworkTAMBA
{
    using System.Drawing;

    using TeamworkTAMBA.Interfaces;

    public class SuperVlado : Friend, IPederasable
    {
        public SuperVlado(SpriteType spriteType,Point location,int id) :
            base(spriteType, location, id)
        {
            
        }

        public void Suck()
        {
            throw new System.NotImplementedException();
        }

        public void fuck()
        {
            throw new System.NotImplementedException();
        }
    }
}
