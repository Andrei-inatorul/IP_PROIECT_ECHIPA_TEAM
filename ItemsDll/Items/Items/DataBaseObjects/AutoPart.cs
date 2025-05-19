namespace Items.DataBaseObjects
{
    public class AutoPart
    {
        private int _id;
        private string _name;
        private string _brand;
        private double _price;
        private int _stock;

        public AutoPart(int id, string name, string brand, double price, int stock)
        {
            _id = id;
            _name = name;
            _brand = brand;
            _price = price;
            _stock = stock;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Brand { get { return _brand; } set { _brand = value; } }
        public double Price { get { return _price; } set { _price = value; } }
        public int Stock { get { return _stock; } set { _stock = value; } }

        public string ToString()
        {
            return _id + " " + _name + " " + _brand + " " + _price + " " + _stock;
        }
    }
}