namespace BridgePattern
{
    public class Ctype : IType
    {
        public string GetInfo()
        {
            return this.GetType().Name;
        }
    }
}