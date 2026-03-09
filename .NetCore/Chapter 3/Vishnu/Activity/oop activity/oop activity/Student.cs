using System;
using System.Collections.Generic;
using System.Text;

namespace oop_activity
{
    class Student : Person
    {
        private int marks;
        public void SetMarks (int m)
        {
            if (m >= 0 && m <= 100)
                marks = m;
            else
                Console.WriteLine("Invalid marks");
        }

        public int GetMarks()
        {
            return marks;
        }

        public void ShowRole()
        {
            Console.WriteLine("Role : Student");
        }

        public string CalculateGrade()
        {
            if (marks >= 75)
                return "A";
            else if(marks >= 50)
                return "B";
            else
                return "C";
        }
            
    }
}
