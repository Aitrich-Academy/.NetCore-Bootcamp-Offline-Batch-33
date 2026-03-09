using Exercise_OOP.Enums;
using Exercise_OOP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_OOP.Managers
{
    internal class JobManager
    {
        public Job[] jobs = new Job[10];

        public JobManager()
        {
            jobs[0] = new Job(1, "Software Developer", ExperienceLevels.Fresher, "TCS", "Delhi", "3-5 LPA", "Full-Time");
            jobs[1] = new Job(2, "Backend Developer", ExperienceLevels.MidLevel, "Infosys", "Bangalore", "6-10 LPA", "Full-Time");
            jobs[2] = new Job(3, "Frontend Developer", ExperienceLevels.Fresher, "Wipro", "Noida", "4-6 LPA", "Full-Time");
            jobs[3] = new Job(4, "DevOps Engineer", ExperienceLevels.Senior, "Amazon", "Hyderabad", "15-25 LPA", "Full-Time");
            jobs[4] = new Job(5, "QA Engineer", ExperienceLevels.MidLevel, "Capgemini", "Pune", "6-8 LPA", "Full-Time");
        }

        public void ListJobs()
        {
            PrintJobs(jobs);
        }

        public void PrintJobs(Job[] jobs)
        {
            foreach (var job in jobs)
            {
                if (job != null)
                    job.PrintJob();
            }
        }

        public Job GetJobById(int jobId)
        {
            foreach (var job in jobs)
            {
                if (job != null && job.Id == jobId)
                    return job;
            }
            return null;
        }
    }


}

