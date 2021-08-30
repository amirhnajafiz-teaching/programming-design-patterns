namespace BridgePattern
{
    public class Bmodel : Model
    {
        public Bmodel(IType type)
        {
            this.Type = type;
        }
        
        public override string ClassInfo()
        {
            return "B model of type " + this.Type.GetInfo();
        }
    }
}