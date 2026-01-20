using System;
using System.Collections.Generic;

class Program
{
    // Simple Job class
    class Job
    {
        public int Id;
        public string Title;
        public string Experience;
        public string Company;
        public string Location;
        public string Salary;
    }

    static void Main()
    {
        string registeredEmail = "";
        string registeredPassword = "";
        string registeredName = "";

        // Predefined job list
        List<Job> jobs = new List<Job>
        {
            new Job { Id = 1, Title = "Software Engineer", Experience = "3+ years", Company = "Acme Inc.", Location = "New York, NY", Salary = "$100,000 - $150,000" },
            new Job { Id = 2, Title = "Product Manager", Experience = "5+ years", Company = "Globex Corp.", Location = "San Francisco, CA", Salary = "$120,000 - $180,000" },
            new Job { Id = 3, Title = "Marketing Specialist", Experience = "2+ years", Company = "Hooli Enterprises", Location = "Seattle, WA", Salary = "$70,000 - $90,000" }
        };

        bool exitApp = false;

        while (!exitApp)
        {
            Console.WriteLine("\nWelcome to the jobseeker portal!");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter your name: ");
                    registeredName = Console.ReadLine();

                    Console.Write("Enter your email: ");
                    registeredEmail = Console.ReadLine();

                    Console.Write("Enter your password: ");
                    registeredPassword = Console.ReadLine();

                    Console.WriteLine("Registration successful!");
                    break;

                case "2":
                    Console.Write("Enter your email: ");
                    string loginEmail = Console.ReadLine();

                    Console.Write("Enter your password: ");
                    string loginPassword = Console.ReadLine();

                    if (loginEmail == registeredEmail && loginPassword == registeredPassword)
                    {
                        Console.WriteLine("Login successful!");
                        LoggedInMenu(registeredName, registeredEmail, jobs);
                    }
                    else
                    {
                        Console.WriteLine("Invalid email or password!");
                    }
                    break;

                case "3":
                    exitApp = true;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }

    static void LoggedInMenu(string name, string email, List<Job> jobs)
    {
        bool loggedIn = true;

        while (loggedIn)
        {
            Console.WriteLine($"\nWelcome {name}!");
            Console.WriteLine("1. List all jobs");
            Console.WriteLine("2. My profile");
            Console.WriteLine("3. Logout");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nJobs available:");
                    Console.WriteLine("ID  Title                  Experience   Company              Location           Salary Range");

                    foreach (var job in jobs)
                    {
                        Console.WriteLine($"{job.Id}   {job.Title,-22} {job.Experience,-12} {job.Company,-18} {job.Location,-18} {job.Salary}");
                    }
                    break;

                case "2":
                    Console.WriteLine("\nMy Profile:");
                    Console.WriteLine($"Name  : {name}");
                    Console.WriteLine($"Email : {email}");
                    break;

                case "3":
                    loggedIn = false;
                    Console.WriteLine("Logged out successfully!");
                    break;

                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }
}
