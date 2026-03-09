using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Excercise__2
{
    public class Book
    {
        public int BookID;
        public string Title;
        public string Author;

        public void BookInfo()
        {
            Console.WriteLine("Book ID :" + BookID);
            Console.WriteLine("Title :" + Title);
            Console.WriteLine("Author :" + Author);
        }
    }
}
