namespace BridgePattern
{
    public class Amodel : Model
    {
        public Amodel(IType type)
        {
            this.Type = type;
        }
        
        public override string ClassInfo()
        {
            return "A model of type " + this.Type.GetInfo();
        }
    }
}