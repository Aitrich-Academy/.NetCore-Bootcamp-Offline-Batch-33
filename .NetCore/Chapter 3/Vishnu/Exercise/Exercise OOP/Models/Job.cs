using Exercise_OOP.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_OOP.Models
{
    internal class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ExperienceLevels experience  { get; set; }

        public string Company { get; set; }
        public string Location { get; set; }
        public string SalaryRange { get; set; }
        public string JobType { get; set; }

        public Job (int id, string title, ExperienceLevels experience, string company, string location, string salaryRange, string jobType)
        {
            this.Id = id;
            this.Title = title;
            this.experience = experience;
            this.Company = company;
            this.Location = location;
            this.SalaryRange = salaryRange;
            this.JobType = jobType;
        }

        public void PrintJob() 
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Company: {Company}");
            Console.WriteLine($"Location: {Location}");
            Console.WriteLine($"Experience: {experience}");
            Console.WriteLine($"Salary: {SalaryRange}");
            Console.WriteLine($"Type: {JobType}");
            Console.WriteLine("----------------------------");
        }
    }

}
