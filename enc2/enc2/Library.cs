using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enc2
{
    internal class Library
    {
        public Book[] Books = new Book[] { };

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }
        public void GetFilteredBooks(string genre)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                // basa dusmedim
            }
        }


        public void GetFilteredBooks(int minPrice, int maxPrice)
        {
            // basa dusmedim
        }
        public void ShowAllBooks()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Console.WriteLine($"Name: {Books[i].Name}, Price: {Books[i].Price} ,Count:{Books[i].Count},Genre:{Books[i].Genre} No:{Books[i].No}");
            }
        }

    }
}
