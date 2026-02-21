using JobPortalApplication.Managers;
using JobPortalApplication.Models;
using JobApp = JobPortalApplication.Models.JobApplication;

internal class Program
{
    private static void Main(string[] args)
    {
        JobPortalManager manager = new JobPortalManager();
        Printer printer = new Printer();

        // Sample applications (topic requirement)
        JobApplication[] applications =
        {
            new JobApplication { Id = 1, JobId = 1, ApplicantName = "Alice", Status = "Applied" },
            new JobApplication { Id = 2, JobId = 2, ApplicantName = "Bob", Status = "Shortlisted" }
        };

        User loggedInUser = null;

        while (true)
        {
            // ================= BEFORE LOGIN =================
            while (loggedInUser == null)
            {
                Console.WriteLine("\n=== Job Portal ===");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    User user = new User();

                    Console.Write("First Name: ");
                    user.FirstName = Console.ReadLine();

                    Console.Write("Last Name: ");
                    user.LastName = Console.ReadLine();

                    Console.Write("Email: ");
                    user.Email = Console.ReadLine();

                    Console.Write("Phone: ");
                    user.PhoneNumber = Console.ReadLine();

                    Console.Write("Password: ");
                    user.Password = Console.ReadLine();

                    user.Role = Roles.Employer; // Job actions allowed

                    manager.Register(user);
                }
                else if (choice == "2")
                {
                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Password: ");
                    string password = Console.ReadLine();

                    loggedInUser = manager.Login(email, password);
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Exiting application...");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }

            // ================= AFTER LOGIN =================
            Console.WriteLine($"\nWelcome {loggedInUser.FirstName}!");

            bool logout = false;
            while (!logout)
            {
                Console.WriteLine("\n=== Dashboard ===");
                Console.WriteLine("1. Post Job");
                Console.WriteLine("2. List Jobs");
                Console.WriteLine("3. Schedule Interview");
                Console.WriteLine("4. List Interviews");
                Console.WriteLine("5. List Applications");
                Console.WriteLine("6. Logout");
                Console.Write("Choose option: ");

                string option = Console.ReadLine();

                switch (option) 
                {
                    case "1":
                        Job job = new Job();
                        Console.Write("Title: ");
                        job.Title = Console.ReadLine();
                        Console.Write("Description: ");
                        job.Description = Console.ReadLine();
                        Console.Write("Company: ");
                        job.Company = Console.ReadLine();
                        Console.Write("Location: ");
                        job.Location = Console.ReadLine();
                        Console.Write("Salary: ");
                        job.Salary = Console.ReadLine();
                        Console.Write("Type: ");
                        job.Type = Console.ReadLine();

                        manager.PostJob(job);
                        break;

                    case "2":
                        printer.Print(manager.GetJobs());
                        break;

                    case "3":
                        Interview interview = new Interview();
                        Console.Write("Company: ");
                        interview.Company = Console.ReadLine();
                        Console.Write("Post: ");
                        interview.Post = Console.ReadLine();
                        Console.Write("Date: ");
                        interview.Date = Console.ReadLine();
                        Console.Write("Time: ");
                        interview.Time = Console.ReadLine();
                        Console.Write("Location: ");
                        interview.Location = Console.ReadLine();

                        manager.ScheduleInterview(interview);
                        break;

                    case "4":
                        printer.Print(manager.GetInterviews());
                        break;

                    case "5":
                        printer.Print(applications);
                        break;

                    case "6":
                        loggedInUser = null;
                        logout = true;
                        Console.WriteLine("Logged out successfully.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
