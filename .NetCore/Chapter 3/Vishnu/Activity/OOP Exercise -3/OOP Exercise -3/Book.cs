using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercise__3
{
    class Book : Ibooks

    {
        public string Title;
        private double Price;
        public Book(string t, double p)
        { 
            Title = t; Price = p; 
        }
        public void BookDetails()
        {
            Console.WriteLine("Book Tile : " + Title);
            Console.WriteLine("Book's Price : " + Price);
        }
    }
}
