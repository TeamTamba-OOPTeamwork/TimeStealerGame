namespace TeamworkTAMBA
{
    using System.Drawing;

    using TeamworkTAMBA.Interfaces;

    public class Nakov : Friend, ISingable
    {
        public Nakov(SpriteType spriteType,Point location,int id) :
            base(spriteType, location, id)
        {
            
        }

        public void SingPederasi_Pederasi()
        {
            throw new System.NotImplementedException();
        }
    }
}
