using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop3.Models
{
    public class Job
    {
       
        private int id;
        private string title;
        private string salary;
        private string location;
        private string description;
        string requiredskills;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Requiredskills
        {
            get { return requiredskills; }
            set { requiredskills = value; }
        }
        public bool IsAvailable { get; set; }


    }
}
