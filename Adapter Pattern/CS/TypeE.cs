namespace AdapterPattern
{
    public class TypeE
    {
        private bool _switchKeyMain;
        private readonly string _onPlugId;

        public TypeE(string onPlugId)
        {
            this._onPlugId = onPlugId;
        }

        public bool ToggleMain()
        {
            this._switchKeyMain = !this._switchKeyMain;
            return this._switchKeyMain;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this._onPlugId;
        }
    }
}