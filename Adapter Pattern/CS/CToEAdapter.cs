namespace AdapterPattern
{
    public class CToEAdapter : TypeC
    {
        private TypeE _typeE;

        public CToEAdapter(string id) : base(id)
        {
            this._typeE = new TypeE(id);
        }
        
        public override bool ToggleTarget()
        {
            return false;
        }
    }
}