using System;
using System.Collections.Generic;

namespace JobProvider
{
    internal class Program
    {
        static Operations portal = new Operations();
        static User currentUser = null;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. List Companies");
                Console.WriteLine("3. User Menu");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                if (choice == "1") RegisterFlow();
                else if (choice == "2") ListCompanies();
                else if (choice == "3") UserMenu();
                else if (choice == "4") break;
                else Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        static void RegisterFlow()
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Please enter your email address: ");
            string email = Console.ReadLine();
            Console.Write("Please enter your phone number: ");
            string phone = Console.ReadLine();
            Console.Write("Please enter a password: ");
            string password = Console.ReadLine();

            Console.WriteLine("Choose role: 1. JobSeeker  2. JobProvider");
            string roleChoice = Console.ReadLine();
            UserRole role = roleChoice == "2" ? UserRole.JobProvider : UserRole.JobSeeker;

            try
            {
                User user = new User(firstName, lastName, email, phone, password, role);
                portal.RegisterUser(user);
                Console.WriteLine("Registration successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ListCompanies()
        {
            var companies = portal.ListCompanies();
            Console.WriteLine("Companies:");
            foreach (var company in companies)
            {
                Console.WriteLine($"- {company}");
            }
        }

        static void UserMenu()
        {
            while (true)
            {
                Console.WriteLine("\nEnter User Menu");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                if (choice == "1") RegisterFlow();
                else if (choice == "2")
                {
                    Console.Write("Please enter your email address: ");
                    string email = Console.ReadLine();
                    Console.Write("Please enter your password: ");
                    string password = Console.ReadLine();

                    try
                    {
                        currentUser = portal.LoginUser(email.ToLower(), password);
                        Console.WriteLine($"Login successful!\nWelcome {currentUser.FirstName}");
                        if (currentUser.Role == UserRole.JobProvider) ProviderMenu();
                        else SeekerMenu();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Login failed. " + ex.Message);
                    }
                }
                else if (choice == "3") break;
                else Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        static void ProviderMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Post a job");
                Console.WriteLine("2. List all Jobs");
                Console.WriteLine("3. Logout");

                string choice = Console.ReadLine();

                if (choice == "1") PostJob();
                else if (choice == "2") ListJobs();
                else if (choice == "3")
                {
                    Console.WriteLine("Logged out successfully!");
                    currentUser = null;
                    break;
                }
                else Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        static void SeekerMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. List all jobs");
                Console.WriteLine("2. Saved Jobs");
                Console.WriteLine("3. Applied Jobs");
                Console.WriteLine("4. My profile");
                Console.WriteLine("5. Logout");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    ListJobs();
                    Console.WriteLine("1. Apply a job\n2. Save a Job\n3. Back");
                    string subChoice = Console.ReadLine();

                    if (subChoice == "1") ApplyJob();
                    else if (subChoice == "2") SaveJob();
                }
                else if (choice == "2") ShowSavedJobs();
                else if (choice == "3") ShowAppliedJobs();
                else if (choice == "4") Console.WriteLine(currentUser.GetProfile());
                else if (choice == "5")
                {
                    Console.WriteLine("Logged out successfully!");
                    currentUser = null;
                    break;
                }
                else Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        static void PostJob()
        {
            Console.Write("Enter Job title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Job description: ");
            string desc = Console.ReadLine();
            Console.Write("Enter Job location: ");
            string location = Console.ReadLine();
            Console.Write("Enter Job Type: ");
            string type = Console.ReadLine();
            Console.Write("Enter Job salary range: ");
            string salary = Console.ReadLine();
            Console.Write("Enter Job company: ");
            string companyName = Console.ReadLine();

            Company company = new Company(companyName, "N/A", location);
            Job job = new Job(portal.ListJobs().Count, title, desc, location, type, salary, company, "Fresher");

            portal.PostJob(job);
            Console.WriteLine("Job posted successfully.");
        }

        static void ListJobs()
        {
            var jobs = portal.ListJobs();
            Console.WriteLine("\nJobs available:\n");
            Console.WriteLine("JobId | Title | ExperienceLevel | Company | Location | SalaryRange");
            Console.WriteLine("       | JobType");
            Console.WriteLine("---------------------------------------------------------------");

            foreach (var job in jobs)
            {
                Console.WriteLine($"{job.JobId} | {job.JobTitle} | {job.ExperienceLevel} | {job.Company.CompanyName} | {job.Location} | {job.SalaryRange}");
                Console.WriteLine($"       | {job.JobType}");
                Console.WriteLine("---------------------------------------------------------------");
            }
        }

        static void ApplyJob()
        {
            Console.Write("Enter JobId of the job you want to apply: ");
            int jobId = int.Parse(Console.ReadLine());
            portal.ApplyJob(currentUser.Email, jobId);
            Console.WriteLine("Job applied successfully.");
        }

        static void SaveJob()
        {
            Console.Write("Enter JobId of the job you want to save: ");
            int jobId = int.Parse(Console.ReadLine());
            portal.SaveJob(currentUser.Email, jobId);
            Console.WriteLine("Job saved successfully.");
        }

        static void ShowAppliedJobs()
        {
            var jobs = portal.ShowAppliedJobs(currentUser.Email);
            Console.WriteLine("Applied Jobs:");
            foreach (var job in jobs)
            {
                Console.WriteLine(job.GetDetails());
            }
        }

        static void ShowSavedJobs()
        {
            var jobs = portal.ShowSavedJobs(currentUser.Email);
            Console.WriteLine("Saved Jobs:");
            foreach (var job in jobs)
            {
                Console.WriteLine(job.GetDetails());
            }
        }
    }
}