using System;
using System.Collections.Generic;

namespace JobProvider
{
    internal class Operations
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();
        private HashSet<string> companies = new HashSet<string>();
        private List<Job> jobs = new List<Job>();
        private Dictionary<string, List<Job>> appliedJobs = new Dictionary<string, List<Job>>();
        private Dictionary<string, List<Job>> savedJobs = new Dictionary<string, List<Job>>();

        public void RegisterUser(User user)
        {
            if (users.ContainsKey(user.Email))
            {
                throw new DuplicateUserException("User already exists with this email.");
            }
            users[user.Email] = user;
        }

        public User LoginUser(string email, string password)
        {
            if (!users.ContainsKey(email))
            {
                throw new InvalidCredentialsException("User not found.");
            }

            User user = users[email];
            if (!user.Authenticate(password))
            {
                throw new InvalidCredentialsException("Invalid password.");
            }

            return user;
        }

        public void PostJob(Job job)
        {
            jobs.Add(job);
            companies.Add(job.Company.CompanyName);
        }

        public List<Job> ListJobs()
        {
            return jobs;
        }

        public void ApplyJob(string userEmail, int jobId)
        {
            Job job = jobs.Find(j => j.JobId == jobId);
            if (job == null)
            {
                throw new JobNotFoundException("Job not found.");
            }

            if (!appliedJobs.ContainsKey(userEmail))
            {
                appliedJobs[userEmail] = new List<Job>();
            }
            appliedJobs[userEmail].Add(job);
        }

        public void SaveJob(string userEmail, int jobId)
        {
            Job job = jobs.Find(j => j.JobId == jobId);
            if (job == null)
            {
                throw new JobNotFoundException("Job not found.");
            }

            if (!savedJobs.ContainsKey(userEmail))
            {
                savedJobs[userEmail] = new List<Job>();
            }
            savedJobs[userEmail].Add(job);
        }

        public List<Job> ShowAppliedJobs(string userEmail)
        {
            if (appliedJobs.ContainsKey(userEmail))
            {
                return appliedJobs[userEmail];
            }
            else
            {
                return new List<Job>();
            }
        }

        public List<Job> ShowSavedJobs(string userEmail)
        {
            if (savedJobs.ContainsKey(userEmail))
            {
                return savedJobs[userEmail];
            }
            else
            {
                return new List<Job>();
            }
        }

        public List<string> ListCompanies()
        {
            return new List<string>(companies);
        }
    }
}