using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Workshop_1.Model
{
    internal class Job
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string salary { get; set; }
        public string location { get; set; }

        public Job(int id,string title,string description,string salary,string location) 
        {
            this.id = id;
            this.title = title;     
            this.description = description; 
            this.salary = salary;   
            this.location = location;   

        }
    }
}
