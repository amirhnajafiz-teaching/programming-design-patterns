namespace AdapterPattern
{
    public class TypeC
    {
        private bool _switchKeyMain;
        private bool _switchKeyTarget;
        private readonly string _onPlugId;

        public TypeC(string onPlugId)
        {
            this._onPlugId = onPlugId;
        }

        public bool ToggleMain()
        {
            this._switchKeyMain = !this._switchKeyMain;
            return this._switchKeyMain;
        }

        public virtual bool ToggleTarget()
        {
            this._switchKeyTarget = !this._switchKeyTarget;
            return this._switchKeyTarget;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this._onPlugId;
        }
    }
}