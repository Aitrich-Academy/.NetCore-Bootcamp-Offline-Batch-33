using exercise3.Managers;
using exercise3.Models;
using exercise3.Interfaces;
using System.Reflection;

namespace exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JobManager jobM = new JobManager();
            ApplicationManager apliM=new ApplicationManager();
            InterviewManager interM=new InterviewManager(); 
            Printer print=new Printer();

            Console.WriteLine("Welcome to the Job Portal!");
            Console.WriteLine("1. Post a Job");
            Console.WriteLine("2. View Jobs");
            Console.WriteLine("3. Add Application");
            Console.WriteLine("4. View Applications");
            Console.WriteLine("5. Schedule Interview");
            Console.WriteLine("6. View Interviews");
            Console.WriteLine("7. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    jobM.PostJob(new Models.Job { Id = 1, Title = "Software Engineer", Company = "Tech Corp", Location = "New York", Salary = "$100K", Type = "Full-Time", Description = "Develop and maintain software." });
                    break;
                    case 2:
                    print.Print(jobM.GetJobs());
                    break;
                case 3:
                    apliM.AddApplication(new Models.Application { Id = 1, Name = "John Doe", Location = "New York", Qualification = "B.Sc. Computer Science", Experience = "5 years" });
                    break;
                case 4:
                    print.Print(apliM.GetApplications());
                    break;
                case 5:
                    interM.ScheduledInterview(new Models.Interview { Id = 1, Company = "Tech Corp", Post = "Software Engineer", Date = "2025-04-10", Time = "10:00 AM", Location = "New York" });
                    break ;
                case 6:
                    print.Print(interM.GetInterviews());
                    break;
                case 7:
                    Console.WriteLine("Exiting Job Portal");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
