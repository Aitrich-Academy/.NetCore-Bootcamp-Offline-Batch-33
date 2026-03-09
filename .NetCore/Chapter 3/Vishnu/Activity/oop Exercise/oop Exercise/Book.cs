using System;
using System.Collections.Generic;
using System.Text;

namespace oop_Exercise
{
    class Book
    {
        public string title;
        public string Author;

        public void DisplayBookDetails()
        {
            Console.WriteLine("Title of the book : " + title);
            Console.WriteLine("Author of the book : " + Author);
        }
    }
}
