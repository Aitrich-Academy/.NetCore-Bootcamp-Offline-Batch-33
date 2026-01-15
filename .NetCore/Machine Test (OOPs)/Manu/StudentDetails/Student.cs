using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDetails
{
    internal class Student
    {
        public string Name { get; set; }

        private int age;
        public int Age
        { 
            get { return age; }
            set 
            {
                if(value >= 18 && value <= 25)
                    age = value;

                else
                {
                    throw new Exception("Age must be between 18 and 25");
                }                  
            }
        }

        public List<int> Marks { get; set; }
        public Student(string name, int age, List<int> marks)
        {
            Name = name;
            Age = age;
            Marks = marks;
        }

        public double CalcCgpa()
        {
            double totalMark = 0;
            foreach (int n in Marks)
            {
                totalMark += n;
            }
            double average = (totalMark / Marks.Count) / 10;
            return average;
        }

        public string Getgrade()
        {
            double cgpa = CalcCgpa();
            if (cgpa >= 9)
            {
                return "A";
            }
            else if (cgpa >= 8)
            {
                return "B";
            }
            else if (cgpa >= 7)
            {
                return "C";
            }
            else if (cgpa >= 6)
            {
                return "D";
            }
            else if (cgpa >= 5)
            {
                return "E";
            }
            else
            {
                return "Fail";
            }
        }
    }
}
