using System;

namespace JobProvider
{
    internal class Job
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string Location { get; set; }
        public string JobType { get; set; }
        public string SalaryRange { get; set; }
        public Company Company { get; set; }
        public string ExperienceLevel { get; set; }

        public Job(int jobId, string jobTitle, string jobDescription, string location,
                   string jobType, string salaryRange, Company company, string experienceLevel)
        {
            if (string.IsNullOrWhiteSpace(jobTitle))
            {
                throw new InvalidInputException("Job title cannot be empty");
            }
            if (company == null)
            {
                throw new InvalidInputException("Company must be provided");
            }

            JobId = jobId;
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            Location = location;
            JobType = jobType;
            SalaryRange = salaryRange;
            Company = company;
            ExperienceLevel = experienceLevel;
        }

        public string GetDetails()
        {
            return $"Job ID: {JobId}, Title: {JobTitle}, Description: {JobDescription}, " +
                   $"Location: {Location}, Job Type: {JobType}, Salary: {SalaryRange}, " +
                   $"Company: {Company.CompanyName}, Experience: {ExperienceLevel}";
        }
    }
}