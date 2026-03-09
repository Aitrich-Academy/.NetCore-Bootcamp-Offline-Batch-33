using System;
using System.Collections.Generic;
using System.Text;

namespace oop_Exercise
{
    class IssuedBook : Book
    {
        public int IssueDate;

        public void IssueDateDetail()
        {
            Console.WriteLine("Issue Date : " + IssueDate);
        }
         
    }
}
