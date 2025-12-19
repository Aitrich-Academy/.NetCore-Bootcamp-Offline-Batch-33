using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise3.Interfaces;
using exercise3.Models;

namespace exercise3.Managers
{
    public class JobManager : Interfaces.IJobProvider
    {
        private List<Job> jobs = new List<Job>();

        public void PostJob(Job job)
        {
            jobs.Add(job);
            Console.WriteLine("Job posted successfully.");
        }

        public Job[] GetJobs()
        {
            return jobs.ToArray();
        }
    }

    public class ApplicationManager : Interfaces.IApplicationProvider
    {
        private List<Application> applications = new List<Application>();

        public void AddApplication(Application application)
        {
            applications.Add(application);
            Console.WriteLine("Application added successfully.");
        }

        public Application[] GetApplications()
        {
            return applications.ToArray();
        }
    }

    public class InterviewManager : Interfaces.IInterviewProvider
    {
        private List<Interview> interviews = new List<Interview>();

        public void ScheduledInterview(Interview interview)
        {
            interviews.Add(interview);
            Console.WriteLine("Interview scheduled successfully.");
        }

        public Interview[] GetInterviews()
        {
            return interviews.ToArray();
        }

    }
}
