using System;
using System.Collections.Generic;
using System.Text;

namespace oop_activity
{
     class Person
    {
        public string name;
        public int age;

        public void ShowBasicInfo()
        {
            Console.WriteLine("Name :" +  name);
            Console.WriteLine("Age :" + age);
        }
    }
}
