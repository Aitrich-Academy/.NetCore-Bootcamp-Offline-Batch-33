using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDetails
{
    internal class Department : Student
    {
        public string DepName { get; set; }
        public Department(string name, int age, List<int> marks, string depName) : base (name, age, marks)
        {
            DepName = depName;
        }

        public static Student FindTopper(List<Student> students)
        {
            Student topper = null;
            double highestCgpa = 0;

            foreach (var s in students)
            {
                double cgpa = s.CalcCgpa();
                if (cgpa > highestCgpa)
                {
                    highestCgpa = cgpa;
                    topper = s;
                }
            }
            return topper;
        }
    }
}
