using System;

namespace SalesItem
{
    public class SalesItem
    {
        private string _name;
        private double _price;

        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (value == null) throw new ArgumentNullException();
                if (value.Length < 2) throw new ArgumentException();
                _name = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value < 0.0) throw new ArgumentOutOfRangeException();
                _price = value;
            }
        }

        public override string ToString()
        {
            return Id + " " + Name + " " + Price;
        }
    }
}
