using OOP_Workshop_1.Interface;
using OOP_Workshop_1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Net.WebRequestMethods;

namespace OOP_Workshop_1.Manager
{
    public class JobManager : IJob
    {
        private Job[] jobs = new Job[100];

        private int job_numbs = 0;

        public void addjob()
        {
            if (job_numbs == jobs.Length)
            {
                Console.WriteLine("maximum number of job been added. Please try again");
                return;
            }

            Console.WriteLine("Enter Job Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Job Title : ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter Job Description");
            string description = Console.ReadLine();

            Console.WriteLine("Enter Job Salary : ");
            string salary = Console.ReadLine();

            Console.WriteLine("Enter Job Location");
            string location = Console.ReadLine();

            Job newjob = new Job(id, title, description, salary, location);

            jobs[job_numbs] = newjob;

            job_numbs++;
        }

        public void listjob()
        {
            Console.WriteLine("Jobs : ");

            for (int i = 0; i < job_numbs; i++)
            {
                Console.WriteLine($"Title : {jobs[i].title}");
                Console.WriteLine($"Description : {jobs[i].description}");
                Console.WriteLine($"Salary : {jobs[i].salary}");
                Console.WriteLine($"Location : {jobs[i].location}");
            }
        }
    }
}







