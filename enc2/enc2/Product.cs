using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enc2
{
    internal class Product
    {
        private double _price;
        private double _count;
        public int No;
        public string Name;



        public Product(double price, double count, string name, int no)
        {
            _price = price;
            _count = count;
            Name = name;
            No = no;
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public double Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }
    }
}
