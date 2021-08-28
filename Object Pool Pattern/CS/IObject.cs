namespace ObjectPool
{
    public class IObject
    {
        private readonly int _code;
        private string _data;

        public IObject(int code, string data)
        {
            this._code = code;
            this._data = data;
        }

        public IObject SetData(string data)
        {
            this._data = data;
            return this;
        }

        public int GetCode()
        {
            return this._code;
        }

        public override string ToString()
        {
            return this._code + "::" + this._data;
        }
    }
}