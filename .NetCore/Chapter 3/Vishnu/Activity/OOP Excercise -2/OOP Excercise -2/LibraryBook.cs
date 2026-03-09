using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Excercise__2
{
    internal class LibraryBook : Book
    {
        public bool AvailabilityStatus;

        public void Availability()
        {
            if (AvailabilityStatus == true)
                Console.WriteLine("The book is available");

            else
                Console.WriteLine("The book is Issued");
        }

    }
}
