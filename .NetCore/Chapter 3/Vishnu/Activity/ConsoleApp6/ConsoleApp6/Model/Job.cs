using System;
using System.Collections.Generic;
using System.Text;

namespace ADMIN_JOB.Model
{
    internal class Job
    {
        public int Id {  get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string salary { get; set; }

        public string location { get; set; }

        public Job(int id, string name, string description, string salary, string location)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.salary = salary;
            this.location = location;
        }
    }
}
