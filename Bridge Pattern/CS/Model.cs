namespace BridgePattern
{
    public abstract class Model
    {
        protected IType Type;

        public abstract string ClassInfo();
    }
}