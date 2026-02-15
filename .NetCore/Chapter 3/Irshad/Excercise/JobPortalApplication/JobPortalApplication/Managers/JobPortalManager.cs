using System;
using System.Collections.Generic;
using System.Text;
using JobPortalApplication.Interfaces;
using JobPortalApplication.Models;

namespace JobPortalApplication.Managers
{
    internal class JobPortalManager : IUser, IJobProvider, IInterviewProvider
    {
        private const int MAX_USERS = 10;
        private const int MAX_JOBS = 20;
        private const int MAX_INTERVIEWS = 20;

        private User[] users = new User[MAX_USERS];
        private Job[] jobs = new Job[MAX_JOBS];
        private Interview[] interviews = new Interview[MAX_INTERVIEWS];

        private int userCount = 0;
        private int jobCount = 0;
        private int interviewCount = 0;

        private int userId = 1;
        private int jobId = 1;
        private int interviewId = 1;

        // ================= USER =================
        public void Register(User user)
        {
            if (userCount == MAX_USERS)
            {
                Console.WriteLine("User limit reached.");
                return;
            }

            user.Id = userId++;
            users[userCount++] = user;

            Console.WriteLine("User registered successfully.");
        }

        public User Login(string username, string password)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (users[i].Email == username && users[i].Password == password)
                {
                    Console.WriteLine("Login successful.");
                    return users[i];
                }
            }

            Console.WriteLine("Invalid credentials.");
            return null;
        }

        // ================= JOB =================
        public void PostJob(Job job)
        {
            if (jobCount == MAX_JOBS)
            {
                Console.WriteLine("Job limit reached.");
                return;
            }

            job.Id = jobId++;
            jobs[jobCount++] = job;

            Console.WriteLine("Job posted successfully.");
        }

        public Job[] GetJobs()
        {
            Job[] result = new Job[jobCount];
            for (int i = 0; i < jobCount; i++)
            {
                result[i] = jobs[i];
            }
            return result;
        }

        // ================= INTERVIEW =================
        public void ScheduleInterview(Interview interview)
        {
            if (interviewCount == MAX_INTERVIEWS)
            {
                Console.WriteLine("Interview limit reached.");
                return;
            }

            interview.Id = interviewId++;
            interviews[interviewCount++] = interview;

            Console.WriteLine("Interview scheduled successfully.");
        }

        public Interview[] GetInterviews()
        {
            Interview[] result = new Interview[interviewCount];
            for (int i = 0; i < interviewCount; i++)
            {
                result[i] = interviews[i];
            }
            return result;
        }
    }
}

