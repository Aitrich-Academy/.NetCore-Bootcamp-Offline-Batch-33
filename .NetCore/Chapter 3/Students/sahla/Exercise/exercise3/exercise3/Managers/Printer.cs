using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise3.Models;

namespace exercise3.Managers
{
    public class Printer
    {
        public void Print(Job[] jobs)
        {
            foreach (var job in jobs)
            {
                Console.WriteLine($"Job ID: {job.Id}, Title: {job.Title}, Company: {job.Company}, Location: {job.Location}, Salary: {job.Salary}, Type: {job.Type}, Description: {job.Description}");
            }
        }

        public void Print(Application[] applications)
        {
            foreach (var application in applications)
            {
                Console.WriteLine($"Application ID: {application.Id}, Name: {application.Name}, Location: {application.Location}, Qualification: {application.Qualification}, Experience: {application.Experience}");
            }
        }

        public void Print(Interview[] interviews)
        {
            foreach (var interview in interviews)
            {
                Console.WriteLine($"Interview ID: {interview.Id}, Company: {interview.Company}, Post: {interview.Post}, Date: {interview.Date}, Time: {interview.Time}, Location: {interview.Location}");
            }
        }
    }
}
