namespace Builder
{
    public class IObject
    {
        private int _code;
        private string _meta;
        private string _id;
        private bool _nullAble;

        public IObject()
        {
            // Empty Construct
        }

        public IObject SetCode(int code)
        {
            this._code = code;
            return this;
        }

        public IObject SetMeta(string meta)
        {
            this._meta = meta;
            return this;
        }

        public IObject SetId(string id)
        {
            this._id = id;
            return this;
        }

        public IObject SetNullAble(bool nullAble)
        {
            this._nullAble = nullAble;
            return this;
        }
    }
}