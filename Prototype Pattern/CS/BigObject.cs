using System;

namespace Prototype
{
    public class BigObject
    {
        private readonly int _code;
        private string _data;

        public BigObject(int code, string data)
        {
            this._code = code;
            this._data = data;
        }

        public BigObject ResetWith(string data)
        {
            this._data = data;
            return this;
        }

        public override string ToString()
        {
            return this._code + " " + this._data;
        }

        public BigObject Copy()
        {
            return (BigObject)this.MemberwiseClone();
        }
    }
}