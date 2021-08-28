namespace Filter
{
    public class Item
    {
        private readonly string _barcode;
        private readonly string _city;

        public Item(string barcode, string city)
        {
            this._barcode = barcode;
            this._city = city;
        }

        public string GetBarcode()
        {
            return this._barcode;
        }

        public string GetCity()
        {
            return this._city;
        }

        public override string ToString()
        {
            return this._city + " " + this._barcode;
        }
    }
}