using System;

namespace JobProvider
{
    internal class Company
    {
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }

        public Company(string companyName, string description, string location)
        {
            if (string.IsNullOrWhiteSpace(companyName))
            {
                throw new InvalidInputException("Company name cannot be empty");
            }

            CompanyName = companyName;
            Description = description;
            Location = location;
        }

        public string GetDetails()
        {
            return $"Company: {CompanyName}, Location: {Location}, Description: {Description}";
        }
    }
}