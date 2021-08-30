namespace BridgePattern
{
    public class Dtype : IType
    {
        public string GetInfo()
        {
            return this.GetType().Name;
        }
    }
}