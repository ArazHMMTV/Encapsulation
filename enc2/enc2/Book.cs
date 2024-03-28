using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace enc2
{
    internal class Book:Product
    {
        public string Genre;

        public Book(double price, double count, string name, int no, string genre) : base(price, count, name, no)
        {
            Genre = genre;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Name:{Genre}");
            Console.WriteLine($"Name:{No}");
            Console.WriteLine($"Name:{Count}");
            Console.WriteLine($"Name:{Price}");
        }
    }
}
