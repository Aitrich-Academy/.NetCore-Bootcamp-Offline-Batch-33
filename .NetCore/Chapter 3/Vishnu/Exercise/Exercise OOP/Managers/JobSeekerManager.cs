using Exercise_OOP.Enums;
using Exercise_OOP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_OOP.Managers
{
    internal class JobSeekerManager 

    {
        public class JobSeekerManagers
        {
            private JobSeeker[] jobSeekers = new JobSeeker[50];
            private int count = 0;

            private JobSeeker loggedInJobSeeker;
            private JobManager jobManager = new JobManager();

            public void RegisterJobSeeker()
            {
                
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                // Provide defaults for constructor parameters not collected interactively
                string phone = "";
                string location = "";
                string aboutMe = "";
                string qualification = "";

                // Create JobSeeker using the constructor that requires all parameters.
                // Use count+1 as Id and default(ExperienceLevels) for the enum parameter.
                JobSeeker js = new JobSeeker(
                    count + 1,
                    firstName,
                    lastName,
                    email,
                    phone,
                    location,
                    aboutMe,
                    qualification,
                    default(ExperienceLevels),
                    password
                );

                jobSeekers[count++] = js;

                Console.WriteLine("Registration Successful!");
            }

            public void LoginJobSeeker()
            {
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                foreach (var js in jobSeekers)
                {
                    if (js != null && js.Email == email && js.Password == password)
                    {
                        loggedInJobSeeker = js;
                        Console.WriteLine("Login Successful!");
                        ShowJobSeekerMenu();
                        return;
                    }
                }

                Console.WriteLine("Invalid Credentials!");
            }

            public void ShowJobSeekerMenu()
            {
                int choice;

                do
                {
                    Console.WriteLine("\n1. View Jobs");
                    Console.WriteLine("2. Apply Job");
                    Console.WriteLine("3. Save Job");
                    Console.WriteLine("4. View Profile");
                    Console.WriteLine("5. Logout");

                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            jobManager.ListJobs();
                            break;

                        case 2:
                            ApplyJob();
                            break;

                        case 3:
                            SaveJob();
                            break;

                        case 4:
                            ViewProfile();
                            break;

                        case 5:
                            Logout();
                            break;
                    }

                } while (choice != 5);
            }

            public void ApplyJob()
            {
                Console.Write("Enter Job ID: ");
                int id = int.Parse(Console.ReadLine());

                var job = jobManager.GetJobById(id);

                if (job != null)
                {
                    loggedInJobSeeker.AddAppliedJob(job);
                    Console.WriteLine("Job Applied Successfully!");
                }
                else
                {
                    Console.WriteLine("Job not found!");
                }
            }

            public void SaveJob()
            {
                Console.Write("Enter Job ID: ");
                int id = int.Parse(Console.ReadLine());

                var job = jobManager.GetJobById(id);

                if (job != null)
                {
                    loggedInJobSeeker.addSavedJob(job);
                    Console.WriteLine("Job Saved Successfully!");
                }
                else
                {
                    Console.WriteLine("Job not found!");
                }
            }

            public void ViewProfile()
            {
                Console.WriteLine($"Name: {loggedInJobSeeker.FirstName} {loggedInJobSeeker.LastName}");
                Console.WriteLine($"Email: {loggedInJobSeeker.Email}");
            }

            public void Logout()
            {
                loggedInJobSeeker = null;
                Console.WriteLine("Logged out successfully!");
            }

            public void ShowMainMenu()
            {
                int choice;

                do
                {
                    Console.WriteLine("\n--- HireMeNow Portal ---");
                    Console.WriteLine("1. Register");
                    Console.WriteLine("2. Login");
                    Console.WriteLine("3. Exit");

                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            RegisterJobSeeker();
                            break;

                        case 2:
                            LoginJobSeeker();
                            break;
                    }

                } while (choice != 3);
            }
        }
    }


}
