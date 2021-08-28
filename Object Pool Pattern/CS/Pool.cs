using System.Collections.Generic;

namespace ObjectPool
{
    public sealed class Pool
    {
        private Dictionary<int, IObject> _objects;

        public Pool(int number = 5)
        {
            _objects = new Dictionary<int, IObject>(number);

            for (var i = 0; i < number; i++)
            {
                var id = GetHashCode();
                _objects.Add(id, new IObject(id, null));
            }
        }

        public IObject CheckIn(string data)
        {
            foreach (var key in this._objects.Keys)
            {
                var temp = this._objects[key].SetData(data);
                this._objects.Remove(key);
                return temp;
            }

            return null;
        }

        public IObject CheckOut(IObject obj)
        {
            this._objects.Add(obj.GetCode(), obj);
            return null;
        }
    }
}